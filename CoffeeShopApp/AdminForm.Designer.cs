namespace CoffeeShopApp
{
    partial class AdminForm
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
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.buttonMarkCompleted = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.button1Exit = new System.Windows.Forms.Button();
            this.button1Back = new System.Windows.Forms.Button();
            this.tabControlAdmin.SuspendLayout();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.tabProducts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabOrders);
            this.tabControlAdmin.Controls.Add(this.tabProducts);
            this.tabControlAdmin.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlAdmin.Location = new System.Drawing.Point(21, 23);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(700, 500);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // tabOrders
            // 
            this.tabOrders.BackColor = System.Drawing.Color.Tan;
            this.tabOrders.BackgroundImage = global::CoffeeShopApp.Properties.Resources.фон6_курсова;
            this.tabOrders.Controls.Add(this.buttonMarkCompleted);
            this.tabOrders.Controls.Add(this.dataGridViewOrders);
            this.tabOrders.Location = new System.Drawing.Point(4, 29);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(692, 467);
            this.tabOrders.TabIndex = 0;
            this.tabOrders.Text = "Замовлення";
            // 
            // buttonMarkCompleted
            // 
            this.buttonMarkCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(21)))));
            this.buttonMarkCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMarkCompleted.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMarkCompleted.ForeColor = System.Drawing.Color.Tan;
            this.buttonMarkCompleted.Location = new System.Drawing.Point(253, 408);
            this.buttonMarkCompleted.Name = "buttonMarkCompleted";
            this.buttonMarkCompleted.Size = new System.Drawing.Size(189, 32);
            this.buttonMarkCompleted.TabIndex = 1;
            this.buttonMarkCompleted.Text = "Позначити як виконане";
            this.buttonMarkCompleted.UseVisualStyleBackColor = false;
            this.buttonMarkCompleted.Click += new System.EventHandler(this.buttonMarkCompleted_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(30, 29);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(633, 364);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // tabProducts
            // 
            this.tabProducts.BackColor = System.Drawing.Color.Tan;
            this.tabProducts.BackgroundImage = global::CoffeeShopApp.Properties.Resources.фон6_курсова;
            this.tabProducts.Controls.Add(this.groupBox1);
            this.tabProducts.Controls.Add(this.dataGridViewProducts);
            this.tabProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(21)))));
            this.tabProducts.Location = new System.Drawing.Point(4, 29);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(692, 467);
            this.tabProducts.TabIndex = 1;
            this.tabProducts.Text = "Меню товарів";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::CoffeeShopApp.Properties.Resources.фон6_курсова;
            this.groupBox1.Controls.Add(this.textBoxProductName);
            this.groupBox1.Controls.Add(this.buttonDeleteProduct);
            this.groupBox1.Controls.Add(this.textBoxCategory);
            this.groupBox1.Controls.Add(this.buttonAddProduct);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.textBoxProductPrice);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(21)))));
            this.groupBox1.Location = new System.Drawing.Point(18, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 93);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель керування";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.Color.White;
            this.textBoxProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(21)))));
            this.textBoxProductName.Location = new System.Drawing.Point(24, 39);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(100, 26);
            this.textBoxProductName.TabIndex = 1;
            this.textBoxProductName.Text = "Назва товару";
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(21)))));
            this.buttonDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteProduct.ForeColor = System.Drawing.Color.Tan;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(563, 57);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(87, 31);
            this.buttonDeleteProduct.TabIndex = 4;
            this.buttonDeleteProduct.Text = "Видалити обране";
            this.buttonDeleteProduct.UseVisualStyleBackColor = false;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.BackColor = System.Drawing.Color.White;
            this.textBoxCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(21)))));
            this.textBoxCategory.Location = new System.Drawing.Point(268, 39);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(100, 26);
            this.textBoxCategory.TabIndex = 8;
            this.textBoxCategory.Text = "Категорія";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(21)))));
            this.buttonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddProduct.ForeColor = System.Drawing.Color.Tan;
            this.buttonAddProduct.Location = new System.Drawing.Point(575, 19);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 32);
            this.buttonAddProduct.TabIndex = 3;
            this.buttonAddProduct.Text = "Додати товар";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(21)))));
            this.textBoxDescription.Location = new System.Drawing.Point(146, 39);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 26);
            this.textBoxDescription.TabIndex = 6;
            this.textBoxDescription.Text = "Опис товару";
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.BackColor = System.Drawing.Color.White;
            this.textBoxProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(21)))));
            this.textBoxProductPrice.Location = new System.Drawing.Point(390, 39);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(100, 26);
            this.textBoxProductPrice.TabIndex = 2;
            this.textBoxProductPrice.Text = "Ціна";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(43, 25);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(609, 327);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.White;
            this.labelWelcome.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelWelcome.Location = new System.Drawing.Point(299, 7);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(92, 13);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Вітаємо, Тамаро";
            // 
            // button1Exit
            // 
            this.button1Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1Exit.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(21)))));
            this.button1Exit.Location = new System.Drawing.Point(661, 529);
            this.button1Exit.Name = "button1Exit";
            this.button1Exit.Size = new System.Drawing.Size(86, 40);
            this.button1Exit.TabIndex = 2;
            this.button1Exit.Text = "Вихід";
            this.button1Exit.UseVisualStyleBackColor = true;
            this.button1Exit.Click += new System.EventHandler(this.button1Exit_Click);
            // 
            // button1Back
            // 
            this.button1Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1Back.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(37)))), ((int)(((byte)(21)))));
            this.button1Back.Location = new System.Drawing.Point(12, 529);
            this.button1Back.Name = "button1Back";
            this.button1Back.Size = new System.Drawing.Size(86, 40);
            this.button1Back.TabIndex = 3;
            this.button1Back.Text = "Назад";
            this.button1Back.UseVisualStyleBackColor = true;
            this.button1Back.Click += new System.EventHandler(this.button1Back_Click);
            // 
            // AdminForm
            // 
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::CoffeeShopApp.Properties.Resources.фон4_курсова;
            this.ClientSize = new System.Drawing.Size(759, 581);
            this.Controls.Add(this.button1Back);
            this.Controls.Add(this.button1Exit);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "AdminForm";
            this.Text = "Форма адміністратора";
            this.Load += new System.EventHandler(this.AdminForm_Load_1);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.tabProducts.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.Button buttonMarkCompleted;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button button1Exit;
        private System.Windows.Forms.Button button1Back;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}