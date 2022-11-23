using RestAssuredDemoProject.Models.PetStore;

namespace RestAssuredDemoProject.Tests
{
    public class PetStore
    {
        [Test]
        public void AtestWithAddingAJsonBodyToTheRequest()
        {

            //todo: uitzoeken wat hier nu mis gaat
            //https://petstore.swagger.io/#/pet/updatePetWithForm
            //https://json2csharp.com/
            //https://github.com/basdijkstra/rest-assured-net/wiki/Usage-Guide
            //https://github.com/basdijkstra/rest-assured-net/issues
            //https://www.ontestautomation.com/introducing-rest-assured-net/
            // 

            PostPetJsonBody pet = new PostPetJsonBody
            {
                Id = 26,
                Category = new Category
                {
                    Id = 0,
                    Name = "Hyena"
                },
                Name = "Luca",
                PhotoUrls = new List<string> { "blaat" },//{ Guid.NewGuid().ToString() + "001", Guid.NewGuid().ToString() + "002" },
                Status = "available"
            };

            Given()
            //.ContentType("application/json")
            .Body(pet)
            .When()
            .Post("https://petstore.swagger.io/v2/pet")
            .Then()
             .Log().Body()
                 .Log().All()
            .StatusCode(200);
                //.And()

                //.Body("name", NHamcrest.Is.EqualTo("Hyena"));
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
            .And()
                .Body("$.places[0].state", NHamcrest.Is.EqualTo("California"));
        }
    }
}
