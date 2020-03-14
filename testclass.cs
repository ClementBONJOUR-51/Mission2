using Xunit;
using System;

namespace Mission2
{
    public class testclass
    {
        [Fact]
        public void testGetMoisPrecedent()
        {
            DateTime dateTest = new DateTime(2020, 03, 14);
            Assert.Equal("02", gestionDate.getMoisPrecedent(dateTest));
            Assert.Equal("02", gestionDate.getMoisPrecedent()); //ici mettre le mois précedant du mois actuel ("02" actuellement)
        }

        [Fact]
        public void testGetMoisSuivant()
        {
            DateTime dateTest = new DateTime(2020, 03, 14);
            Assert.Equal("04", gestionDate.getMoisSuivant(dateTest));
            Assert.Equal("04", gestionDate.getMoisSuivant()); //ici mettre le mois suivant du mois actuel ("02" actuellement)
        }
    }
}