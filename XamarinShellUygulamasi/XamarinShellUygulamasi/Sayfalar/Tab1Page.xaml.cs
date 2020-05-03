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
    public partial class Tab1Page : ContentPage
    {
        public Tab1Page()
        {
            InitializeComponent();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string eleman = e.SelectedItem.ToString();
           // var destinationRoute = (Shell.Current as AppShell).Routes.FirstOrDefault(route => route.Key.Equals("detaylar")).Value;
            //string aaa = destinationRoute.ToString();
            ShellNavigationState state = Shell.Current.CurrentState;
            string yer = state.Location.ToString();
            //string state1 = Shell.Current.CurrentItem.Route;
            await Shell.Current.GoToAsync($"{state.Location}/detaylar?name={eleman}");
            //Shell.Current.FlyoutIsPresented = false;

        }
    }
}