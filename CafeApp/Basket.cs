namespace CafeApp
{
    // Item Basket class
    class Basket
    {
        // Properties
        private List<Item>? items;

        // Constructor
        public Basket() => items = new List<Item>();

        // Add item to basket
        public void AddItem(Item item) => items?.Add(item);

        // Display items in basket
        public string DisplayItems()
        {
            string display = "Name:\tQuantity\tPrice\n";
            if (items != null)
            {
                foreach (Item item in items)
                {
                    display += $"{item.Name}\t{item.Quantity}\tR{item.Price}\n";
                }
                // Calculate total price
                display += $"\nTotal Price: R{items.Sum(item => item.Price * item.Quantity)}";
            }
            return display;
        }
    }
}
