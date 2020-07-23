namespace skrr.Dtos 
{
    // To illustrate the use of DTO's, we're not using the platform attribute
    // As we send the object to the client.
    public class CommandReadDto 
    {        
        public int Id { get; set; }
        
        public string HowTo { get; set; }
        
        public string Line { get; set; }
       
    }
}