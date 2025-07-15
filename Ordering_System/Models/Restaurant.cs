namespace Ordering_System.Models
{
    public class Restaurant
    {

        // Primary Key for the Restaurant model
        public int Id { get; set; }

        // Name of the restaurant (e.g., "McDonald's Braamfontein")
        public string Name { get; set; } = "";

        // A brief description of the restaurant's location (e.g., "Jan Smuts Avenue")
        public string LocationDescription { get; set; } = "";

        // Contact number for the restaurant
        public string ContactNumber { get; set; } = "";
    }

}
