using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacKrediManager = new PersonalFinanceCreditManager();
            ICreditManager tasitKrediManager = new CarLoanManager();
            ICreditManager konutKrediManager = new HousingLoanManager();

            ApplicationManager basvuruManager = new ApplicationManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager);
        }
    }
}
