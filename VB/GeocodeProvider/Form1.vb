Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace GeocodeProvider
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Const yourBingKey As String = "INSERT_YOUR_BING_KEY_HERE"

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			' Create a map control.
			Dim map As New MapControl()

			' Specify the map position on the form.           
			map.Dock = DockStyle.Fill

			' Add the map control to the window.
			Me.Controls.Add(map)

			' Create an image tiles layer and add it to the map.
			Dim tilesLayer As New ImageTilesLayer()
			map.Layers.Add(tilesLayer)

			' Create an  information layer and add it to the map.
			Dim infoLayer As New InformationLayer()
			map.Layers.Add(infoLayer)

			' Create a Bing data provider and specify the Bing key.
			Dim bingProvider As New BingMapDataProvider()
			tilesLayer.DataProvider = bingProvider
			bingProvider.BingKey = yourBingKey

			' Create a Geocode data provider.
			Dim geocodeProvider As New BingGeocodeDataProvider()
			infoLayer.DataProvider = geocodeProvider
			geocodeProvider.BingKey = yourBingKey

			' Specify the total number of results to be displayed simultaneously on the map.  
			geocodeProvider.MaxVisibleResultCount = 1

		End Sub
	End Class
End Namespace


