namespace WinFormsToDoApp
{
    partial class LoginForm
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
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            usernameTextBox = new System.Windows.Forms.TextBox();
            passwordTextBox = new System.Windows.Forms.TextBox();
            loginButton = new System.Windows.Forms.Button();
            loginLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            loginLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            usernameLabel.Location = new System.Drawing.Point(33, 30);
            usernameLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(110, 28);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Přihlašovací jméno:";
            usernameLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            passwordLabel.Location = new System.Drawing.Point(33, 66);
            passwordLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            passwordLabel.Size = new System.Drawing.Size(110, 26);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Heslo:";
            passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            usernameTextBox.Location = new System.Drawing.Point(149, 40);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new System.Drawing.Size(206, 23);
            usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            passwordTextBox.Location = new System.Drawing.Point(149, 69);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new System.Drawing.Size(206, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            loginButton.Location = new System.Drawing.Point(117, 18);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(150, 30);
            loginButton.TabIndex = 10;
            loginButton.Text = "Přihlásit se";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // loginLayoutPanel
            // 
            loginLayoutPanel.AutoSize = true;
            loginLayoutPanel.ColumnCount = 2;
            loginLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            loginLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            loginLayoutPanel.Controls.Add(usernameLabel, 0, 0);
            loginLayoutPanel.Controls.Add(passwordLabel, 0, 1);
            loginLayoutPanel.Controls.Add(passwordTextBox, 1, 1);
            loginLayoutPanel.Controls.Add(usernameTextBox, 1, 0);
            loginLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            loginLayoutPanel.Location = new System.Drawing.Point(0, 0);
            loginLayoutPanel.Name = "loginLayoutPanel";
            loginLayoutPanel.Padding = new System.Windows.Forms.Padding(30, 30, 30, 0);
            loginLayoutPanel.RowCount = 2;
            loginLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            loginLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            loginLayoutPanel.Size = new System.Drawing.Size(384, 95);
            loginLayoutPanel.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(loginButton, 1, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 95);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(384, 71);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(384, 166);
            Controls.Add(loginLayoutPanel);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Text = "LoginForm";
            loginLayoutPanel.ResumeLayout(false);
            loginLayoutPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TableLayoutPanel loginLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}