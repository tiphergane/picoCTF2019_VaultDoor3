using System;
using System.Threading.Tasks;

namespace picoCTF_Vault_3
{
    class Program
    {
        /// <summary>
        /// Création du l'unscrambler pour le picoCTF2019
        /// par tiphergane
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char[] BaseFlag = new char[32];
            char[] buffer = new char[32];
            char[] ResultFlag = new char[32];

            BaseFlag = ("jU5t_a_sna_3lpm1dg347_u_4_mfr54b").ToCharArray();
            int i;
            for (i = 0; i < 8; i++)
                {
                    buffer[i] = BaseFlag[i];
                }
            for (; i < 16; i++) //le ; après la parenthèse ouverte est pour dire que l'on récupère l'ancienne valeur de i
                {
                    buffer[i] = BaseFlag[23 - i];
                }
            for (; i < 32; i++)
                {
                    buffer[i] = BaseFlag[46 - i];
                }
            for (i = 31; i >= 17; i -= 2)
                {
                    buffer[i] = BaseFlag[i];
                }
            //
            // sorry Minion #2671, your evil masterplan to protect
            // that door have just failed, us, cats, are smarter than
            // a banana securisation
            //
            ResultFlag = buffer;
            string r = new string(BaseFlag);
            string s = new string(ResultFlag);
            string d = "picoCTF{";
            string e = "}";
            Console.WriteLine("Connecting to database");
            Console.WriteLine("Riddle reception");
            Console.WriteLine("Riddle is: {0}", r);
            Console.WriteLine("Connecting to NSA's Neural Network");
            Console.WriteLine("Processing Hawking's Theories");
            Task.Delay(1000).Wait();
            Console.WriteLine("Flag is : {0}{1}{2}", d,s,e);
            Console.WriteLine("Press Enter to quit");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
    }
}
