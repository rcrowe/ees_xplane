/*
 * User: rcrowe
 * Date: 16/02/2010
 * Time: 09:41
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

using Lidgren.Network;

namespace IOSees_Master
{
    /// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MasterForm : Form
	{
        private Config config;

		public MasterForm()
		{
			InitializeComponent();

            config = Config.Instance;
		}
		
		private void SetButton(string bttn)
		{
			//Lets clear everyone back to white
			//Weather
			this.bttnWeather.FlatAppearance.BorderColor = Color.White;
			this.lblWeather.ForeColor = Color.White;
			//Cloud
			this.bttnCloud.FlatAppearance.BorderColor = Color.White;
			this.lblCloud.ForeColor = Color.White;
			//Wind
			this.bttnWind.FlatAppearance.BorderColor = Color.White;
			this.lblWind.ForeColor = Color.White;
			//Altitude
			this.bttnAltitude.FlatAppearance.BorderColor = Color.White;
			this.lblAltitude.ForeColor = Color.White;
			//Metar
			this.bttnMetar.FlatAppearance.BorderColor = Color.White;
			this.lblMetar.ForeColor = Color.White;
			//Recent weather
			this.bttnRecentWeather.FlatAppearance.BorderColor = Color.White;
			this.lblRecentWeather.ForeColor = Color.White;
			//Visibility
			this.bttnVisibility.FlatAppearance.BorderColor = Color.White;
			this.lblVisibility.ForeColor = Color.White;
			//Runway Visibility
			this.bttnRunwayVisibility.FlatAppearance.BorderColor = Color.White;
			this.lblRunwayVisibility.ForeColor = Color.White;
			//Time
			this.bttnTime.FlatAppearance.BorderColor = Color.White;
			this.lblTime.ForeColor = Color.White;
			//Wind Shear
			this.bttnWindShear.FlatAppearance.BorderColor = Color.White;
			this.lblWindShear.ForeColor = Color.White;
			//Trend
			this.bttnTrend.FlatAppearance.BorderColor = Color.White;
			this.lblTrend.ForeColor = Color.White;
			
			
			if(bttn == "weather")
			{
				this.bttnWeather.FlatAppearance.BorderColor = Color.DarkGreen;
				this.lblWeather.ForeColor = Color.DarkGreen;
			}
			
			if(bttn == "cloud")
			{
				this.bttnCloud.FlatAppearance.BorderColor = Color.DarkGreen;
				this.lblCloud.ForeColor = Color.DarkGreen;
			}
			
			if(bttn == "wind")
			{
				this.bttnWind.FlatAppearance.BorderColor = Color.DarkGreen;
				this.lblWind.ForeColor = Color.DarkGreen;
			}
			
			if(bttn == "altitude")
			{
				this.bttnAltitude.FlatAppearance.BorderColor = Color.DarkGreen;
				this.lblAltitude.ForeColor = Color.DarkGreen;
			}
			
			if(bttn == "metar")
			{
				this.bttnMetar.FlatAppearance.BorderColor = Color.DarkGreen;
				this.lblMetar.ForeColor = Color.DarkGreen;
			}
			
			if(bttn == "recentweather")
			{
				this.bttnRecentWeather.FlatAppearance.BorderColor = Color.DarkGreen;
				this.lblRecentWeather.ForeColor = Color.DarkGreen;
			}
			
			if(bttn == "visibility")
			{
				this.bttnVisibility.FlatAppearance.BorderColor = Color.DarkGreen;
				this.lblVisibility.ForeColor = Color.DarkGreen;
			}
			
			if(bttn == "runwayvisibility")
			{
				this.bttnRunwayVisibility.FlatAppearance.BorderColor = Color.DarkGreen;
				this.lblRunwayVisibility.ForeColor = Color.DarkGreen;
			}
			
			if(bttn == "time")
			{
				this.bttnTime.FlatAppearance.BorderColor = Color.DarkGreen;
				this.lblTime.ForeColor = Color.DarkGreen;
			}
			
			if(bttn == "windshear")
			{
				this.bttnWindShear.FlatAppearance.BorderColor = Color.DarkGreen;
				this.lblWindShear.ForeColor = Color.DarkGreen;
			}
			
			if(bttn == "trend")
			{
				this.bttnTrend.FlatAppearance.BorderColor = Color.DarkGreen;
				this.lblTrend.ForeColor = Color.DarkGreen;
			}
		}
		
		
		void PicWeatherClick(object sender, EventArgs e)
		{
			this.WeatherClick();
		}
		
		void LblWeatherClick(object sender, EventArgs e)
		{
			this.WeatherClick();
		}
		
		void BttnWeatherClick(object sender, EventArgs e)
		{
			this.WeatherClick();
		}
		
		private void WeatherClick()
		{
			SetButton("weather");
            this.SendMessage("page:weather");
		}
		
		
		void PicCloudClick(object sender, EventArgs e)
		{
			this.CloudClick();
		}
		
		void LblCloudClick(object sender, EventArgs e)
		{
			this.CloudClick();
		}
		
		void BttnCloudClick(object sender, EventArgs e)
		{
			this.CloudClick();
		}
		
		private void CloudClick()
		{
			SetButton("cloud");
            this.SendMessage("page:cloud");
		}
		
		
		void BttnWindClick(object sender, EventArgs e)
		{
			this.WindClick();
		}
		
		void PicWindClick(object sender, EventArgs e)
		{
			this.WindClick();
		}
		
		void LblWindClick(object sender, EventArgs e)
		{
			this.WindClick();
		}
		
		private void WindClick()
		{
			SetButton("wind");
            this.SendMessage("page:wind");
		}
		
		
		void LblExitClick(object sender, EventArgs e)
		{
			Console.WriteLine("Client: IOS Master exited");
            Console.Write("Client: Closing connections to server");

            config.Client.keep_running = false;

            //Give it time to send message and server do its thing
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }

            this.Close();
		}
		
		
		void BttnAltitudeClick(object sender, EventArgs e)
		{
			this.AltitudeClick();
		}
		
		void PicAltitudeClick(object sender, EventArgs e)
		{
			this.AltitudeClick();
		}
		
		void LblAltitudeClick(object sender, EventArgs e)
		{
			this.AltitudeClick();
		}
		
		private void AltitudeClick()
		{
			SetButton("altitude");
            this.SendMessage("page:altitude");
		}
		
		
		void PicMetarClick(object sender, EventArgs e)
		{
			this.MetarClick();
		}
		
		void BttnMetarClick(object sender, EventArgs e)
		{
			this.MetarClick();
		}
		
		void LblMetarClick(object sender, EventArgs e)
		{
			this.MetarClick();
		}
		
		private void MetarClick()
		{
			SetButton("metar");
            this.SendMessage("page:metar");
		}
		
		
		void BttnRecentWeatherClick(object sender, EventArgs e)
		{
			this.RecentWeatherClick();
		}
		
		void PicRecentWeatherClick(object sender, EventArgs e)
		{
			this.RecentWeatherClick();
		}
		
		void LblRecentWeatherClick(object sender, EventArgs e)
		{
			this.RecentWeatherClick();
		}
		
		private void RecentWeatherClick()
		{
			SetButton("recentweather");
            this.SendMessage("page:recentweather");
		}
		
		
		void PicVisibilityClick(object sender, EventArgs e)
		{
			this.VisibilityClick();
		}
		
		void LblVisibilityClick(object sender, EventArgs e)
		{
			this.VisibilityClick();
		}
		
		void BttnVisibilityClick(object sender, EventArgs e)
		{
			this.VisibilityClick();
		}
		
		private void VisibilityClick()
		{
			SetButton("visibility");
            this.SendMessage("page:visibility");
		}
		
		
		void PicRunwayVisibilityClick(object sender, EventArgs e)
		{
			this.RunwayVisibilityClick();
		}
		
		void BttnRunwayVisibilityClick(object sender, EventArgs e)
		{
			this.RunwayVisibilityClick();
		}
		
		void LblRunwayVisibilityClick(object sender, EventArgs e)
		{
			this.RunwayVisibilityClick();
		}
		
		private void RunwayVisibilityClick()
		{
			SetButton("runwayvisibility");
            this.SendMessage("page:runwayvisibility");
		}
		
		
		void PicTimeClick(object sender, EventArgs e)
		{
			this.TimeClick();
		}
		
		void LblTimeClick(object sender, EventArgs e)
		{
			this.TimeClick();
		}
		
		void BttnTimeClick(object sender, EventArgs e)
		{
			this.TimeClick();
		}
		
		private void TimeClick()
		{
			SetButton("time");
            this.SendMessage("page:time");
		}
		
		
		void PicWindShearClick(object sender, EventArgs e)
		{
			this.WindShearClick();
		}
		
		void LblWindShearClick(object sender, EventArgs e)
		{
			this.WindShearClick();
		}
		
		void BttnWindShearClick(object sender, EventArgs e)
		{
			this.WindShearClick();
		}
		
		private void WindShearClick()
		{
			SetButton("windshear");
            this.SendMessage("page:windshear");
		}
		
		void PicTrendClick(object sender, EventArgs e)
		{
			this.TrendClick();
		}
		
		void LblTrendClick(object sender, EventArgs e)
		{
			this.TrendClick();
		}
		
		void BttnTrendClick(object sender, EventArgs e)
		{
			this.TrendClick();
		}
		
		private void TrendClick()
		{
			SetButton("trend");
            this.SendMessage("page:trend");
		}
		
		void LblClearClick(object sender, EventArgs e)
		{
			SetButton(null);
		}
		
		void LblClearMouseEnter(object sender, EventArgs e)
		{
			this.lblClear.ForeColor = Color.White;
		}
		
		void LblClearMouseLeave(object sender, EventArgs e)
		{
			this.lblClear.ForeColor = Color.DimGray;
		}
		
		void LblExitMouseEnter(object sender, EventArgs e)
		{
			this.lblExit.ForeColor = Color.White;
		}
		
		void LblExitMouseLeave(object sender, EventArgs e)
		{
			this.lblExit.ForeColor = Color.DimGray;
		}

        private void SendMessage(string msg)
        {
            //Get connection and buffer
            NetClient client = config.Client.connection;
            NetBuffer buffer = client.CreateBuffer();

            buffer.Write(msg);

            client.SendMessage(buffer, NetChannel.ReliableInOrder1);
        }
	}
}
