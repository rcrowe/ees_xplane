/*
 * User: rcrowe
 * Date: 25/02/2010
 * Time: 12:39
 */
namespace IOSees_Slave_Wind
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblWindAngle = new System.Windows.Forms.Label();
			this.bttnLayer1 = new System.Windows.Forms.Button();
			this.bttnLayer2 = new System.Windows.Forms.Button();
			this.bttnLayer3 = new System.Windows.Forms.Button();
			this.bttnAltitude = new System.Windows.Forms.Button();
			this.bttnSpeed = new System.Windows.Forms.Button();
			this.bttnTurbulance = new System.Windows.Forms.Button();
			this.bttnSet = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblTurbulanceInfo = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblSpeedInfo = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblAltitudeInfo = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblLayerInfo = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Location = new System.Drawing.Point(66, 354);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(500, 500);
			this.panel.TabIndex = 0;
			this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMouseDown);
			this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPaint);
			this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelMouseUp);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(54, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 44);
			this.label1.TabIndex = 2;
			this.label1.Text = "Wind";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(66, 313);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Direction:";
			// 
			// lblWindAngle
			// 
			this.lblWindAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWindAngle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblWindAngle.Location = new System.Drawing.Point(152, 302);
			this.lblWindAngle.Name = "lblWindAngle";
			this.lblWindAngle.Size = new System.Drawing.Size(153, 43);
			this.lblWindAngle.TabIndex = 11;
			this.lblWindAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// bttnLayer1
			// 
			this.bttnLayer1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.bttnLayer1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.bttnLayer1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.bttnLayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnLayer1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bttnLayer1.Location = new System.Drawing.Point(66, 147);
			this.bttnLayer1.Name = "bttnLayer1";
			this.bttnLayer1.Size = new System.Drawing.Size(210, 117);
			this.bttnLayer1.TabIndex = 12;
			this.bttnLayer1.Text = "Layer 1";
			this.bttnLayer1.UseVisualStyleBackColor = true;
			this.bttnLayer1.Click += new System.EventHandler(this.BttnLayer1Click);
			// 
			// bttnLayer2
			// 
			this.bttnLayer2.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.bttnLayer2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.bttnLayer2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.bttnLayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnLayer2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bttnLayer2.Location = new System.Drawing.Point(311, 147);
			this.bttnLayer2.Name = "bttnLayer2";
			this.bttnLayer2.Size = new System.Drawing.Size(210, 117);
			this.bttnLayer2.TabIndex = 13;
			this.bttnLayer2.Text = "Layer 2";
			this.bttnLayer2.UseVisualStyleBackColor = true;
			this.bttnLayer2.Click += new System.EventHandler(this.BttnLayer2Click);
			// 
			// bttnLayer3
			// 
			this.bttnLayer3.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.bttnLayer3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.bttnLayer3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.bttnLayer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnLayer3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bttnLayer3.Location = new System.Drawing.Point(553, 147);
			this.bttnLayer3.Name = "bttnLayer3";
			this.bttnLayer3.Size = new System.Drawing.Size(210, 117);
			this.bttnLayer3.TabIndex = 14;
			this.bttnLayer3.Text = "Layer 3";
			this.bttnLayer3.UseVisualStyleBackColor = true;
			this.bttnLayer3.Click += new System.EventHandler(this.BttnLayer3Click);
			// 
			// bttnAltitude
			// 
			this.bttnAltitude.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.bttnAltitude.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.bttnAltitude.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.bttnAltitude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnAltitude.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bttnAltitude.Location = new System.Drawing.Point(708, 354);
			this.bttnAltitude.Name = "bttnAltitude";
			this.bttnAltitude.Size = new System.Drawing.Size(210, 117);
			this.bttnAltitude.TabIndex = 16;
			this.bttnAltitude.Text = "Altitude";
			this.bttnAltitude.UseVisualStyleBackColor = true;
			this.bttnAltitude.Click += new System.EventHandler(this.BttnAltitudeClick);
			// 
			// bttnSpeed
			// 
			this.bttnSpeed.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.bttnSpeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.bttnSpeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.bttnSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnSpeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bttnSpeed.Location = new System.Drawing.Point(962, 354);
			this.bttnSpeed.Name = "bttnSpeed";
			this.bttnSpeed.Size = new System.Drawing.Size(210, 117);
			this.bttnSpeed.TabIndex = 18;
			this.bttnSpeed.Text = "Speed";
			this.bttnSpeed.UseVisualStyleBackColor = true;
			this.bttnSpeed.Click += new System.EventHandler(this.BttnSpeedClick);
			// 
			// bttnTurbulance
			// 
			this.bttnTurbulance.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.bttnTurbulance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.bttnTurbulance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.bttnTurbulance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnTurbulance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bttnTurbulance.Location = new System.Drawing.Point(708, 520);
			this.bttnTurbulance.Name = "bttnTurbulance";
			this.bttnTurbulance.Size = new System.Drawing.Size(210, 117);
			this.bttnTurbulance.TabIndex = 20;
			this.bttnTurbulance.Text = "Turbulance";
			this.bttnTurbulance.UseVisualStyleBackColor = true;
			this.bttnTurbulance.Click += new System.EventHandler(this.BttnTurbulanceClick);
			// 
			// bttnSet
			// 
			this.bttnSet.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.bttnSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.bttnSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.bttnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnSet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bttnSet.Location = new System.Drawing.Point(962, 520);
			this.bttnSet.Name = "bttnSet";
			this.bttnSet.Size = new System.Drawing.Size(210, 117);
			this.bttnSet.TabIndex = 21;
			this.bttnSet.Text = "Set";
			this.bttnSet.UseVisualStyleBackColor = true;
			this.bttnSet.Click += new System.EventHandler(this.BttnSetClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblTurbulanceInfo);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.lblSpeedInfo);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.lblAltitudeInfo);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.lblLayerInfo);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(708, 685);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(464, 169);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Details";
			// 
			// lblTurbulanceInfo
			// 
			this.lblTurbulanceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTurbulanceInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblTurbulanceInfo.Location = new System.Drawing.Point(271, 95);
			this.lblTurbulanceInfo.Name = "lblTurbulanceInfo";
			this.lblTurbulanceInfo.Size = new System.Drawing.Size(135, 23);
			this.lblTurbulanceInfo.TabIndex = 29;
			this.lblTurbulanceInfo.Text = "0";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label7.Location = new System.Drawing.Point(183, 96);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 23);
			this.label7.TabIndex = 30;
			this.label7.Text = "Turbulance:";
			// 
			// lblSpeedInfo
			// 
			this.lblSpeedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSpeedInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblSpeedInfo.Location = new System.Drawing.Point(91, 94);
			this.lblSpeedInfo.Name = "lblSpeedInfo";
			this.lblSpeedInfo.Size = new System.Drawing.Size(104, 23);
			this.lblSpeedInfo.TabIndex = 27;
			this.lblSpeedInfo.Text = "0";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label6.Location = new System.Drawing.Point(30, 95);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 23);
			this.label6.TabIndex = 28;
			this.label6.Text = "Speed:";
			// 
			// lblAltitudeInfo
			// 
			this.lblAltitudeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAltitudeInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblAltitudeInfo.Location = new System.Drawing.Point(271, 41);
			this.lblAltitudeInfo.Name = "lblAltitudeInfo";
			this.lblAltitudeInfo.Size = new System.Drawing.Size(135, 23);
			this.lblAltitudeInfo.TabIndex = 25;
			this.lblAltitudeInfo.Text = "0";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(210, 42);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 23);
			this.label5.TabIndex = 26;
			this.label5.Text = "Altitude:";
			// 
			// lblLayerInfo
			// 
			this.lblLayerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLayerInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblLayerInfo.Location = new System.Drawing.Point(84, 40);
			this.lblLayerInfo.Name = "lblLayerInfo";
			this.lblLayerInfo.Size = new System.Drawing.Size(59, 23);
			this.lblLayerInfo.TabIndex = 23;
			this.lblLayerInfo.Text = "1";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(30, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 23);
			this.label4.TabIndex = 24;
			this.label4.Text = "Layer:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1280, 1024);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.bttnSet);
			this.Controls.Add(this.bttnTurbulance);
			this.Controls.Add(this.bttnSpeed);
			this.Controls.Add(this.bttnAltitude);
			this.Controls.Add(this.bttnLayer3);
			this.Controls.Add(this.bttnLayer2);
			this.Controls.Add(this.bttnLayer1);
			this.Controls.Add(this.lblWindAngle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IOSees_Slave_Wind";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblTurbulanceInfo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblSpeedInfo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblAltitudeInfo;
		private System.Windows.Forms.Label lblLayerInfo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button bttnSet;
		private System.Windows.Forms.Button bttnSpeed;
		private System.Windows.Forms.Button bttnAltitude;
		private System.Windows.Forms.Button bttnTurbulance;
		private System.Windows.Forms.Button bttnLayer3;
		private System.Windows.Forms.Button bttnLayer2;
		private System.Windows.Forms.Button bttnLayer1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblWindAngle;
		private System.Windows.Forms.Panel panel;
	}
}
