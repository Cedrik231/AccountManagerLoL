namespace AccountManagerLoL
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
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.ts_dropdown_datei = new System.Windows.Forms.ToolStripDropDownButton();
            this.accountsImportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsExportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_add_account = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_button_options = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_accounts = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_detail = new System.Windows.Forms.Panel();
            this.btn_acc_start = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_tft = new System.Windows.Forms.PictureBox();
            this.lbl_tft_elo = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_flex = new System.Windows.Forms.PictureBox();
            this.lbl_flex_elo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_duo = new System.Windows.Forms.Label();
            this.pb_duoq = new System.Windows.Forms.PictureBox();
            this.lbl_duo_elo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_ingame = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolBar.SuspendLayout();
            this.panel_detail.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tft)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_flex)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_duoq)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.toolBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_dropdown_datei,
            this.toolStripSeparator1,
            this.ts_button_options});
            this.toolBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolBar.Size = new System.Drawing.Size(909, 28);
            this.toolBar.TabIndex = 0;
            // 
            // ts_dropdown_datei
            // 
            this.ts_dropdown_datei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsImportierenToolStripMenuItem,
            this.accountsExportierenToolStripMenuItem,
            this.tsm_add_account,
            this.entfernenToolStripMenuItem});
            this.ts_dropdown_datei.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_dropdown_datei.ForeColor = System.Drawing.Color.White;
            this.ts_dropdown_datei.Image = ((System.Drawing.Image)(resources.GetObject("ts_dropdown_datei.Image")));
            this.ts_dropdown_datei.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_dropdown_datei.Name = "ts_dropdown_datei";
            this.ts_dropdown_datei.Size = new System.Drawing.Size(75, 25);
            this.ts_dropdown_datei.Text = "Datei";
            // 
            // accountsImportierenToolStripMenuItem
            // 
            this.accountsImportierenToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.accountsImportierenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountsImportierenToolStripMenuItem.Image")));
            this.accountsImportierenToolStripMenuItem.Name = "accountsImportierenToolStripMenuItem";
            this.accountsImportierenToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.accountsImportierenToolStripMenuItem.Text = "Importieren";
            // 
            // accountsExportierenToolStripMenuItem
            // 
            this.accountsExportierenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountsExportierenToolStripMenuItem.Image")));
            this.accountsExportierenToolStripMenuItem.Name = "accountsExportierenToolStripMenuItem";
            this.accountsExportierenToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.accountsExportierenToolStripMenuItem.Text = "Exportieren";
            // 
            // tsm_add_account
            // 
            this.tsm_add_account.Name = "tsm_add_account";
            this.tsm_add_account.Size = new System.Drawing.Size(166, 26);
            this.tsm_add_account.Text = "Hinzufügen";
            this.tsm_add_account.Click += new System.EventHandler(this.Tsm_add_account_Click);
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.entfernenToolStripMenuItem.Text = "Entfernen";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // ts_button_options
            // 
            this.ts_button_options.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_button_options.ForeColor = System.Drawing.Color.White;
            this.ts_button_options.Image = ((System.Drawing.Image)(resources.GetObject("ts_button_options.Image")));
            this.ts_button_options.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_button_options.Name = "ts_button_options";
            this.ts_button_options.Size = new System.Drawing.Size(95, 25);
            this.ts_button_options.Text = "Optionen";
            this.ts_button_options.Click += new System.EventHandler(this.Ts_button_options_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 2);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.panel2.Location = new System.Drawing.Point(345, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 543);
            this.panel2.TabIndex = 3;
            // 
            // panel_accounts
            // 
            this.panel_accounts.AutoScroll = true;
            this.panel_accounts.Location = new System.Drawing.Point(13, 82);
            this.panel_accounts.Name = "panel_accounts";
            this.panel_accounts.Size = new System.Drawing.Size(326, 506);
            this.panel_accounts.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accounts";
            // 
            // panel_detail
            // 
            this.panel_detail.Controls.Add(this.btn_acc_start);
            this.panel_detail.Controls.Add(this.panel7);
            this.panel_detail.Controls.Add(this.panel6);
            this.panel_detail.Controls.Add(this.panel5);
            this.panel_detail.Controls.Add(this.panel4);
            this.panel_detail.Location = new System.Drawing.Point(353, 82);
            this.panel_detail.Name = "panel_detail";
            this.panel_detail.Size = new System.Drawing.Size(544, 506);
            this.panel_detail.TabIndex = 5;
            this.panel_detail.Visible = false;
            // 
            // btn_acc_start
            // 
            this.btn_acc_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_acc_start.BackgroundImage")));
            this.btn_acc_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_acc_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acc_start.Location = new System.Drawing.Point(448, 423);
            this.btn_acc_start.Name = "btn_acc_start";
            this.btn_acc_start.Size = new System.Drawing.Size(84, 71);
            this.btn_acc_start.TabIndex = 20;
            this.btn_acc_start.UseVisualStyleBackColor = true;
            this.btn_acc_start.Click += new System.EventHandler(this.Btn_acc_start_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.pb_tft);
            this.panel7.Controls.Add(this.lbl_tft_elo);
            this.panel7.Location = new System.Drawing.Point(364, 120);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(122, 133);
            this.panel7.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "TFT";
            // 
            // pb_tft
            // 
            this.pb_tft.Location = new System.Drawing.Point(27, 31);
            this.pb_tft.Name = "pb_tft";
            this.pb_tft.Size = new System.Drawing.Size(67, 64);
            this.pb_tft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_tft.TabIndex = 2;
            this.pb_tft.TabStop = false;
            // 
            // lbl_tft_elo
            // 
            this.lbl_tft_elo.AutoSize = true;
            this.lbl_tft_elo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tft_elo.ForeColor = System.Drawing.Color.White;
            this.lbl_tft_elo.Location = new System.Drawing.Point(23, 98);
            this.lbl_tft_elo.Name = "lbl_tft_elo";
            this.lbl_tft_elo.Size = new System.Drawing.Size(69, 21);
            this.lbl_tft_elo.TabIndex = 15;
            this.lbl_tft_elo.Text = "Uranked";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.pb_flex);
            this.panel6.Controls.Add(this.lbl_flex_elo);
            this.panel6.Location = new System.Drawing.Point(63, 120);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(122, 133);
            this.panel6.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Flex";
            // 
            // pb_flex
            // 
            this.pb_flex.Location = new System.Drawing.Point(27, 31);
            this.pb_flex.Name = "pb_flex";
            this.pb_flex.Size = new System.Drawing.Size(67, 64);
            this.pb_flex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_flex.TabIndex = 2;
            this.pb_flex.TabStop = false;
            // 
            // lbl_flex_elo
            // 
            this.lbl_flex_elo.AutoSize = true;
            this.lbl_flex_elo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_flex_elo.ForeColor = System.Drawing.Color.White;
            this.lbl_flex_elo.Location = new System.Drawing.Point(16, 98);
            this.lbl_flex_elo.Name = "lbl_flex_elo";
            this.lbl_flex_elo.Size = new System.Drawing.Size(78, 21);
            this.lbl_flex_elo.TabIndex = 15;
            this.lbl_flex_elo.Text = "Unranked";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lbl_duo);
            this.panel5.Controls.Add(this.pb_duoq);
            this.panel5.Controls.Add(this.lbl_duo_elo);
            this.panel5.Location = new System.Drawing.Point(213, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(122, 133);
            this.panel5.TabIndex = 17;
            // 
            // lbl_duo
            // 
            this.lbl_duo.AutoSize = true;
            this.lbl_duo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duo.ForeColor = System.Drawing.Color.White;
            this.lbl_duo.Location = new System.Drawing.Point(23, 6);
            this.lbl_duo.Name = "lbl_duo";
            this.lbl_duo.Size = new System.Drawing.Size(76, 21);
            this.lbl_duo.TabIndex = 10;
            this.lbl_duo.Text = "Solo/Duo";
            // 
            // pb_duoq
            // 
            this.pb_duoq.Location = new System.Drawing.Point(27, 31);
            this.pb_duoq.Name = "pb_duoq";
            this.pb_duoq.Size = new System.Drawing.Size(67, 64);
            this.pb_duoq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_duoq.TabIndex = 2;
            this.pb_duoq.TabStop = false;
            // 
            // lbl_duo_elo
            // 
            this.lbl_duo_elo.AutoSize = true;
            this.lbl_duo_elo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duo_elo.ForeColor = System.Drawing.Color.White;
            this.lbl_duo_elo.Location = new System.Drawing.Point(16, 98);
            this.lbl_duo_elo.Name = "lbl_duo_elo";
            this.lbl_duo_elo.Size = new System.Drawing.Size(78, 21);
            this.lbl_duo_elo.TabIndex = 15;
            this.lbl_duo_elo.Text = "Unranked";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(544, 1);
            this.panel4.TabIndex = 0;
            // 
            // lbl_ingame
            // 
            this.lbl_ingame.AutoSize = true;
            this.lbl_ingame.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingame.ForeColor = System.Drawing.Color.White;
            this.lbl_ingame.Location = new System.Drawing.Point(7, 5);
            this.lbl_ingame.Name = "lbl_ingame";
            this.lbl_ingame.Size = new System.Drawing.Size(0, 34);
            this.lbl_ingame.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_ingame);
            this.panel3.Location = new System.Drawing.Point(543, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 43);
            this.panel3.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(909, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_detail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_accounts);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountManager";
            this.Load += new System.EventHandler(this.on_load);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.panel_detail.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tft)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_flex)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_duoq)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripDropDownButton ts_dropdown_datei;
        private System.Windows.Forms.ToolStripMenuItem accountsImportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsExportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ts_button_options;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_accounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tsm_add_account;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
        private System.Windows.Forms.Panel panel_detail;
        private System.Windows.Forms.Label lbl_ingame;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pb_duoq;
        private System.Windows.Forms.Label lbl_duo;
        private System.Windows.Forms.Label lbl_duo_elo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_tft;
        private System.Windows.Forms.Label lbl_tft_elo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_flex;
        private System.Windows.Forms.Label lbl_flex_elo;
        private System.Windows.Forms.Button btn_acc_start;
    }
}

