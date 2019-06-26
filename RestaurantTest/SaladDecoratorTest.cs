using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant.CustomExceptions;
using Restaurant.Salad;


namespace RestaurantTest
{
    [TestClass]
    public class SaladDecoratorTest
    {
        private SaladDecorator _saladDecorator;

        [TestMethod()]
        public void ShouldSimpleSalad_Cost7()
        {
            _saladDecorator = new SaladDecorator();
            _saladDecorator.ChooseSalad(new Batavia());
            _saladDecorator.AddTopping(new ChickPeas());
            
            var salad = _saladDecorator.GetSalad();
            Assert.AreEqual(8, salad.GetPrice());
        }
        
        [TestMethod()]
        public void ShouldComplexSalad_Cost13()
        {
            _saladDecorator = new SaladDecorator();
            _saladDecorator.ChooseSalad(new Iceberg());
            _saladDecorator.AddTopping(new ChickPeas());
            _saladDecorator.AddTopping(new Avocado());
            _saladDecorator.AddTopping(new Chicken());
            
            var salad = _saladDecorator.GetSalad();
            Assert.AreEqual(13, salad.GetPrice());
        }
        
        [TestMethod()]
        [ExpectedException(typeof(SaladNotFoundException))]
        public void ShouldAdditionOfToppingWithoutSalad_ThrowException()
        {
            _saladDecorator = new SaladDecorator();
            _saladDecorator.AddTopping(new Chicken());
        }
    }
}