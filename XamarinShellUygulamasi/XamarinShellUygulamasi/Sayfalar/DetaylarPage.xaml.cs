using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinShellUygulamasi.Model;

namespace XamarinShellUygulamasi.Sayfalar
{
    [QueryProperty("Name", "name")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetaylarPage : ContentPage
    {
        public string Name
        {
            set
            {
               
                gelenDataLabel.Text =  Uri.UnescapeDataString(value);
            }
        }
        public DetaylarPage()
        {
            InitializeComponent();
            
        }
    }
}