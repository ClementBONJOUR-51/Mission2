using System;

namespace Mission2
{
    public class gestionDate
    {
        public static string getMoisPrecedent()
        {
            DateTime reponse = DateTime.Now.AddMonths(-1);
            return reponse.ToString("MM");
        }

        public static string getMoisPrecedent(DateTime date)
        {
            DateTime reponse = date.AddMonths(-1);
            return reponse.ToString("MM");
        }

        
        public static string getMoisSuivant()
        {
            DateTime reponse = DateTime.Now.AddMonths(1);
            return reponse.ToString("MM");
        }

        public static string getMoisSuivant(DateTime date)
        {
            DateTime reponse = date.AddMonths(1);
            return reponse.ToString("MM");
        }
    }
}