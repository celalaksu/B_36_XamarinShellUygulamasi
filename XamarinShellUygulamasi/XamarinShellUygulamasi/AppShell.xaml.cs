using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinShellUygulamasi.Sayfalar;

namespace XamarinShellUygulamasi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        
        Dictionary<string, Type> routes = new Dictionary<string, Type>();
        public Dictionary<string, Type> Routes { get { return routes; } }

        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }
                
        void RegisterRoutes()
        {
            routes.Add("Hakkımızda", typeof(AboutPage));
            routes.Add("detaylar", typeof(DetaylarPage));
            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            var eleman = (MenuItem)sender;
            string ee = eleman.Text;
            //var destinationRoute = Routes.FirstOrDefault(route => route.Key.Equals(ee)).Value;
            //string aaa = destinationRoute.ToString();
            //ShellNavigationState state = Shell.Current.CurrentState;
            string state1 = Shell.Current.CurrentItem.Route;
            await Shell.Current.GoToAsync($"//{state1}/{ee}");
            Shell.Current.FlyoutIsPresented = false;
        }


    }
}