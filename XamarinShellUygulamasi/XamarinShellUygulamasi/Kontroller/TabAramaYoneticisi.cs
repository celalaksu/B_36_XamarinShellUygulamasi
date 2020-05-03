using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinShellUygulamasi.Model;
using XamarinShellUygulamasi.Veri;

namespace XamarinShellUygulamasi.Kontroller
{
    public class TabAramaYoneticisi : SearchHandler
    {        
        protected override void OnQueryChanged(string eskiDeger, string yeniDeger)
        {
            base.OnQueryChanged(eskiDeger, yeniDeger);          

            if (string.IsNullOrWhiteSpace(yeniDeger))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = NotlarVerisi.Notlarim
                    .Where(not => not.Detay.ToLower().Contains(yeniDeger.ToLower()))
                    .ToList<Notlar>();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            //base.OnItemSelected(item);
            var eleman = (Notlar)item;
            string parametre = eleman.Detay;
            await Task.Delay(1000);

            ShellNavigationState state = Shell.Current.CurrentState;
            //string yer = state.Location.ToString();
            //string state1 = Shell.Current.CurrentItem.Route;
            await Shell.Current.GoToAsync($"{state.Location}/detaylar?name={parametre}");
            //await Shell.Current.GoToAsync($"detaylar?name={parametre}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/monkeys/monkeydetails?name={((Animal)item).Name}");
        }
    }
}

