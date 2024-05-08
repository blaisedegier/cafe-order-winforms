namespace CafeApp
{
    public partial class Form1 : Form
    {
        Basket basket = new Basket();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            basket.AddItem(new Item(cmbItem.Text, (int)sedQuantity.Value));
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            redDisplay.Text = basket.DisplayItems();
        }
    }          
}
