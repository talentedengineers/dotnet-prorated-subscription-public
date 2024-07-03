namespace DotNetProratedSubscription.Tests
{
    [TestClass]
    public class SubscriptionTest
    {
        [TestMethod]
        public void CalculateProratedSubscription()
        {
            Assert.AreEqual(Convert.ToDecimal(99), Subscription.CalculateProratedSubscription(new DateTime(2024, 8, 1, 10, 51, 34), Convert.ToDecimal(99)));
        }
    }
}