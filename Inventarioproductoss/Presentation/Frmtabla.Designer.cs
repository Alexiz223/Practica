namespace Inventarioproductoss.Presentation
{
    partial class Frmtabla
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Productotxt = new System.Windows.Forms.TextBox();
            this.preciotxt = new System.Windows.Forms.TextBox();
            this.stocktxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // Productotxt
            // 
            this.Productotxt.Location = new System.Drawing.Point(113, 42);
            this.Productotxt.MaxLength = 100;
            this.Productotxt.Name = "Productotxt";
            this.Productotxt.Size = new System.Drawing.Size(416, 22);
            this.Productotxt.TabIndex = 3;
            // 
            // preciotxt
            // 
            this.preciotxt.Location = new System.Drawing.Point(113, 129);
            this.preciotxt.MaxLength = 10;
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(416, 22);
            this.preciotxt.TabIndex = 4;
            // 
            // stocktxt
            // 
            this.stocktxt.Location = new System.Drawing.Point(113, 221);
            this.stocktxt.MaxLength = 30;
            this.stocktxt.Name = "stocktxt";
            this.stocktxt.Size = new System.Drawing.Size(416, 22);
            this.stocktxt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frmtabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stocktxt);
            this.Controls.Add(this.preciotxt);
            this.Controls.Add(this.Productotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmtabla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Productotxt;
        private System.Windows.Forms.TextBox preciotxt;
        private System.Windows.Forms.TextBox stocktxt;
        private System.Windows.Forms.Button button1;
    }
}