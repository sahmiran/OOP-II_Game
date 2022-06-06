namespace OOP_II_Game
{
    partial class UserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userExitButton = new System.Windows.Forms.Button();
            this.userProfileButton = new System.Windows.Forms.Button();
            this.userSettingsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userExitButton);
            this.panel1.Controls.Add(this.userProfileButton);
            this.panel1.Controls.Add(this.userSettingsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(666, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 450);
            this.panel1.TabIndex = 0;
            // 
            // userExitButton
            // 
            this.userExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userExitButton.Location = new System.Drawing.Point(0, 427);
            this.userExitButton.Name = "userExitButton";
            this.userExitButton.Size = new System.Drawing.Size(134, 23);
            this.userExitButton.TabIndex = 2;
            this.userExitButton.Text = "Exit";
            this.userExitButton.UseVisualStyleBackColor = true;
            this.userExitButton.Click += new System.EventHandler(this.userExitButton_Click);
            // 
            // userProfileButton
            // 
            this.userProfileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userProfileButton.Location = new System.Drawing.Point(0, 23);
            this.userProfileButton.Name = "userProfileButton";
            this.userProfileButton.Size = new System.Drawing.Size(134, 23);
            this.userProfileButton.TabIndex = 1;
            this.userProfileButton.Text = "Profile";
            this.userProfileButton.UseVisualStyleBackColor = true;
            // 
            // userSettingsButton
            // 
            this.userSettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userSettingsButton.Location = new System.Drawing.Point(0, 0);
            this.userSettingsButton.Name = "userSettingsButton";
            this.userSettingsButton.Size = new System.Drawing.Size(134, 23);
            this.userSettingsButton.TabIndex = 0;
            this.userSettingsButton.Text = "Settings";
            this.userSettingsButton.UseVisualStyleBackColor = true;
            this.userSettingsButton.Click += new System.EventHandler(this.userSettingsButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button userExitButton;
        private System.Windows.Forms.Button userProfileButton;
        private System.Windows.Forms.Button userSettingsButton;
    }
}