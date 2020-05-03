using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinShellUygulamasi.Sayfalar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sayfa1Page : ContentPage
    {
        public Sayfa1Page()
        {
            InitializeComponent();
        }

        private void dataListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}