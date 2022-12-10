using CheckStockMarketTime;
namespace StockMarketTimeTestUnit
{
    public class Tests
    {
        [Test]
        public void 週日市場不開()
        {
          Assert.IsFalse( StockMarket.CheckTWStockMarketTime(new DateTime(2022, 12, 11, 8, 30, 00)));
             
        }
        [Test]
        public void 平日下午2點不開()
        {
            Assert.IsFalse(StockMarket.CheckTWStockMarketTime(new DateTime(2022, 12, 12, 14, 00, 00)));

        }
        [Test]
        public void 平日市場開()
        {
            Assert.IsTrue(StockMarket.CheckTWStockMarketTime(new DateTime(2022, 12, 12, 10, 30, 00)));

        }
        [Test]
        public void 平日早上5點不開()
        {
            Assert.IsFalse(StockMarket.CheckTWStockMarketTime(new DateTime(2022, 12, 12, 05, 00, 00)));

        }
    }
}