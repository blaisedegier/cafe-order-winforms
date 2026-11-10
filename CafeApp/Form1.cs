namespace CafeApp
{
    public partial class Form1 : Form
    {
        private readonly Basket basket = new Basket();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbItem.SelectedItem is not string drink)
            {
                MessageBox.Show("Please select a drink.", "Cafe");
                return;
            }

            int quantity = decimal.ToInt32(sedQuantity.Value);
            if (quantity < 1)
            {
                MessageBox.Show("Quantity must be at least 1.", "Cafe");
                return;
            }

            basket.AddItem(new Item(drink, quantity));
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            redDisplay.Text = basket.DisplayItems();
        }
    }
}
