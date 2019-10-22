namespace AccountManagerLoL.Forms
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_apikey = new System.Windows.Forms.TextBox();
            this.btn_test_key = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_test_user = new System.Windows.Forms.Button();
            this.tb_user_x = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_user_y = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_pw_y = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_test_pw = new System.Windows.Forms.Button();
            this.tb_pw_x = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "API-Key";
            // 
            // tb_apikey
            // 
            this.tb_apikey.BackColor = System.Drawing.Color.White;
            this.tb_apikey.Location = new System.Drawing.Point(93, 18);
            this.tb_apikey.Name = "tb_apikey";
            this.tb_apikey.Size = new System.Drawing.Size(405, 28);
            this.tb_apikey.TabIndex = 1;
            // 
            // btn_test_key
            // 
            this.btn_test_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btn_test_key.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_test_key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_test_key.ForeColor = System.Drawing.Color.White;
            this.btn_test_key.Location = new System.Drawing.Point(518, 18);
            this.btn_test_key.Name = "btn_test_key";
            this.btn_test_key.Size = new System.Drawing.Size(63, 29);
            this.btn_test_key.TabIndex = 2;
            this.btn_test_key.Text = "Test";
            this.btn_test_key.UseVisualStyleBackColor = false;
            this.btn_test_key.Click += new System.EventHandler(this.Btn_test_key_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(451, 164);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(130, 46);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // btn_test_user
            // 
            this.btn_test_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btn_test_user.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_test_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_test_user.ForeColor = System.Drawing.Color.White;
            this.btn_test_user.Location = new System.Drawing.Point(518, 61);
            this.btn_test_user.Name = "btn_test_user";
            this.btn_test_user.Size = new System.Drawing.Size(62, 29);
            this.btn_test_user.TabIndex = 6;
            this.btn_test_user.Text = "Test";
            this.btn_test_user.UseVisualStyleBackColor = false;
            this.btn_test_user.Click += new System.EventHandler(this.Btn_test_user_Click);
            // 
            // tb_user_x
            // 
            this.tb_user_x.BackColor = System.Drawing.Color.White;
            this.tb_user_x.Location = new System.Drawing.Point(290, 61);
            this.tb_user_x.Name = "tb_user_x";
            this.tb_user_x.Size = new System.Drawing.Size(57, 28);
            this.tb_user_x.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Koordinaten Benutzer Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y";
            // 
            // tb_user_y
            // 
            this.tb_user_y.BackColor = System.Drawing.Color.White;
            this.tb_user_y.Location = new System.Drawing.Point(441, 61);
            this.tb_user_y.Name = "tb_user_y";
            this.tb_user_y.Size = new System.Drawing.Size(57, 28);
            this.tb_user_y.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Y";
            // 
            // tb_pw_y
            // 
            this.tb_pw_y.BackColor = System.Drawing.Color.White;
            this.tb_pw_y.Location = new System.Drawing.Point(441, 99);
            this.tb_pw_y.Name = "tb_pw_y";
            this.tb_pw_y.Size = new System.Drawing.Size(57, 28);
            this.tb_pw_y.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "X";
            // 
            // btn_test_pw
            // 
            this.btn_test_pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.btn_test_pw.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_test_pw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_test_pw.ForeColor = System.Drawing.Color.White;
            this.btn_test_pw.Location = new System.Drawing.Point(518, 99);
            this.btn_test_pw.Name = "btn_test_pw";
            this.btn_test_pw.Size = new System.Drawing.Size(62, 29);
            this.btn_test_pw.TabIndex = 12;
            this.btn_test_pw.Text = "Test";
            this.btn_test_pw.UseVisualStyleBackColor = false;
            this.btn_test_pw.Click += new System.EventHandler(this.Btn_test_pw_Click);
            // 
            // tb_pw_x
            // 
            this.tb_pw_x.BackColor = System.Drawing.Color.White;
            this.tb_pw_x.Location = new System.Drawing.Point(290, 99);
            this.tb_pw_x.Name = "tb_pw_x";
            this.tb_pw_x.Size = new System.Drawing.Size(57, 28);
            this.tb_pw_x.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Koordinaten Passwort Input";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 146);
            this.label8.MaximumSize = new System.Drawing.Size(400, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(400, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bei \"Test\" sollten die Mauskoordinaten des Textfeldes direkt über dem Input von B" +
    "enutzer bzw. Passwort liegen";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 222);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_pw_y);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_test_pw);
            this.Controls.Add(this.tb_pw_x);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_user_y);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_test_user);
            this.Controls.Add(this.tb_user_x);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_test_key);
            this.Controls.Add(this.tb_apikey);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfigForm";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_apikey;
        private System.Windows.Forms.Button btn_test_key;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_test_user;
        private System.Windows.Forms.TextBox tb_user_x;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_user_y;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_pw_y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_test_pw;
        private System.Windows.Forms.TextBox tb_pw_x;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}