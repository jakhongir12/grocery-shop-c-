namespace Project_1_Grocery_Store
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShoppingPageL = new System.Windows.Forms.Label();
            this.AvailableProducts = new System.Windows.Forms.Label();
            this.ShoppingBasket = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Select = new System.Windows.Forms.Button();
            this.Sum_label = new System.Windows.Forms.Label();
            this.sum_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.ProductName_OPT = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.ID_OPT = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Price_OPT = new System.Windows.Forms.Label();
            this.sign = new System.Windows.Forms.Label();
            this.Quantity_OPT = new System.Windows.Forms.NumericUpDown();
            this.Checkout = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.AddToBasket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_OPT)).BeginInit();
            this.SuspendLayout();
            // 
            // ShoppingPageL
            // 
            this.ShoppingPageL.AutoSize = true;
            this.ShoppingPageL.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingPageL.Location = new System.Drawing.Point(43, 32);
            this.ShoppingPageL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShoppingPageL.Name = "ShoppingPageL";
            this.ShoppingPageL.Size = new System.Drawing.Size(408, 64);
            this.ShoppingPageL.TabIndex = 1;
            this.ShoppingPageL.Text = "Shopping Page";
            // 
            // AvailableProducts
            // 
            this.AvailableProducts.AutoSize = true;
            this.AvailableProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableProducts.Location = new System.Drawing.Point(49, 130);
            this.AvailableProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AvailableProducts.Name = "AvailableProducts";
            this.AvailableProducts.Size = new System.Drawing.Size(193, 26);
            this.AvailableProducts.TabIndex = 3;
            this.AvailableProducts.Text = "Available Products";
            // 
            // ShoppingBasket
            // 
            this.ShoppingBasket.AutoSize = true;
            this.ShoppingBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingBasket.Location = new System.Drawing.Point(509, 130);
            this.ShoppingBasket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShoppingBasket.Name = "ShoppingBasket";
            this.ShoppingBasket.Size = new System.Drawing.Size(177, 26);
            this.ShoppingBasket.TabIndex = 4;
            this.ShoppingBasket.Text = "Shopping Basket";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(54, 170);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(321, 144);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(514, 170);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(321, 144);
            this.listBox2.TabIndex = 6;
            // 
            // Select
            // 
            this.Select.BackColor = System.Drawing.Color.Yellow;
            this.Select.Location = new System.Drawing.Point(54, 341);
            this.Select.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(321, 40);
            this.Select.TabIndex = 7;
            this.Select.Text = "Select";
            this.Select.UseVisualStyleBackColor = false;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Sum_label
            // 
            this.Sum_label.AutoSize = true;
            this.Sum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum_label.Location = new System.Drawing.Point(518, 341);
            this.Sum_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sum_label.Name = "Sum_label";
            this.Sum_label.Size = new System.Drawing.Size(70, 26);
            this.Sum_label.TabIndex = 8;
            this.Sum_label.Text = "Sum: ";
            // 
            // sum_lbl
            // 
            this.sum_lbl.AutoSize = true;
            this.sum_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum_lbl.Location = new System.Drawing.Point(592, 341);
            this.sum_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sum_lbl.Name = "sum_lbl";
            this.sum_lbl.Size = new System.Drawing.Size(24, 26);
            this.sum_lbl.TabIndex = 19;
            this.sum_lbl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(662, 341);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "$";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(49, 421);
            this.ProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(164, 26);
            this.ProductName.TabIndex = 22;
            this.ProductName.Text = "Product Name: ";
            // 
            // ProductName_OPT
            // 
            this.ProductName_OPT.AutoSize = true;
            this.ProductName_OPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName_OPT.Location = new System.Drawing.Point(238, 421);
            this.ProductName_OPT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductName_OPT.Name = "ProductName_OPT";
            this.ProductName_OPT.Size = new System.Drawing.Size(0, 26);
            this.ProductName_OPT.TabIndex = 23;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(49, 469);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(46, 26);
            this.ID.TabIndex = 24;
            this.ID.Text = "ID: ";
            // 
            // ID_OPT
            // 
            this.ID_OPT.AutoSize = true;
            this.ID_OPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_OPT.Location = new System.Drawing.Point(238, 469);
            this.ID_OPT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID_OPT.Name = "ID_OPT";
            this.ID_OPT.Size = new System.Drawing.Size(0, 26);
            this.ID_OPT.TabIndex = 25;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(49, 516);
            this.Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(68, 26);
            this.Price.TabIndex = 26;
            this.Price.Text = "Price:";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(49, 565);
            this.Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(99, 26);
            this.Quantity.TabIndex = 27;
            this.Quantity.Text = "Quantity:";
            // 
            // Price_OPT
            // 
            this.Price_OPT.AutoSize = true;
            this.Price_OPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_OPT.Location = new System.Drawing.Point(248, 516);
            this.Price_OPT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Price_OPT.Name = "Price_OPT";
            this.Price_OPT.Size = new System.Drawing.Size(24, 26);
            this.Price_OPT.TabIndex = 28;
            this.Price_OPT.Text = "0";
            // 
            // sign
            // 
            this.sign.AutoSize = true;
            this.sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign.Location = new System.Drawing.Point(304, 516);
            this.sign.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(24, 26);
            this.sign.TabIndex = 29;
            this.sign.Text = "$";
            // 
            // Quantity_OPT
            // 
            this.Quantity_OPT.Location = new System.Drawing.Point(243, 568);
            this.Quantity_OPT.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Quantity_OPT.Name = "Quantity_OPT";
            this.Quantity_OPT.Size = new System.Drawing.Size(97, 26);
            this.Quantity_OPT.TabIndex = 31;
            this.Quantity_OPT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Checkout
            // 
            this.Checkout.BackColor = System.Drawing.Color.Yellow;
            this.Checkout.Location = new System.Drawing.Point(514, 409);
            this.Checkout.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(321, 38);
            this.Checkout.TabIndex = 32;
            this.Checkout.Text = "Checkout";
            this.Checkout.UseVisualStyleBackColor = false;
            this.Checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Yellow;
            this.Exit.Location = new System.Drawing.Point(514, 640);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(321, 40);
            this.Exit.TabIndex = 33;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AddToBasket
            // 
            this.AddToBasket.BackColor = System.Drawing.Color.Yellow;
            this.AddToBasket.Location = new System.Drawing.Point(54, 641);
            this.AddToBasket.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AddToBasket.Name = "AddToBasket";
            this.AddToBasket.Size = new System.Drawing.Size(321, 39);
            this.AddToBasket.TabIndex = 34;
            this.AddToBasket.Text = "Add To Basket";
            this.AddToBasket.UseVisualStyleBackColor = false;
            this.AddToBasket.Click += new System.EventHandler(this.AddToBasket_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(967, 725);
            this.Controls.Add(this.AddToBasket);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Checkout);
            this.Controls.Add(this.Quantity_OPT);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.Price_OPT);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ID_OPT);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.ProductName_OPT);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sum_lbl);
            this.Controls.Add(this.Sum_label);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ShoppingBasket);
            this.Controls.Add(this.AvailableProducts);
            this.Controls.Add(this.ShoppingPageL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "Shopping Page";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_OPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShoppingPageL;
        private System.Windows.Forms.Label AvailableProducts;
        private System.Windows.Forms.Label ShoppingBasket;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Label Sum_label;
        private System.Windows.Forms.Label sum_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label ProductName_OPT;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label ID_OPT;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label Price_OPT;
        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.NumericUpDown Quantity_OPT;
        private System.Windows.Forms.Button Checkout;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button AddToBasket;
    }
}