namespace CafeApp
{
    // One line of an order: a drink from the menu, how many, and its unit price in rand.
    class Item
    {
        public Item(string name, int quantity)
        {
            if (quantity < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be at least 1.");
            }

            // The unit price comes from the menu. A name that is not on it is rejected rather than priced at zero.
            Price = name switch
            {
                "Espresso" => 20,
                "Cappuccino" => 25,
                "Latte" => 30,
                "Americano" => 15,
                _ => throw new ArgumentException($"'{name}' is not on the menu.", nameof(name))
            };
            Name = name;
            Quantity = quantity;
        }

        public string Name { get; }
        public int Quantity { get; }
        public int Price { get; }
        public int LineTotal => Price * Quantity;
    }
}
