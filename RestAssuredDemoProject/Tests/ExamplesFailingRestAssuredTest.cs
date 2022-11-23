namespace RestAssuredDemoProject.Tests
{
    public class ExamplesFailingRestAssuredTest
    {
        [Test]
        public void WrongStatusCode()
        {
            Given()
            .When()
                .Get("http://api.zippopotam.us/us/90210")
            .Then()
                .StatusCode(400);
        }

        [Test]
        public void WrongBodyData()
        {
            Given()
            .When()
                .Get("http://api.zippopotam.us/us/90210")
            .Then()
                .AssertThat()
                .StatusCode(200)
            .And()
                .Body("$.places[0].state", NHamcrest.Is.EqualTo("WrongBodyData"));
        }
    }
}
