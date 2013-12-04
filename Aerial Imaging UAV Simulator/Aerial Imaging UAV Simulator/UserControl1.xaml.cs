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


//using Aerial_Imaging_UAV_Simulator.GeocodeService;
using Aerial_Imaging_UAV_Simulator.ImageryService;
using Aerial_Imaging_UAV_Simulator.SearchService;
using Aerial_Imaging_UAV_Simulator.RouteService;
using System.IO;

namespace Aerial_Imaging_UAV_Simulator
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {




        public UserControl1()
        {
            InitializeComponent();

            bingmap.ZoomLevel = 10;

            bingmap.Center = new Microsoft.Maps.MapControl.WPF.Location(47.6421, -122.1420);

        }



        public void setZoom(int zoom)
        {

            bingmap.ZoomLevel = zoom;

        }

        public void setLocation(double lat, double longi, int zoom)
        {

            bingmap.Center.Latitude = lat;
            bingmap.Center.Longitude = longi;
            bingmap.ZoomLevel = 18;
            bingmap.Center = new Microsoft.Maps.MapControl.WPF.Location(lat, longi, 18);


        }



        //TODO change this method to accept the long and lat determined by the form , and move button to form 
        public string GetImagery(double lat, double longi)
        {
            string key = "AiRFtOkxCuI_LQXyPmK8arEdFpqM0_8GRW4ufZBJt-p5LIF7BgeD7fLYT8hs8xl7";
            MapUriRequest mapUriRequest = new MapUriRequest();

            // Set credentials using a valid Bing Maps key
            mapUriRequest.Credentials = new Microsoft.Maps.MapControl.WPF.Credentials();
            mapUriRequest.Credentials.ApplicationId = key;

            // Set the location of the requested image
            mapUriRequest.Center = new ImageryService.Location();
            //string[] digits = locationString.Split(',');
           // mapUriRequest.Center.Latitude = double.Parse(digits[0].Trim());
            //mapUriRequest.Center.Longitude = double.Parse(digits[1].Trim());
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

       
            
        //BitmapImage image = new BitmapImage(new Uri(imageURI));






        
    }
        } 




       
        

      
    

