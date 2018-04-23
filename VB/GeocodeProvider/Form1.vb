Imports DevExpress.XtraMap
Imports System.Windows.Forms

Namespace GeocodeProvider
    Partial Public Class Form1
        Inherits Form

        Private Const bingKey As String = "YOUR BING KEY HERE"

        Private ReadOnly Property GeocodeLayer() As InformationLayer
            Get
                Return CType(mapControl1.Layers("GeocodeLayer"), InformationLayer)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()

            GeocodeLayer.DataProvider = New BingGeocodeDataProvider() With {.BingKey = bingKey, .MaxVisibleResultCount = 1}
        End Sub
    End Class

End Namespace
