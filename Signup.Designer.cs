﻿
namespace aru_software_eng_UI
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.RulesCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginGetter = new System.Windows.Forms.TextBox();
            this.RulesText = new System.Windows.Forms.LinkLabel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.EmailGetter = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordGetter1 = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.AgainPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordGetter2 = new System.Windows.Forms.TextBox();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignUpButton
            // 

            this.SignUpButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SignUpButton.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SignUpButton.Location = new System.Drawing.Point(386, 344);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(212, 85);
            this.SignUpButton.TabIndex = 0;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;

            this.SignUpLabel.Font = new System.Drawing.Font("Agency FB", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.Location = new System.Drawing.Point(238, 9);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(1179, 153);
            this.SignUpLabel.TabIndex = 1;
            this.SignUpLabel.Text = "Create an account";
            // 
            // RulesCheckBox
            // 
            this.RulesCheckBox.AutoSize = true;
            this.RulesCheckBox.Location = new System.Drawing.Point(320, 315);
            this.RulesCheckBox.Name = "RulesCheckBox";
            this.RulesCheckBox.Size = new System.Drawing.Size(28, 27);
            this.RulesCheckBox.TabIndex = 2;
            this.RulesCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginGetter
            // 
            this.LoginGetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LoginGetter.Location = new System.Drawing.Point(344, 129);
            this.LoginGetter.Name = "LoginGetter";
            this.LoginGetter.Size = new System.Drawing.Size(266, 38);
            this.LoginGetter.TabIndex = 3;
            // 
            // RulesText
            // 
            this.RulesText.AutoSize = true;
            this.RulesText.Location = new System.Drawing.Point(341, 316);
            this.RulesText.Name = "RulesText";
            this.RulesText.Size = new System.Drawing.Size(243, 13);
            this.RulesText.TabIndex = 4;
            this.RulesText.TabStop = true;
            this.RulesText.Text = "I confirm I have read the rules and privacy policies";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold);
            this.LoginLabel.Location = new System.Drawing.Point(222, 130);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(106, 34);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "Username:";
            // 
            // EmailGetter
            // 
            this.EmailGetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailGetter.Location = new System.Drawing.Point(344, 173);
            this.EmailGetter.Name = "EmailGetter";
            this.EmailGetter.Size = new System.Drawing.Size(266, 38);
            this.EmailGetter.TabIndex = 6;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold);
            this.EmailLabel.Location = new System.Drawing.Point(264, 177);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(64, 34);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "Email:";
            // 
            // PasswordGetter1
            // 
            this.PasswordGetter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordGetter1.Location = new System.Drawing.Point(344, 217);
            this.PasswordGetter1.Name = "PasswordGetter1";
            this.PasswordGetter1.Size = new System.Drawing.Size(266, 38);
            this.PasswordGetter1.TabIndex = 8;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.Location = new System.Drawing.Point(222, 221);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(106, 34);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // AgainPasswordLabel
            // 
            this.AgainPasswordLabel.AutoSize = true;
            this.AgainPasswordLabel.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold);
            this.AgainPasswordLabel.Location = new System.Drawing.Point(170, 266);
            this.AgainPasswordLabel.Name = "AgainPasswordLabel";
            this.AgainPasswordLabel.Size = new System.Drawing.Size(168, 34);
            this.AgainPasswordLabel.TabIndex = 10;
            this.AgainPasswordLabel.Text = "Repeat password:";
            // 
            // PasswordGetter2
            // 
            this.PasswordGetter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordGetter2.Location = new System.Drawing.Point(344, 265);
            this.PasswordGetter2.Name = "PasswordGetter2";
            this.PasswordGetter2.Size = new System.Drawing.Size(266, 38);
            this.PasswordGetter2.TabIndex = 11;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.GoBackButton.Location = new System.Drawing.Point(408, 394);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(116, 54);
            this.GoBackButton.TabIndex = 12;
            this.GoBackButton.Text = "Go back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 887);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.PasswordGetter2);
            this.Controls.Add(this.AgainPasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordGetter1);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailGetter);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.RulesText);
            this.Controls.Add(this.LoginGetter);
            this.Controls.Add(this.RulesCheckBox);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.SignUpButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.CheckBox RulesCheckBox;
        private System.Windows.Forms.TextBox LoginGetter;
        private System.Windows.Forms.LinkLabel RulesText;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox EmailGetter;
        private System.Windows.Forms.TextBox PasswordGetter1;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label AgainPasswordLabel;
        private System.Windows.Forms.TextBox PasswordGetter2;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label EmailLabel;
    }
}