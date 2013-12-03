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

            

        public void setZoom(int zoom) {

            bingmap.ZoomLevel = zoom;
        
        }

        public void setLocation(double lat, double longi) {

            bingmap.Center.Latitude = lat;
            bingmap.Center.Longitude = longi;
            bingmap.Center = new Microsoft.Maps.MapControl.WPF.Location(lat, longi);
            

        }
    
        


        private string GetImagery(string locationString)
        {
            string key = "AiRFtOkxCuI_LQXyPmK8arEdFpqM0_8GRW4ufZBJt-p5LIF7BgeD7fLYT8hs8xl7";
            MapUriRequest mapUriRequest = new MapUriRequest();

            // Set credentials using a valid Bing Maps key
            mapUriRequest.Credentials = new Microsoft.Maps.MapControl.WPF.Credentials();
            mapUriRequest.Credentials.ApplicationId = key;

            // Set the location of the requested image
            mapUriRequest.Center = new ImageryService.Location();
            string[] digits = locationString.Split(',');
            mapUriRequest.Center.Latitude = double.Parse(digits[0].Trim());
            mapUriRequest.Center.Longitude = double.Parse(digits[1].Trim());

            // Set the map style and zoom level
            MapUriOptions mapUriOptions = new MapUriOptions();
            mapUriOptions.Style = MapStyle.AerialWithLabels;
            mapUriOptions.ZoomLevel = 19;

            // Set the size of the requested image in pixels
            mapUriOptions.ImageSize = new ImageryService.SizeOfint();
            mapUriOptions.ImageSize.Height = 600;
            mapUriOptions.ImageSize.Width = 600;

            mapUriRequest.Options = mapUriOptions;

            //Make the request and return the URI
            ImageryServiceClient imageryService = new ImageryServiceClient("BasicHttpBinding_IImageryService");
            MapUriResponse mapUriResponse = imageryService.GetMapUri(mapUriRequest);
            return mapUriResponse.Uri;
        }

        private void RequestImage_Click(object sender, RoutedEventArgs e)
        {
            // Make label hidden and image visible
            //labelResults.Visibility = Visibility.Hidden;
            imageResult2.Visibility = Visibility.Visible;

            //Get URI and set image
            String imageURI = GetImagery(textInput.Text);
            imageResult2.Source = new BitmapImage(new Uri(imageURI));
            
        }

        

      
    }
}
