using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Waymex.Gps;
using Waymex.Gps.Nmea;

namespace GpsPlot {

    public partial class Form1 : Form {

        NmeaDevice gps;
        GMapOverlay markersOverlay;

        public Form1() {
            InitializeComponent();

            //map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            map.MapProvider = GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance;
            map.SetPositionByKeywords("Switzerland");
            map.MinZoom = 3;
            map.MaxZoom = 20;
            map.Zoom = 20;
            map.Manager.Mode = GMap.NET.AccessMode.ServerAndCache;
            markersOverlay = new GMapOverlay("markers");
            map.Overlays.Add(markersOverlay);

            gps = new NmeaDevice();
            gps.OpenPort(6, 115200);
            gps.Start();

            gps.ReceiveSentence += gps_ReceiveSentence;
            FormClosing += Form1_FormClosing;
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            gps.Stop();
        }

        void gps_ReceiveSentence(object sender, ReceiveSentenceEventArgs e) {
            var gsa = e.Sentence as SentenceGsa;
            var rmc = e.Sentence as SentenceRmc;
            var gsv = e.Sentence as SentenceGsv;

            if (gsa != null) {
                BeginInvoke((Action)delegate {
                    label_satelliten.Text = String.Format("Satelliten: {0}", gsa.Satellites.Count());
                    label_vdop.Text = String.Format("VDOP: {0}", gsa.VerticalDilution);
                    label_hdop.Text = String.Format("HDOP: {0}", gsa.HorizontalDilution);
                    label_mode.Text = String.Format("Type: {0}", GetTypeText(gsa.FixType));
                });
            }

            if (rmc != null) {
                BeginInvoke((Action)delegate {
                    var point = new GMap.NET.PointLatLng(rmc.Latitude, rmc.Longitude);
                    var marker = new GMarkerCross(point);
                    markersOverlay.Markers.Add(marker);
                    map.Position = point;
                });
            }

            if (gsv != null) {

            }
        }

        private void button1_Click(object sender, EventArgs e) {
            markersOverlay.Markers.Clear();
        }

        private string GetTypeText(Waymex.Gps.Nmea.SentenceGsa.GsaFixType type) {
            switch (type) {
                case SentenceGsa.GsaFixType.FixType2D:
                    return "2D";
                case SentenceGsa.GsaFixType.FixType3D:
                    return "3D";
                case SentenceGsa.GsaFixType.FixTypeNotAvailable:
                    return "none";
                default:
                    return "unknown";
            }
        }
    }
}
