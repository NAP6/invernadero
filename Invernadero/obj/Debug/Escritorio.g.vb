﻿#ExternalChecksum("..\..\Escritorio.xaml","{8829d00f-11b8-4213-878b-770e8597ac16}","66216E2B54428CB48473D7CB971D514FB3294B756A678F3B63D6137DB36CBAB6")
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
'''Escritorio
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Escritorio
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\Escritorio.xaml",102)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents GridBarraTitulo As System.Windows.Controls.Grid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Escritorio.xaml",110)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents BtnSalir As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Escritorio.xaml",205)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Temperatura_interior As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Escritorio.xaml",273)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents BorderG1 As System.Windows.Controls.Border
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Escritorio.xaml",285)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents BorderG2 As System.Windows.Controls.Border
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Escritorio.xaml",287)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Tiempo As LiveCharts.Wpf.CartesianChart
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Escritorio.xaml",311)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents BorderG1_1 As System.Windows.Controls.Border
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Escritorio.xaml",323)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents BorderG2_1 As System.Windows.Controls.Border
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Escritorio.xaml",325)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Humedad As LiveCharts.Wpf.CartesianChart
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Escritorio.xaml",349)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents BorderG1_2 As System.Windows.Controls.Border
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Escritorio.xaml",361)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents BorderG2_2 As System.Windows.Controls.Border
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Escritorio.xaml",363)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Co2 As LiveCharts.Wpf.CartesianChart
    
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
        Dim resourceLocater As System.Uri = New System.Uri("/Invernadero;component/escritorio.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\Escritorio.xaml",1)
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
            
            #ExternalSource("..\..\Escritorio.xaml",102)
            AddHandler Me.GridBarraTitulo.MouseDown, New System.Windows.Input.MouseButtonEventHandler(AddressOf Me.GridBarraTitulo_MouseDown)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 2) Then
            Me.BtnSalir = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\Escritorio.xaml",110)
            AddHandler Me.BtnSalir.Click, New System.Windows.RoutedEventHandler(AddressOf Me.BtnSalir_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 3) Then
            Me.Temperatura_interior = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 4) Then
            Me.BorderG1 = CType(target,System.Windows.Controls.Border)
            Return
        End If
        If (connectionId = 5) Then
            Me.BorderG2 = CType(target,System.Windows.Controls.Border)
            Return
        End If
        If (connectionId = 6) Then
            Me.Tiempo = CType(target,LiveCharts.Wpf.CartesianChart)
            Return
        End If
        If (connectionId = 7) Then
            Me.BorderG1_1 = CType(target,System.Windows.Controls.Border)
            Return
        End If
        If (connectionId = 8) Then
            Me.BorderG2_1 = CType(target,System.Windows.Controls.Border)
            Return
        End If
        If (connectionId = 9) Then
            Me.Humedad = CType(target,LiveCharts.Wpf.CartesianChart)
            Return
        End If
        If (connectionId = 10) Then
            Me.BorderG1_2 = CType(target,System.Windows.Controls.Border)
            Return
        End If
        If (connectionId = 11) Then
            Me.BorderG2_2 = CType(target,System.Windows.Controls.Border)
            Return
        End If
        If (connectionId = 12) Then
            Me.Co2 = CType(target,LiveCharts.Wpf.CartesianChart)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

