namespace RestAssuredDemoProject.Tests
{
    public class TestingBasicsSetupNunitFramework
    {
        [Test]
        public void VerifiedIfTestFrameworkDoesWork_Pass()
        {
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void VerifiedIfTestFrameworkDoesWork_Fail()
        {
            Assert.AreEqual(1, 2);
        }
    }
}