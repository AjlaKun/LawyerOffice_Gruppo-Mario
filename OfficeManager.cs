using LawyerOffice_Gruppo_Mario.Translation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LawyerOffice_Gruppo_Mario
{
    public class OfficeManager
    {
        TranslationOffice translationOffice = new TranslationOffice();
        //public TranslationOffice _translationOffice { get; set; }
        //public TranslationDelivery _deliveryOffice { get; set; }
        public string startTanslation(LANGUAGE lang, string text)
        {
            return translationOffice.Translate(lang, text);
            
        }

        public void passDelivery()
        {

           
        }
        public OfficeManager()
        {
            
        }

    }
}
