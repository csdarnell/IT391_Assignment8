using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            string url = $"https://maps.googleapis.com/maps/api/geocode/json?address={streetAddress.Text.Replace(" ", "+")},+{city.Text.Replace(" ", "+")},+{state.Text}&key={apiKey.Text}";


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
