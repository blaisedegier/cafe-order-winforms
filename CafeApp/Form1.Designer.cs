namespace CafeApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cmbItem = new ComboBox();
            bindingSource1 = new BindingSource(components);
            sedQuantity = new NumericUpDown();
            btnAdd = new Button();
            redDisplay = new RichTextBox();
            lblTitle = new Label();
            panel1 = new Panel();
            btnDisplay = new Button();
            lblQuantity = new Label();
            lblItem = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sedQuantity).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbItem
            // 
            cmbItem.Font = new Font("Arial", 12F);
            cmbItem.FormattingEnabled = true;
            cmbItem.Items.AddRange(new object[] { "Espresso", "Cappuccino", "Latte", "Americano" });
            cmbItem.Location = new Point(12, 132);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(195, 26);
            cmbItem.TabIndex = 0;
            // 
            // sedQuantity
            // 
            sedQuantity.Font = new Font("Arial", 12F);
            sedQuantity.Location = new Point(12, 217);
            sedQuantity.Name = "sedQuantity";
            sedQuantity.Size = new Size(195, 26);
            sedQuantity.TabIndex = 1;
            sedQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial Black", 11F);
            btnAdd.Location = new Point(12, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 40);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // redDisplay
            // 
            redDisplay.Font = new Font("Arial Black", 12F);
            redDisplay.Location = new Point(406, 0);
            redDisplay.Name = "redDisplay";
            redDisplay.Size = new Size(400, 375);
            redDisplay.TabIndex = 4;
            redDisplay.Text = "";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Black", 28F, FontStyle.Bold);
            lblTitle.Location = new Point(3, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(366, 54);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Cafe Application";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDisplay);
            panel1.Controls.Add(lblQuantity);
            panel1.Controls.Add(lblItem);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(cmbItem);
            panel1.Controls.Add(sedQuantity);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 375);
            panel1.TabIndex = 6;
            // 
            // btnDisplay
            // 
            btnDisplay.Font = new Font("Arial Black", 11F);
            btnDisplay.Location = new Point(256, 290);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(113, 40);
            btnDisplay.TabIndex = 9;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblQuantity.Location = new Point(12, 188);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(182, 26);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Choose Quantity";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblItem.Location = new Point(12, 103);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(124, 26);
            lblItem.TabIndex = 6;
            lblItem.Text = "Select Item";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 376);
            Controls.Add(panel1);
            Controls.Add(redDisplay);
            Name = "Form1";
            Text = "CafeApp";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sedQuantity).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbItem;
        private BindingSource bindingSource1;
        private NumericUpDown sedQuantity;
        private Button btnAdd;
        private RichTextBox redDisplay;
        private Label lblTitle;
        private Panel panel1;
        private Label lblItem;
        private Label lblQuantity;
        private Button btnDisplay;
    }
}
