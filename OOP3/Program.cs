using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program

    {
        static void Main(string[] args)
        {

            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
          
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
           
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new DataBaseLogService());
            List<IKrediManager> krediler = new List<IKrediManager> {ihtiyacKrediManager,konutKrediManager,tasıtKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }

 
    }
}
