using System;
using System.Collections.Generic;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            //testSQL();
            
        }
    
        static public void testSQL()
        {
            Connection maConnection = Connection.getPdoGsb();
            var stm = "SELECT idvisiteur, mois, idetat FROM fichefrais WHERE fichefrais.idetat = 'VA'";
            List<List<string>> reponse = maConnection.sendQuery(stm);

            foreach (List<string> ligne in reponse)
            {
                foreach (string val in ligne)
                {
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
