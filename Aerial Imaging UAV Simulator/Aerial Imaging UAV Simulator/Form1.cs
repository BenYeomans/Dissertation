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
using System.Diagnostics;
using System.Collections;
using System.Text.RegularExpressions;
//using ConsoleApplication2;
using FlightGearData;


namespace Aerial_Imaging_UAV_Simulator
{
    public partial class Form1 : Form
    {
   

        public Form1()
        {
           
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                //userControl11.Sprite.Top -= 10;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           // Process.Start("C:\\FlightGear\\bin\\Win64\\fgrun.exe");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num;
            bool isNumLat = Double.TryParse(latTxtBox.Text, out num);
            bool isNumLong = Double.TryParse(longTxtBox.Text, out num);
            string latitude;
            string longitude;
            double latitude2;
            double longitude2;

            if (string.IsNullOrWhiteSpace(latTxtBox.Text) && (string.IsNullOrWhiteSpace(longTxtBox.Text)))
                {

                    if (MessageBox.Show("No value has been given for Latitude and Longitude please enter a value", "Error",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        latTxtBox.Text = "";
                        longTxtBox.Text = "";
                    }




                }
            else if (string.IsNullOrWhiteSpace(latTxtBox.Text) || (string.IsNullOrWhiteSpace(longTxtBox.Text)))
            {
                if (MessageBox.Show("Only one value for latitude and longitude has been entered , please enter a value for both", "Error",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    latTxtBox.Text = "";
                    longTxtBox.Text = "";
                }
            }
          else if((isNumLat == false) || (isNumLong == false))
            {
                if (MessageBox.Show("You have entered a non numeric digit please enter only numeric data", "Error",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    latTxtBox.Text = "";
                    longTxtBox.Text = "";
                }
            
            }     
            else
            {

                latitude = latTxtBox.Text;
                longitude = longTxtBox.Text;

                latitude2 = double.Parse(latitude);
                longitude2 = double.Parse(longitude);

                userControl11.setLocation(latitude2, longitude2, 18);
                
            }

        }
        
        

        private void takeImage_Click(object sender, EventArgs e)
        {
            double num;
            bool isNumLat = Double.TryParse(latTxtBox.Text, out num);
            bool isNumLong = Double.TryParse(longTxtBox.Text, out num);
            string latitude;
            string longitude;
            double latitude2;
            double longitude2;
            

                if (string.IsNullOrWhiteSpace(latTxtBox.Text) && (string.IsNullOrWhiteSpace(longTxtBox.Text)))
                {

                    if (MessageBox.Show("No value has been given for Latitude and Longitude please enter a value", "Error",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        latTxtBox.Text = "";
                        longTxtBox.Text = "";
                    }




                }
                else if (string.IsNullOrWhiteSpace(latTxtBox.Text) || (string.IsNullOrWhiteSpace(longTxtBox.Text)))
                {
                    if (MessageBox.Show("Only one value for latitude and longitude has been entered , please enter a value for both", "Error",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        latTxtBox.Text = "";
                        longTxtBox.Text = "";
                    }
                }
            else if ((isNumLat == false) || (isNumLong == false))
                {
                    if (MessageBox.Show("You have entered a non numeric digit please enter only numeric data", "Error",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        latTxtBox.Text = "";
                        longTxtBox.Text = "";
                    }

                }       
            else{


                    System.Media.SoundPlayer player =
                        new System.Media.SoundPlayer(@"C://Users//Yeomans//Desktop//Sound.wav");
                    player.Play();



                    latitude = latTxtBox.Text;
                    longitude = longTxtBox.Text;

                    latitude2 = double.Parse(latitude);
                    longitude2 = double.Parse(longitude);


                    string image = userControl11.GetImagery(latitude2, longitude2);
                    userControl11.imageResult2.Source = new BitmapImage(new Uri(image));

                    userControl11.imageResult2.Height = 600;
                    userControl11.imageResult2.Width = 600;

                    storeImage();
                }
            
            
        }


        private void storeImage()
        {

            List<string> images = new List<string>();

            string filePath = "C:\\Users\\Yeomans\\Desktop\\images\\images.png";
            bool iexist = System.IO.File.Exists(filePath);
            int i = 0;
            while (iexist)
            {
                filePath = "C:\\Users\\Yeomans\\Desktop\\images\\images" + i + ".png";
                iexist = System.IO.File.Exists(filePath);
                i++;
            }

            images.Add(filePath);
           

            string[] i2 = images.ToArray();

            var encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create((BitmapSource)userControl11.imageResult2.Source));
            using (FileStream stream = new FileStream(i2[0], FileMode.Create))
                encoder.Save(stream);

        }

        private void longTxtBox_TextChanged(object sender, EventArgs e)
        {

        }




        private void searchAdd_Click_1(object sender, EventArgs e)
        {
            string address1 = addText.Text;
            address1 = userControl11.GeocodeAddressLat(address1);
            address1 = userControl11.GeocodeAddressLongi(address1);

            latTxtBox.Text = userControl11.GeocodeAddressLat(addText.Text);
            longTxtBox.Text = userControl11.GeocodeAddressLongi(addText.Text);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.setZoom(10);
        }

        private void zoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            userControl11.setZoom(18);
        }

        private void zoomToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            userControl11.setZoom(25);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(latTxtBox.Text);
                    sw.Write(", ");
                    sw.Write(longTxtBox.Text);
                }
            }

        }



        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string chosen_File = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv";
            ofd.FileName = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                chosen_File = ofd.FileName;
                var reader = new StreamReader(File.OpenRead(chosen_File));
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listA.Add(values[0]);
                    listB.Add(values[1]);
                }

                string[] i = listA.ToArray();
                string[] i2 = listB.ToArray();

                Console.Write("Lat: " + i[0]);
                Console.Write("Long: " + i2[0]);

                latTxtBox.Text = i[0];
                longTxtBox.Text = i2[0];

            }

        }

        private void viewUAVImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Yeomans\Desktop\images");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

            if (MessageBox.Show("All Current Locations will be discarded if not saved", "Warning",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                latTxtBox.Text = "";
                longTxtBox.Text = "";

            }
            else
            {
                //do nothing 
            }

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Process.Start("C:\\Users\\Yeomans\\Documents\\Visual Studio 2013\\Projects\\ConsoleApplication2.");
         

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopUpForm frm = new PopUpForm();

            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

       


    }
}
               
            
            
            
      


       

 
