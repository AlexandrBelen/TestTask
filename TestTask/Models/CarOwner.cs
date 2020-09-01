namespace TestTask.Models
{
    
    public class CarOwner
    {
        public int Id { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}