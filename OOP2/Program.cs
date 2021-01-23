using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "123333";
            musteri1.Adi = "Eda";
            musteri1.Soyadi = "drms";
            musteri1.TcNo = "15555";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "55555";
            musteri2.SirketAdi = "EDAAAA";


            Müşteri musteri3 = new GercekMusteri();
            Müşteri musteri4 = new TuzelMusteri();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);




         

        }
    }
}
