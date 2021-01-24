using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void BasvuruYap(ICreditManager krediManager)
        {
            krediManager.Hesapla();
        }
        public void KrediOnBilgilendirmesiYap()
        {

        }
    }
}
