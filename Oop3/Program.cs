using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManeger ihtiyacKrediManeger = new IhtiyacKrediManeger();
            IKrediManeger tasitKrediManeger = new TasitKrediManeger();
            IKrediManeger konutKrediManeger = new KonutKrediManeger();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerservice = new FileLoggerService();

            BasvuruManeger basvuruManeger = new BasvuruManeger();
            basvuruManeger.BasvuruYap(konutKrediManeger,new) DatabaseLoggerService());


            List<IKrediManeger> krediler = new List<IKrediManeger>() { };
            basvuruManeger.KrediOnBilgilendirmesiyap (krediler);







            




        }
    }
}
