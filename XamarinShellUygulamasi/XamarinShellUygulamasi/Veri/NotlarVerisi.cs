using System;
using System.Collections.Generic;
using System.Text;
using XamarinShellUygulamasi.Model;

namespace XamarinShellUygulamasi.Veri
{
    public static class NotlarVerisi
    {
        public static IList<Notlar> Notlarim { get; private set; }

        static NotlarVerisi()
        {
            Notlarim = new List<Notlar>();

            Notlarim.Add(new Notlar
            {
                ID = "1",
                Baslik= "Not1",
                Detay = " Not 1 detay",
                ResimUrl = "not1.png"
            });
            Notlarim.Add(new Notlar
            {
                ID = "2",
                Baslik = "Not2",
                Detay = " Not 2 detay",
                ResimUrl = "not1.png"
            });
            Notlarim.Add(new Notlar
            {
                ID = "3",
                Baslik = "Not3",
                Detay = " Not 3 detay",
                ResimUrl = "not3.png"
            });
            Notlarim.Add(new Notlar
            {
                ID = "4",
                Baslik = "Not4",
                Detay = " Not 4 detay",
                ResimUrl = "not4.png"
            });
            Notlarim.Add(new Notlar
            {
                ID = "5",
                Baslik = "Not5",
                Detay = " Not 5 detay",
                ResimUrl = "not5.png"
            });
            Notlarim.Add(new Notlar
            {
                ID = "6",
                Baslik = "Not6",
                Detay = " Not 6 detay",
                ResimUrl = "not6.png"
            });
            Notlarim.Add(new Notlar
            {
                ID = "6",
                Baslik = "Not6",
                Detay = " Not 6 detay",
                ResimUrl = "not6.png"
            });

        }
    }
}
