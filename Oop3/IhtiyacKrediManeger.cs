using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class IhtiyacKrediManeger : IKrediManeger
    {
        public void Biseyyap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("ihtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
