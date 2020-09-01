using System.Collections.Generic;

namespace TestTask.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
        public ICollection<CarOwner> CarOwners { get; set; }
    }
}
