using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingLoanManager : ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
