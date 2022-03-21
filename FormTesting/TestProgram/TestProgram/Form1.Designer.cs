
namespace TestProgram
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
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ProgramDescriptionLabel = new System.Windows.Forms.Label();
            this.DollarText = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.USDAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(42, 181);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(119, 46);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Konvertera";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ProgramDescriptionLabel
            // 
            this.ProgramDescriptionLabel.AutoSize = true;
            this.ProgramDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProgramDescriptionLabel.Location = new System.Drawing.Point(42, 45);
            this.ProgramDescriptionLabel.Name = "ProgramDescriptionLabel";
            this.ProgramDescriptionLabel.Size = new System.Drawing.Size(220, 17);
            this.ProgramDescriptionLabel.TabIndex = 1;
            this.ProgramDescriptionLabel.Text = "This program converts USD to SEK";
            // 
            // DollarText
            // 
            this.DollarText.Location = new System.Drawing.Point(138, 86);
            this.DollarText.Name = "DollarText";
            this.DollarText.Size = new System.Drawing.Size(100, 23);
            this.DollarText.TabIndex = 2;
            this.DollarText.TextChanged += new System.EventHandler(this.DollarText_TextChanged);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.Location = new System.Drawing.Point(42, 138);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(50, 17);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Result:";
            // 
            // USDAmountLabel
            // 
            this.USDAmountLabel.AutoSize = true;
            this.USDAmountLabel.Location = new System.Drawing.Point(42, 89);
            this.USDAmountLabel.Name = "USDAmountLabel";
            this.USDAmountLabel.Size = new System.Drawing.Size(90, 15);
            this.USDAmountLabel.TabIndex = 4;
            this.USDAmountLabel.Text = "Amount of USD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 264);
            this.Controls.Add(this.USDAmountLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.DollarText);
            this.Controls.Add(this.ProgramDescriptionLabel);
            this.Controls.Add(this.ConvertButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label ProgramDescriptionLabel;
        private System.Windows.Forms.TextBox DollarText;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label USDAmountLabel;
    }
}

