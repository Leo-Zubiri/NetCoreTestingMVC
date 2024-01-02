using System.ComponentModel.DataAnnotations;

namespace NetCoreTestingMVC.Models
{
    public class Address
    {
        // Primary Key
        [Key] public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
