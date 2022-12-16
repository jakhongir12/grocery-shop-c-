namespace Project_1_Grocery_Store
{
    partial class Form1
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
            this.GroceryShop = new System.Windows.Forms.Label();
            this.AddProducts = new System.Windows.Forms.Button();
            this.ShoppingMenu = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GroceryShop
            // 
            this.GroceryShop.AutoSize = true;
            this.GroceryShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroceryShop.Location = new System.Drawing.Point(71, 34);
            this.GroceryShop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GroceryShop.Name = "GroceryShop";
            this.GroceryShop.Size = new System.Drawing.Size(372, 64);
            this.GroceryShop.TabIndex = 1;
            this.GroceryShop.Text = "Grocery Shop";
            // 
            // AddProducts
            // 
            this.AddProducts.BackColor = System.Drawing.Color.Yellow;
            this.AddProducts.Location = new System.Drawing.Point(135, 207);
            this.AddProducts.Margin = new System.Windows.Forms.Padding(2);
            this.AddProducts.Name = "AddProducts";
            this.AddProducts.Size = new System.Drawing.Size(245, 62);
            this.AddProducts.TabIndex = 3;
            this.AddProducts.Text = "Add Products";
            this.AddProducts.UseVisualStyleBackColor = false;
            this.AddProducts.Click += new System.EventHandler(this.AddProducts_Click);
            // 
            // ShoppingMenu
            // 
            this.ShoppingMenu.BackColor = System.Drawing.Color.Yellow;
            this.ShoppingMenu.Location = new System.Drawing.Point(135, 295);
            this.ShoppingMenu.Margin = new System.Windows.Forms.Padding(2);
            this.ShoppingMenu.Name = "ShoppingMenu";
            this.ShoppingMenu.Size = new System.Drawing.Size(245, 68);
            this.ShoppingMenu.TabIndex = 4;
            this.ShoppingMenu.Text = "Shopping Menu";
            this.ShoppingMenu.UseVisualStyleBackColor = false;
            this.ShoppingMenu.Click += new System.EventHandler(this.ShoppingMenu_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Yellow;
            this.Exit.Location = new System.Drawing.Point(135, 389);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(245, 58);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 582);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Programmed by [ Tiger 1 ]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(515, 635);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ShoppingMenu);
            this.Controls.Add(this.AddProducts);
            this.Controls.Add(this.GroceryShop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Grocery Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GroceryShop;
        private System.Windows.Forms.Button AddProducts;
        private System.Windows.Forms.Button ShoppingMenu;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
    }
}

