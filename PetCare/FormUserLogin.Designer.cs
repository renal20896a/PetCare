namespace PetCare
{
    partial class FormUserLogin
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
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Signup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Back = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Logo.Image = global::PetCare.Properties.Resources.petcare;
            this.pictureBox_Logo.Location = new System.Drawing.Point(70, 12);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(165, 120);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 1;
            this.pictureBox_Logo.TabStop = false;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.BackColor = System.Drawing.Color.Transparent;
            this.label_ID.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(108, 157);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(28, 18);
            this.label_ID.TabIndex = 2;
            this.label_ID.Text = "ID :";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.Transparent;
            this.label_Password.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(63, 192);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(73, 18);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Password :";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(142, 157);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID.TabIndex = 4;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(142, 192);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 20);
            this.textBox_Password.TabIndex = 5;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.Transparent;
            this.button_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(115, 228);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 6;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            // 
            // button_Signup
            // 
            this.button_Signup.BackColor = System.Drawing.Color.Transparent;
            this.button_Signup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button_Signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Signup.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Signup.Location = new System.Drawing.Point(115, 286);
            this.button_Signup.Name = "button_Signup";
            this.button_Signup.Size = new System.Drawing.Size(75, 23);
            this.button_Signup.TabIndex = 7;
            this.button_Signup.Text = "Sign Up";
            this.button_Signup.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Or";
            // 
            // label_Back
            // 
            this.label_Back.AutoSize = true;
            this.label_Back.BackColor = System.Drawing.Color.Transparent;
            this.label_Back.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Back.Location = new System.Drawing.Point(12, 12);
            this.label_Back.Name = "label_Back";
            this.label_Back.Size = new System.Drawing.Size(24, 28);
            this.label_Back.TabIndex = 14;
            this.label_Back.Text = "<";
            this.label_Back.Click += new System.EventHandler(this.Label_Back_Click);
            // 
            // FormUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PetCare.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(304, 321);
            this.Controls.Add(this.label_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Signup);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.pictureBox_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(320, 360);
            this.MinimumSize = new System.Drawing.Size(320, 360);
            this.Name = "FormUserLogin";
            this.Text = "UserLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Back;
    }
}