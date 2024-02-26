using _01Esempio.Models;

namespace Models
{
    public class UniTest1
    {
        [Theory]
        [InlineData(2,"pari")]
        [InlineData(3, "dispari")]
        [InlineData(4, "pari")]
        [InlineData(5, "dispari")]

        public void _1_Return_ifPari(int numero, string atteso)
        {
            //Arrange
            Numero n = new Numero();

            //Act
            string attuale = n.VerificaPari(numero);

            //Assert
            Assert.Equal(atteso, attuale);  
        }
    }
}

