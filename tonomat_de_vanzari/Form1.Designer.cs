namespace tonomat_de_vanzari
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
            this.Nickel = new System.Windows.Forms.Button();
            this.Dime = new System.Windows.Forms.Button();
            this.Quarter = new System.Windows.Forms.Button();
            this.credit_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nickel
            // 
            this.Nickel.BackColor = System.Drawing.Color.Silver;
            this.Nickel.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nickel.Location = new System.Drawing.Point(50, 327);
            this.Nickel.Name = "Nickel";
            this.Nickel.Size = new System.Drawing.Size(181, 60);
            this.Nickel.TabIndex = 1;
            this.Nickel.Text = "Nickel";
            this.Nickel.UseVisualStyleBackColor = false;
            this.Nickel.Click += new System.EventHandler(this.Nickel_Click);
            // 
            // Dime
            // 
            this.Dime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dime.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dime.Location = new System.Drawing.Point(278, 327);
            this.Dime.Name = "Dime";
            this.Dime.Size = new System.Drawing.Size(221, 60);
            this.Dime.TabIndex = 2;
            this.Dime.Text = "Dime";
            this.Dime.UseVisualStyleBackColor = false;
            this.Dime.Click += new System.EventHandler(this.Dime_Click);
            // 
            // Quarter
            // 
            this.Quarter.BackColor = System.Drawing.Color.Gold;
            this.Quarter.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Quarter.Location = new System.Drawing.Point(546, 327);
            this.Quarter.Name = "Quarter";
            this.Quarter.Size = new System.Drawing.Size(211, 60);
            this.Quarter.TabIndex = 3;
            this.Quarter.Text = "Quarter";
            this.Quarter.UseVisualStyleBackColor = false;
            this.Quarter.Click += new System.EventHandler(this.Quarter_Click);
            // 
            // credit_label
            // 
            this.credit_label.AutoSize = true;
            this.credit_label.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.credit_label.Location = new System.Drawing.Point(325, 288);
            this.credit_label.Name = "credit_label";
            this.credit_label.Size = new System.Drawing.Size(125, 36);
            this.credit_label.TabIndex = 4;
            this.credit_label.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 393);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 27);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.credit_label);
            this.Controls.Add(this.Quarter);
            this.Controls.Add(this.Dime);
            this.Controls.Add(this.Nickel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Nickel;
        private Button Dime;
        private Button Quarter;
        private Label credit_label;
        private TextBox textBox1;
    }
}