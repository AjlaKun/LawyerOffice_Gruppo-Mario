
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice_Gruppo_Mario.Translation
{
    public class TranslationOffice
    {
        TranslationOnlineStore _onlineStore = new TranslationOnlineStore();
        public string Translate(LANGUAGE lang, string text)
        {
            return _onlineStore.Translate(lang, text);
        }
    }
}
