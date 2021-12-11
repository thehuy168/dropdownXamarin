using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace dropdown
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var countries = GetCountry();
            pickerC.ItemsSource = countries;
           
          
        }
        public List<string>GetCountry()
        {
            return new List<string>
            {
                "Vietnam",
                "UK",
                "USA",
                "Russian"
                
            };
        }
     

        private void Show_Pressed(object sender, EventArgs e)
        {

            var i = pickerC.SelectedIndex;
            var countries = GetCountry();
            var item = countries[i];


            Console.WriteLine( item);
            
        }
    }
}
