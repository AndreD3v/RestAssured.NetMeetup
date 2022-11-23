namespace RestAssuredDemoProject.Tests
{
    public class ExamplesBlogBasDijkstra
    {
        [Test]
        public void StatusCodeIndicatingSuccessCanBeVerifiedAsInteger()
        {
            Given()
            .When()
                .Get("http://api.zippopotam.us/us/90210")
            .Then()
                .StatusCode(200);
        }

        [Test]
        public void CheckResponseStatusCodeAndJsonResponseBodyElementValue()
        {
            Given()
            .When()
                .Get("http://api.zippopotam.us/us/90210")
            .Then()
                .AssertThat()
                .StatusCode(200)
                .Log().Body()
            .And()
                .Body("$.places[0].state", NHamcrest.Is.EqualTo("California"));
        }

        //Below example is from blog Bas Dijkstra: https://www.ontestautomation.com/introducing-rest-assured-net/

        [Test]
        public void DeserializeIntoCSharpObject()
        {
            TodoItem todoItem = (TodoItem)Given()
            .When()
                .Get("https://jsonplaceholder.typicode.com/todos/1")
                .As(typeof(TodoItem));

            Assert.That(todoItem.Title, Is.EqualTo("delectus aut autem"));
        }
    }
}
