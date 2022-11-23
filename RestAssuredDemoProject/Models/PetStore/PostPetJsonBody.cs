namespace RestAssuredDemoProject.Models.PetStore
{
    public class PostPetJsonBody
    {
        
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public List<string> PhotoUrls { get; set; }
//        public List<Tag> Tags { get; set; }
        public string Status { get; set; }
        
    }
}
