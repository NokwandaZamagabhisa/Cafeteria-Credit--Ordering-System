namespace Ordering_System.Models
{
    public class MenuItem
    {
        // Primary Key for MenuItem model
        public int Id { get; set; }

        // Foreign Key to the Restaurant model
        public int RestaurantId { get; set; }

        // Navigation property to the related Restaurant
        public Restaurant Restaurant { get; set; } = "";

        // Name of the menu item (e.g., "Big Mac Meal")
        public string Name { get; set; } = "";

        // Description of the menu item
        public string Description { get; set; } = "";

        // Price of the menu item
        public decimal Price { get; set; }
    }
}
