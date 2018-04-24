namespace IT391_Assignment8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.GeocodeApiKey = new System.Windows.Forms.TextBox();
            this.streetAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.state = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Latitude = new System.Windows.Forms.TextBox();
            this.Longitude = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxSatellite = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBoxRoad = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBoxHybrid = new System.Windows.Forms.PictureBox();
            this.MapsApiKey = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ZoomLevel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSatellite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHybrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geocode API Key";
            // 
            // GeocodeApiKey
            // 
            this.GeocodeApiKey.Location = new System.Drawing.Point(120, 7);
            this.GeocodeApiKey.Name = "GeocodeApiKey";
            this.GeocodeApiKey.Size = new System.Drawing.Size(475, 20);
            this.GeocodeApiKey.TabIndex = 1;
            this.GeocodeApiKey.Text = "AIzaSyDKsIsNQJnoVRLRsacXNK0WYZxMUlJQteA";
            // 
            // streetAddress
            // 
            this.streetAddress.Location = new System.Drawing.Point(120, 59);
            this.streetAddress.Name = "streetAddress";
            this.streetAddress.Size = new System.Drawing.Size(475, 20);
            this.streetAddress.TabIndex = 3;
            this.streetAddress.Text = "1600 Pennsylvania Ave, N.W.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Street Address";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(120, 85);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(475, 20);
            this.city.TabIndex = 5;
            this.city.Text = "Washington";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "City";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(120, 111);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(475, 20);
            this.state.TabIndex = 8;
            this.state.Text = "DC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "State";
            // 
            // zip
            // 
            this.zip.Location = new System.Drawing.Point(120, 137);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(475, 20);
            this.zip.TabIndex = 10;
            this.zip.Text = "20500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Zip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Latitude";
            // 
            // Latitude
            // 
            this.Latitude.Location = new System.Drawing.Point(120, 242);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(475, 20);
            this.Latitude.TabIndex = 12;
            // 
            // Longitude
            // 
            this.Longitude.Location = new System.Drawing.Point(120, 268);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(475, 20);
            this.Longitude.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Longitude";
            // 
            // pictureBoxSatellite
            // 
            this.pictureBoxSatellite.Location = new System.Drawing.Point(12, 323);
            this.pictureBoxSatellite.Name = "pictureBoxSatellite";
            this.pictureBoxSatellite.Size = new System.Drawing.Size(172, 143);
            this.pictureBoxSatellite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSatellite.TabIndex = 15;
            this.pictureBoxSatellite.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Satellite";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Road";
            // 
            // pictureBoxRoad
            // 
            this.pictureBoxRoad.Location = new System.Drawing.Point(209, 323);
            this.pictureBoxRoad.Name = "pictureBoxRoad";
            this.pictureBoxRoad.Size = new System.Drawing.Size(172, 143);
            this.pictureBoxRoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRoad.TabIndex = 17;
            this.pictureBoxRoad.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Hybrid";
            // 
            // pictureBoxHybrid
            // 
            this.pictureBoxHybrid.Location = new System.Drawing.Point(412, 323);
            this.pictureBoxHybrid.Name = "pictureBoxHybrid";
            this.pictureBoxHybrid.Size = new System.Drawing.Size(172, 143);
            this.pictureBoxHybrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHybrid.TabIndex = 19;
            this.pictureBoxHybrid.TabStop = false;
            // 
            // MapsApiKey
            // 
            this.MapsApiKey.Location = new System.Drawing.Point(120, 28);
            this.MapsApiKey.Name = "MapsApiKey";
            this.MapsApiKey.Size = new System.Drawing.Size(475, 20);
            this.MapsApiKey.TabIndex = 22;
            this.MapsApiKey.Text = "AIzaSyBV7yPrGGa5bfc9UfGoxOzGGZQdyBJSSPo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Maps API Key";
            // 
            // ZoomLevel
            // 
            this.ZoomLevel.Location = new System.Drawing.Point(120, 165);
            this.ZoomLevel.Name = "ZoomLevel";
            this.ZoomLevel.Size = new System.Drawing.Size(475, 20);
            this.ZoomLevel.TabIndex = 24;
            this.ZoomLevel.Text = "16";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Zoom-Level";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 477);
            this.Controls.Add(this.ZoomLevel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.MapsApiKey);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBoxHybrid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBoxRoad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBoxSatellite);
            this.Controls.Add(this.Longitude);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Latitude);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.streetAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GeocodeApiKey);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Google API Interrogator!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSatellite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHybrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GeocodeApiKey;
        private System.Windows.Forms.TextBox streetAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Latitude;
        private System.Windows.Forms.TextBox Longitude;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxSatellite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBoxRoad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBoxHybrid;
        private System.Windows.Forms.TextBox MapsApiKey;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ZoomLevel;
        private System.Windows.Forms.Label label12;
    }
}

