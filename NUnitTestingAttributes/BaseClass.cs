using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestingAttributes
{
    class BaseClass
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public bool Sorgula(int sayi1, int sayi2)
        {
            if (sayi1>sayi2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
