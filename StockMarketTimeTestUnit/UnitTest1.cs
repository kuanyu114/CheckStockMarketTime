using CheckStockMarketTime;
namespace StockMarketTimeTestUnit
{
    public class Tests
    {
        [Test]
        public void �g�饫�����}()
        {
          Assert.IsFalse( StockMarket.CheckTWStockMarketTime(new DateTime(2022, 12, 11, 8, 30, 00)));
             
        }
        [Test]
        public void ����U��2�I���}()
        {
            Assert.IsFalse(StockMarket.CheckTWStockMarketTime(new DateTime(2022, 12, 12, 14, 00, 00)));

        }
        [Test]
        public void ���饫���}()
        {
            Assert.IsTrue(StockMarket.CheckTWStockMarketTime(new DateTime(2022, 12, 12, 10, 30, 00)));

        }
        [Test]
        public void ���馭�W5�I���}()
        {
            Assert.IsFalse(StockMarket.CheckTWStockMarketTime(new DateTime(2022, 12, 12, 05, 00, 00)));

        }
    }
}