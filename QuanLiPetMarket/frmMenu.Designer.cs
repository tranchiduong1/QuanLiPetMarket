namespace QuanLiPetMarket
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuContact = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSP = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSP = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            this.btNhanVien = new System.Windows.Forms.Button();
            this.btKhachHang = new System.Windows.Forms.Button();
            this.btLoaiSP = new System.Windows.Forms.Button();
            this.btDonHangChiTiet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.itemMenuSanPham,
            this.menuSP});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuContact,
            this.liênHệToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStripMenuItem.Image")));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.menuToolStripMenuItem.Text = "Home";
            // 
            // itemMenuContact
            // 
            this.itemMenuContact.Image = ((System.Drawing.Image)(resources.GetObject("itemMenuContact.Image")));
            this.itemMenuContact.Name = "itemMenuContact";
            this.itemMenuContact.Size = new System.Drawing.Size(154, 22);
            this.itemMenuContact.Text = "Contact US";
            this.itemMenuContact.Click += new System.EventHandler(this.itemMenuContact_Click);
            // 
            // liênHệToolStripMenuItem
            // 
            this.liênHệToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("liênHệToolStripMenuItem.Image")));
            this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.liênHệToolStripMenuItem.Text = "Help";
            this.liênHệToolStripMenuItem.Click += new System.EventHandler(this.liênHệToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "________________";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // itemMenuSanPham
            // 
            this.itemMenuSanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.customerINFOToolStripMenuItem});
            this.itemMenuSanPham.Image = ((System.Drawing.Image)(resources.GetObject("itemMenuSanPham.Image")));
            this.itemMenuSanPham.Name = "itemMenuSanPham";
            this.itemMenuSanPham.Size = new System.Drawing.Size(53, 20);
            this.itemMenuSanPham.Text = "List";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriesToolStripMenuItem.Image")));
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productsToolStripMenuItem.Image")));
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderDetailsToolStripMenuItem});
            this.ordersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersToolStripMenuItem.Image")));
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.orderDetailsToolStripMenuItem.Text = "OrderDetails";
            this.orderDetailsToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsToolStripMenuItem_Click);
            // 
            // customerINFOToolStripMenuItem
            // 
            this.customerINFOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerINFOToolStripMenuItem.Image")));
            this.customerINFOToolStripMenuItem.Name = "customerINFOToolStripMenuItem";
            this.customerINFOToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.customerINFOToolStripMenuItem.Text = "Customer INFO";
            this.customerINFOToolStripMenuItem.Click += new System.EventHandler(this.customerINFOToolStripMenuItem_Click);
            // 
            // menuSP
            // 
            this.menuSP.Image = ((System.Drawing.Image)(resources.GetObject("menuSP.Image")));
            this.menuSP.Name = "menuSP";
            this.menuSP.Size = new System.Drawing.Size(77, 20);
            this.menuSP.Text = "Support";
            this.menuSP.Click += new System.EventHandler(this.menuSP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(277, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 111);
            this.label1.TabIndex = 2;
            this.label1.Text = "IT-OU Corporation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSP
            // 
            this.btSP.BackColor = System.Drawing.Color.Green;
            this.btSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSP.Location = new System.Drawing.Point(12, 173);
            this.btSP.Name = "btSP";
            this.btSP.Size = new System.Drawing.Size(148, 86);
            this.btSP.TabIndex = 3;
            this.btSP.Text = "PRODUCTS";
            this.btSP.UseVisualStyleBackColor = false;
            this.btSP.Click += new System.EventHandler(this.btSP_Click);
            // 
            // btHelp
            // 
            this.btHelp.BackColor = System.Drawing.Color.Green;
            this.btHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btHelp.Location = new System.Drawing.Point(400, 299);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(148, 86);
            this.btHelp.TabIndex = 4;
            this.btHelp.Text = "SUPPORT";
            this.btHelp.UseVisualStyleBackColor = false;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
            // 
            // btNhanVien
            // 
            this.btNhanVien.BackColor = System.Drawing.Color.Green;
            this.btNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhanVien.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btNhanVien.Location = new System.Drawing.Point(211, 299);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.Size = new System.Drawing.Size(148, 86);
            this.btNhanVien.TabIndex = 5;
            this.btNhanVien.Text = "ADMINISTRATOR";
            this.btNhanVien.UseVisualStyleBackColor = false;
            this.btNhanVien.Click += new System.EventHandler(this.btNhanVien_Click);
            // 
            // btKhachHang
            // 
            this.btKhachHang.BackColor = System.Drawing.Color.Green;
            this.btKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKhachHang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btKhachHang.Location = new System.Drawing.Point(12, 301);
            this.btKhachHang.Name = "btKhachHang";
            this.btKhachHang.Size = new System.Drawing.Size(148, 86);
            this.btKhachHang.TabIndex = 6;
            this.btKhachHang.Text = "CUSTOMER INFOMATIONS";
            this.btKhachHang.UseVisualStyleBackColor = false;
            this.btKhachHang.Click += new System.EventHandler(this.btKhachHang_Click);
            // 
            // btLoaiSP
            // 
            this.btLoaiSP.BackColor = System.Drawing.Color.Green;
            this.btLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoaiSP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLoaiSP.Location = new System.Drawing.Point(400, 173);
            this.btLoaiSP.Name = "btLoaiSP";
            this.btLoaiSP.Size = new System.Drawing.Size(148, 86);
            this.btLoaiSP.TabIndex = 7;
            this.btLoaiSP.Text = "Categories";
            this.btLoaiSP.UseVisualStyleBackColor = false;
            this.btLoaiSP.Click += new System.EventHandler(this.btLoaiSP_Click);
            // 
            // btDonHangChiTiet
            // 
            this.btDonHangChiTiet.BackColor = System.Drawing.Color.Green;
            this.btDonHangChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDonHangChiTiet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btDonHangChiTiet.Location = new System.Drawing.Point(211, 173);
            this.btDonHangChiTiet.Name = "btDonHangChiTiet";
            this.btDonHangChiTiet.Size = new System.Drawing.Size(148, 86);
            this.btDonHangChiTiet.TabIndex = 8;
            this.btDonHangChiTiet.Text = "OrderDetails";
            this.btDonHangChiTiet.UseVisualStyleBackColor = false;
            this.btDonHangChiTiet.Click += new System.EventHandler(this.btDonHangChiTiet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(173, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "IT-OU Corporation @034-144 Duong-Thu @2018";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "x";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(570, 478);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDonHangChiTiet);
            this.Controls.Add(this.btLoaiSP);
            this.Controls.Add(this.btKhachHang);
            this.Controls.Add(this.btNhanVien);
            this.Controls.Add(this.btHelp);
            this.Controls.Add(this.btSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PET MARKET MAIN MENU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMenuContact;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMenuSanPham;
        private System.Windows.Forms.ToolStripMenuItem menuSP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSP;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.Button btNhanVien;
        private System.Windows.Forms.Button btKhachHang;
        private System.Windows.Forms.Button btLoaiSP;
        private System.Windows.Forms.Button btDonHangChiTiet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerINFOToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}