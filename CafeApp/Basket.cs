namespace CafeApp
{
    // The items on the current order.
    class Basket
    {
        private readonly List<Item> items = new List<Item>();

        public void AddItem(Item item) => items.Add(item);

        // One line per item (name, quantity, unit price, line total) followed by the order total.
        public string DisplayItems()
        {
            string display = "Name\tQty\tPrice\tTotal\n";
            foreach (Item item in items)
            {
                display += $"{item.Name}\t{item.Quantity}\tR{item.Price}\tR{item.LineTotal}\n";
            }
            display += $"\nOrder total: R{items.Sum(item => item.LineTotal)}";
            return display;
        }
    }
}
