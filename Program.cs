using System;

namespace LawyerOffice_Gruppo_Mario
{/// <summary>
/// creare class office services 
/// 
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            LawyerOffice lawyerOffice = new LawyerOffice();
            lawyerOffice.FaiTraduzione(LANGUAGE.SPANISH, "HOLA");
            //lawyerOffice.FaiOrdine(PASTI.COLAZIONE);
        }
    }

    public enum LANGUAGE
    {
        ENG,
        GERMAN,
        SPANISH

    }

    public enum PASTI
    {
        COLAZIONE,
        PRANZZO,
        CENA
    }
}
