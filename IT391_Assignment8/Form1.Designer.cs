﻿namespace IT391_Assignment8
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
            this.apiKey = new System.Windows.Forms.TextBox();
            this.streetAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.state = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Google API Key";
            // 
            // apiKey
            // 
            this.apiKey.Location = new System.Drawing.Point(120, 7);
            this.apiKey.Name = "apiKey";
            this.apiKey.Size = new System.Drawing.Size(475, 20);
            this.apiKey.TabIndex = 1;
            this.apiKey.Text = "AIzaSyDKsIsNQJnoVRLRsacXNK0WYZxMUlJQteA";
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
            this.button1.Location = new System.Drawing.Point(306, 163);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.streetAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apiKey);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Google API Interrogator!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apiKey;
        private System.Windows.Forms.TextBox streetAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.Label label5;
    }
}

