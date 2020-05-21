using MaskSupplier.Service;
using NUnit.Framework;

namespace MaskSupplier.Test
{
    [TestFixture]
    public class CityRiskServiceTest
    {
        [Test]
        public void Should_Return_NULL([Values(0)] int infecteds)
        {
            var service = new CityRiskService();
            var output = service.CalculateRisk(infecteds);

            Assert.AreEqual("Sem risco", output);
        }
        [Test]
        public void Should_Return_LOW([Values(12)] int infecteds)
        {
            var service = new CityRiskService();
            var output = service.CalculateRisk(infecteds);

            Assert.AreEqual("Baixo", output);
        }
        [Test]
        public void Should_Return_MEDIUM([Values(56)] int infecteds)
        {
            var service = new CityRiskService();
            var output = service.CalculateRisk(infecteds);

            Assert.AreEqual("Médio", output);
        }
        [Test]
        public void Should_Return_HIGH([Values(101)] int infecteds)
        {
            var service = new CityRiskService();
            var output = service.CalculateRisk(infecteds);

            Assert.AreEqual("Alto", output);
        }
    }
}
