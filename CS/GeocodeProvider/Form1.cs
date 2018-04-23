using System;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace GeocodeProvider {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        const string yourBingKey = "INSERT_YOUR_BING_KEY_HERE";

        private void Form1_Load(object sender, EventArgs e) {

            // Create a map control.
            MapControl map = new MapControl();

            // Specify the map position on the form.           
            map.Dock = DockStyle.Fill;

            // Add the map control to the window.
            this.Controls.Add(map);

            // Create an image tiles layer and add it to the map.
            ImageTilesLayer tilesLayer = new ImageTilesLayer();
            map.Layers.Add(tilesLayer);

            // Create an information layer and add it to the map.
            InformationLayer infoLayer = new InformationLayer();
            map.Layers.Add(infoLayer);

            // Create a Bing data provider and specify the Bing key.
            BingMapDataProvider bingProvider = new BingMapDataProvider();
            tilesLayer.DataProvider = bingProvider;
            bingProvider.BingKey = yourBingKey;

            // Create a Geocode data provider.
            BingGeocodeDataProvider geocodeProvider = new BingGeocodeDataProvider();
            infoLayer.DataProvider = geocodeProvider;
            geocodeProvider.BingKey = yourBingKey;

            // Specify the total number of results to be displayed simultaneously on the map.  
            geocodeProvider.MaxVisibleResultCount = 1;

        }
    }
}


