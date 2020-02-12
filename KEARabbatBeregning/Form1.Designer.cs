namespace KEARabbatBeregning
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
            this.labelNoDiscount = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelPriceWithDiscount = new System.Windows.Forms.Label();
            this.textBoxPriceWithoutDiscount = new System.Windows.Forms.TextBox();
            this.textBoxDiscountPercent = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNoDiscount
            // 
            this.labelNoDiscount.AutoSize = true;
            this.labelNoDiscount.Location = new System.Drawing.Point(102, 84);
            this.labelNoDiscount.Name = "labelNoDiscount";
            this.labelNoDiscount.Size = new System.Drawing.Size(228, 25);
            this.labelNoDiscount.TabIndex = 0;
            this.labelNoDiscount.Text = "Price with no discount:";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(102, 184);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(133, 25);
            this.labelDiscount.TabIndex = 1;
            this.labelDiscount.Text = "Discount % :";
            // 
            // labelPriceWithDiscount
            // 
            this.labelPriceWithDiscount.AutoSize = true;
            this.labelPriceWithDiscount.Location = new System.Drawing.Point(102, 387);
            this.labelPriceWithDiscount.Name = "labelPriceWithDiscount";
            this.labelPriceWithDiscount.Size = new System.Drawing.Size(198, 25);
            this.labelPriceWithDiscount.TabIndex = 2;
            this.labelPriceWithDiscount.Text = "Price with discount:";
            // 
            // textBoxPriceWithoutDiscount
            // 
            this.textBoxPriceWithoutDiscount.Location = new System.Drawing.Point(351, 84);
            this.textBoxPriceWithoutDiscount.Name = "textBoxPriceWithoutDiscount";
            this.textBoxPriceWithoutDiscount.Size = new System.Drawing.Size(144, 31);
            this.textBoxPriceWithoutDiscount.TabIndex = 3;
            // 
            // textBoxDiscountPercent
            // 
            this.textBoxDiscountPercent.Location = new System.Drawing.Point(351, 184);
            this.textBoxDiscountPercent.Name = "textBoxDiscountPercent";
            this.textBoxDiscountPercent.Size = new System.Drawing.Size(144, 31);
            this.textBoxDiscountPercent.TabIndex = 4;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(351, 384);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(144, 31);
            this.textBoxResult.TabIndex = 5;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(107, 312);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(388, 43);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate Discount";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(102, 249);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 25);
            this.labelError.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxDiscountPercent);
            this.Controls.Add(this.textBoxPriceWithoutDiscount);
            this.Controls.Add(this.labelPriceWithDiscount);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelNoDiscount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoDiscount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelPriceWithDiscount;
        private System.Windows.Forms.TextBox textBoxPriceWithoutDiscount;
        private System.Windows.Forms.TextBox textBoxDiscountPercent;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelError;
    }
}

