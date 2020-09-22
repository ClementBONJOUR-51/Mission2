using Xunit;
using System;

namespace Mission2
{
    public class testclass
    {
        [Fact]
        public void testGetMoisPrecedent()
        {
            DateTime dateTest = new DateTime(2020, 01, 14);
            Assert.Equal("12", gestionDate.getMoisPrecedent(dateTest));
            Assert.Equal("08", gestionDate.getMoisPrecedent()); //ici mettre le mois précedant du mois actuel ("09" actuellement)
        }

        [Fact]
        public void testGetMoisSuivant()
        {
            DateTime dateTest = new DateTime(2020, 03, 14);
            Assert.Equal("04", gestionDate.getMoisSuivant(dateTest));
            Assert.Equal("10", gestionDate.getMoisSuivant()); //ici mettre le mois suivant du mois actuel ("22/09/2020")
        }

                [Fact]
        public void testEntre()
        {
            DateTime dateTest = new DateTime(2020,03,14);
            //2 param
            Assert.Equal(true, gestionDate.entre(10,25)); // ("22/09/2020")
            Assert.Equal(true, gestionDate.entre(25,10)); // ("22/09/2020")

            Assert.Equal(false, gestionDate.entre(10,20)); // ("22/09/2020")
            Assert.Equal(false, gestionDate.entre(20,10)); // ("22/09/2020")

            Assert.Equal(true, gestionDate.entre(22,30)); // ("22/09/2020")
            Assert.Equal(true, gestionDate.entre(30,22)); // ("22/09/2020")
            Assert.Equal(true, gestionDate.entre(1,30)); // ("22/09/2020")
            Assert.Equal(true, gestionDate.entre(30,1)); // ("22/09/2020")

            Assert.Equal(true, gestionDate.entre(22,22)); // ("22/09/2020")

            //3 param
            Assert.Equal(true, gestionDate.entre(10,20,dateTest));
            Assert.Equal(true, gestionDate.entre(20,10,dateTest));

            Assert.Equal(false, gestionDate.entre(20,30,dateTest));
            Assert.Equal(false, gestionDate.entre(30,20,dateTest));

            Assert.Equal(true, gestionDate.entre(14,20,dateTest));
            Assert.Equal(true, gestionDate.entre(20,14,dateTest));
            Assert.Equal(true, gestionDate.entre(10,14,dateTest));
            Assert.Equal(true, gestionDate.entre(14,10,dateTest));

            Assert.Equal(true, gestionDate.entre(14,14,dateTest));
        }
    }
}