using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer musteri1 = new IndividualCustomer();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo="12345678910";


            //kodlama.io
            CoorporateCustomer musteri2 = new CoorporateCustomer();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            Customer musteri3 = new IndividualCustomer();
            Customer musteri4 = new CoorporateCustomer();

            CustomerManager MusteriManager = new CustomerManager();
            MusteriManager.Add(musteri1);
            MusteriManager.Add(musteri2);
        }
    }
}
