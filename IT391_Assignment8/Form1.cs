using IT391_Assignment8.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IT391_Assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(streetAddress.Text) 
                || string.IsNullOrWhiteSpace(city.Text) 
                || string.IsNullOrWhiteSpace(state.Text) 
                || string.IsNullOrWhiteSpace(zip.Text))
            {
                MessageBox.Show("All address fields must be populated.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Use the Google Maps Geocoding service to retrieve Lat/Long for the address; https://developers.google.com/maps/documentation/geocoding/start?hl=en_US
            string jsonResult = "";
            try
            {
                string geocodeUrl = $"https://maps.googleapis.com/maps/api/geocode/json?address={streetAddress.Text.Replace(" ", "+")},+{city.Text.Replace(" ", "+")},+{state.Text}&key={GeocodeApiKey.Text}";
                jsonResult = new WebClient().DownloadString(geocodeUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An exception occured while communicating with Google Geocoding API:  {ex.Message}", "Google API error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                RootObject result = JsonConvert.DeserializeObject<RootObject>(jsonResult);

                Latitude.Text = result.results[0].geometry.location.lat.ToString();
                Longitude.Text = result.results[0].geometry.location.lng.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An exception occured while importing Google Geocoding API's response:  {ex.Message}", "Google API error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Now, use the Google Static Maps API to get images;  https://developers.google.com/maps/documentation/static-maps/intro
            string mapsBaseUrl = $"https://maps.googleapis.com/maps/api/staticmap?center={Latitude.Text},{Longitude.Text}&key={MapsApiKey.Text}&size=400x400&zoom={ZoomLevel.Text}";
            string satelliteUrl = String.Concat(mapsBaseUrl, "&maptype=satellite");
            string roadUrl = String.Concat(mapsBaseUrl, "&maptype=roadmap");
            string hybridUrl = String.Concat(mapsBaseUrl, "&maptype=hybrid");

            try
            {

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile(satelliteUrl, @".\satellite.png");
                    pictureBoxSatellite.ImageLocation = @".\satellite.png";
                }
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile(roadUrl, @".\road.png");
                    pictureBoxRoad.ImageLocation = @".\road.png";
                }
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile(hybridUrl, @".\hybrid.png");
                    pictureBoxHybrid.ImageLocation = @".\hybrid.png";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An exception occured while communicating with Google Static Map API:  {ex.Message}", "Google API error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





            ////////XmlDocument grades = new XmlDocument();
            ////////grades.Load(@"C:\Users\csdar\Downloads\studentGrades.xml");


            ////////XmlNode smallestNode = null;

            ////////foreach (XmlNode currentNode in grades.DocumentElement)
            ////////{
            ////////    if (smallestNode == null)
            ////////    {
            ////////        // If this is the first time running, smllestNode will be null, still.  So, set smallestNode to be the current Node
            ////////        smallestNode = currentNode;
            ////////    }
            ////////    else
            ////////    {
            ////////        // smallestNode is not null, so we can now compare it to the current node
            ////////        string studentName = currentNode.ChildNodes[0].InnerText;
            ////////        int studentGrade = Int32.Parse(currentNode.ChildNodes[1].InnerText);

            ////////        if (studentGrade < Int32.Parse(smallestNode.ChildNodes[1].InnerText))
            ////////        {
            ////////            // the current node is the smallest node.  Mark it as the new smallest node.
            ////////            smallestNode = currentNode;
            ////////        }
            ////////    }
            ////////}

            ////////if (smallestNode != null)
            ////////{
            ////////    Console.WriteLine($"The smallest grade is {smallestNode.ChildNodes[1].InnerText}");
            ////////}

        }
    }
}
