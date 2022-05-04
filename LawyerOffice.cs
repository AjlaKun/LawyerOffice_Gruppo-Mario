using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LawyerOffice_Gruppo_Mario
{
    public class LawyerOffice
    {

        OfficeManager officeManager = new OfficeManager();
        public void FaiTraduzione(LANGUAGE lang, string text)
        {
            Console.WriteLine(officeManager.startTanslation( lang, text));
        } 
        public void FaiOrdine()
        {

        }

    
            




            


        

    }
}
