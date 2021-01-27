using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class KonutKrediManeger : IKrediManeger
    {
        public void Biseyyap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
