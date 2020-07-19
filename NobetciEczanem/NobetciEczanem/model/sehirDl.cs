using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NobetciEczanem
{
    public class sehirDl
    {
        public static List<Sehir> sehirler = new List<Sehir> {
            new Sehir() { Id = 1, Ad = "Adana" },
            new Sehir() { Id = 2, Ad = "Adıyaman " },
            new Sehir() { Id = 3, Ad = "Afyonkarahisar" },
            new Sehir() { Id = 4, Ad = "Ağrı" },
            new Sehir() { Id = 5, Ad = "Amasya" },
            new Sehir() { Id = 6, Ad = "Ankara" },
            new Sehir() { Id = 7, Ad = "Antalya" },
            new Sehir() { Id = 8, Ad = "Artvin" },
            new Sehir() { Id = 9, Ad = "Aydın" },
            new Sehir() { Id = 10, Ad = "Balıkesir" },
            new Sehir() { Id = 11, Ad = "Bilecik" },
            new Sehir() { Id = 12, Ad = "Bingöl" },
            new Sehir() { Id = 13, Ad = "Bitlis" },
            new Sehir() { Id = 14, Ad = "Bolu" },
            new Sehir() { Id = 15, Ad = "Burdur" },
            new Sehir() { Id = 16, Ad = "Bursa" },
            new Sehir() { Id = 17, Ad = "Çanakkale" },
            new Sehir() { Id = 18, Ad = "Çankırı" },
            new Sehir() { Id = 19, Ad = "Çorum" },
            new Sehir() { Id = 20, Ad = "Denizli" },
            new Sehir() { Id = 21, Ad = "Diyarbakır" },
            new Sehir() { Id = 22, Ad = "Edirne" },
            new Sehir() { Id = 23, Ad = "Elazığ" },
            new Sehir() { Id = 24, Ad = "Erzincan" },
            new Sehir() { Id = 25, Ad = "Erzurum" },
            new Sehir() { Id = 26, Ad = "Eskişehir" },
            new Sehir() { Id = 27, Ad = "Gaziantep" },
            new Sehir() { Id = 28, Ad = "Giresun" },
            new Sehir() { Id = 29, Ad = "Gümüşhane" },
            new Sehir() { Id = 30, Ad = "Hakkari" },
            new Sehir() { Id = 31, Ad = "Hatay" },
            new Sehir() { Id = 32, Ad = "Isparta" },
            new Sehir() { Id = 33, Ad = "Mersin" },
            new Sehir() { Id = 34, Ad = "İstanbul" },
            new Sehir() { Id = 35, Ad = "İzmir" },
            new Sehir() { Id = 36, Ad = "Kars" },
            new Sehir() { Id = 37, Ad = "Kastamonu" },
            new Sehir() { Id = 38, Ad = "Kayseri" },
            new Sehir() { Id = 39, Ad = "Kırklareli" },
            new Sehir() { Id = 40, Ad = "Kırşehir" },
            new Sehir() { Id = 41, Ad = "Kocaeli" },
            new Sehir() { Id = 42, Ad = "Konya" },
            new Sehir() { Id = 43, Ad = "Kütahya" },
            new Sehir() { Id = 44, Ad = "Malatya" },
            new Sehir() { Id = 45, Ad = "Manisa" },
            new Sehir() { Id = 46, Ad = "Kahramanmaraş" },
            new Sehir() { Id = 47, Ad = "Mardin" },
            new Sehir() { Id = 48, Ad = "Muğla" },
            new Sehir() { Id = 49, Ad = "Muş" },
            new Sehir() { Id = 50, Ad = "Nevşehir" },
            new Sehir() { Id = 51, Ad = "Niğde" },
            new Sehir() { Id = 52, Ad = "Ordu" },
            new Sehir() { Id = 53, Ad = "Rize" },
            new Sehir() { Id = 54, Ad = "Sakarya" },
            new Sehir() { Id = 55, Ad = "Samsun" },
            new Sehir() { Id = 56, Ad = "Siirt" },
            new Sehir() { Id = 57, Ad = "Sinop" },
            new Sehir() { Id = 58, Ad = "Sivas" },
            new Sehir() { Id = 59, Ad = "Tekirdağ" },
            new Sehir() { Id = 60, Ad = "Tokat" },
            new Sehir() { Id = 61, Ad = "Trabzon" },
            new Sehir() { Id = 62, Ad = "Tunceli" },
            new Sehir() { Id = 63, Ad = "Şanlıurfa" },
            new Sehir() { Id = 64, Ad = "Uşak" },
            new Sehir() { Id = 65, Ad = "Van" },
            new Sehir() { Id = 66, Ad = "Yozgat" },
            new Sehir() { Id = 67, Ad = "Zonguldak" },
            new Sehir() { Id = 68, Ad = "Aksaray" },
            new Sehir() { Id = 69, Ad = "Bayburt" },
            new Sehir() { Id = 70, Ad = "Karaman" },
            new Sehir() { Id = 71, Ad = "Kırıkkale" },
            new Sehir() { Id = 72, Ad = "Batman" },
            new Sehir() { Id = 73, Ad = "Şırnak" },
            new Sehir() { Id = 74, Ad = "Bartın" },
            new Sehir() { Id = 75, Ad = "Ardahan" },
            new Sehir() { Id = 76, Ad = "Iğdır" },
            new Sehir() { Id = 77, Ad = "Yalova" },
            new Sehir() { Id = 78, Ad = "Karabük" },
            new Sehir() { Id = 79, Ad = "Kilis" },
            new Sehir() { Id = 80, Ad = "Osmaniye" },
            new Sehir() { Id = 81, Ad = "Düzce" }
        };

        public static List<Sehir> GetCities()
        {
            var list = sehirler;
            return list;
        }
    }
    public class Sehir
    {
        public int Id { get; set; }
        public String Ad { get; set; }
    }
}