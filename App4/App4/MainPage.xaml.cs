using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnButtonClicked(object sender, EventArgs args)
        {
            string text1 = entry1.Text;
            string text2 = entry2.Text;
            string result = $"{text1}{text2}";

            labelResult.Text = result;
        }
    }
}
