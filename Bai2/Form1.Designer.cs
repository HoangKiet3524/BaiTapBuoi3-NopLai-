namespace Bai2
{
    partial class Frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTaoMoiVanBan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMoTapTin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemLuuNoiDungVanBan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDinhDang = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbA = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripcmbFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripcmbSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripItaric = new System.Windows.Forms.ToolStripButton();
            this.toolStripUnderLine = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuDinhDang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTaoMoiVanBan,
            this.toolStripMenuItemMoTapTin,
            this.toolStripSeparator2,
            this.toolStripMenuItemLuuNoiDungVanBan,
            this.toolStripMenuItemThoat});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(88, 26);
            this.menuHeThong.Text = "Hệ Thống";
            this.menuHeThong.Click += new System.EventHandler(this.thoToolStripMenuItem_Click);
            // 
            // toolStripMenuItemTaoMoiVanBan
            // 
            this.toolStripMenuItemTaoMoiVanBan.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemTaoMoiVanBan.Image")));
            this.toolStripMenuItemTaoMoiVanBan.Name = "toolStripMenuItemTaoMoiVanBan";
            this.toolStripMenuItemTaoMoiVanBan.Size = new System.Drawing.Size(235, 26);
            this.toolStripMenuItemTaoMoiVanBan.Text = "Tạo mới văn bản";
            this.toolStripMenuItemTaoMoiVanBan.Click += new System.EventHandler(this.toolStripMenuItemTaoMoiVanBan_Click);
            // 
            // toolStripMenuItemMoTapTin
            // 
            this.toolStripMenuItemMoTapTin.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemMoTapTin.Image")));
            this.toolStripMenuItemMoTapTin.Name = "toolStripMenuItemMoTapTin";
            this.toolStripMenuItemMoTapTin.Size = new System.Drawing.Size(235, 26);
            this.toolStripMenuItemMoTapTin.Text = "Mở tập tin";
            this.toolStripMenuItemMoTapTin.Click += new System.EventHandler(this.toolStripMenuItemMoTapTin_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(232, 6);
            // 
            // toolStripMenuItemLuuNoiDungVanBan
            // 
            this.toolStripMenuItemLuuNoiDungVanBan.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemLuuNoiDungVanBan.Image")));
            this.toolStripMenuItemLuuNoiDungVanBan.Name = "toolStripMenuItemLuuNoiDungVanBan";
            this.toolStripMenuItemLuuNoiDungVanBan.Size = new System.Drawing.Size(235, 26);
            this.toolStripMenuItemLuuNoiDungVanBan.Text = "Lưu nội dung văn bản";
            this.toolStripMenuItemLuuNoiDungVanBan.Click += new System.EventHandler(this.toolStripMenuItemLuuNoiDungVanBan_Click);
            // 
            // toolStripMenuItemThoat
            // 
            this.toolStripMenuItemThoat.Name = "toolStripMenuItemThoat";
            this.toolStripMenuItemThoat.Size = new System.Drawing.Size(235, 26);
            this.toolStripMenuItemThoat.Text = "Thoát";
            this.toolStripMenuItemThoat.Click += new System.EventHandler(this.toolStripMenuItemThoat_Click);
            // 
            // menuDinhDang
            // 
            this.menuDinhDang.Name = "menuDinhDang";
            this.menuDinhDang.Size = new System.Drawing.Size(94, 26);
            this.menuDinhDang.Text = "Định Dạng";
            this.menuDinhDang.Click += new System.EventHandler(this.địnhDạngToolStripMenuItem_Click);
            // 
            // rtbA
            // 
            this.rtbA.Location = new System.Drawing.Point(29, 85);
            this.rtbA.Margin = new System.Windows.Forms.Padding(4);
            this.rtbA.Name = "rtbA";
            this.rtbA.Size = new System.Drawing.Size(904, 410);
            this.rtbA.TabIndex = 2;
            this.rtbA.Text = "";
            this.rtbA.TextChanged += new System.EventHandler(this.rtbA_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripSave,
            this.toolStripSeparator1,
            this.toolStripcmbFont,
            this.toolStripcmbSize,
            this.toolStripBold,
            this.toolStripItaric,
            this.toolStripUnderLine});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 28);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripNew
            // 
            this.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNew.Image")));
            this.toolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.Size = new System.Drawing.Size(29, 28);
            this.toolStripNew.Text = "New";
            this.toolStripNew.Click += new System.EventHandler(this.toolStripNew_Click);
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(29, 28);
            this.toolStripSave.Text = "toolStripSave";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripcmbFont
            // 
            this.toolStripcmbFont.Name = "toolStripcmbFont";
            this.toolStripcmbFont.Size = new System.Drawing.Size(160, 31);
            this.toolStripcmbFont.SelectedIndexChanged += new System.EventHandler(this.toolStripcmbFont_SelectedIndexChanged);
            this.toolStripcmbFont.Click += new System.EventHandler(this.toolStripcmbFont_Click);
            // 
            // toolStripcmbSize
            // 
            this.toolStripcmbSize.Name = "toolStripcmbSize";
            this.toolStripcmbSize.Size = new System.Drawing.Size(160, 31);
            this.toolStripcmbSize.SelectedIndexChanged += new System.EventHandler(this.toolStripcmbSize_SelectedIndexChanged);
            this.toolStripcmbSize.Click += new System.EventHandler(this.toolStripcmbSize_Click);
            // 
            // toolStripBold
            // 
            this.toolStripBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBold.Image")));
            this.toolStripBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBold.Name = "toolStripBold";
            this.toolStripBold.Size = new System.Drawing.Size(29, 28);
            this.toolStripBold.Text = "toolStripBold";
            this.toolStripBold.Click += new System.EventHandler(this.toolStripBold_Click);
            // 
            // toolStripItaric
            // 
            this.toolStripItaric.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItaric.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItaric.Image")));
            this.toolStripItaric.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItaric.Name = "toolStripItaric";
            this.toolStripItaric.Size = new System.Drawing.Size(29, 28);
            this.toolStripItaric.Text = "toolStripItaric";
            this.toolStripItaric.Click += new System.EventHandler(this.toolStripItaric_Click);
            // 
            // toolStripUnderLine
            // 
            this.toolStripUnderLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUnderLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUnderLine.Image")));
            this.toolStripUnderLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUnderLine.Name = "toolStripUnderLine";
            this.toolStripUnderLine.Size = new System.Drawing.Size(29, 28);
            this.toolStripUnderLine.Text = "toolStripUnderline";
            this.toolStripUnderLine.Click += new System.EventHandler(this.toolStripUnderLine_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rtbA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm1";
            this.Text = "Soạn Thảo Văn Bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuDinhDang;
        private System.Windows.Forms.RichTextBox rtbA;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripNew;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripcmbFont;
        private System.Windows.Forms.ToolStripComboBox toolStripcmbSize;
        private System.Windows.Forms.ToolStripButton toolStripBold;
        private System.Windows.Forms.ToolStripButton toolStripItaric;
        private System.Windows.Forms.ToolStripButton toolStripUnderLine;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTaoMoiVanBan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMoTapTin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLuuNoiDungVanBan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemThoat;
    }
}

