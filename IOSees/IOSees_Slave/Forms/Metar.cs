/*
 * User: rcrowe
 * Date: 18/02/2010
 * Time: 12:58
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.ComponentModel;

namespace Forms.IOSees_Slave_Metar
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private string icao_selected = null;
		
		private ComponentResourceManager resources;
		
		private string egkk_metar = "METAR EGKK 041600Z 12003MPS 310V290 1400 R04/P1500N R22/P1500U +SN BKN022 OVC050 M04/M07 Q1020 NOSIG 9949//91=";
		private string egll_metar = "METAR EGLL 041600Z 12003MPS 310V290 1400 R04/P1500N R22/P1500U +SN BKN022 OVC050 M04/M07 Q1020 NOSIG 9949//91=";
		private string ksea_metar = "METAR KSEA 041600Z 12003MPS 310V290 1400 R04/P1500N R22/P1500U +SN BKN022 OVC050 M04/M07 Q1020 NOSIG 9949//91=";
		private string vhhh_metar = "METAR VHHH 041600Z 12003MPS 310V290 1400 R04/P1500N R22/P1500U +SN BKN022 OVC050 M04/M07 Q1020 NOSIG 9949//91=";
		private string fadn_metar = "METAR FADN 041600Z 12003MPS 310V290 1400 R04/P1500N R22/P1500U +SN BKN022 OVC050 M04/M07 Q1020 NOSIG 9949//91=";
		
		public MainForm()
		{
			InitializeComponent();
			
			resources = new ComponentResourceManager(typeof(MainForm));
		}
		
		void BttnEGKKClick(object sender, EventArgs e)
		{
			LoadEGKK();
		}
		
		void BttnEGKKMouseDown(object sender, MouseEventArgs e)
		{
			Graphics gp = picWorld.CreateGraphics();
			gp.Clear(Color.Black);
			
			this.picWorld.Image = ((System.Drawing.Image)(resources.GetObject("picWorld.Image")));
		}
		
		void BttnEGKKMouseUp(object sender, MouseEventArgs e)
		{
			Graphics gp = picWorld.CreateGraphics();
            
            Pen pen = new Pen(Color.DarkRed, 3);
            Rectangle rec = new Rectangle(324, 93, 7, 7);
            gp.DrawEllipse(pen, rec);
            gp.FillEllipse(Brushes.DarkRed, rec);
		}
		
		void BttnEGLLClick(object sender, EventArgs e)
		{
			LoadEGLL();
		}
		
		void BttnEGLLMouseDown(object sender, MouseEventArgs e)
		{
			Graphics gp = picWorld.CreateGraphics();
			gp.Clear(Color.Black);
			
			this.picWorld.Image = ((System.Drawing.Image)(resources.GetObject("picWorld.Image")));
		}
		
		void BttnEGLLMouseUp(object sender, MouseEventArgs e)
		{
			Graphics gp = picWorld.CreateGraphics();
            
            Pen pen = new Pen(Color.DarkRed, 3);
            Rectangle rec = new Rectangle(324, 93, 7, 7);
            gp.DrawEllipse(pen, rec);
            gp.FillEllipse(Brushes.DarkRed, rec);
		}
		
		void BttnKSEAClick(object sender, EventArgs e)
		{
			LoadKSEA();
		}
		
		void BttnKSEAMouseDown(object sender, MouseEventArgs e)
		{
			Graphics gp = picWorld.CreateGraphics();
			gp.Clear(Color.Black);
			
			this.picWorld.Image = ((System.Drawing.Image)(resources.GetObject("picWorld.Image")));
		}
		
		void BttnKSEAMouseUp(object sender, MouseEventArgs e)
		{
			Graphics gp = picWorld.CreateGraphics();
            
            Pen pen = new Pen(Color.DarkRed, 3);
            Rectangle rec = new Rectangle(82, 105, 7, 7);
            gp.DrawEllipse(pen, rec);
            gp.FillEllipse(Brushes.DarkRed, rec);
		}
		
		void BttnVHHHClick(object sender, EventArgs e)
		{
			LoadVHHH();
		}
		
		void BttnVHHHMouseDown(object sender, MouseEventArgs e)
		{
			Graphics gp = picWorld.CreateGraphics();
			gp.Clear(Color.Black);
			
			this.picWorld.Image = ((System.Drawing.Image)(resources.GetObject("picWorld.Image")));
		}
		
		void BttnVHHHMouseUp(object sender, MouseEventArgs e)
		{
			Graphics gp = picWorld.CreateGraphics();
            
            Pen pen = new Pen(Color.DarkRed, 3);
            Rectangle rec = new Rectangle(555, 159, 7, 7);
            gp.DrawEllipse(pen, rec);
            gp.FillEllipse(Brushes.DarkRed, rec);
		}
		
		void BttnFADNClick(object sender, EventArgs e)
		{
			LoadFADN();
		}
		
		void BttnFADNMouseDown(object sender, MouseEventArgs e)
		{
			Graphics gp = picWorld.CreateGraphics();
			gp.Clear(Color.Black);
			
			this.picWorld.Image = ((System.Drawing.Image)(resources.GetObject("picWorld.Image")));
		}
		
		void BttnFADNMouseUp(object sender, MouseEventArgs e)
		{
			Graphics gp = picWorld.CreateGraphics();
            
            Pen pen = new Pen(Color.DarkRed, 3);
            Rectangle rec = new Rectangle(379, 264, 7, 7);
            gp.DrawEllipse(pen, rec);
            gp.FillEllipse(Brushes.DarkRed, rec);
		}
		
		private void LoadEGKK()
		{
			//Set metar
			this.lblMetar.Text = egkk_metar;
			
			//Set the destination selected info
			this.lblPlace.Text = "Gatwick (EGKK)";
			this.lblLongitude.Text = "-0.19666666";
			this.lblLatitude.Text = "51.14805555";
			
			//Currently selected
			this.icao_selected = "EGKK";
		}
		
		private void LoadEGLL()
		{
			//Set metar
			this.lblMetar.Text = egll_metar;
			
			//Set the destination selected info
			this.lblPlace.Text = "Heathrow (EGLL)";
			this.lblLongitude.Text = "-0.45277777";
			this.lblLatitude.Text = "51.47138888";
			
			this.icao_selected = "EGLL";
		}
		
		private void LoadKSEA()
		{
			//Set metar
			this.lblMetar.Text = ksea_metar;
			
			//Set the destination selected info
			this.lblPlace.Text = "Seattle (KSEA)";
			this.lblLongitude.Text = "-122.30555555";
			this.lblLatitude.Text = "47.44722222";
			
			this.icao_selected = "KSEA";
		}
		
		private void LoadVHHH()
		{
			//Set metar
			this.lblMetar.Text = vhhh_metar;
			
			//Set the destination selected info
			this.lblPlace.Text = "Hong Kong (VHHH)";
			this.lblLongitude.Text = "114.2";
			this.lblLatitude.Text = "22.31805555";
			
			this.icao_selected = "VHHH";
		}
		
		private void LoadFADN()
		{
			//Set metar
			this.lblMetar.Text = fadn_metar;
			
			//Set the destination selected info
			this.lblPlace.Text = "Durban (FADN)";
			this.lblLongitude.Text = "30.95694444";
			this.lblLatitude.Text = "-29.96916666";
			
			this.icao_selected = "FADN";
		}
		
		void BttnSaveClick(object sender, EventArgs e)
		{
			if(this.icao_selected != null)
			{
				SaveFileDialog savedialog = new SaveFileDialog();
				savedialog.FileName = icao_selected + "_ios_metar";
				savedialog.Filter = "IOS Metar File|*.ios";
				savedialog.Title = "IOS Metar Information";
				savedialog.ShowDialog();
				
				if(savedialog.FileName != "")
				{
					FileStream fs = (FileStream)savedialog.OpenFile();
					
					if(fs.CanWrite)
					{
						TextWriter writter = new StreamWriter(fs);
						writter.WriteLine(this.lblMetar.Text);
						writter.Close();
					}
					else
					{
						MessageBox.Show("Can not save file to current directory");
					}
					
					fs.Close();
				}
			}
			else
			{
				MessageBox.Show("No ICAO selected");
			}
		}
		
		void BttnLoadClick(object sender, EventArgs e)
		{
			OpenFileDialog opendialog = new OpenFileDialog();
			opendialog.Filter = "IOS Metar File|*.ios";
			opendialog.Title = "IOS Metar Information";
			DialogResult result = opendialog.ShowDialog();
					
			if(result == DialogResult.OK)
			{
				if(opendialog.FileName != "")
				{
					//Lets see what were loading
					string metar_file = opendialog.FileName;
					string[] metar_file_parts = metar_file.Split('_');
					
					string[] path_parts = metar_file_parts[0].Split('\\');
					int path_parts_count = path_parts.Length;
					
					if(path_parts[path_parts_count-1] == "EGKK")
					{
						LoadEGKK();
					}
					
					if(path_parts[path_parts_count-1] == "EGLL")
					{
						LoadEGLL();
					}
					
					if(path_parts[path_parts_count-1] == "KSEA")
					{
						LoadKSEA();
					}
					
					if(path_parts[path_parts_count-1] == "VHHH")
					{
						LoadVHHH();
					}
					
					if(path_parts[path_parts_count-1] == "FADN")
					{
						LoadFADN();
					}
				}
				else
				{
					MessageBox.Show("No file selected");
				}
			}
		}
		
		void BttnSetClick(object sender, EventArgs e)
		{
			//Check which metar is loaded
			//if(this.icao_selected == "egkk")
			
			//then just send the plugin fixed values based on the metar file
		}
	}
}
