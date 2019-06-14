namespace AccountManager
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_accounts = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label_user = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_open_client = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_accounts);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 442);
            this.panel1.TabIndex = 0;
            // 
            // panel_accounts
            // 
            this.panel_accounts.AutoScroll = true;
            this.panel_accounts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_accounts.Location = new System.Drawing.Point(0, 69);
            this.panel_accounts.Name = "panel_accounts";
            this.panel_accounts.Size = new System.Drawing.Size(260, 355);
            this.panel_accounts.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 424);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(260, 18);
            this.panel8.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Deine Accounts";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 2);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(260, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 442);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.panel4.Controls.Add(this.btn_close);
            this.panel4.Controls.Add(this.label_user);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(270, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(404, 46);
            this.panel4.TabIndex = 2;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(359, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 36);
            this.btn_close.TabIndex = 4;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_click);
            // 
            // label_user
            // 
            this.label_user.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_user.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.ForeColor = System.Drawing.Color.White;
            this.label_user.Location = new System.Drawing.Point(196, 11);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(157, 22);
            this.label_user.TabIndex = 3;
            this.label_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(34, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(179, 1);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.tb_password);
            this.panel6.Controls.Add(this.tb_username);
            this.panel6.Controls.Add(this.btn_add);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(292, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 183);
            this.panel6.TabIndex = 4;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.Color.DarkGray;
            this.tb_password.Location = new System.Drawing.Point(34, 78);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(179, 20);
            this.tb_password.TabIndex = 7;
            this.tb_password.Text = "Password";
            this.tb_password.Enter += new System.EventHandler(this.on_focus);
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.DarkGray;
            this.tb_username.Location = new System.Drawing.Point(34, 23);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(179, 20);
            this.tb_username.TabIndex = 6;
            this.tb_username.Text = "Username";
            this.tb_username.Enter += new System.EventHandler(this.on_focus);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(165)))), ((int)(((byte)(137)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(34, 131);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(137, 36);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Hinzufügen";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(34, 104);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(179, 1);
            this.panel7.TabIndex = 4;
            // 
            // btn_open_client
            // 
            this.btn_open_client.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_open_client.BackgroundImage")));
            this.btn_open_client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_open_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open_client.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_client.ForeColor = System.Drawing.Color.White;
            this.btn_open_client.Location = new System.Drawing.Point(568, 350);
            this.btn_open_client.Name = "btn_open_client";
            this.btn_open_client.Size = new System.Drawing.Size(85, 74);
            this.btn_open_client.TabIndex = 5;
            this.btn_open_client.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_open_client.UseVisualStyleBackColor = true;
            this.btn_open_client.Click += new System.EventHandler(this.Btn_open_client_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(674, 442);
            this.Controls.Add(this.btn_open_client);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountManager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_accounts;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_open_client;
    }
}

