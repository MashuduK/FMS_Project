namespace FMS_Project.Models
{
    public class Fridge
    {

        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? SerialNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public ICollection<ServiceCheck> ServiceChecks { get; set; }
    }
}
