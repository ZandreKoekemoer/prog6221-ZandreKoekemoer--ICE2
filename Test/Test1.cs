using ICE2;

namespace Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void updatePowerTest()
        {
            Cars car = new Cars(300, 786, 340, "AMD Valkyrie", "Austin Martin");
            car[0] = 500;
            Assert.AreEqual(car[0], 500);

        }

        [TestMethod]
        public void updateSpeedTest()
        {
            Cars car = new Cars(300, 786, 340, "AMD Valkyrie", "Austin Martin");
            car[2] = 400;
            Assert.AreEqual(car[2], 400);
        }

        [TestMethod]
        public void updateWeightTest()
        {
            Cars car = new Cars(300, 786, 340, "AMD Valkyrie", "Austin Martin");
            car[1] = 1000;
            Assert.AreEqual(car[1], 1000);
        }

        [TestMethod]
        public void TestModel()
        {
            Cars car = new Cars(300, 786, 340, "AMD Valkyrie", "Austin Martin");
            Assert.AreEqual(car[3], "AMD Valkyrie");
        }
        [TestMethod]
        public void TestBrand()
        {
            Cars car = new Cars(300, 786, 340, "AMD Valkyrie", "Austin Martin");
            Assert.AreEqual(car[4], "Austin Martin");
        }
    }
}
