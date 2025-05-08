using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Models
{

    public class Item
    {
        public int Id { get; set; }
        public string name { get; set; } = null!;
        public double price { get; set; }
        //public int? serialNumberId { get; set; }
        //public SerialNumber? SerialNumber { get; set; }
    }
}
