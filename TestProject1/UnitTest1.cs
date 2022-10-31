using TaiwanStock.Utilities;

namespace TestProject1
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			string input = "2022/10/31 14:00";
			bool isDate = DateTime.TryParse(input, out DateTime dt);
			var tradeDay = new TaiwanStockUtility().IsTradingTime(dt);

			Assert.AreEqual(false, tradeDay);
		}
		[Test]
		public void Test2()
		{
			string input = "2022/10/31 13:00";
			bool isDate = DateTime.TryParse(input, out DateTime dt);

			var tradeDay = new TaiwanStockUtility().IsTradingTime(dt);

			Assert.AreEqual(true, tradeDay);
		}
	}
}