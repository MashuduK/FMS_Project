namespace FMS_Project.Models
{
    public class ServiceCheck
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public bool Passed { get; set; }
        public int FridgeId { get; set; }
        public Fridge? Fridge { get; set; }
    }
}
