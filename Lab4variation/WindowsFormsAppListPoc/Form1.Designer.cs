
namespace WindowsFormsAppListPoc
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
            this.listStorageBox = new System.Windows.Forms.ListBox();
            this.listShopBox = new System.Windows.Forms.ListBox();
            this.listBasketBox = new System.Windows.Forms.ListBox();
            this.btnAddToBasket = new System.Windows.Forms.Button();
            this.btRemoveFromBasket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listStorageBox
            // 
            this.listStorageBox.FormattingEnabled = true;
            this.listStorageBox.Location = new System.Drawing.Point(40, 38);
            this.listStorageBox.Name = "listStorageBox";
            this.listStorageBox.Size = new System.Drawing.Size(217, 342);
            this.listStorageBox.TabIndex = 0;
            this.listStorageBox.SelectedIndexChanged += new System.EventHandler(this.listStorageBox_SelectedIndexChanged);
            // 
            // listShopBox
            // 
            this.listShopBox.FormattingEnabled = true;
            this.listShopBox.Location = new System.Drawing.Point(339, 38);
            this.listShopBox.Name = "listShopBox";
            this.listShopBox.Size = new System.Drawing.Size(154, 238);
            this.listShopBox.TabIndex = 1;
            this.listShopBox.SelectedIndexChanged += new System.EventHandler(this.listShopBox_SelectedIndexChanged);
            // 
            // listBasketBox
            // 
            this.listBasketBox.FormattingEnabled = true;
            this.listBasketBox.Location = new System.Drawing.Point(635, 38);
            this.listBasketBox.Name = "listBasketBox";
            this.listBasketBox.Size = new System.Drawing.Size(120, 238);
            this.listBasketBox.TabIndex = 2;
            this.listBasketBox.SelectedIndexChanged += new System.EventHandler(this.listBasketBox_SelectedIndexChanged);
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.Location = new System.Drawing.Point(519, 38);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(75, 23);
            this.btnAddToBasket.TabIndex = 3;
            this.btnAddToBasket.Text = ">>";
            this.btnAddToBasket.UseVisualStyleBackColor = true;
            this.btnAddToBasket.Click += new System.EventHandler(this.btnAddToBasket_Click);
            // 
            // btRemoveFromBasket
            // 
            this.btRemoveFromBasket.Location = new System.Drawing.Point(519, 91);
            this.btRemoveFromBasket.Name = "btRemoveFromBasket";
            this.btRemoveFromBasket.Size = new System.Drawing.Size(75, 23);
            this.btRemoveFromBasket.TabIndex = 4;
            this.btRemoveFromBasket.Text = "<<";
            this.btRemoveFromBasket.UseVisualStyleBackColor = true;
            this.btRemoveFromBasket.Click += new System.EventHandler(this.btRemoveFromBasket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Varor i butik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Shopping korg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemoveFromBasket);
            this.Controls.Add(this.btnAddToBasket);
            this.Controls.Add(this.listBasketBox);
            this.Controls.Add(this.listShopBox);
            this.Controls.Add(this.listStorageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listStorageBox;
        private System.Windows.Forms.ListBox listShopBox;
        private System.Windows.Forms.ListBox listBasketBox;
        private System.Windows.Forms.Button btnAddToBasket;
        private System.Windows.Forms.Button btRemoveFromBasket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

