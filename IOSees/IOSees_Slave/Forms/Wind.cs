/*
 * User: rcrowe
 * Date: 25/02/2010
 * Time: 12:39
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using IOS.Calculator;

namespace IOSees_Slave_Wind
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int click_offset = 5;
		private const int radius = 250;
		double x_one;
        double y_one;
        double x_two;
        double y_two;
		
		//Panel
        private double panel_width_half  = 0;
        private double panel_height_half = 0;
        
        //Mouse location handling
        private double mouse_down_x = 0;
        private double mouse_down_y = 0;
        
        //Final points too draw
        private double draw_x_one = 0;
        private double draw_y_one = 0;
        private double draw_x_two = 0;
        private double draw_y_two = 0;
        
		public MainForm()
		{
			InitializeComponent();
			
			//Get panel dimensions
			panel_width_half  = panel.Width / 2;
			panel_height_half = panel.Height / 2;
			
			//Set wind direction to 0
			lblWindAngle.Text = "0" + "\u00B0";
			
			//Set layer 1 as selected
			this.bttnLayer1.FlatAppearance.BorderColor = Color.DarkGreen;
			this.bttnLayer1.ForeColor = Color.DarkGreen;
		}
		
		void PanelPaint(object sender, PaintEventArgs e)
		{
			Graphics gp = e.Graphics;

            //gp.Clear(Color.WhiteSmoke);
            
            gp.PixelOffsetMode = PixelOffsetMode.HighQuality;
            
            //gp.FillRectangle(Brushes.Black, new Rectangle(0, 0, 500, 500));

            Pen pen = new Pen(Color.White, 3);
            Rectangle rec = new Rectangle(0, 0, 500, 500);
            gp.DrawEllipse(pen, rec);
		}
		
		void PanelMouseDown(object sender, MouseEventArgs e)
		{
			mouse_down_x = e.X;
			mouse_down_y = e.Y;
		}
		
		void PanelMouseUp(object sender, MouseEventArgs e)
		{
			calc_angles();
		}
		
		private void calc_angles()
		{
			double x  = panel.Width / 2;
            double y  = panel.Height / 2;
            
            x = mouse_down_x - x;
            x = Math.Abs(x);

            y = (panel.Height - mouse_down_y) - (panel.Height / 2);

            double theta = (Math.Atan(y/x));
            theta = theta * 180 / Math.PI;
                          
            double alpha = theta - click_offset;
            alpha = alpha * Math.PI / 180;
                          
            double beta  = theta + click_offset;
            beta = beta * Math.PI / 180;

            x_one = radius * Math.Cos(beta);
            y_one = radius * Math.Sin(beta);
            x_two = radius * Math.Cos(alpha);
            y_two = radius * Math.Sin(alpha);

            if (mouse_down_x > 250)
            {
                x_one = x_one + (panel.Width / 2);
            }
            else
            {
                x_one = x_one - (panel.Width / 2);
                x_one = Math.Abs(x_one);
            }

            if (mouse_down_y > 250)
            {
                y_one = Math.Abs(y_one);
                y_one = y_one + (panel.Width / 2);
            }
            else
            {
                y_one = Math.Abs(y_one);
                y_one = y_one - (panel.Width / 2);
                y_one = Math.Abs(y_one);
            }

            if (mouse_down_x > 250)
            {
                x_two = x_two + (panel.Width / 2);
            }
            else
            {
                x_two = x_two - (panel.Width / 2);
                x_two = Math.Abs(x_two);
            }

            if (mouse_down_y > 250)
            {
                y_two = -y_two + (panel.Width / 2);
            }
            else
            {
                y_two = y_two - (panel.Width / 2);
                y_two = Math.Abs(y_two);
            }
            
            draw_x_one = x_one;
            draw_y_one = y_one;
            draw_x_two = x_two;
            draw_y_two = y_two;
            
            if(mouse_down_x != 250 && mouse_down_y != 250)
			{
            	draw();
			}
            
            wind_direction(theta);
		}
		
		void wind_direction(double angle)
		{
			double wind_angle = 0;
			
			angle = Math.Abs(angle);
			
			if(mouse_down_x < 250 && mouse_down_y < 250)
			{
				//Zone 1;
				wind_angle = 270 + angle;
			}
			
			else if(mouse_down_x > 250 && mouse_down_y < 250)
			{
				//Zone 2
				wind_angle = 90 - angle;
			}
			
			else if(mouse_down_x < 250 && mouse_down_y > 250)
			{
				//Zone 4
				wind_angle = 270 - angle;
			}
			
			else if(mouse_down_x > 250 && mouse_down_y > 250)
			{
				//Zone 3
				wind_angle = 90 + angle;
			}
			
			wind_angle = Math.Round(wind_angle);
			
			//Set wind angle label
			lblWindAngle.Text = wind_angle.ToString() + "\u00B0";
		}
		
		void draw()
		{
			//Graphics gp = this.CreateGraphics();
            Graphics gp = panel.CreateGraphics();

            gp.Clear(Color.WhiteSmoke);
            
            gp.PixelOffsetMode = PixelOffsetMode.HighQuality;
            
            gp.FillRectangle(Brushes.Black, new Rectangle(0, 0, 500, 500));

            Pen pen = new Pen(Color.White, 3);
            Rectangle rec = new Rectangle(0, 0, 500, 500);
            gp.DrawEllipse(pen, rec);

            Point[] points = new Point[3];
            points[0] = new Point(250, 250);
            points[1] = new Point((int)draw_x_one, (int)draw_y_one);
            points[2] = new Point((int)draw_x_two, (int)draw_y_two);

            Pen poly_pen = new Pen(Color.White, 1);

            gp.DrawPolygon(poly_pen, points);
            gp.FillPolygon(Brushes.White, points);
		}
		
		
		/* Altitude */
		private void AltitudeInput(int amount)
		{
			//Check its valid
			if(amount < 0 || amount > 40000)
			{
				MessageBox.Show("Amount entered is out of bounds.\nPlease enter a value between 0 - 40,000");
				return;
			}
			
			lblAltitudeInfo.Text = amount.ToString() + " meters";
			
			/* Reset colors to white */
			this.bttnAltitude.FlatAppearance.BorderColor = Color.White;
			this.bttnAltitude.ForeColor = Color.White;
		}
		
		void BttnAltitudeClick(object sender, EventArgs e)
		{
			/* Change color to show selected */
			this.bttnAltitude.FlatAppearance.BorderColor = Color.DarkGreen;
			this.bttnAltitude.ForeColor = Color.DarkGreen;
			
			IOS.Calculator.Input inp = new Input();
			inp.inputChanged += new IOS.Calculator.Input.InputChangeHandler(AltitudeInput);
		}
		
		/* Speed */
		private void SpeedInput(int amount)
		{
			//Check its valid
			if(amount < 0 || amount > 1000)
			{
				MessageBox.Show("Amount entered is out of bounds.\nPlease enter a value between 0 - 1000");
				return;
			}
			
			lblSpeedInfo.Text = amount.ToString() + " kts";
			
			/* Reset colors to white */
			this.bttnSpeed.FlatAppearance.BorderColor = Color.White;
			this.bttnSpeed.ForeColor = Color.White;
		}
		
		void BttnSpeedClick(object sender, EventArgs e)
		{
			/* Change color to show selected */
			this.bttnSpeed.FlatAppearance.BorderColor = Color.DarkGreen;
			this.bttnSpeed.ForeColor = Color.DarkGreen;
			
			IOS.Calculator.Input inp = new Input();
			inp.inputChanged += new IOS.Calculator.Input.InputChangeHandler(SpeedInput);
		}
		
		/* Turbulance */
		private void TurbulanceInput(int amount)
		{
			if(amount < 0 || amount > 10)
			{
				MessageBox.Show("Amount entered is out of bounds.\nPlease enter a value between 0 - 10");
				return;
			}
			
			lblTurbulanceInfo.Text = amount.ToString();
			
			/* Reset colors to white */
			this.bttnTurbulance.FlatAppearance.BorderColor = Color.White;
			this.bttnTurbulance.ForeColor = Color.White;
		}
		
		void BttnTurbulanceClick(object sender, EventArgs e)
		{
			/* Change color to show selected */
			this.bttnTurbulance.FlatAppearance.BorderColor = Color.DarkGreen;
			this.bttnTurbulance.ForeColor = Color.DarkGreen;
			
			IOS.Calculator.Input inp = new Input();
			inp.inputChanged += new IOS.Calculator.Input.InputChangeHandler(TurbulanceInput);
		}
		
		
		/* Layers */
		private void Border(int num)
		{
			//First clear all of them
			this.bttnLayer1.FlatAppearance.BorderColor = Color.White;
			this.bttnLayer1.ForeColor = Color.White;
			
			this.bttnLayer2.FlatAppearance.BorderColor = Color.White;
			this.bttnLayer2.ForeColor = Color.White;
			
			this.bttnLayer3.FlatAppearance.BorderColor = Color.White;
			this.bttnLayer3.ForeColor = Color.White;
			
			if(num == 1)
			{
				this.bttnLayer1.FlatAppearance.BorderColor = Color.DarkGreen;
				this.bttnLayer1.ForeColor = Color.DarkGreen;
			}
			
			if(num == 2)
			{
				this.bttnLayer2.FlatAppearance.BorderColor = Color.DarkGreen;
				this.bttnLayer2.ForeColor = Color.DarkGreen;
			}
			
			if(num == 3)
			{
				this.bttnLayer3.FlatAppearance.BorderColor = Color.DarkGreen;
				this.bttnLayer3.ForeColor = Color.DarkGreen;
			}
		}
			
		void BttnLayer1Click(object sender, EventArgs e)
		{
			this.Border(1);
			lblLayerInfo.Text = "1";
		}
		
		void BttnLayer2Click(object sender, EventArgs e)
		{
			this.Border(2);
			lblLayerInfo.Text = "2";
		}
		
		void BttnLayer3Click(object sender, EventArgs e)
		{
			this.Border(3);
			lblLayerInfo.Text = "3";
		}
		
		
		/* Set */
		void BttnSetClick(object sender, EventArgs e)
		{
			//Probably only going to set the altitude and the turbulance here
			//mainly because its the easiest to demonstrate that something has changed
			//to the environment
		}
	}
}
