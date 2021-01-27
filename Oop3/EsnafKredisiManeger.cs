using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class EsnafKredisiManeger: IKrediManeger
    {
        public void Biseyyap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }
           
    }
}
