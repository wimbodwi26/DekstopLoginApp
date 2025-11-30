namespace WinFormsApp1
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
            Nama = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Nama
            // 
            Nama.AutoSize = true;
            Nama.Location = new Point(35, 31);
            Nama.Name = "Nama";
            Nama.Size = new Size(63, 15);
            Nama.TabIndex = 0;
            Nama.Text = "Username:";
            Nama.Click += label_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(126, 23);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(570, 23);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 66);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(126, 58);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(570, 23);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(126, 108);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 4;
            button1.Text = "Login Button";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 291);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(Nama);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nama;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtPassword;
        private Button button1;
    }
}
