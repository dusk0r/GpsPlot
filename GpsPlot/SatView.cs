using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GpsPlot {
    
    public class SatView : Control {

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            var graphics = e.Graphics;

            e.Graphics.FillRectangle(Brushes.Red, new Rectangle(0, 0, 20, 20));
        }
    }
}
