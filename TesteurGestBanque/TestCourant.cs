
using Models;

namespace TesteurGestBanque
{
    [TestClass]
    public class TestCourant
    {
        [TestMethod]
        public void RetraitWithValidAmount()
        {
            //Arrange
            Personne titulaire = new Personne("Doe", "John", DateTime.Now);
            Courant courant = new Courant("0001", titulaire);
            courant.Depot(100);            
            
            //Act
            courant.Retrait(5);

            //Assert
            Assert.AreEqual(95, courant.Solde);
        }
    }

 
}