namespace mencarinilaimaksimum
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
            label1 = new Label();
            label2 = new Label();
            txtAngkapertama = new TextBox();
            txtAngkaKedua = new TextBox();
            btnCari = new Button();
            txtMaksimal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 44);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Angka pertama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 101);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Angka Kedua";
            // 
            // txtAngkapertama
            // 
            txtAngkapertama.Location = new Point(297, 44);
            txtAngkapertama.Name = "txtAngkapertama";
            txtAngkapertama.Size = new Size(244, 27);
            txtAngkapertama.TabIndex = 2;
            // 
            // txtAngkaKedua
            // 
            txtAngkaKedua.Location = new Point(297, 101);
            txtAngkaKedua.Name = "txtAngkaKedua";
            txtAngkaKedua.Size = new Size(244, 27);
            txtAngkaKedua.TabIndex = 3;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(116, 168);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(425, 29);
            btnCari.TabIndex = 4;
            btnCari.Text = "&Tekan";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // txtMaksimal
            // 
            txtMaksimal.Location = new Point(116, 217);
            txtMaksimal.Name = "txtMaksimal";
            txtMaksimal.ReadOnly = true;
            txtMaksimal.Size = new Size(425, 27);
            txtMaksimal.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMaksimal);
            Controls.Add(btnCari);
            Controls.Add(txtAngkaKedua);
            Controls.Add(txtAngkapertama);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAngkapertama;
        private TextBox txtAngkaKedua;
        private Button btnCari;
        private TextBox txtMaksimal;
    }
}
