﻿namespace QLNHANSU
{
    partial class FrmHopDongLaoDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHopDongLaoDong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cboThoiHan = new System.Windows.Forms.ComboBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoiDung = new DevExpress.XtraRichEdit.RichEditControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.slkNhanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.spHeSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.spLanKy = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayKy = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.txtSoHD = new DevExpress.XtraEditors.TextEdit();
            this.lblSoHD = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SOHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYBATDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYKETTHUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOIHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LANKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLanKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.btnDong,
            this.btnPrint});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(299, 132);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPrint, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In";
            this.btnPrint.Id = 6;
            this.btnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrint.ImageOptions.SvgImage")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1048, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 541);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1048, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 517);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1048, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 517);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cboThoiHan);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainer1.Panel1.Controls.Add(this.txtNoiDung);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainer1.Panel1.Controls.Add(this.slkNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.spHeSoLuong);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.spLanKy);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayKy);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayKetThuc);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayBatDau);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoHD);
            this.splitContainer1.Panel1.Controls.Add(this.lblSoHD);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1048, 517);
            this.splitContainer1.SplitterDistance = 410;
            this.splitContainer1.TabIndex = 6;
            // 
            // cboThoiHan
            // 
            this.cboThoiHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThoiHan.FormattingEnabled = true;
            this.cboThoiHan.Items.AddRange(new object[] {
            "3 tháng",
            "6 tháng",
            "12 tháng"});
            this.cboThoiHan.Location = new System.Drawing.Point(646, 17);
            this.cboThoiHan.Name = "cboThoiHan";
            this.cboThoiHan.Size = new System.Drawing.Size(159, 21);
            this.cboThoiHan.TabIndex = 17;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(587, 20);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(52, 14);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Thời hạn:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(102, 128);
            this.txtNoiDung.MenuManager = this.barManager1;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            this.txtNoiDung.Size = new System.Drawing.Size(856, 266);
            this.txtNoiDung.TabIndex = 15;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(42, 128);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 14);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Nội Dung";
            // 
            // slkNhanVien
            // 
            this.slkNhanVien.Location = new System.Drawing.Point(587, 75);
            this.slkNhanVien.MenuManager = this.barManager1;
            this.slkNhanVien.Name = "slkNhanVien";
            this.slkNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.slkNhanVien.Properties.Appearance.Options.UseFont = true;
            this.slkNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkNhanVien.Properties.PopupView = this.searchLookUpEdit1View;
            this.slkNhanVien.Size = new System.Drawing.Size(218, 22);
            this.slkNhanVien.TabIndex = 13;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colHoTen});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMaNV
            // 
            this.colMaNV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaNV.AppearanceHeader.Options.UseFont = true;
            this.colMaNV.Caption = "MÃ NV";
            this.colMaNV.FieldName = "MANV";
            this.colMaNV.MaxWidth = 80;
            this.colMaNV.MinWidth = 80;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            this.colMaNV.Width = 80;
            // 
            // colHoTen
            // 
            this.colHoTen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colHoTen.AppearanceHeader.Options.UseFont = true;
            this.colHoTen.Caption = "HỌ TÊN";
            this.colHoTen.FieldName = "HOTEN";
            this.colHoTen.MaxWidth = 200;
            this.colHoTen.MinWidth = 200;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            this.colHoTen.Width = 200;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(525, 83);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 14);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Nhân Viên";
            // 
            // spHeSoLuong
            // 
            this.spHeSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spHeSoLuong.Location = new System.Drawing.Point(400, 77);
            this.spHeSoLuong.MenuManager = this.barManager1;
            this.spHeSoLuong.Name = "spHeSoLuong";
            this.spHeSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spHeSoLuong.Size = new System.Drawing.Size(65, 20);
            this.spHeSoLuong.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(322, 83);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 14);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Hệ Số Lương";
            // 
            // spLanKy
            // 
            this.spLanKy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spLanKy.Location = new System.Drawing.Point(400, 50);
            this.spLanKy.MenuManager = this.barManager1;
            this.spLanKy.Name = "spLanKy";
            this.spLanKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spLanKy.Properties.IsFloatValue = false;
            this.spLanKy.Properties.MaskSettings.Set("mask", "N00");
            this.spLanKy.Size = new System.Drawing.Size(65, 20);
            this.spLanKy.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(358, 56);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 14);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Lần Ký";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(350, 25);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 14);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Ngày Ký";
            // 
            // dtNgayKy
            // 
            this.dtNgayKy.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKy.Location = new System.Drawing.Point(400, 20);
            this.dtNgayKy.Name = "dtNgayKy";
            this.dtNgayKy.Size = new System.Drawing.Size(157, 21);
            this.dtNgayKy.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(52, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Ngày KT";
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(102, 78);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(157, 21);
            this.dtNgayKetThuc.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(50, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ngày BĐ";
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayBatDau.Location = new System.Drawing.Point(102, 51);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(157, 21);
            this.dtNgayBatDau.TabIndex = 2;
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(102, 25);
            this.txtSoHD.MenuManager = this.barManager1;
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Properties.ReadOnly = true;
            this.txtSoHD.Size = new System.Drawing.Size(157, 20);
            this.txtSoHD.TabIndex = 1;
            // 
            // lblSoHD
            // 
            this.lblSoHD.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblSoHD.Appearance.Options.UseFont = true;
            this.lblSoHD.Location = new System.Drawing.Point(62, 27);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(34, 14);
            this.lblSoHD.TabIndex = 0;
            this.lblSoHD.Text = "Số HĐ";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1048, 103);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SOHD,
            this.NGAYBATDAU,
            this.NGAYKETTHUC,
            this.THOIHAN,
            this.HESOLUONG,
            this.LANKY,
            this.NGAYKY,
            this.MANV,
            this.HOTEN});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // SOHD
            // 
            this.SOHD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SOHD.AppearanceHeader.Options.UseFont = true;
            this.SOHD.Caption = "SỐ HỢP ĐỒNG";
            this.SOHD.FieldName = "SOHD";
            this.SOHD.MaxWidth = 150;
            this.SOHD.MinWidth = 150;
            this.SOHD.Name = "SOHD";
            this.SOHD.Visible = true;
            this.SOHD.VisibleIndex = 0;
            this.SOHD.Width = 150;
            // 
            // NGAYBATDAU
            // 
            this.NGAYBATDAU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.NGAYBATDAU.AppearanceHeader.Options.UseFont = true;
            this.NGAYBATDAU.Caption = "NGÀY BẮT ĐẦU";
            this.NGAYBATDAU.FieldName = "NGAYBATDAU";
            this.NGAYBATDAU.MaxWidth = 150;
            this.NGAYBATDAU.MinWidth = 150;
            this.NGAYBATDAU.Name = "NGAYBATDAU";
            this.NGAYBATDAU.Visible = true;
            this.NGAYBATDAU.VisibleIndex = 1;
            this.NGAYBATDAU.Width = 150;
            // 
            // NGAYKETTHUC
            // 
            this.NGAYKETTHUC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.NGAYKETTHUC.AppearanceHeader.Options.UseFont = true;
            this.NGAYKETTHUC.Caption = "NGÀY KẾT THÚC";
            this.NGAYKETTHUC.FieldName = "NGAYKETTHUC";
            this.NGAYKETTHUC.MaxWidth = 150;
            this.NGAYKETTHUC.MinWidth = 150;
            this.NGAYKETTHUC.Name = "NGAYKETTHUC";
            this.NGAYKETTHUC.Visible = true;
            this.NGAYKETTHUC.VisibleIndex = 2;
            this.NGAYKETTHUC.Width = 150;
            // 
            // THOIHAN
            // 
            this.THOIHAN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.THOIHAN.AppearanceHeader.Options.UseFont = true;
            this.THOIHAN.Caption = "THỜI HẠN";
            this.THOIHAN.FieldName = "THOIHAN";
            this.THOIHAN.MaxWidth = 120;
            this.THOIHAN.MinWidth = 120;
            this.THOIHAN.Name = "THOIHAN";
            this.THOIHAN.Visible = true;
            this.THOIHAN.VisibleIndex = 3;
            this.THOIHAN.Width = 120;
            // 
            // HESOLUONG
            // 
            this.HESOLUONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.HESOLUONG.AppearanceHeader.Options.UseFont = true;
            this.HESOLUONG.Caption = "HS LƯƠNG";
            this.HESOLUONG.FieldName = "HESOLUONG";
            this.HESOLUONG.MaxWidth = 120;
            this.HESOLUONG.MinWidth = 120;
            this.HESOLUONG.Name = "HESOLUONG";
            this.HESOLUONG.Visible = true;
            this.HESOLUONG.VisibleIndex = 4;
            this.HESOLUONG.Width = 120;
            // 
            // LANKY
            // 
            this.LANKY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.LANKY.AppearanceHeader.Options.UseFont = true;
            this.LANKY.Caption = "LẦN KÝ";
            this.LANKY.FieldName = "LANKY";
            this.LANKY.MaxWidth = 120;
            this.LANKY.MinWidth = 120;
            this.LANKY.Name = "LANKY";
            this.LANKY.Visible = true;
            this.LANKY.VisibleIndex = 5;
            this.LANKY.Width = 120;
            // 
            // NGAYKY
            // 
            this.NGAYKY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.NGAYKY.AppearanceHeader.Options.UseFont = true;
            this.NGAYKY.Caption = "NGÀY KÝ";
            this.NGAYKY.FieldName = "NGAYKY";
            this.NGAYKY.MaxWidth = 100;
            this.NGAYKY.MinWidth = 100;
            this.NGAYKY.Name = "NGAYKY";
            this.NGAYKY.Visible = true;
            this.NGAYKY.VisibleIndex = 6;
            this.NGAYKY.Width = 100;
            // 
            // MANV
            // 
            this.MANV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MANV.AppearanceHeader.Options.UseFont = true;
            this.MANV.Caption = "MANV";
            this.MANV.FieldName = "MANV";
            this.MANV.MaxWidth = 300;
            this.MANV.MinWidth = 300;
            this.MANV.Name = "MANV";
            this.MANV.Visible = true;
            this.MANV.VisibleIndex = 7;
            this.MANV.Width = 300;
            // 
            // HOTEN
            // 
            this.HOTEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.HOTEN.AppearanceHeader.Options.UseFont = true;
            this.HOTEN.Caption = "NHÂN VIÊN";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 200;
            this.HOTEN.MinWidth = 200;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 8;
            this.HOTEN.Width = 200;
            // 
            // FrmHopDongLaoDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmHopDongLaoDong";
            this.Text = "Hợp Đồng Lao Động";
            this.Load += new System.EventHandler(this.FrmHopDongLaoDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLanKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn SOHD;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYBATDAU;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYKETTHUC;
        private DevExpress.XtraGrid.Columns.GridColumn THOIHAN;
        private DevExpress.XtraGrid.Columns.GridColumn HESOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn LANKY;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private DevExpress.XtraEditors.TextEdit txtSoHD;
        private DevExpress.XtraEditors.LabelControl lblSoHD;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker dtNgayKy;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        private DevExpress.XtraEditors.SearchLookUpEdit slkNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SpinEdit spHeSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SpinEdit spLanKy;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraRichEdit.RichEditControl txtNoiDung;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private System.Windows.Forms.ComboBox cboThoiHan;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYKY;
    }
}