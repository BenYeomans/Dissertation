using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.IO;


namespace Aerial_Imaging_UAV_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //set Zoom to 10
            userControl11.setZoom(10);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            userControl11.setZoom(18);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            userControl11.setZoom(30);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string latitude;
            string longitude;
            double latitude2;
            double longitude2;

            latitude = latTxtBox.Text;
            longitude = longTxtBox.Text;

           latitude2 = double.Parse(latitude);
           longitude2 = double.Parse(longitude);

           userControl11.setLocation(latitude2, longitude2 , 18);
           
        }

        private void takeImage_Click(object sender, EventArgs e)
        {
            string latitude;
            string longitude;
            double latitude2;
            double longitude2;

          
          

            latitude = latTxtBox.Text;
            longitude = longTxtBox.Text;

            latitude2 = double.Parse(latitude);
            longitude2 = double.Parse(longitude);

            
            string image = userControl11.GetImagery(latitude2, longitude2);
            userControl11.imageResult2.Source = new BitmapImage(new Uri(image));
            userControl11.imageResult2.Height = 600;
            userControl11.imageResult2.Width = 600;



            string filePath = "C:\\Users\\Yeomans\\Desktop\\images\\image.png";


            var encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create((BitmapSource)userControl11.imageResult2.Source));
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
                encoder.Save(stream);

        }

       

    }
}
