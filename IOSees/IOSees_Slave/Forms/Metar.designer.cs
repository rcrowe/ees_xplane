/*
 * User: rcrowe
 * Date: 18/02/2010
 * Time: 12:58
 */
namespace Forms.IOSees_Slave_Metar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.bttnEGKK = new System.Windows.Forms.Button();
			this.bttnEGLL = new System.Windows.Forms.Button();
			this.bttnKSEA = new System.Windows.Forms.Button();
			this.bttnVHHH = new System.Windows.Forms.Button();
			this.bttnFADN = new System.Windows.Forms.Button();
			this.picWorld = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblPlace = new System.Windows.Forms.Label();
			this.lblLongitude = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblLatitude = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblMetar = new System.Windows.Forms.Label();
			this.bttnSet = new System.Windows.Forms.Button();
			this.bttnSave = new System.Windows.Forms.Button();
			this.bttnLoad = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picWorld)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(54, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "Metar";
			// 
			// bttnEGKK
			// 
			this.bttnEGKK.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.bttnEGKK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnEGKK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bttnEGKK.Location = new System.Drawing.Point(66, 147);
			this.bttnEGKK.Name = "bttnEGKK";
			this.bttnEGKK.Size = new System.Drawing.Size(210, 117);
			this.bttnEGKK.TabIndex = 1;
			this.bttnEGKK.Text = "EGKK";
			this.bttnEGKK.UseVisualStyleBackColor = true;
			this.bttnEGKK.Click += new System.EventHandler(this.BttnEGKKClick);
			this.bttnEGKK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BttnEGKKMouseDown);
			this.bttnEGKK.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BttnEGKKMouseUp);
			// 
			// bttnEGLL
			// 
			this.bttnEGLL.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.bttnEGLL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnEGLL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bttnEGLL.Location = new System.Drawing.Point(300, 147);
			this.bttnEGLL.Name = "bttnEGLL";
			this.bttnEGLL.Size = new System.Drawing.Size(210, 117);
			this.bttnEGLL.TabIndex = 2;
			this.bttnEGLL.Text = "EGLL";
			this.bttnEGLL.UseVisualStyleBackColor = true;
			this.bttnEGLL.Click += new System.EventHandler(this.BttnEGLLClick);
			this.bttnEGLL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BttnEGLLMouseDown);
			this.bttnEGLL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BttnEGLLMouseUp);
			// 
			// bttnKSEA
			// 
			this.bttnKSEA.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.bttnKSEA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnKSEA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bttnKSEA.Location = new System.Drawing.Point(534, 147);
			this.bttnKSEA.Name = "bttnKSEA";
			this.bttnKSEA.Size = new System.Drawing.Size(210, 117);
			this.bttnKSEA.TabIndex = 3;
			this.bttnKSEA.Text = "KSEA";
			this.bttnKSEA.UseVisualStyleBackColor = true;
			this.bttnKSEA.Click += new System.EventHandler(this.BttnKSEAClick);
			this.bttnKSEA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BttnKSEAMouseDown);
			this.bttnKSEA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BttnKSEAMouseUp);
			// 
			// bttnVHHH
			// 
			this.bttnVHHH.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.bttnVHHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnVHHH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bttnVHHH.Location = new System.Drawing.Point(768, 147);
			this.bttnVHHH.Name = "bttnVHHH";
			this.bttnVHHH.Size = new System.Drawing.Size(210, 117);
			this.bttnVHHH.TabIndex = 4;
			this.bttnVHHH.Text = "VHHH";
			this.bttnVHHH.UseVisualStyleBackColor = true;
			this.bttnVHHH.Click += new System.EventHandler(this.BttnVHHHClick);
			this.bttnVHHH.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BttnVHHHMouseDown);
			this.bttnVHHH.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BttnVHHHMouseUp);
			// 
			// bttnFADN
			// 
			this.bttnFADN.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.bttnFADN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnFADN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bttnFADN.Location = new System.Drawing.Point(1004, 147);
			this.bttnFADN.Name = "bttnFADN";
			this.bttnFADN.Size = new System.Drawing.Size(210, 117);
			this.bttnFADN.TabIndex = 5;
			this.bttnFADN.Text = "FADN";
			this.bttnFADN.UseVisualStyleBackColor = true;
			this.bttnFADN.Click += new System.EventHandler(this.BttnFADNClick);
			this.bttnFADN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BttnFADNMouseDown);
			this.bttnFADN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BttnFADNMouseUp);
			// 
			// picWorld
			// 
			this.picWorld.Image = ((System.Drawing.Image)(resources.GetObject("picWorld.Image")));
			this.picWorld.InitialImage = ((System.Drawing.Image)(resources.GetObject("picWorld.InitialImage")));
			this.picWorld.Location = new System.Drawing.Point(514, 318);
			this.picWorld.Name = "picWorld";
			this.picWorld.Size = new System.Drawing.Size(700, 326);
			this.picWorld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picWorld.TabIndex = 6;
			this.picWorld.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(66, 345);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Place:";
			// 
			// lblPlace
			// 
			this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblPlace.Location = new System.Drawing.Point(158, 331);
			this.lblPlace.Name = "lblPlace";
			this.lblPlace.Size = new System.Drawing.Size(334, 43);
			this.lblPlace.TabIndex = 8;
			this.lblPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblLongitude
			// 
			this.lblLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLongitude.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblLongitude.Location = new System.Drawing.Point(158, 404);
			this.lblLongitude.Name = "lblLongitude";
			this.lblLongitude.Size = new System.Drawing.Size(334, 43);
			this.lblLongitude.TabIndex = 10;
			this.lblLongitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(66, 418);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Longitude:";
			// 
			// lblLatitude
			// 
			this.lblLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLatitude.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblLatitude.Location = new System.Drawing.Point(158, 477);
			this.lblLatitude.Name = "lblLatitude";
			this.lblLatitude.Size = new System.Drawing.Size(334, 43);
			this.lblLatitude.TabIndex = 12;
			this.lblLatitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label7.Location = new System.Drawing.Point(66, 491);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Latitude:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(66, 711);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 23);
			this.label3.TabIndex = 13;
			this.label3.Text = "Live Metar:";
			// 
			// lblMetar
			// 
			this.lblMetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMetar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblMetar.Location = new System.Drawing.Point(158, 700);
			this.lblMetar.Name = "lblMetar";
			this.lblMetar.Size = new System.Drawing.Size(1056, 43);
			this.lblMetar.TabIndex = 14;
			this.lblMetar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// bttnSet
			// 
			this.bttnSet.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.bttnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnSet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bttnSet.Location = new System.Drawing.Point(1004, 861);
			this.bttnSet.Name = "bttnSet";
			this.bttnSet.Size = new System.Drawing.Size(210, 117);
			this.bttnSet.TabIndex = 15;
			this.bttnSet.Text = "Set";
			this.bttnSet.UseVisualStyleBackColor = true;
			this.bttnSet.Click += new System.EventHandler(this.BttnSetClick);
			// 
			// bttnSave
			// 
			this.bttnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.bttnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bttnSave.Location = new System.Drawing.Point(768, 861);
			this.bttnSave.Name = "bttnSave";
			this.bttnSave.Size = new System.Drawing.Size(210, 117);
			this.bttnSave.TabIndex = 16;
			this.bttnSave.Text = "Save";
			this.bttnSave.UseVisualStyleBackColor = true;
			this.bttnSave.Click += new System.EventHandler(this.BttnSaveClick);
			// 
			// bttnLoad
			// 
			this.bttnLoad.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.bttnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bttnLoad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bttnLoad.Location = new System.Drawing.Point(529, 861);
			this.bttnLoad.Name = "bttnLoad";
			this.bttnLoad.Size = new System.Drawing.Size(210, 117);
			this.bttnLoad.TabIndex = 17;
			this.bttnLoad.Text = "Load";
			this.bttnLoad.UseVisualStyleBackColor = true;
			this.bttnLoad.Click += new System.EventHandler(this.BttnLoadClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlText;
			this.ClientSize = new System.Drawing.Size(1280, 1024);
			this.ControlBox = false;
			this.Controls.Add(this.bttnLoad);
			this.Controls.Add(this.bttnSave);
			this.Controls.Add(this.bttnSet);
			this.Controls.Add(this.lblMetar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblLatitude);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblLongitude);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblPlace);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.picWorld);
			this.Controls.Add(this.bttnFADN);
			this.Controls.Add(this.bttnVHHH);
			this.Controls.Add(this.bttnKSEA);
			this.Controls.Add(this.bttnEGLL);
			this.Controls.Add(this.bttnEGKK);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "IOSees_Slave_Metar";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.picWorld)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox picWorld;
		private System.Windows.Forms.Button bttnLoad;
		private System.Windows.Forms.Button bttnSave;
		private System.Windows.Forms.Button bttnSet;
		private System.Windows.Forms.Label lblMetar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bttnVHHH;
		private System.Windows.Forms.Button bttnFADN;
		private System.Windows.Forms.Button bttnKSEA;
		private System.Windows.Forms.Button bttnEGLL;
		private System.Windows.Forms.Label lblLatitude;
		private System.Windows.Forms.Label lblLongitude;
		private System.Windows.Forms.Label lblPlace;
		private System.Windows.Forms.Button bttnEGKK;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
