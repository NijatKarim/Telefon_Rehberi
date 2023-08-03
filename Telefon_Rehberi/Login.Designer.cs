namespace Telefon_Rehberi
{
    partial class Login
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 237);
            label1.Name = "label1";
            label1.Size = new Size(120, 22);
            label1.TabIndex = 0;
            label1.Text = "LOGİN FORMU";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.enter;
            pictureBox1.Location = new Point(223, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(349, 325);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(246, 30);
            txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 328);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 3;
            label2.Text = "User Name :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(349, 374);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(246, 30);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 377);
            label3.Name = "label3";
            label3.Size = new Size(110, 22);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(349, 432);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(161, 36);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Enter";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 539);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Login";
            Text = "Telefon Rehberi Uygulaması Giriş";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
    }
}