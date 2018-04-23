using DevExpress.XtraMap;
using System.Windows.Forms;

namespace GeocodeProvider {
    public partial class Form1 : Form {
        const string bingKey = "YOUR BING KEY HERE";

        InformationLayer GeocodeLayer {
            get {
                return (InformationLayer)mapControl1.Layers["GeocodeLayer"];
            }
        }

        public Form1() {
            InitializeComponent();

            GeocodeLayer.DataProvider = new BingGeocodeDataProvider() {
                BingKey = bingKey,
                MaxVisibleResultCount = 1
            };
        }
    }

}
