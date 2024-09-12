using Tyuiu.TyazhovLA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.TyazhovLA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Леонид";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Леонид", res);
        }
    }
}