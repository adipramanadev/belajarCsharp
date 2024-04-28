namespace studikasusifaja
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
            label3 = new Label();
            txtSkor1 = new TextBox();
            txtSkor2 = new TextBox();
            txtSkor3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            lblPesan = new Label();
            label4 = new Label();
            txtRata = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Skor 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 87);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Skor 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 158);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Skor 3";
            // 
            // txtSkor1
            // 
            txtSkor1.Location = new Point(162, 19);
            txtSkor1.Name = "txtSkor1";
            txtSkor1.Size = new Size(125, 27);
            txtSkor1.TabIndex = 3;
            // 
            // txtSkor2
            // 
            txtSkor2.Location = new Point(162, 80);
            txtSkor2.Name = "txtSkor2";
            txtSkor2.Size = new Size(125, 27);
            txtSkor2.TabIndex = 4;
            // 
            // txtSkor3
            // 
            txtSkor3.Location = new Point(162, 151);
            txtSkor3.Name = "txtSkor3";
            txtSkor3.Size = new Size(125, 27);
            txtSkor3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(371, 19);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 6;
            button1.Text = "Hitung Rata";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(594, 19);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblPesan
            // 
            lblPesan.AutoSize = true;
            lblPesan.Location = new Point(371, 87);
            lblPesan.Name = "lblPesan";
            lblPesan.Size = new Size(0, 20);
            lblPesan.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 211);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 9;
            label4.Text = "Rata rata";
            // 
            // txtRata
            // 
            txtRata.Location = new Point(162, 211);
            txtRata.Name = "txtRata";
            txtRata.ReadOnly = true;
            txtRata.Size = new Size(363, 27);
            txtRata.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRata);
            Controls.Add(label4);
            Controls.Add(lblPesan);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtSkor3);
            Controls.Add(txtSkor2);
            Controls.Add(txtSkor1);
            Controls.Add(label3);
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
        private Label label3;
        private TextBox txtSkor1;
        private TextBox txtSkor2;
        private TextBox txtSkor3;
        private Button button1;
        private Button button2;
        private Label lblPesan;
        private Label label4;
        private TextBox txtRata;
    }
}
