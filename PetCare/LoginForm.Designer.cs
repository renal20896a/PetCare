namespace PetCare
{
    partial class Form_Login
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
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.button_Admin_Login = new System.Windows.Forms.Button();
            this.button_User_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Logo.Image = global::PetCare.Properties.Resources.petcare;
            this.pictureBox_Logo.Location = new System.Drawing.Point(93, 68);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(227, 175);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // button_Admin_Login
            // 
            this.button_Admin_Login.BackColor = System.Drawing.Color.Transparent;
            this.button_Admin_Login.FlatAppearance.BorderSize = 0;
            this.button_Admin_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button_Admin_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Admin_Login.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Admin_Login.Image = global::PetCare.Properties.Resources.administrator_2_64;
            this.button_Admin_Login.Location = new System.Drawing.Point(422, 12);
            this.button_Admin_Login.Name = "button_Admin_Login";
            this.button_Admin_Login.Size = new System.Drawing.Size(170, 146);
            this.button_Admin_Login.TabIndex = 1;
            this.button_Admin_Login.Text = "Admin";
            this.button_Admin_Login.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Admin_Login.UseVisualStyleBackColor = false;
            this.button_Admin_Login.Click += new System.EventHandler(this.Button_Admin_Login_Click);
            // 
            // button_User_Login
            // 
            this.button_User_Login.BackColor = System.Drawing.Color.Transparent;
            this.button_User_Login.FlatAppearance.BorderSize = 0;
            this.button_User_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button_User_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_User_Login.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_User_Login.Image = global::PetCare.Properties.Resources.contacts_64;
            this.button_User_Login.Location = new System.Drawing.Point(422, 153);
            this.button_User_Login.Name = "button_User_Login";
            this.button_User_Login.Size = new System.Drawing.Size(170, 146);
            this.button_User_Login.TabIndex = 2;
            this.button_User_Login.Text = "User";
            this.button_User_Login.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_User_Login.UseVisualStyleBackColor = false;
            this.button_User_Login.Click += new System.EventHandler(this.Button_User_Login_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PetCare.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 311);
            this.Controls.Add(this.button_User_Login);
            this.Controls.Add(this.button_Admin_Login);
            this.Controls.Add(this.pictureBox_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(620, 350);
            this.MinimumSize = new System.Drawing.Size(620, 350);
            this.Name = "Form_Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Button button_Admin_Login;
        private System.Windows.Forms.Button button_User_Login;
    }
}

