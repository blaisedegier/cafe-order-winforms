namespace CafeApp
{
    //Item class
    class Item
    {
        // Properties
        private string name;
        private int quantity;
        private int price;

        // Constructor
        public Item(string name, int quantity)
        {
            if (name == "Espresso" || name == "Cappuccino" || name == "Latte" || name == "")
            {
                
            }
            this.name = name;
            this.quantity = quantity;
            switch (name)
            {
                case "Espresso":
                    price = 20;
                    break;
                case "Cappuccino":
                    price = 25;
                    break;
                case "Latte":
                    price = 30;
                    break;
                case "Americano":
                    price = 15;
                    break;
            }
        }

        // Getters and Setters
        public string Name { get { return name; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public int Price { get { return price; } set { price = value; } }

    }
}
