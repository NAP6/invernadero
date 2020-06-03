Imports System.ComponentModel

Public Class UsuarioNotify
    Inherits Usuario
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyPropertyChanged(ByVal info As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
    End Sub

    Public Property Nombre As String
        Get
            Return nombrev
        End Get
        Set(value As String)
            If Not (nombrev = value) Then
                nombrev = value
                NotifyPropertyChanged("Nombre")
            End If
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return usuariov
        End Get
        Set(value As String)

            If Not (usuariov = value) Then
                usuariov = value
                NotifyPropertyChanged("Usuario")
            End If
        End Set
    End Property

    Public Property Correo As String
        Get
            Return correov
        End Get
        Set(value As String)
            If Not (correov = value) Then
                correov = value
                NotifyPropertyChanged("Correo")
            End If
        End Set
    End Property

    Public Property Invernaderos_propios As Registro_invernadero
        Get
            Return invernaderos_propiosv
        End Get
        Set(value As Registro_invernadero)
            If Not (invernaderos_propiosv.Equals(value)) Then
                invernaderos_propiosv = value
                NotifyPropertyChanged("Invernaderos_propios")
            End If
        End Set
    End Property
End Class
