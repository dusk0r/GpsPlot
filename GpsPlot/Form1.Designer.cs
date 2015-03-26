namespace GpsPlot {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_satelliten = new System.Windows.Forms.Label();
            this.label_hdop = new System.Windows.Forms.Label();
            this.label_vdop = new System.Windows.Forms.Label();
            this.label_mode = new System.Windows.Forms.Label();
            this.satView1 = new GpsPlot.SatView();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(12, 12);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(487, 448);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(424, 466);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_satelliten
            // 
            this.label_satelliten.AutoSize = true;
            this.label_satelliten.Location = new System.Drawing.Point(13, 471);
            this.label_satelliten.Name = "label_satelliten";
            this.label_satelliten.Size = new System.Drawing.Size(62, 13);
            this.label_satelliten.TabIndex = 2;
            this.label_satelliten.Text = "Satelliten: 0";
            // 
            // label_hdop
            // 
            this.label_hdop.AutoSize = true;
            this.label_hdop.Location = new System.Drawing.Point(13, 484);
            this.label_hdop.Name = "label_hdop";
            this.label_hdop.Size = new System.Drawing.Size(47, 13);
            this.label_hdop.TabIndex = 3;
            this.label_hdop.Text = "HDOP: -";
            // 
            // label_vdop
            // 
            this.label_vdop.AutoSize = true;
            this.label_vdop.Location = new System.Drawing.Point(13, 498);
            this.label_vdop.Name = "label_vdop";
            this.label_vdop.Size = new System.Drawing.Size(46, 13);
            this.label_vdop.TabIndex = 4;
            this.label_vdop.Text = "VDOP: -";
            // 
            // label_mode
            // 
            this.label_mode.AutoSize = true;
            this.label_mode.Location = new System.Drawing.Point(13, 511);
            this.label_mode.Name = "label_mode";
            this.label_mode.Size = new System.Drawing.Size(48, 13);
            this.label_mode.TabIndex = 4;
            this.label_mode.Text = "Modus: -";
            // 
            // satView1
            // 
            this.satView1.Location = new System.Drawing.Point(505, 12);
            this.satView1.Name = "satView1";
            this.satView1.Size = new System.Drawing.Size(517, 448);
            this.satView1.TabIndex = 5;
            this.satView1.Text = "satView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 546);
            this.Controls.Add(this.satView1);
            this.Controls.Add(this.label_mode);
            this.Controls.Add(this.label_vdop);
            this.Controls.Add(this.label_hdop);
            this.Controls.Add(this.label_satelliten);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.map);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label_satelliten;
        private System.Windows.Forms.Label label_hdop;
        private System.Windows.Forms.Label label_vdop;
        private System.Windows.Forms.Label label_mode;
        private SatView satView1;
    }
}

