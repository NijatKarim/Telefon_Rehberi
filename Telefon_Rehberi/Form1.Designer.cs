namespace Telefon_Rehberi
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtname = new TextBox();
            btnadd = new Button();
            btnedit = new Button();
            btnremove = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(12, 116);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(491, 466);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 58);
            label1.Name = "label1";
            label1.Size = new Size(160, 22);
            label1.TabIndex = 1;
            label1.Text = "Telefon Rehberi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(759, 41);
            label2.Name = "label2";
            label2.Size = new Size(150, 22);
            label2.TabIndex = 2;
            label2.Text = "Isim ve numara";
            // 
            // txtname
            // 
            txtname.Location = new Point(679, 79);
            txtname.Name = "txtname";
            txtname.Size = new Size(311, 30);
            txtname.TabIndex = 3;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(759, 144);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(134, 37);
            btnadd.TabIndex = 4;
            btnadd.Text = "Ekle";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(759, 201);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(134, 37);
            btnedit.TabIndex = 4;
            btnedit.Text = "Düzenle";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btnremove
            // 
            btnremove.Location = new Point(759, 255);
            btnremove.Name = "btnremove";
            btnremove.Size = new Size(134, 35);
            btnremove.TabIndex = 4;
            btnremove.Text = "Sil";
            btnremove.UseVisualStyleBackColor = true;
            btnremove.Click += btnremove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 660);
            Controls.Add(btnremove);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(txtname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private TextBox txtname;
        private Button btnadd;
        private Button btnedit;
        private Button btnremove;
    }
}