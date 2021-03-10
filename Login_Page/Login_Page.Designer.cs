namespace Login_Page
{
    partial class Login_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_Icons = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.text_user_name = new System.Windows.Forms.TextBox();
            this.text_paswrd = new System.Windows.Forms.TextBox();
            this.pnl_signUp = new System.Windows.Forms.Panel();
            this.btn_register_user = new System.Windows.Forms.Button();
            this.btn_signUp_back = new System.Windows.Forms.Button();
            this.text_signUp_paswrd = new System.Windows.Forms.TextBox();
            this.text_signUP_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Sign_up = new System.Windows.Forms.Button();
            this.btn_Forget = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_signUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(812, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(812, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Login_Icons
            // 
            this.Login_Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Login_Icons.ImageStream")));
            this.Login_Icons.TransparentColor = System.Drawing.Color.SteelBlue;
            this.Login_Icons.Images.SetKeyName(0, "sign-out-option.png");
            this.Login_Icons.Images.SetKeyName(1, "user (2).png");
            this.Login_Icons.Images.SetKeyName(2, "user (3).png");
            this.Login_Icons.Images.SetKeyName(3, "thumb-up-sign (1).png");
            this.Login_Icons.Images.SetKeyName(4, "visibility.png");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(752, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 73);
            this.label1.TabIndex = 14;
            this.label1.Text = "LOGIN";
            // 
            // text_user_name
            // 
            this.text_user_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text_user_name.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_user_name.Location = new System.Drawing.Point(755, 284);
            this.text_user_name.Margin = new System.Windows.Forms.Padding(4);
            this.text_user_name.Name = "text_user_name";
            this.text_user_name.Size = new System.Drawing.Size(244, 24);
            this.text_user_name.TabIndex = 23;
            // 
            // text_paswrd
            // 
            this.text_paswrd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text_paswrd.Location = new System.Drawing.Point(755, 366);
            this.text_paswrd.Margin = new System.Windows.Forms.Padding(4);
            this.text_paswrd.Name = "text_paswrd";
            this.text_paswrd.Size = new System.Drawing.Size(244, 22);
            this.text_paswrd.TabIndex = 24;
            this.text_paswrd.UseSystemPasswordChar = true;
            // 
            // pnl_signUp
            // 
            this.pnl_signUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnl_signUp.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnl_signUp.Controls.Add(this.btn_register_user);
            this.pnl_signUp.Controls.Add(this.btn_signUp_back);
            this.pnl_signUp.Controls.Add(this.text_signUp_paswrd);
            this.pnl_signUp.Controls.Add(this.text_signUP_username);
            this.pnl_signUp.Controls.Add(this.label4);
            this.pnl_signUp.Controls.Add(this.label5);
            this.pnl_signUp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pnl_signUp.Location = new System.Drawing.Point(683, 231);
            this.pnl_signUp.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_signUp.Name = "pnl_signUp";
            this.pnl_signUp.Size = new System.Drawing.Size(353, 210);
            this.pnl_signUp.TabIndex = 25;
            this.pnl_signUp.Visible = false;
            // 
            // btn_register_user
            // 
            this.btn_register_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_register_user.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_register_user.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register_user.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_register_user.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_register_user.ImageIndex = 3;
            this.btn_register_user.ImageList = this.Login_Icons;
            this.btn_register_user.Location = new System.Drawing.Point(19, 241);
            this.btn_register_user.Margin = new System.Windows.Forms.Padding(4);
            this.btn_register_user.MaximumSize = new System.Drawing.Size(123, 34);
            this.btn_register_user.MinimumSize = new System.Drawing.Size(133, 34);
            this.btn_register_user.Name = "btn_register_user";
            this.btn_register_user.Size = new System.Drawing.Size(133, 34);
            this.btn_register_user.TabIndex = 30;
            this.btn_register_user.Text = "REGIS&TER";
            this.btn_register_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_register_user.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_register_user.UseVisualStyleBackColor = false;
            this.btn_register_user.Click += new System.EventHandler(this.btn_register_user_Click);
            // 
            // btn_signUp_back
            // 
            this.btn_signUp_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_signUp_back.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_signUp_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signUp_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_signUp_back.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_signUp_back.ImageIndex = 0;
            this.btn_signUp_back.ImageList = this.Login_Icons;
            this.btn_signUp_back.Location = new System.Drawing.Point(235, 242);
            this.btn_signUp_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_signUp_back.MaximumSize = new System.Drawing.Size(123, 34);
            this.btn_signUp_back.MinimumSize = new System.Drawing.Size(133, 34);
            this.btn_signUp_back.Name = "btn_signUp_back";
            this.btn_signUp_back.Size = new System.Drawing.Size(133, 34);
            this.btn_signUp_back.TabIndex = 29;
            this.btn_signUp_back.Text = "BAC&K";
            this.btn_signUp_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_signUp_back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_signUp_back.UseVisualStyleBackColor = false;
            this.btn_signUp_back.Click += new System.EventHandler(this.btn_signUp_back_Click);
            // 
            // text_signUp_paswrd
            // 
            this.text_signUp_paswrd.Location = new System.Drawing.Point(79, 124);
            this.text_signUp_paswrd.Margin = new System.Windows.Forms.Padding(4);
            this.text_signUp_paswrd.Name = "text_signUp_paswrd";
            this.text_signUp_paswrd.Size = new System.Drawing.Size(244, 22);
            this.text_signUp_paswrd.TabIndex = 28;
            this.text_signUp_paswrd.UseSystemPasswordChar = true;
            // 
            // text_signUP_username
            // 
            this.text_signUP_username.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_signUP_username.Location = new System.Drawing.Point(79, 42);
            this.text_signUP_username.Margin = new System.Windows.Forms.Padding(4);
            this.text_signUP_username.Name = "text_signUP_username";
            this.text_signUP_username.Size = new System.Drawing.Size(244, 24);
            this.text_signUP_username.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(120, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(120, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "User Name";
            // 
            // btn_Sign_up
            // 
            this.btn_Sign_up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Sign_up.BackColor = System.Drawing.Color.Crimson;
            this.btn_Sign_up.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sign_up.ForeColor = System.Drawing.Color.White;
            this.btn_Sign_up.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sign_up.ImageIndex = 3;
            this.btn_Sign_up.ImageList = this.Login_Icons;
            this.btn_Sign_up.Location = new System.Drawing.Point(503, 484);
            this.btn_Sign_up.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sign_up.MaximumSize = new System.Drawing.Size(123, 34);
            this.btn_Sign_up.MinimumSize = new System.Drawing.Size(133, 34);
            this.btn_Sign_up.Name = "btn_Sign_up";
            this.btn_Sign_up.Size = new System.Drawing.Size(133, 34);
            this.btn_Sign_up.TabIndex = 22;
            this.btn_Sign_up.Text = "SIG&N UP";
            this.btn_Sign_up.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sign_up.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Sign_up.UseVisualStyleBackColor = false;
            this.btn_Sign_up.Click += new System.EventHandler(this.btn_Sign_up_Click);
            // 
            // btn_Forget
            // 
            this.btn_Forget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Forget.BackColor = System.Drawing.Color.Crimson;
            this.btn_Forget.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Forget.ForeColor = System.Drawing.Color.White;
            this.btn_Forget.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Forget.ImageIndex = 4;
            this.btn_Forget.ImageList = this.Login_Icons;
            this.btn_Forget.Location = new System.Drawing.Point(716, 484);
            this.btn_Forget.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Forget.MaximumSize = new System.Drawing.Size(123, 34);
            this.btn_Forget.MinimumSize = new System.Drawing.Size(133, 34);
            this.btn_Forget.Name = "btn_Forget";
            this.btn_Forget.Size = new System.Drawing.Size(133, 34);
            this.btn_Forget.TabIndex = 21;
            this.btn_Forget.Text = "FORGET";
            this.btn_Forget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Forget.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Forget.UseVisualStyleBackColor = false;
            this.btn_Forget.Click += new System.EventHandler(this.btn_Forget_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImageIndex = 2;
            this.button2.ImageList = this.Login_Icons;
            this.button2.Location = new System.Drawing.Point(926, 485);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.MaximumSize = new System.Drawing.Size(123, 34);
            this.button2.MinimumSize = new System.Drawing.Size(133, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "LO&GIN";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Exit.BackColor = System.Drawing.Color.Crimson;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.ImageIndex = 0;
            this.Exit.ImageList = this.Login_Icons;
            this.Exit.Location = new System.Drawing.Point(1146, 485);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.MaximumSize = new System.Drawing.Size(123, 33);
            this.Exit.MinimumSize = new System.Drawing.Size(133, 33);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(133, 33);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(1, 779);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(363, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "© 2020Abriansoft All Rights Reserved";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1827, 919);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnl_signUp);
            this.Controls.Add(this.text_paswrd);
            this.Controls.Add(this.text_user_name);
            this.Controls.Add(this.btn_Sign_up);
            this.Controls.Add(this.btn_Forget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login_Form";
            this.Text = "Login Window";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.pnl_signUp.ResumeLayout(false);
            this.pnl_signUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList Login_Icons;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Forget;
        private System.Windows.Forms.Button btn_Sign_up;
        private System.Windows.Forms.TextBox text_user_name;
        private System.Windows.Forms.TextBox text_paswrd;
        private System.Windows.Forms.Panel pnl_signUp;
        private System.Windows.Forms.TextBox text_signUp_paswrd;
        private System.Windows.Forms.TextBox text_signUP_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_register_user;
        private System.Windows.Forms.Button btn_signUp_back;
        private System.Windows.Forms.Label label6;
    }
}

