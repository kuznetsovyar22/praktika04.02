using ClassLibrary1;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculations calculations = new Calculations(10, 1, "Консультация");
            double result = calculations.CostPriem();
            Assert.IsNotNull(result);
            Assert.AreEqual(result, 900);
            
        }

        [TestMethod]
        public void TestMethod2()
        {
            Calculations calculations = new Calculations(10, 1, "Обследование");
            double result = calculations.CostPriem();
            Assert.IsNotNull(result);
            Assert.AreEqual(result, 1800);

        }

        [TestMethod]
        public void TestMethod3()
        {
            Calculations calculations = new Calculations(10, 1, "Лечение");
            double result = calculations.CostPriem();
            Assert.IsNotNull(result);
            Assert.AreEqual(result, 2700);

        }

        [TestMethod]
        public void TestMethod4()
        {
            Calculations calculations = new Calculations(10, 2, "Консультация");
            double result = calculations.CostPriem();
            Assert.IsNotNull(result);
            Assert.AreEqual(result, 1800);

        }

        [TestMethod]
        public void TestMethod5()
        {
            Calculations calculations = new Calculations(20, 2, "Обследование");
            double result = calculations.CostPriem();
            Assert.IsNotNull(result);
            Assert.AreEqual(result, 3200);

        }

        [TestMethod]
        public void TestMethod6()
        {
            Calculations calculations = new Calculations(30, 2, "Лечение");
            double result = calculations.CostPriem();
            Assert.IsNotNull(result);
            Assert.AreEqual(result, 4200);

        }
        [TestMethod]
        public void TestMethod7()
        {
            Calculations calculations = new Calculations(10, 3, "Консультация");
            double result = calculations.CostPriem();
            Assert.IsNotNull(result);
            Assert.AreEqual(result, 2700);

        }
        [TestMethod]
        public void TestMethod8()
        {
            Calculations calculations = new Calculations(30, 3, "Консультация");
            double result = calculations.CostPriem();
            Assert.IsNotNull(result);
            Assert.AreEqual(result, 2100);

        }
        [TestMethod]
        public void TestMethod9()
        {
            Calculations calculations = new Calculations(50, 3, "Консультация");
            double result = calculations.CostPriem();
            Assert.IsNotNull(result);
            Assert.AreEqual(result, 1500);

        }
        [TestMethod]
        public void TestMethod10()
        {
            Calculations calculations = new Calculations(0, 3, "Обследование");
            double result = calculations.CostPriem();
            Assert.IsNotNull(result);
            Assert.AreEqual(result, 6000);

        }




    }
}