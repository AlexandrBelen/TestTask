using System.Collections.Generic;

namespace TestTask.Models
{
    public class Owner
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public string MidName { get; set; }
		public string DateOfBirth { get; set; }
		public ICollection<CarOwner> Owners { get; set; }
	}
}