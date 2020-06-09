// MQTT broker

//Se solicita la Libreria Mosca para el broker MQTT
var mosca = require('mosca');

// Acepta la conexión si el nombre de usuario y la contraseña son válidos 
var authenticate = function(client, username, password, callback) {
    var res = false;
    var sql = 'SELECT * FROM invernadero.ta_usuarios WHERE username = "' + username + '";';
    db.query(sql, function(err, result) {
        if (err) throw err;
        for (i = 0; i < result.length; i++) {
            if (result[i]['contraseña'] == password) {
                res = true;
                break;
            }
        }
        var authorized = res;
        if (authorized) {
            var sql = "INSERT INTO ta_histo_login (username) values ('" + username + "');";
            db.query(sql, (err) => {
                if (err) {
                    console.log(sql);
                    console.log(dbStat);
                    console.log(err);
                } else {
                    console.log("Datos Login Ingresados")
                }
            });
            client.user = username;

        }
        callback(null, authorized);

    });
}

//Acepta la publicacion entre un usuario y el Topic
var authorizePublish = function(client, topic, payload, callback) {
    var res = false;
    if (client.user == "ServidorP") {
        callback(null, true)
    }
    var sql = 'SELECT inver_id FROM invernadero.ta_invernaderos WHERE username = "' + client.user + '";';
    db.query(sql, function(err, result) {
        if (err) throw err;
        var regex;
        for (i = 0; i < result.length; i++) {
            regex = RegExp("^" + client.user + "/" + result[i].inver_id + ".*$");
            if (regex.test(topic)) {
                res = true;
                break;
            }
        }
        callback(null, res);
    });
}

//Autoriza al usuario suscribirse en el Topic
var authorizeSubscribe = function(client, topic, callback) {
        var res = false;
        if (client.user == "ServidorP") {
            callback(null, true)
        }
        var sql = 'SELECT inver_id FROM invernadero.ta_invernaderos WHERE username = "' + client.user + '";';

        db.query(sql, function(err, result) {
            if (err) {
                console.log(sql);
                console.log(dbStat);
                console.log(err);
            } else {

                for (i = 0; i < result.length; i++) {
                    res = true;
                    regex = RegExp("^" + client.user + "/" + result[i].inver_id + ".*$");
                    console.log(topic + " : ", regex.test(topic));
                    if (regex.test(topic)) {
                        break;
                    }
                    var regex;
                }

                callback(null, res);
            }
        });
    }
    //Configuracion de puertos para la Conexion
var settings = {
    port: 1880,
    http: {
        port: 8050,
        bundle: true,
        static: './public'
    }
};
//Creacion del Broker con la Configuaracion Pre Establecida
var broker = new mosca.Server(settings);

//Se manda todas las configuraciones anteriores cuando el Broker este listo.
broker.on('ready', () => {
    console.log('Broker is ready!')
    broker.authenticate = authenticate;
    broker.authorizePublish = authorizePublish;
    broker.authorizeSubscribe = authorizeSubscribe;
});

//Imprime en consola cuando el cliente se Conecta
broker.on('clientConnected', function(client) {
    console.log('client connected', client.id);
});

//Imprime en consola el nombre del cliente el id el topic y el mensaje que esta pasando por el Broker
//Guarda el Historial del Ambiente y Actuadores en la Base de Datos
broker.on('published', function(packet, client) {
    if (client != null) {
        var message = packet.payload.toString();
        var topic = packet.topic.toString();
        console.log(client['user'] + "    " + client['id'] + "    " + topic + "   " + message);
        if (topic.split("/")[2] == "invernadero") {
            var Divicion = message.split(":");
            var Ambiente = Divicion[0].split("/");
            var Temperatura = Ambiente[0].split("-");
            var Co2 = Ambiente[1].split("-");
            var HumedadSuelo = Ambiente[2].split("-");
            var HumedadAire = Ambiente[3].split("-");
            var Actuador = Divicion[1].split("/");
            var InverId = topic.split("/")[1];
            var Fecha = new Date().toMysqlFormat();
            var sql = "INSERT INTO invernadero.ta_historial_invernadero(fecha_historial,inver_id,his_temperatura_ex,his_temperatura_int,his_humedad_aire_ex,his_humedad_aire_int,his_humedad_suelo_ex,his_humedad_suelo_int,his_Co2_ex,his_Co2_int) values('" + Fecha + "'," + InverId + "," + Temperatura[1] + "," + Temperatura[0] + "," + HumedadAire[1] + "," + HumedadAire[0] + "," + HumedadSuelo[1] + "," + HumedadSuelo[0] + "," + Co2[1] + "," + Co2[0] + ");";
            db.query(sql, (err) => {
                if (err) {
                    console.log(sql);
                    console.log(dbStat);
                    console.log(err);
                } else {
                    console.log("Insert Ambiente Correcto");
                    Actuador.forEach(element => {
                        var Actu = element.split("-");
                        var sql2 = "INSERT INTO invernadero.ta_histo_actuadores(actu_id,inver_id,fecha_historial,his_actu_estado) values (" + Actu[0] + "," + InverId + ",'" + Fecha + "'," + Actu[1] + ");";
                        db.query(sql2, (err) => {
                            if (err) {
                                console.log(sql2);
                                console.log(dbStat);
                                console.log(err);
                            } else {
                                console.log("Insert Actuadores Correcto");
                            }
                        });
                    });

                }
            });

        }
    }
});

//Funcion que recibe un numero y le pasa a dos digitos.
function twoDigits(d) {
    if (0 <= d && d < 10) return "0" + d.toString();
    if (-10 < d && d < 0) return "-0" + (-1 * d).toString();
    return d.toString();
}

//Convierte a date en un formato String que acepta la base de Datos Mysql
Date.prototype.toMysqlFormat = function() {
    return this.getUTCFullYear() + "-" + twoDigits(1 + this.getUTCMonth()) + "-" + twoDigits(this.getUTCDate()) + " " + twoDigits(this.getUTCHours()) + ":" + twoDigits(this.getUTCMinutes()) + ":" + twoDigits(this.getUTCSeconds());
};

//Imprime en consola cuando un cliente se desconecta
broker.on('clientDisconnected', function(client) {
    console.log('Client Disconnected:', client.id);
});

//MySQL
//Se solicita la Libreria MySQL para la conexion con la base de datos
var mysql = require('mysql');

//Crear la conexion con una configuracion a la Base de datos.
var db = mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: 'admin',
    database: 'invernadero'
});

//Imprime en consola cuando se conecta a la Base de datos
db.connect(() => {
    console.log('Database conected!')
});