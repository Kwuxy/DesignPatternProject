using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant;
using Restaurant.CustomExceptions;
using Restaurant.Extras;
using Restaurant.Salad;

namespace RestaurantTest
{
    [TestClass]
    public class OrderBuilderTest
    {
        private OrderBuilder _orderBuilder;
        private IIngredient _salad;
        private Client _client;

        [TestInitialize()]
        public void Initialize()
        {
            _client = new Client("Visitor");
            _salad = GetSalad();
        }
        
        [TestMethod()]
        [ExpectedException(typeof(ClientNotFoundException))]
        public void ShouldOrderWithoutClient_ThrowException()
        {
            _orderBuilder = new OrderBuilder();
            _orderBuilder.SetSalad(_salad).Build();
        }
        
        [TestMethod()]
        [ExpectedException(typeof(NothingToOrderException))]
        public void ShouldOrderWithoutFood_ThrowException()
        {
            _orderBuilder = new OrderBuilder();
            _orderBuilder.SetClient(_client).Build();
        }
        
        [TestMethod()]
        public void ShouldOrder_WithSalad_WithoutExtra_Cost8()
        {
            _orderBuilder = new OrderBuilder();
            _orderBuilder.SetClient(_client).SetSalad(_salad);
            
            Assert.AreEqual(8, _orderBuilder.Build().GetPrice());
        }
        
        [TestMethod()]
        public void ShouldOrder_WithSalad_WithDessert_Cost11_5()
        {
            _orderBuilder = new OrderBuilder();
            _orderBuilder.SetClient(_client).SetSalad(_salad).SetDessert(new Tiramisu());
            
            Assert.AreEqual(11.5, _orderBuilder.Build().GetPrice());
        }
        
        [TestMethod()]
        public void ShouldOrder_WithSalad_WithDrink_Cost10()
        {
            _orderBuilder = new OrderBuilder();
            _orderBuilder.SetClient(_client).SetSalad(_salad).SetDrink(new Coffee());
            
            Assert.AreEqual(10, _orderBuilder.Build().GetPrice());
        }
        
        [TestMethod()]
        public void ShouldOrder_WithSalad_WithDrink_WithDessert_Cost13()
        {
            _orderBuilder = new OrderBuilder();
            _orderBuilder.SetClient(_client).SetSalad(_salad).SetDrink(new Coffee()).SetDessert(new ApplePie());
            
            Assert.AreEqual(13, _orderBuilder.Build().GetPrice());
        }

        public IIngredient GetSalad()
        {
            var _saladDecorator = new SaladDecorator();
            _saladDecorator = new SaladDecorator();
            _saladDecorator.ChooseSalad(new Batavia());
            _saladDecorator.AddTopping(new ChickPeas());
            
            return _saladDecorator.GetSalad();
        }
    }
}