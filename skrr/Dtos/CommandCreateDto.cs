namespace skrr.Dtos 
{
    public class CommandCreateDto 
    {   
        // Here we don't have an Id when we create a new object
        // since that is handled automatically by our database.
        public string HowTo { get; set; }
        
        public string Line { get; set; }

        public string Platform { get; set; }
       
    }
}