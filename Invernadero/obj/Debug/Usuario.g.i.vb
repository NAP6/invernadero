﻿#ExternalChecksum("..\..\Usuario.xaml","{8829d00f-11b8-4213-878b-770e8597ac16}","5C74DF514706AA4C9EDE074199951B9B9A71705D14B896C3CBEE9F1C098ED9E2")
'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Invernadero
Imports LiveCharts.Wpf
Imports MaterialDesignThemes.Wpf
Imports MaterialDesignThemes.Wpf.Converters
Imports MaterialDesignThemes.Wpf.Transitions
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''Usuario
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Usuario
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\Usuario.xaml",103)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents GridBarraTitulo As System.Windows.Controls.Grid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Usuario.xaml",105)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btn_notificaciones As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Usuario.xaml",108)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btn_login As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Usuario.xaml",111)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents BtnSalir As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Usuario.xaml",136)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btn_escritorio As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Usuario.xaml",142)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btn_perfil As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Usuario.xaml",148)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btn_tablas As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Usuario.xaml",154)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btn_invernadero As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Usuario.xaml",160)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btn_control As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Usuario.xaml",166)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btn_configuracion As System.Windows.Controls.Button
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/Invernadero;component/usuario.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\Usuario.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.GridBarraTitulo = CType(target,System.Windows.Controls.Grid)
            
            #ExternalSource("..\..\Usuario.xaml",103)
            AddHandler Me.GridBarraTitulo.MouseDown, New System.Windows.Input.MouseButtonEventHandler(AddressOf Me.GridBarraTitulo_MouseDown)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 2) Then
            Me.btn_notificaciones = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\Usuario.xaml",105)
            AddHandler Me.btn_notificaciones.Click, New System.Windows.RoutedEventHandler(AddressOf Me.Btn_notificaciones_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 3) Then
            Me.btn_login = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\Usuario.xaml",108)
            AddHandler Me.btn_login.Click, New System.Windows.RoutedEventHandler(AddressOf Me.Btn_login_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 4) Then
            Me.BtnSalir = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\Usuario.xaml",111)
            AddHandler Me.BtnSalir.Click, New System.Windows.RoutedEventHandler(AddressOf Me.BtnSalir_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 5) Then
            Me.btn_escritorio = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\Usuario.xaml",136)
            AddHandler Me.btn_escritorio.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btn_escritorio_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 6) Then
            Me.btn_perfil = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\Usuario.xaml",142)
            AddHandler Me.btn_perfil.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btn_perfil_click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 7) Then
            Me.btn_tablas = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\Usuario.xaml",148)
            AddHandler Me.btn_tablas.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btn_tablas_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 8) Then
            Me.btn_invernadero = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\Usuario.xaml",154)
            AddHandler Me.btn_invernadero.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btn_invernadero_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 9) Then
            Me.btn_control = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\Usuario.xaml",160)
            AddHandler Me.btn_control.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btn_control_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 10) Then
            Me.btn_configuracion = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\Usuario.xaml",166)
            AddHandler Me.btn_configuracion.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btn_configuracion_Click)
            
            #End ExternalSource
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

