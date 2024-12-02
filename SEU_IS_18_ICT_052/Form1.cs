namespace SEU_IS_18_ICT_052
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validate Fields
            if (cmbBookName.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtQuantity.Text) || cmbMembership.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Quantity
            int enteredQty;
            if (!int.TryParse(txtQuantity.Text, out enteredQty) || enteredQty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fetch Book Details
            int availableQty = 0;
            double price = 0;
            switch (cmbBookName.SelectedIndex)
            {
                case 0: availableQty = 25; price = 19.99; break; // The Lord of the Rings
                case 1: availableQty = 30; price = 12.99; break; // Harry Potter
                case 2: availableQty = 15; price = 8.99; break; // Pride and Prejudice
                case 3: availableQty = 20; price = 11.99; break; // To Kill a Mockingbird
                case 4: availableQty = 18; price = 9.99; break; // The Great Gatsby
                case 5: availableQty = 22; price = 10.99; break; // The Catcher in the Rye
                case 6: availableQty = 10; price = 7.99; break; // 1984
                case 7: availableQty = 12; price = 14.99; break; // The Hitchhiker's Guide to the Galaxy
                case 8: availableQty = 15; price = 12.99; break; // The Alchemist
                case 9: availableQty = 28; price = 16.99; break; // The Silent Patient
            }

            if (enteredQty > availableQty)
            {
                MessageBox.Show("Entered quantity exceeds available stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate Total Price Before Discount
            double totalBeforeDiscount = price * enteredQty;
            double discount = 0;

            // Apply Discounts
            if (cmbMembership.SelectedItem.ToString() == "Club Member")
            {
                discount = totalBeforeDiscount * 0.12; // Club Member Discount
            }
            else if (totalBeforeDiscount >= 50)
            {
                discount = totalBeforeDiscount * 0.10; // Bulk Purchase Discount
            }
            else
            {
                // Special Book Discounts
                if (cmbBookName.SelectedItem.ToString().Contains("Harry Potter"))
                {
                    discount = totalBeforeDiscount * 0.15;
                }
                else if (cmbBookName.SelectedItem.ToString().Contains("Hitchhiker's Guide"))
                {
                    discount = totalBeforeDiscount * 0.15;
                }
                else if (cmbBookName.SelectedItem.ToString().Contains("The Alchemist"))
                {
                    discount = totalBeforeDiscount * 0.15;
                }
            }

            // Calculate Total After Discount
            double totalAfterDiscount = totalBeforeDiscount - discount;

            // Display Bill Details
            rtbBill.Text = $"Book Name: {cmbBookName.SelectedItem}\n" +
                           $"Quantity: {enteredQty}\n" +
                           $"Price per Item: ${price:F2}\n" +
                           $"Total Before Discount: ${totalBeforeDiscount:F2}\n" +
                           $"Discount Applied: ${discount:F2}\n" +
                           $"Total After Discount: ${totalAfterDiscount:F2}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear Fields
            cmbBookName.SelectedIndex = -1;
            txtQuantity.Clear();
            cmbMembership.SelectedIndex = -1;
            rtbBill.Clear();
        }
    }
}
