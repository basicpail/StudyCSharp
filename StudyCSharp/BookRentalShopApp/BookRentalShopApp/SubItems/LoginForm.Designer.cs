namespace BookRentalShopApp.NewFolder1
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtUserID = new MetroFramework.Controls.MetroTextBox();
            this.TxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.BtnOk = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(144, 133);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 23);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(133, 187);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 23);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "PASSWORD :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtUserID
            // 
            // 
            // 
            // 
            this.TxtUserID.CustomButton.Image = null;
            this.TxtUserID.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.TxtUserID.CustomButton.Name = "";
            this.TxtUserID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtUserID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUserID.CustomButton.TabIndex = 1;
            this.TxtUserID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUserID.CustomButton.UseSelectable = true;
            this.TxtUserID.CustomButton.Visible = false;
            this.TxtUserID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtUserID.Lines = new string[0];
            this.TxtUserID.Location = new System.Drawing.Point(255, 133);
            this.TxtUserID.MaxLength = 12;
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.PasswordChar = '\0';
            this.TxtUserID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUserID.SelectedText = "";
            this.TxtUserID.SelectionLength = 0;
            this.TxtUserID.SelectionStart = 0;
            this.TxtUserID.ShortcutsEnabled = true;
            this.TxtUserID.Size = new System.Drawing.Size(195, 25);
            this.TxtUserID.TabIndex = 0;
            this.TxtUserID.UseSelectable = true;
            this.TxtUserID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUserID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserID_KeyPress);
            // 
            // TxtPassword
            // 
            // 
            // 
            // 
            this.TxtPassword.CustomButton.Image = null;
            this.TxtPassword.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.TxtPassword.CustomButton.Name = "";
            this.TxtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPassword.CustomButton.TabIndex = 1;
            this.TxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPassword.CustomButton.UseSelectable = true;
            this.TxtPassword.CustomButton.Visible = false;
            this.TxtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtPassword.Lines = new string[0];
            this.TxtPassword.Location = new System.Drawing.Point(255, 187);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '●';
            this.TxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.ShortcutsEnabled = true;
            this.TxtPassword.Size = new System.Drawing.Size(195, 25);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.UseSelectable = true;
            this.TxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // BtnCancel
            // 
            this.BtnCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnCancel.Location = new System.Drawing.Point(334, 249);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(116, 36);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseSelectable = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnOk.Location = new System.Drawing.Point(212, 249);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(116, 36);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseSelectable = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 378);
            this.ControlBox = false;
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserID);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtUserID;
        private MetroFramework.Controls.MetroTextBox TxtPassword;
        private MetroFramework.Controls.MetroButton BtnCancel;
        private MetroFramework.Controls.MetroButton BtnOk;
    }
}