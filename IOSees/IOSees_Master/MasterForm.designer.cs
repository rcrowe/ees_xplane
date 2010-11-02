/*
 * User: rcrowe
 * Date: 16/02/2010
 * Time: 09:41
 */
namespace IOSees_Master
{
	partial class MasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.picWeather = new System.Windows.Forms.PictureBox();
            this.bttnWeather = new System.Windows.Forms.Button();
            this.lblWeather = new System.Windows.Forms.Label();
            this.lblCloud = new System.Windows.Forms.Label();
            this.picCloud = new System.Windows.Forms.PictureBox();
            this.bttnCloud = new System.Windows.Forms.Button();
            this.lblWind = new System.Windows.Forms.Label();
            this.picWind = new System.Windows.Forms.PictureBox();
            this.bttnWind = new System.Windows.Forms.Button();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.picAltitude = new System.Windows.Forms.PictureBox();
            this.bttnAltitude = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblMetar = new System.Windows.Forms.Label();
            this.picMetar = new System.Windows.Forms.PictureBox();
            this.bttnMetar = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.picTime = new System.Windows.Forms.PictureBox();
            this.bttnTime = new System.Windows.Forms.Button();
            this.lblRecentWeather = new System.Windows.Forms.Label();
            this.picRecentWeather = new System.Windows.Forms.PictureBox();
            this.bttnRecentWeather = new System.Windows.Forms.Button();
            this.lblWindShear = new System.Windows.Forms.Label();
            this.picWindShear = new System.Windows.Forms.PictureBox();
            this.bttnWindShear = new System.Windows.Forms.Button();
            this.lblVisibility = new System.Windows.Forms.Label();
            this.picVisibility = new System.Windows.Forms.PictureBox();
            this.bttnVisibility = new System.Windows.Forms.Button();
            this.lblRunwayVisibility = new System.Windows.Forms.Label();
            this.picRunwayVisibility = new System.Windows.Forms.PictureBox();
            this.bttnRunwayVisibility = new System.Windows.Forms.Button();
            this.lblTrend = new System.Windows.Forms.Label();
            this.picTrend = new System.Windows.Forms.PictureBox();
            this.bttnTrend = new System.Windows.Forms.Button();
            this.lblClear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAltitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMetar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecentWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWindShear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVisibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRunwayVisibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrend)).BeginInit();
            this.SuspendLayout();
            // 
            // picWeather
            // 
            this.picWeather.Image = ((System.Drawing.Image)(resources.GetObject("picWeather.Image")));
            this.picWeather.InitialImage = ((System.Drawing.Image)(resources.GetObject("picWeather.InitialImage")));
            this.picWeather.Location = new System.Drawing.Point(129, 105);
            this.picWeather.Name = "picWeather";
            this.picWeather.Size = new System.Drawing.Size(101, 98);
            this.picWeather.TabIndex = 0;
            this.picWeather.TabStop = false;
            this.picWeather.Click += new System.EventHandler(this.PicWeatherClick);
            // 
            // bttnWeather
            // 
            this.bttnWeather.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnWeather.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttnWeather.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bttnWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnWeather.Location = new System.Drawing.Point(54, 62);
            this.bttnWeather.Name = "bttnWeather";
            this.bttnWeather.Size = new System.Drawing.Size(250, 215);
            this.bttnWeather.TabIndex = 1;
            this.bttnWeather.UseVisualStyleBackColor = true;
            this.bttnWeather.Click += new System.EventHandler(this.BttnWeatherClick);
            // 
            // lblWeather
            // 
            this.lblWeather.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeather.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWeather.Location = new System.Drawing.Point(67, 219);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(225, 23);
            this.lblWeather.TabIndex = 2;
            this.lblWeather.Text = "Weather";
            this.lblWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWeather.Click += new System.EventHandler(this.LblWeatherClick);
            // 
            // lblCloud
            // 
            this.lblCloud.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblCloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloud.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCloud.Location = new System.Drawing.Point(384, 219);
            this.lblCloud.Name = "lblCloud";
            this.lblCloud.Size = new System.Drawing.Size(220, 23);
            this.lblCloud.TabIndex = 5;
            this.lblCloud.Text = "Cloud";
            this.lblCloud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCloud.Click += new System.EventHandler(this.LblCloudClick);
            // 
            // picCloud
            // 
            this.picCloud.Image = ((System.Drawing.Image)(resources.GetObject("picCloud.Image")));
            this.picCloud.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCloud.InitialImage")));
            this.picCloud.Location = new System.Drawing.Point(436, 112);
            this.picCloud.Name = "picCloud";
            this.picCloud.Size = new System.Drawing.Size(126, 98);
            this.picCloud.TabIndex = 3;
            this.picCloud.TabStop = false;
            this.picCloud.Click += new System.EventHandler(this.PicCloudClick);
            // 
            // bttnCloud
            // 
            this.bttnCloud.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnCloud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttnCloud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bttnCloud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCloud.Location = new System.Drawing.Point(370, 62);
            this.bttnCloud.Name = "bttnCloud";
            this.bttnCloud.Size = new System.Drawing.Size(250, 215);
            this.bttnCloud.TabIndex = 2;
            this.bttnCloud.UseVisualStyleBackColor = true;
            this.bttnCloud.Click += new System.EventHandler(this.BttnCloudClick);
            // 
            // lblWind
            // 
            this.lblWind.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWind.Location = new System.Drawing.Point(686, 220);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(222, 23);
            this.lblWind.TabIndex = 8;
            this.lblWind.Text = "Wind";
            this.lblWind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWind.Click += new System.EventHandler(this.LblWindClick);
            // 
            // picWind
            // 
            this.picWind.Image = ((System.Drawing.Image)(resources.GetObject("picWind.Image")));
            this.picWind.InitialImage = ((System.Drawing.Image)(resources.GetObject("picWind.InitialImage")));
            this.picWind.Location = new System.Drawing.Point(717, 94);
            this.picWind.Name = "picWind";
            this.picWind.Size = new System.Drawing.Size(155, 116);
            this.picWind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWind.TabIndex = 6;
            this.picWind.TabStop = false;
            this.picWind.Click += new System.EventHandler(this.PicWindClick);
            // 
            // bttnWind
            // 
            this.bttnWind.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnWind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttnWind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bttnWind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnWind.Location = new System.Drawing.Point(672, 62);
            this.bttnWind.Name = "bttnWind";
            this.bttnWind.Size = new System.Drawing.Size(250, 215);
            this.bttnWind.TabIndex = 3;
            this.bttnWind.UseVisualStyleBackColor = true;
            this.bttnWind.Click += new System.EventHandler(this.BttnWindClick);
            // 
            // lblAltitude
            // 
            this.lblAltitude.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltitude.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAltitude.Location = new System.Drawing.Point(984, 220);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(229, 23);
            this.lblAltitude.TabIndex = 11;
            this.lblAltitude.Text = "Altitude";
            this.lblAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAltitude.Click += new System.EventHandler(this.LblAltitudeClick);
            // 
            // picAltitude
            // 
            this.picAltitude.Image = ((System.Drawing.Image)(resources.GetObject("picAltitude.Image")));
            this.picAltitude.InitialImage = ((System.Drawing.Image)(resources.GetObject("picAltitude.InitialImage")));
            this.picAltitude.Location = new System.Drawing.Point(1037, 101);
            this.picAltitude.Name = "picAltitude";
            this.picAltitude.Size = new System.Drawing.Size(119, 109);
            this.picAltitude.TabIndex = 9;
            this.picAltitude.TabStop = false;
            this.picAltitude.Click += new System.EventHandler(this.PicAltitudeClick);
            // 
            // bttnAltitude
            // 
            this.bttnAltitude.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnAltitude.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttnAltitude.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bttnAltitude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAltitude.Location = new System.Drawing.Point(972, 62);
            this.bttnAltitude.Name = "bttnAltitude";
            this.bttnAltitude.Size = new System.Drawing.Size(250, 215);
            this.bttnAltitude.TabIndex = 4;
            this.bttnAltitude.UseVisualStyleBackColor = true;
            this.bttnAltitude.Click += new System.EventHandler(this.BttnAltitudeClick);
            // 
            // lblExit
            // 
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.DimGray;
            this.lblExit.Location = new System.Drawing.Point(1216, 982);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(43, 23);
            this.lblExit.TabIndex = 14;
            this.lblExit.Text = "EXIT";
            this.lblExit.MouseLeave += new System.EventHandler(this.LblExitMouseLeave);
            this.lblExit.Click += new System.EventHandler(this.LblExitClick);
            this.lblExit.MouseEnter += new System.EventHandler(this.LblExitMouseEnter);
            // 
            // lblMetar
            // 
            this.lblMetar.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblMetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMetar.Location = new System.Drawing.Point(67, 498);
            this.lblMetar.Name = "lblMetar";
            this.lblMetar.Size = new System.Drawing.Size(225, 23);
            this.lblMetar.TabIndex = 15;
            this.lblMetar.Text = "Metar";
            this.lblMetar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMetar.Click += new System.EventHandler(this.LblMetarClick);
            // 
            // picMetar
            // 
            this.picMetar.Image = ((System.Drawing.Image)(resources.GetObject("picMetar.Image")));
            this.picMetar.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMetar.InitialImage")));
            this.picMetar.Location = new System.Drawing.Point(103, 394);
            this.picMetar.Name = "picMetar";
            this.picMetar.Size = new System.Drawing.Size(152, 77);
            this.picMetar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMetar.TabIndex = 13;
            this.picMetar.TabStop = false;
            this.picMetar.Click += new System.EventHandler(this.PicMetarClick);
            // 
            // bttnMetar
            // 
            this.bttnMetar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnMetar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttnMetar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bttnMetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMetar.Location = new System.Drawing.Point(54, 341);
            this.bttnMetar.Name = "bttnMetar";
            this.bttnMetar.Size = new System.Drawing.Size(250, 215);
            this.bttnMetar.TabIndex = 5;
            this.bttnMetar.UseVisualStyleBackColor = true;
            this.bttnMetar.Click += new System.EventHandler(this.BttnMetarClick);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(67, 780);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(225, 23);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.Click += new System.EventHandler(this.LblTimeClick);
            // 
            // picTime
            // 
            this.picTime.Image = ((System.Drawing.Image)(resources.GetObject("picTime.Image")));
            this.picTime.InitialImage = ((System.Drawing.Image)(resources.GetObject("picTime.InitialImage")));
            this.picTime.Location = new System.Drawing.Point(114, 659);
            this.picTime.Name = "picTime";
            this.picTime.Size = new System.Drawing.Size(134, 105);
            this.picTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTime.TabIndex = 16;
            this.picTime.TabStop = false;
            this.picTime.Click += new System.EventHandler(this.PicTimeClick);
            // 
            // bttnTime
            // 
            this.bttnTime.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttnTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bttnTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnTime.Location = new System.Drawing.Point(54, 623);
            this.bttnTime.Name = "bttnTime";
            this.bttnTime.Size = new System.Drawing.Size(250, 215);
            this.bttnTime.TabIndex = 9;
            this.bttnTime.UseVisualStyleBackColor = true;
            this.bttnTime.Click += new System.EventHandler(this.BttnTimeClick);
            // 
            // lblRecentWeather
            // 
            this.lblRecentWeather.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblRecentWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentWeather.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRecentWeather.Location = new System.Drawing.Point(383, 498);
            this.lblRecentWeather.Name = "lblRecentWeather";
            this.lblRecentWeather.Size = new System.Drawing.Size(225, 23);
            this.lblRecentWeather.TabIndex = 21;
            this.lblRecentWeather.Text = "Recent Weather";
            this.lblRecentWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecentWeather.Click += new System.EventHandler(this.LblRecentWeatherClick);
            // 
            // picRecentWeather
            // 
            this.picRecentWeather.Image = ((System.Drawing.Image)(resources.GetObject("picRecentWeather.Image")));
            this.picRecentWeather.InitialImage = ((System.Drawing.Image)(resources.GetObject("picRecentWeather.InitialImage")));
            this.picRecentWeather.Location = new System.Drawing.Point(423, 384);
            this.picRecentWeather.Name = "picRecentWeather";
            this.picRecentWeather.Size = new System.Drawing.Size(149, 98);
            this.picRecentWeather.TabIndex = 19;
            this.picRecentWeather.TabStop = false;
            this.picRecentWeather.Click += new System.EventHandler(this.PicRecentWeatherClick);
            // 
            // bttnRecentWeather
            // 
            this.bttnRecentWeather.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnRecentWeather.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttnRecentWeather.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bttnRecentWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRecentWeather.Location = new System.Drawing.Point(370, 341);
            this.bttnRecentWeather.Name = "bttnRecentWeather";
            this.bttnRecentWeather.Size = new System.Drawing.Size(250, 215);
            this.bttnRecentWeather.TabIndex = 6;
            this.bttnRecentWeather.UseVisualStyleBackColor = true;
            this.bttnRecentWeather.Click += new System.EventHandler(this.BttnRecentWeatherClick);
            // 
            // lblWindShear
            // 
            this.lblWindShear.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblWindShear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindShear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWindShear.Location = new System.Drawing.Point(383, 780);
            this.lblWindShear.Name = "lblWindShear";
            this.lblWindShear.Size = new System.Drawing.Size(225, 23);
            this.lblWindShear.TabIndex = 24;
            this.lblWindShear.Text = "Wind Shear";
            this.lblWindShear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWindShear.Click += new System.EventHandler(this.LblWindShearClick);
            // 
            // picWindShear
            // 
            this.picWindShear.Image = ((System.Drawing.Image)(resources.GetObject("picWindShear.Image")));
            this.picWindShear.InitialImage = ((System.Drawing.Image)(resources.GetObject("picWindShear.InitialImage")));
            this.picWindShear.Location = new System.Drawing.Point(421, 668);
            this.picWindShear.Name = "picWindShear";
            this.picWindShear.Size = new System.Drawing.Size(144, 98);
            this.picWindShear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWindShear.TabIndex = 22;
            this.picWindShear.TabStop = false;
            this.picWindShear.Click += new System.EventHandler(this.PicWindShearClick);
            // 
            // bttnWindShear
            // 
            this.bttnWindShear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnWindShear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttnWindShear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bttnWindShear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnWindShear.Location = new System.Drawing.Point(370, 623);
            this.bttnWindShear.Name = "bttnWindShear";
            this.bttnWindShear.Size = new System.Drawing.Size(250, 215);
            this.bttnWindShear.TabIndex = 10;
            this.bttnWindShear.UseVisualStyleBackColor = true;
            this.bttnWindShear.Click += new System.EventHandler(this.BttnWindShearClick);
            // 
            // lblVisibility
            // 
            this.lblVisibility.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisibility.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVisibility.Location = new System.Drawing.Point(685, 498);
            this.lblVisibility.Name = "lblVisibility";
            this.lblVisibility.Size = new System.Drawing.Size(225, 23);
            this.lblVisibility.TabIndex = 27;
            this.lblVisibility.Text = "Visibility";
            this.lblVisibility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVisibility.Click += new System.EventHandler(this.LblVisibilityClick);
            // 
            // picVisibility
            // 
            this.picVisibility.Image = ((System.Drawing.Image)(resources.GetObject("picVisibility.Image")));
            this.picVisibility.InitialImage = ((System.Drawing.Image)(resources.GetObject("picVisibility.InitialImage")));
            this.picVisibility.Location = new System.Drawing.Point(735, 383);
            this.picVisibility.Name = "picVisibility";
            this.picVisibility.Size = new System.Drawing.Size(101, 98);
            this.picVisibility.TabIndex = 25;
            this.picVisibility.TabStop = false;
            this.picVisibility.Click += new System.EventHandler(this.PicVisibilityClick);
            // 
            // bttnVisibility
            // 
            this.bttnVisibility.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnVisibility.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttnVisibility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bttnVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnVisibility.Location = new System.Drawing.Point(672, 341);
            this.bttnVisibility.Name = "bttnVisibility";
            this.bttnVisibility.Size = new System.Drawing.Size(250, 215);
            this.bttnVisibility.TabIndex = 7;
            this.bttnVisibility.UseVisualStyleBackColor = true;
            this.bttnVisibility.Click += new System.EventHandler(this.BttnVisibilityClick);
            // 
            // lblRunwayVisibility
            // 
            this.lblRunwayVisibility.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblRunwayVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunwayVisibility.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRunwayVisibility.Location = new System.Drawing.Point(985, 498);
            this.lblRunwayVisibility.Name = "lblRunwayVisibility";
            this.lblRunwayVisibility.Size = new System.Drawing.Size(225, 23);
            this.lblRunwayVisibility.TabIndex = 30;
            this.lblRunwayVisibility.Text = "Runway Visibility";
            this.lblRunwayVisibility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRunwayVisibility.Click += new System.EventHandler(this.LblRunwayVisibilityClick);
            // 
            // picRunwayVisibility
            // 
            this.picRunwayVisibility.Image = ((System.Drawing.Image)(resources.GetObject("picRunwayVisibility.Image")));
            this.picRunwayVisibility.InitialImage = ((System.Drawing.Image)(resources.GetObject("picRunwayVisibility.InitialImage")));
            this.picRunwayVisibility.Location = new System.Drawing.Point(1026, 383);
            this.picRunwayVisibility.Name = "picRunwayVisibility";
            this.picRunwayVisibility.Size = new System.Drawing.Size(123, 111);
            this.picRunwayVisibility.TabIndex = 28;
            this.picRunwayVisibility.TabStop = false;
            this.picRunwayVisibility.Click += new System.EventHandler(this.PicRunwayVisibilityClick);
            // 
            // bttnRunwayVisibility
            // 
            this.bttnRunwayVisibility.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnRunwayVisibility.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttnRunwayVisibility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bttnRunwayVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRunwayVisibility.Location = new System.Drawing.Point(972, 341);
            this.bttnRunwayVisibility.Name = "bttnRunwayVisibility";
            this.bttnRunwayVisibility.Size = new System.Drawing.Size(250, 215);
            this.bttnRunwayVisibility.TabIndex = 8;
            this.bttnRunwayVisibility.UseVisualStyleBackColor = true;
            this.bttnRunwayVisibility.Click += new System.EventHandler(this.BttnRunwayVisibilityClick);
            // 
            // lblTrend
            // 
            this.lblTrend.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblTrend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTrend.Location = new System.Drawing.Point(685, 780);
            this.lblTrend.Name = "lblTrend";
            this.lblTrend.Size = new System.Drawing.Size(225, 23);
            this.lblTrend.TabIndex = 33;
            this.lblTrend.Text = "Trend";
            this.lblTrend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTrend.Click += new System.EventHandler(this.LblTrendClick);
            // 
            // picTrend
            // 
            this.picTrend.Image = ((System.Drawing.Image)(resources.GetObject("picTrend.Image")));
            this.picTrend.InitialImage = ((System.Drawing.Image)(resources.GetObject("picTrend.InitialImage")));
            this.picTrend.Location = new System.Drawing.Point(732, 665);
            this.picTrend.Name = "picTrend";
            this.picTrend.Size = new System.Drawing.Size(133, 108);
            this.picTrend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTrend.TabIndex = 31;
            this.picTrend.TabStop = false;
            this.picTrend.Click += new System.EventHandler(this.PicTrendClick);
            // 
            // bttnTrend
            // 
            this.bttnTrend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnTrend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttnTrend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bttnTrend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnTrend.Location = new System.Drawing.Point(672, 623);
            this.bttnTrend.Name = "bttnTrend";
            this.bttnTrend.Size = new System.Drawing.Size(250, 215);
            this.bttnTrend.TabIndex = 11;
            this.bttnTrend.UseVisualStyleBackColor = true;
            this.bttnTrend.Click += new System.EventHandler(this.BttnTrendClick);
            // 
            // lblClear
            // 
            this.lblClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.DimGray;
            this.lblClear.Location = new System.Drawing.Point(1149, 982);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(61, 23);
            this.lblClear.TabIndex = 13;
            this.lblClear.Text = "CLEAR";
            this.lblClear.MouseLeave += new System.EventHandler(this.LblClearMouseLeave);
            this.lblClear.Click += new System.EventHandler(this.LblClearClick);
            this.lblClear.MouseEnter += new System.EventHandler(this.LblClearMouseEnter);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.ControlBox = false;
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.lblTrend);
            this.Controls.Add(this.picTrend);
            this.Controls.Add(this.bttnTrend);
            this.Controls.Add(this.lblRunwayVisibility);
            this.Controls.Add(this.picRunwayVisibility);
            this.Controls.Add(this.bttnRunwayVisibility);
            this.Controls.Add(this.lblVisibility);
            this.Controls.Add(this.picVisibility);
            this.Controls.Add(this.bttnVisibility);
            this.Controls.Add(this.lblWindShear);
            this.Controls.Add(this.picWindShear);
            this.Controls.Add(this.bttnWindShear);
            this.Controls.Add(this.lblRecentWeather);
            this.Controls.Add(this.picRecentWeather);
            this.Controls.Add(this.bttnRecentWeather);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picTime);
            this.Controls.Add(this.bttnTime);
            this.Controls.Add(this.lblMetar);
            this.Controls.Add(this.picMetar);
            this.Controls.Add(this.bttnMetar);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblAltitude);
            this.Controls.Add(this.picAltitude);
            this.Controls.Add(this.bttnAltitude);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.picWind);
            this.Controls.Add(this.bttnWind);
            this.Controls.Add(this.lblCloud);
            this.Controls.Add(this.picCloud);
            this.Controls.Add(this.bttnCloud);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.picWeather);
            this.Controls.Add(this.bttnWeather);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "MasterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IOSees_Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAltitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMetar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecentWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWindShear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVisibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRunwayVisibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrend)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label lblClear;
		private System.Windows.Forms.Button bttnTime;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.PictureBox picTime;
		private System.Windows.Forms.Label lblWindShear;
		private System.Windows.Forms.PictureBox picWindShear;
		private System.Windows.Forms.Button bttnWindShear;
		private System.Windows.Forms.Label lblVisibility;
		private System.Windows.Forms.PictureBox picVisibility;
		private System.Windows.Forms.Button bttnVisibility;
		private System.Windows.Forms.Label lblRunwayVisibility;
		private System.Windows.Forms.PictureBox picRunwayVisibility;
		private System.Windows.Forms.Button bttnRunwayVisibility;
		private System.Windows.Forms.Label lblTrend;
		private System.Windows.Forms.PictureBox picTrend;
		private System.Windows.Forms.Button bttnTrend;
		private System.Windows.Forms.Label lblRecentWeather;
		private System.Windows.Forms.PictureBox picRecentWeather;
		private System.Windows.Forms.Button bttnRecentWeather;
		private System.Windows.Forms.Label lblMetar;
		private System.Windows.Forms.PictureBox picMetar;
		private System.Windows.Forms.Button bttnMetar;
		private System.Windows.Forms.Label lblAltitude;
		private System.Windows.Forms.PictureBox picAltitude;
		private System.Windows.Forms.Button bttnAltitude;
		private System.Windows.Forms.Label lblExit;
		private System.Windows.Forms.Button bttnWind;
		private System.Windows.Forms.PictureBox picWind;
		private System.Windows.Forms.Label lblWind;
		private System.Windows.Forms.Button bttnCloud;
		private System.Windows.Forms.PictureBox picCloud;
		private System.Windows.Forms.Label lblCloud;
		private System.Windows.Forms.PictureBox picWeather;
		private System.Windows.Forms.Label lblWeather;
		private System.Windows.Forms.Button bttnWeather;
	}
}
