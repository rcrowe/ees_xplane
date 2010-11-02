namespace IOSees_Master
{
    partial class IOS_Master
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
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnWeather = new System.Windows.Forms.Button();
            this.bttnMetar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(377, 314);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(75, 23);
            this.bttnExit.TabIndex = 0;
            this.bttnExit.Text = "Exit";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bttnWeather
            // 
            this.bttnWeather.Location = new System.Drawing.Point(27, 23);
            this.bttnWeather.Name = "bttnWeather";
            this.bttnWeather.Size = new System.Drawing.Size(75, 23);
            this.bttnWeather.TabIndex = 1;
            this.bttnWeather.Text = "Weather";
            this.bttnWeather.UseVisualStyleBackColor = true;
            this.bttnWeather.Click += new System.EventHandler(this.bttnTest_Click);
            // 
            // bttnMetar
            // 
            this.bttnMetar.Location = new System.Drawing.Point(108, 23);
            this.bttnMetar.Name = "bttnMetar";
            this.bttnMetar.Size = new System.Drawing.Size(75, 23);
            this.bttnMetar.TabIndex = 2;
            this.bttnMetar.Text = "Metar";
            this.bttnMetar.UseVisualStyleBackColor = true;
            this.bttnMetar.Click += new System.EventHandler(this.bttnMetar_Click);
            // 
            // IOS_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 349);
            this.Controls.Add(this.bttnMetar);
            this.Controls.Add(this.bttnWeather);
            this.Controls.Add(this.bttnExit);
            this.Name = "IOS_Master";
            this.Text = "Menu_Top";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnWeather;
        private System.Windows.Forms.Button bttnMetar;
    }
}