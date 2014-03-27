using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


using Microsoft.Maps.MapControl.WPF;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

using Aerial_Imaging_UAV_Simulator.GeocodeService;
using Aerial_Imaging_UAV_Simulator.ImageryService;
//using Aerial_Imaging_UAV_Simulator.SearchService;
//using Aerial_Imaging_UAV_Simulator.RouteService;
using System.IO;
using ConsoleApplication2;


namespace Aerial_Imaging_UAV_Simulator
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
       // FlightGearData data = new FlightGearData();
       // private BufferedGraphicsContext myContext;
       // private BufferedGraphics myBuffer;
        //private LinearGraidentBrush

        public List<System.Windows.Point> m_Points;
        public Random m_Random;
       

        /*
        private System.Drawing.Size s = new System.Drawing.Size(width:100, height:100);
        private int x = 256;
        private int y = 256;
        private System.Drawing.Rectangle r = new System.Drawing.Rectangle();
       */

        
        public UserControl1()
        {
            InitializeComponent();
            m_Points = new List<System.Windows.Point>();
            m_Random = new Random();
            System.Windows.Shapes.Rectangle rec;
            double newX;
            double newY;
            Canvas canvas;
            

        

          //  this.KeyDown += new System.Windows.UserControl11.KeyEventHandler(this.downKeyPressed);

            bingmap.ZoomLevel = 10;
            
            bingmap.Center = new Microsoft.Maps.MapControl.WPF.Location(47.6421, -122.1420);

            CompositionTarget.Rendering += new EventHandler(upKeyPressed);
            CompositionTarget.Rendering += new EventHandler(downKeyPressed);
            CompositionTarget.Rendering += new EventHandler(rightKeyPressed);
            CompositionTarget.Rendering += new EventHandler(leftKeyPressed);


        }

         
        //Method that sets the zoom levels
        public void setZoom(int zoom)
        {

            bingmap.ZoomLevel = zoom;

        }
        
        public String GeocodeAddressLat(string address)
        {
            string results = "";
            string key = "Avdf_LjTXXKUV1-qiGxg-GJTQvEfAWl1UQ2zE7vAYicOuIMRszW4Skplwk_9mIIq";
            GeocodeRequest geocodeRequest = new GeocodeRequest();

            // Set the credentials using a valid Bing Maps key
            geocodeRequest.Credentials =new Microsoft.Maps.MapControl.WPF.Credentials();
            geocodeRequest.Credentials.ApplicationId = key;

            // Set the full address query
            geocodeRequest.Query = address;

            // Set the options to only return high confidence results 
            ConfidenceFilter[] filters = new ConfidenceFilter[1];
            filters[0] = new ConfidenceFilter();
            filters[0].MinimumConfidence = GeocodeService.Confidence.High;

            // Add the filters to the options
            GeocodeOptions geocodeOptions = new GeocodeOptions();
            geocodeOptions.Filters = filters;
            geocodeRequest.Options = geocodeOptions;

            // Make the geocode request
            GeocodeServiceClient geocodeService = new GeocodeServiceClient();
            GeocodeResponse geocodeResponse = geocodeService.Geocode(geocodeRequest);

            if (geocodeResponse.Results.Length > 0)
                results = String.Format("Latitude: {0}",
                  geocodeResponse.Results[0].Locations[0].Latitude);
            else
                results = "No Results Found";

            return results;
        }

        //Method to convert an address into longitude and latitude 
        //TODO doesn't work needs to print the latitude and longitude to the textboxes in the form
        public String GeocodeAddressLongi(string address)
        {
            string resultsLongi = "";
            string key = "Avdf_LjTXXKUV1-qiGxg-GJTQvEfAWl1UQ2zE7vAYicOuIMRszW4Skplwk_9mIIq";
            GeocodeRequest geocodeRequest = new GeocodeRequest();

            // Set the credentials using a valid Bing Maps key
            geocodeRequest.Credentials = new Microsoft.Maps.MapControl.WPF.Credentials();
            geocodeRequest.Credentials.ApplicationId = key;

            // Set the full address query
            geocodeRequest.Query = address;

            // Set the options to only return high confidence results 
            ConfidenceFilter[] filters = new ConfidenceFilter[1];
            filters[0] = new ConfidenceFilter();
            filters[0].MinimumConfidence = GeocodeService.Confidence.High;

            // Add the filters to the options
            GeocodeOptions geocodeOptions = new GeocodeOptions();
            geocodeOptions.Filters = filters;
            geocodeRequest.Options = geocodeOptions;

            // Make the geocode request
            GeocodeServiceClient geocodeService = new GeocodeServiceClient();
            GeocodeResponse geocodeResponse = geocodeService.Geocode(geocodeRequest);

            if (geocodeResponse.Results.Length > 0)
                resultsLongi = String.Format("Longitude: {0}",
                  geocodeResponse.Results[0].Locations[0].Longitude);
            else
                resultsLongi = "No Results Found";

            return resultsLongi;
        }

        //sets the location by taking a double for latitude and longitude and an int for zoom
        public void setLocation(double lat, double longi, int zoom)
        {

            bingmap.Center.Latitude = lat;
            bingmap.Center.Longitude = longi;
            bingmap.ZoomLevel = 18;
            bingmap.Center = new Microsoft.Maps.MapControl.WPF.Location(lat, longi, 18);


        }

        //Method to take image using Imagery Service
        public string GetImagery(double lat, double longi)
        {
            
           // cameraSound.Play();

            //Map Key 
            string key = "Avdf_LjTXXKUV1-qiGxg-GJTQvEfAWl1UQ2zE7vAYicOuIMRszW4Skplwk_9mIIq";
            MapUriRequest mapUriRequest = new MapUriRequest();

            // Set credentials using a valid Bing Maps key
            mapUriRequest.Credentials = new Microsoft.Maps.MapControl.WPF.Credentials();
            mapUriRequest.Credentials.ApplicationId = key;

            // Set the location of the requested image
            mapUriRequest.Center = new ImageryService.Location();
            
            mapUriRequest.Center.Latitude = lat;
            mapUriRequest.Center.Longitude = longi;

            // Set the map style and zoom level
            MapUriOptions mapUriOptions = new MapUriOptions();
            mapUriOptions.Style = MapStyle.AerialWithLabels;
            mapUriOptions.ZoomLevel = 18;

            // Set the size of the requested image in pixels
            mapUriOptions.ImageSize = new ImageryService.SizeOfint();
            mapUriOptions.ImageSize.Height = 834;
            mapUriOptions.ImageSize.Width = 900;

            mapUriRequest.Options = mapUriOptions;

            //Make the request and return the URI
            ImageryServiceClient imageryService = new ImageryServiceClient("BasicHttpBinding_IImageryService");
            MapUriResponse mapUriResponse = imageryService.GetMapUri(mapUriRequest);
           
            return mapUriResponse.Uri;
        }


        public void imageSprite() {

            ImageSource imageSource = new BitmapImage(new Uri("C:\\Users\\Yeomans\\Desktop\\Dissertation\\planesprite.PNG"));
           // Sprite.Source = imageSource;

                   
        }

      
        
        


       //check if the the keys are pressed
        public void upKeyPressed(object sender, EventArgs e)
        {
           
          
            if ((Keyboard.GetKeyStates(Key.W) & KeyStates.Down) > 0)
            {
                Console.WriteLine("Test up key is pressed ");
                //canvas.Children.Add(rec);
                rect.Margin = new Thickness(rect.Margin.Left, rect.Margin.Top - 10, rect.Margin.Right, rect.Margin.Bottom);
                //currentPos.Y =-1;
                planeIMG.Margin = new Thickness(planeIMG.Margin.Left, planeIMG.Margin.Top - 10, planeIMG.Margin.Right, planeIMG.Margin.Bottom);
              
               
                }
            }

       
       
           

        void downKeyPressed(object sender, EventArgs e)
        {
            if ((Keyboard.GetKeyStates(Key.S) & KeyStates.Down) > 0)
            {
                Console.WriteLine("Test down key is pressed ");
                rect.Margin = new Thickness(rect.Margin.Left, rect.Margin.Top +10 , rect.Margin.Right, rect.Margin.Bottom);
                planeIMG.Margin = new Thickness(planeIMG.Margin.Left, planeIMG.Margin.Top , planeIMG.Margin.Right, planeIMG.Margin.Bottom -10);
            }

        }

        void rightKeyPressed(object sender, EventArgs e)
        {
            if ((Keyboard.GetKeyStates(Key.A) & KeyStates.Down) > 0)
            {
                Console.WriteLine("Test left key is pressed ");
                rect.Margin = new Thickness(rect.Margin.Left -10 , rect.Margin.Top, rect.Margin.Right, rect.Margin.Bottom);
                planeIMG.Margin = new Thickness(planeIMG.Margin.Left -10, planeIMG.Margin.Top, planeIMG.Margin.Right, planeIMG.Margin.Bottom);
            }

        }

        void leftKeyPressed(object sender, EventArgs e)
        {
            

            if ((Keyboard.GetKeyStates(Key.D) & KeyStates.Down) > 0)
            {
                Console.WriteLine("Test right key is pressed ");
                rect.Margin = new Thickness(rect.Margin.Left + 10, rect.Margin.Top, rect.Margin.Right, rect.Margin.Bottom);
                planeIMG.Margin = new Thickness(planeIMG.Margin.Left, planeIMG.Margin.Top, planeIMG.Margin.Right -10, planeIMG.Margin.Bottom);
            }

        }
        /*
        public void boundaries(System.Drawing.Point currentPosition, EventArgs e)
        {
            int boundsY = 348;
            int boundsX = 500;

            Canvas.SetTop(rect, currentPosition.Y);
            Canvas.SetLeft(rect, currentPosition.X);
            Console.WriteLine("value =" + currentPosition.Y);


            if (currentPosition.X > boundsX || currentPosition.Y > boundsY)  
            {
                rect.Margin = new Thickness(rect.Margin.Left, rect.Margin.Top, rect.Margin.Right, rect.Margin.Bottom -500);
                Console.WriteLine("Image gone past bounds");
            }


        }*/

       


















































































































    




        
    }
        } 




       
        

      
    

