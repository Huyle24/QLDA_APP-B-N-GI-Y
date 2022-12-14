namespace QLCH_UI
{
    partial class UC_ItemImport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ItemImport));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lb_soluong = new Guna.UI.WinForms.GunaLabel();
            this.lb_trigia = new Guna.UI.WinForms.GunaLabel();
            this.lb_masp = new Guna.UI.WinForms.GunaLabel();
            this.lb_mahd = new Guna.UI.WinForms.GunaLabel();
            this.lb_ngaynhap = new Guna.UI.WinForms.GunaLabel();
            this.btn_delete = new Guna.UI.WinForms.GunaButton();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.lb_soluong);
            this.gunaLinePanel1.Controls.Add(this.lb_trigia);
            this.gunaLinePanel1.Controls.Add(this.lb_masp);
            this.gunaLinePanel1.Controls.Add(this.lb_mahd);
            this.gunaLinePanel1.Controls.Add(this.lb_ngaynhap);
            this.gunaLinePanel1.Controls.Add(this.btn_delete);
            this.gunaLinePanel1.Controls.Add(this.btnEdit);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 2;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.WhiteSmoke;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1515, 55);
            this.gunaLinePanel1.TabIndex = 1;
            this.gunaLinePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaLinePanel1_Paint);
            this.gunaLinePanel1.MouseEnter += new System.EventHandler(this.gunaLinePanel1_MouseEnter);
            this.gunaLinePanel1.MouseLeave += new System.EventHandler(this.gunaLinePanel1_MouseLeave);
            // 
            // lb_soluong
            // 
            this.lb_soluong.AutoSize = true;
            this.lb_soluong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.lb_soluong.Location = new System.Drawing.Point(889, 14);
            this.lb_soluong.Name = "lb_soluong";
            this.lb_soluong.Size = new System.Drawing.Size(71, 20);
            this.lb_soluong.TabIndex = 24;
            this.lb_soluong.Text = "Số lượng";
            // 
            // lb_trigia
            // 
            this.lb_trigia.AutoSize = true;
            this.lb_trigia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trigia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.lb_trigia.Location = new System.Drawing.Point(1154, 14);
            this.lb_trigia.Name = "lb_trigia";
            this.lb_trigia.Size = new System.Drawing.Size(52, 20);
            this.lb_trigia.TabIndex = 23;
            this.lb_trigia.Text = "Trị giá";
            // 
            // lb_masp
            // 
            this.lb_masp.AutoSize = true;
            this.lb_masp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_masp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.lb_masp.Location = new System.Drawing.Point(636, 14);
            this.lb_masp.Name = "lb_masp";
            this.lb_masp.Size = new System.Drawing.Size(103, 20);
            this.lb_masp.TabIndex = 22;
            this.lb_masp.Text = "Mã sản phẩm";
            // 
            // lb_mahd
            // 
            this.lb_mahd.AutoSize = true;
            this.lb_mahd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mahd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.lb_mahd.Location = new System.Drawing.Point(354, 14);
            this.lb_mahd.Name = "lb_mahd";
            this.lb_mahd.Size = new System.Drawing.Size(92, 20);
            this.lb_mahd.TabIndex = 21;
            this.lb_mahd.Text = "Mã hoá đơn";
            // 
            // lb_ngaynhap
            // 
            this.lb_ngaynhap.AutoSize = true;
            this.lb_ngaynhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaynhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(109)))));
            this.lb_ngaynhap.Location = new System.Drawing.Point(82, 14);
            this.lb_ngaynhap.Name = "lb_ngaynhap";
            this.lb_ngaynhap.Size = new System.Drawing.Size(124, 20);
            this.lb_ngaynhap.TabIndex = 20;
            this.lb_ngaynhap.Text = "Ngày nhập hàng";
            // 
            // btn_delete
            // 
            this.btn_delete.AnimationHoverSpeed = 0.07F;
            this.btn_delete.AnimationSpeed = 0.03F;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btn_delete.BorderColor = System.Drawing.Color.Black;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_delete.FocusedColor = System.Drawing.Color.Empty;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_delete.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_delete.Location = new System.Drawing.Point(1411, 11);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btn_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_delete.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_delete.OnHoverImage = null;
            this.btn_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_delete.Radius = 10;
            this.btn_delete.Size = new System.Drawing.Size(47, 33);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.ImageSize = new System.Drawing.Size(22, 22);
            this.btnEdit.Location = new System.Drawing.Point(1353, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 10;
            this.btnEdit.Size = new System.Drawing.Size(47, 33);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // UC_ItemImport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "UC_ItemImport";
            this.Size = new System.Drawing.Size(1515, 55);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaButton btn_delete;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private Guna.UI.WinForms.GunaLabel lb_soluong;
        private Guna.UI.WinForms.GunaLabel lb_trigia;
        private Guna.UI.WinForms.GunaLabel lb_masp;
        private Guna.UI.WinForms.GunaLabel lb_mahd;
        private Guna.UI.WinForms.GunaLabel lb_ngaynhap;
    }
}
