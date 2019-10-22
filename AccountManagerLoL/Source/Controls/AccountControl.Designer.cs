namespace AccountManagerLoL.Source.Controls
{
    partial class AccountControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pb_ranked_elo = new System.Windows.Forms.PictureBox();
            this.lbl_elo = new System.Windows.Forms.Label();
            this.lbl_winrate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ranked_elo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 2);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 83);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(2, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 2);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(301, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 81);
            this.panel4.TabIndex = 3;
            // 
            // pb_icon
            // 
            this.pb_icon.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pb_icon.ErrorImage")));
            this.pb_icon.Image = ((System.Drawing.Image)(resources.GetObject("pb_icon.Image")));
            this.pb_icon.Location = new System.Drawing.Point(8, 8);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(74, 69);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icon.TabIndex = 4;
            this.pb_icon.TabStop = false;
            this.pb_icon.Click += new System.EventHandler(this.on_detail);
            this.pb_icon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.on_mouse_click);
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(3, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(129, 27);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "xTremeNuke";
            this.lbl_name.Click += new System.EventHandler(this.on_detail);
            this.lbl_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.on_mouse_click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbl_name);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(88, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(140, 30);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Click += new System.EventHandler(this.on_detail);
            this.flowLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.on_mouse_click);
            // 
            // pb_ranked_elo
            // 
            this.pb_ranked_elo.Location = new System.Drawing.Point(89, 43);
            this.pb_ranked_elo.Name = "pb_ranked_elo";
            this.pb_ranked_elo.Size = new System.Drawing.Size(35, 35);
            this.pb_ranked_elo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ranked_elo.TabIndex = 8;
            this.pb_ranked_elo.TabStop = false;
            this.pb_ranked_elo.Click += new System.EventHandler(this.on_detail);
            this.pb_ranked_elo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.on_mouse_click);
            // 
            // lbl_elo
            // 
            this.lbl_elo.AutoSize = true;
            this.lbl_elo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_elo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_elo.Location = new System.Drawing.Point(127, 51);
            this.lbl_elo.Name = "lbl_elo";
            this.lbl_elo.Size = new System.Drawing.Size(0, 21);
            this.lbl_elo.TabIndex = 9;
            this.lbl_elo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.on_mouse_click);
            // 
            // lbl_winrate
            // 
            this.lbl_winrate.AutoSize = true;
            this.lbl_winrate.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winrate.Location = new System.Drawing.Point(243, 32);
            this.lbl_winrate.Name = "lbl_winrate";
            this.lbl_winrate.Size = new System.Drawing.Size(0, 21);
            this.lbl_winrate.TabIndex = 10;
            this.lbl_winrate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.on_mouse_click);
            // 
            // AccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Controls.Add(this.lbl_winrate);
            this.Controls.Add(this.lbl_elo);
            this.Controls.Add(this.pb_ranked_elo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pb_icon);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "AccountControl";
            this.Size = new System.Drawing.Size(303, 85);
            this.Load += new System.EventHandler(this.on_load);
            this.SizeChanged += new System.EventHandler(this.on_size_changed);
            this.Click += new System.EventHandler(this.on_detail);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.on_mouse_click);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ranked_elo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pb_ranked_elo;
        private System.Windows.Forms.Label lbl_elo;
        private System.Windows.Forms.Label lbl_winrate;
    }
}
