using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class UnitTestShoppingCart
    {
        private ShoppingCart _shoppingCart;
        [SetUp]
        public void Setup()
        {
            _shoppingCart = new ShoppingCart();
        }
        [Test]
        public void testCost()
        {
            ShoppingCart myCart = new ShoppingCart();
            myCart.setCost(100);
            myCart.setMass(100,90);
            myCart.setVip(0, 100);
            myCart.computeCost();
            Assert.That(myCart.getCost(),Is.EqualTo(90));
        }
        [Test]
        public void testCost2()
        {
            ShoppingCart myCart = new ShoppingCart();
            myCart.setCost(100);
            myCart.setMass(200, 90);
            myCart.setVip(0, 100);
            myCart.computeCost();
            Assert.That(myCart.getCost(), Is.EqualTo(100));
        }
        [Test]
        public void testVip()
        {
            ShoppingCart myCart = new ShoppingCart();
            myCart.setCost(100);
            myCart.setMass(100, 90);
            myCart.setVip(1, 80);
            myCart.computeCost();
            Assert.That(myCart.getCost(), Is.EqualTo(72));
        }
        [Test]
        public void testVip2()
        {
            ShoppingCart myCart = new ShoppingCart();
            myCart.setCost(100);
            myCart.setMass(200, 90);
            myCart.setVip(1, 80);
            myCart.computeCost();
            Assert.That(myCart.getCost(), Is.EqualTo(80));
        }

    }
}
