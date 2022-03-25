
namespace Laboration4
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
            this.components = new System.ComponentModel.Container();
            this.listOfProducts = new System.Windows.Forms.ListBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabStore = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabStorage = new System.Windows.Forms.TabPage();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxGametime = new System.Windows.Forms.TextBox();
            this.textBoxLanguage = new System.Windows.Forms.TextBox();
            this.textBoxPlatform = new System.Windows.Forms.TextBox();
            this.textBoxFormat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonStoreProduct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxStorage = new System.Windows.Forms.ListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonNewProduct = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.tabStore.SuspendLayout();
            this.tabStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfProducts
            // 
            this.listOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfProducts.FormattingEnabled = true;
            this.listOfProducts.ItemHeight = 33;
            this.listOfProducts.Location = new System.Drawing.Point(8, 6);
            this.listOfProducts.Name = "listOfProducts";
            this.listOfProducts.Size = new System.Drawing.Size(258, 400);
            this.listOfProducts.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabStore);
            this.TabControl.Controls.Add(this.tabStorage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(776, 450);
            this.TabControl.TabIndex = 1;
            // 
            // tabStore
            // 
            this.tabStore.Controls.Add(this.button3);
            this.tabStore.Controls.Add(this.button4);
            this.tabStore.Controls.Add(this.textBox1);
            this.tabStore.Controls.Add(this.listOfProducts);
            this.tabStore.Location = new System.Drawing.Point(4, 22);
            this.tabStore.Name = "tabStore";
            this.tabStore.Padding = new System.Windows.Forms.Padding(3);
            this.tabStore.Size = new System.Drawing.Size(768, 424);
            this.tabStore.TabIndex = 0;
            this.tabStore.Text = "Butik";
            this.tabStore.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 43);
            this.button3.TabIndex = 15;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(425, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 43);
            this.button4.TabIndex = 14;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 29);
            this.textBox1.TabIndex = 1;
            // 
            // tabStorage
            // 
            this.tabStorage.Controls.Add(this.buttonNewProduct);
            this.tabStorage.Controls.Add(this.textBoxStock);
            this.tabStorage.Controls.Add(this.textBoxGametime);
            this.tabStorage.Controls.Add(this.textBoxLanguage);
            this.tabStorage.Controls.Add(this.textBoxPlatform);
            this.tabStorage.Controls.Add(this.textBoxFormat);
            this.tabStorage.Controls.Add(this.label10);
            this.tabStorage.Controls.Add(this.label9);
            this.tabStorage.Controls.Add(this.label8);
            this.tabStorage.Controls.Add(this.label7);
            this.tabStorage.Controls.Add(this.label6);
            this.tabStorage.Controls.Add(this.buttonDelete);
            this.tabStorage.Controls.Add(this.buttonStoreProduct);
            this.tabStorage.Controls.Add(this.label5);
            this.tabStorage.Controls.Add(this.textBoxGenre);
            this.tabStorage.Controls.Add(this.textBoxAuthor);
            this.tabStorage.Controls.Add(this.textBoxPrice);
            this.tabStorage.Controls.Add(this.textBoxName);
            this.tabStorage.Controls.Add(this.textBoxId);
            this.tabStorage.Controls.Add(this.label4);
            this.tabStorage.Controls.Add(this.label3);
            this.tabStorage.Controls.Add(this.label2);
            this.tabStorage.Controls.Add(this.label1);
            this.tabStorage.Controls.Add(this.listBoxStorage);
            this.tabStorage.Location = new System.Drawing.Point(4, 22);
            this.tabStorage.Name = "tabStorage";
            this.tabStorage.Padding = new System.Windows.Forms.Padding(3);
            this.tabStorage.Size = new System.Drawing.Size(768, 424);
            this.tabStorage.TabIndex = 1;
            this.tabStorage.Text = "Lager";
            this.tabStorage.UseVisualStyleBackColor = true;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(610, 233);
            this.textBoxStock.Multiline = true;
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(120, 30);
            this.textBoxStock.TabIndex = 23;
            this.textBoxStock.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxStock_Validating);
            this.textBoxStock.Validated += new System.EventHandler(this.textBoxStock_Validated);
            // 
            // textBoxGametime
            // 
            this.textBoxGametime.Location = new System.Drawing.Point(610, 187);
            this.textBoxGametime.Multiline = true;
            this.textBoxGametime.Name = "textBoxGametime";
            this.textBoxGametime.Size = new System.Drawing.Size(120, 30);
            this.textBoxGametime.TabIndex = 22;
            // 
            // textBoxLanguage
            // 
            this.textBoxLanguage.Location = new System.Drawing.Point(610, 84);
            this.textBoxLanguage.Multiline = true;
            this.textBoxLanguage.Name = "textBoxLanguage";
            this.textBoxLanguage.Size = new System.Drawing.Size(120, 30);
            this.textBoxLanguage.TabIndex = 21;
            // 
            // textBoxPlatform
            // 
            this.textBoxPlatform.Location = new System.Drawing.Point(610, 137);
            this.textBoxPlatform.Multiline = true;
            this.textBoxPlatform.Name = "textBoxPlatform";
            this.textBoxPlatform.Size = new System.Drawing.Size(120, 30);
            this.textBoxPlatform.TabIndex = 8;
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Location = new System.Drawing.Point(610, 29);
            this.textBoxFormat.Multiline = true;
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(120, 30);
            this.textBoxFormat.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(525, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Antal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(512, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Speltid";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(507, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Plattform";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(518, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Språk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(518, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Format";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(610, 328);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 43);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Ta Bort";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonStoreProduct
            // 
            this.buttonStoreProduct.Location = new System.Drawing.Point(442, 328);
            this.buttonStoreProduct.Name = "buttonStoreProduct";
            this.buttonStoreProduct.Size = new System.Drawing.Size(105, 43);
            this.buttonStoreProduct.TabIndex = 13;
            this.buttonStoreProduct.Text = "Lagra";
            this.buttonStoreProduct.UseVisualStyleBackColor = true;
            this.buttonStoreProduct.Click += new System.EventHandler(this.buttonStoreProduct_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Genre";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(381, 233);
            this.textBoxGenre.Multiline = true;
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(120, 30);
            this.textBoxGenre.TabIndex = 11;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(381, 187);
            this.textBoxAuthor.Multiline = true;
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(120, 30);
            this.textBoxAuthor.TabIndex = 10;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(381, 137);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(120, 30);
            this.textBoxPrice.TabIndex = 9;
            this.textBoxPrice.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrice_Validating);
            this.textBoxPrice.Validated += new System.EventHandler(this.textBoxPrice_Validated);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(381, 84);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 30);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTitle_Validating);
            this.textBoxName.Validated += new System.EventHandler(this.textBoxTitle_Validated);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(381, 29);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(120, 30);
            this.textBoxId.TabIndex = 7;
            this.textBoxId.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxId_Validating);
            this.textBoxId.Validated += new System.EventHandler(this.textBoxId_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Författare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pris";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Namn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // listBoxStorage
            // 
            this.listBoxStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStorage.FormattingEnabled = true;
            this.listBoxStorage.ItemHeight = 33;
            this.listBoxStorage.Location = new System.Drawing.Point(8, 6);
            this.listBoxStorage.Name = "listBoxStorage";
            this.listBoxStorage.Size = new System.Drawing.Size(256, 400);
            this.listBoxStorage.TabIndex = 1;
            this.listBoxStorage.SelectedIndexChanged += new System.EventHandler(this.listBoxStorage_SelectedIndexChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // buttonNewProduct
            // 
            this.buttonNewProduct.Enabled = false;
            this.buttonNewProduct.Location = new System.Drawing.Point(286, 328);
            this.buttonNewProduct.Name = "buttonNewProduct";
            this.buttonNewProduct.Size = new System.Drawing.Size(105, 43);
            this.buttonNewProduct.TabIndex = 24;
            this.buttonNewProduct.Text = "Ny Produkt";
            this.buttonNewProduct.UseVisualStyleBackColor = true;
            this.buttonNewProduct.Click += new System.EventHandler(this.buttonNewProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.tabStore.ResumeLayout(false);
            this.tabStore.PerformLayout();
            this.tabStorage.ResumeLayout(false);
            this.tabStorage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOfProducts;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabStore;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabStorage;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonStoreProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxStorage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxGametime;
        private System.Windows.Forms.TextBox textBoxLanguage;
        private System.Windows.Forms.TextBox textBoxPlatform;
        private System.Windows.Forms.TextBox textBoxFormat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button buttonNewProduct;
    }
}

