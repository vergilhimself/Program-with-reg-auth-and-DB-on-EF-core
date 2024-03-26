namespace lab4WinForms
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
            UsernameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            PasswordTextBox = new TextBox();
            RegisterButton = new Button();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(67, 12);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(100, 23);
            UsernameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(67, 41);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(100, 23);
            PasswordTextBox.TabIndex = 2;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(12, 141);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(155, 23);
            RegisterButton.TabIndex = 4;
            RegisterButton.Text = "Зарегестрироваться";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(12, 170);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(155, 23);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(175, 211);
            Controls.Add(LoginButton);
            Controls.Add(RegisterButton);
            Controls.Add(label2);
            Controls.Add(PasswordTextBox);
            Controls.Add(label1);
            Controls.Add(UsernameTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameTextBox;
        private Label label1;
        private Label label2;
        private TextBox PasswordTextBox;
        private Button RegisterButton;
        private Button LoginButton;
    }
}
