using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vruzki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Hide();
            linkLabel2.Text = "camera";
            linkLabel2.Links.Add(0, linkLabel2.Text.Length, "https://weather-webcam.eu/sofia-lozenec-panorama-kamera-na-jivo/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.Show();
            pictureBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pictureBox1.Show();
            pictureBox1.Enabled = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://weather-webcam.eu/sofia-lozenec-panorama-kamera-na-jivo/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Enabled = true;
            webBrowser1.Navigate("https://weather-webcam.eu/sofia-lozenec-panorama-kamera-na-jivo/");
            WebBrowser webBrowser2 = new WebBrowser();
            webBrowser2.Location = pictureBox2.Location;
            webBrowser2.Size = pictureBox2.Size;
            webBrowser2.Navigate("https://weather-webcam.eu/ueb-kamera-ot-sofiya-lyulin-7-sledete-vremeto-i-trafika/");
            this.Controls.Add(webBrowser2);
            pictureBox2.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://weather-webcam.eu/ueb-kamera-ot-sofiya-lyulin-7-sledete-vremeto-i-trafika/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(url))
            {
                Process.Start(url);
            }
        }
    }
}
