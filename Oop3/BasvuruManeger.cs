using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManeger
    {
        public void BasvuruYap(IKrediManeger krediManeger, ILoggerservice loggerservice loggerservice)
        {
            krediManeger.Hesapla();
        }
        public void  KrediOnBilgilendirmesiyap(List<IKrediManeger> krediler)
            
        {
                foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }


    }
}
