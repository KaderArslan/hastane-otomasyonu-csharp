namespace Proje_Hastane
{
    partial class FrmDuyurular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuyurular));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iLETİŞİMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusBar2 = new System.Windows.Forms.StatusBar();
            this.BtnSil = new System.Windows.Forms.Button();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(785, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iLETİŞİMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iLETİŞİMToolStripMenuItem
            // 
            this.iLETİŞİMToolStripMenuItem.CheckOnClick = true;
            this.iLETİŞİMToolStripMenuItem.Image = global::Proje_Hastane.Properties.Resources.iletişim;
            this.iLETİŞİMToolStripMenuItem.Name = "iLETİŞİMToolStripMenuItem";
            this.iLETİŞİMToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.iLETİŞİMToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.iLETİŞİMToolStripMenuItem.Text = "İLETİŞİM";
            this.iLETİŞİMToolStripMenuItem.Click += new System.EventHandler(this.iLETİŞİMToolStripMenuItem_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBar1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusBar1.Location = new System.Drawing.Point(678, 350);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(107, 25);
            this.statusBar1.TabIndex = 2;
            this.statusBar1.Text = "statusBar1";
            this.statusBar1.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.statusBar1_PanelClick);
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusBar2
            // 
            this.statusBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBar2.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBar2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusBar2.Location = new System.Drawing.Point(611, 0);
            this.statusBar2.Name = "statusBar2";
            this.statusBar2.Size = new System.Drawing.Size(174, 22);
            this.statusBar2.TabIndex = 3;
            this.statusBar2.Text = "16010011039-KADER ARSLAN";
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnSil.Location = new System.Drawing.Point(363, 328);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(139, 35);
            this.BtnSil.TabIndex = 25;
            this.BtnSil.Text = "Duyuru Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(363, 289);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(139, 33);
            this.Txtid.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(226, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Duyuru id:";
            // 
            // FrmDuyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Proje_Hastane.Properties.Resources.images__14_9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 375);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.Txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBar2);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmDuyurular";
            this.Text = "FrmDuyurular";
            this.Load += new System.EventHandler(this.FrmDuyurular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iLETİŞİMToolStripMenuItem;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusBar statusBar2;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label1;
    }
}