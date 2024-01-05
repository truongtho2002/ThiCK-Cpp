﻿using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace QLNHANSU
{
    public partial class FrmNhanVien_DieuChuyen : DevExpress.XtraEditors.XtraForm
    {
        public FrmNhanVien_DieuChuyen()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        NHANVIEN_DIEUCHUYEN _nvdc;
        NHANVIEN _nhanvien;
        PHONGBAN _phongban;

        private void FrmNhanVien_DieuChuyen_Load(object sender, EventArgs e)
        {
            _nvdc = new NHANVIEN_DIEUCHUYEN();
            _nhanvien = new NHANVIEN();
            _phongban = new PHONGBAN();
            _them = false;
            _showHide(true);
            loadNhanVien();
            loadDonViDen();
            loadData();
            splitContainer1.Panel1Collapsed = true;
        }
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnPrint.Enabled = kt;
            gcDanhSach.Enabled = kt;
            txtSoQD.Enabled = !kt;
            txtGhiChu.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            cboDonViDen.Enabled = !kt;
            slkNhanVien.Enabled = !kt;

        }

        void _reset()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            //dtNgayBatDau.Value = DateTime.Now;
            //dtNgayBatDau.Value = dtNgayBatDau.Value.AddMonths(6);

        }
        void loadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
        }
        void loadDonViDen()
        {
            cboDonViDen.DataSource = _phongban.getList();
            cboDonViDen.DisplayMember = "TENPB";
            cboDonViDen.ValueMember = "IDPB";
        }
        void loadData()
        {
            gcDanhSach.DataSource = _nvdc.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            _reset();
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
            splitContainer1.Panel1Collapsed = false;
            gcDanhSach.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _nvdc.Delete(_soQD, 1);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void SaveData()
        {
            tb_NHANVIEN_DIEUCHUYEN dc;
            if (_them)
            {
                var maxSoQD = _nvdc.MaxSoQuyetDinh();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;


                dc = new tb_NHANVIEN_DIEUCHUYEN();
                dc.SOQD = so.ToString("00000") + @"/"+DateTime.Now.Year.ToString()+"/QĐDC";
                dc.LYDO = txtLyDo.Text;
                dc.NGAY = dtNgay.Value;
                dc.GHICHU = txtGhiChu.Text;
                dc.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                dc.MAPB = _nhanvien.getItem(int.Parse(slkNhanVien.EditValue.ToString())).IDBP;
                dc.MAPB2 = int.Parse(cboDonViDen.SelectedValue.ToString());
                dc.GHICHU = txtGhiChu.Text;
                dc.CREATED_BY = 1;
                dc.CREATED_DATE = DateTime.Now;
                _nvdc.Add(dc);

            }
            else
            {
                dc = _nvdc.getItem(_soQD);
                dc.LYDO = txtLyDo.Text;
                dc.NGAY = dtNgay.Value;
                dc.GHICHU = txtGhiChu.Text;
                dc.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                dc.MAPB2 = int.Parse(cboDonViDen.SelectedValue.ToString());
                dc.UPDATED_BY = 1;
                dc.UPDATED_DATE = DateTime.Now;
                _nvdc.Update(dc);
            }
            var nv = _nhanvien.getItem(dc.MANV.Value);
            nv.IDBP = dc.MAPB2;
            _nhanvien.Update(nv);
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soQD = (gvDanhSach.GetFocusedRowCellValue("SOQD").ToString());
                var dc = _nvdc.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtNgay.Value = dc.NGAY.Value;
                slkNhanVien.EditValue = dc.MANV;
                txtGhiChu.Text = dc.GHICHU;
                txtLyDo.Text = dc.LYDO;
                cboDonViDen.SelectedValue = dc.MAPB2;
            }
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name=="DELETED_BY" && e.CellValue!=null)
            {
                Image img = Properties.Resources.delete_x16;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}