﻿using BusinessLayer;
using BusinessLayer.DTO;
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

namespace QLNHANSU
{
    public partial class FrmKhenThuong : DevExpress.XtraEditors.XtraForm
    {
        public FrmKhenThuong()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        KHENTHUONG_KYLUAT _ktkl;
        NHANVIEN _nhanvien;

        private void FrmKhenThuong_Load(object sender, EventArgs e)
        {
            _ktkl = new KHENTHUONG_KYLUAT();
            _nhanvien = new NHANVIEN();
            _them = false;
            _showHide(true);
            loadNhanVien();
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
            txtNoiDung.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            //dtNgayBatDau.Enabled = !kt;
            //dtNgayKetThuc.Enabled = !kt;
            
            slkNhanVien.Enabled = !kt;

        }

        void _reset()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            //dtNgayBatDau.Value = DateTime.Now;
            //dtNgayBatDau.Value = dtNgayBatDau.Value.AddMonths(6);
            
        }
        void loadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
        }
        void loadData()
        {
            gcDanhSach.DataSource = _ktkl.getListFull(1);
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
                _ktkl.Delete(_soQD,1);
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
            if (_them)
            {
                var maxSoQD = _ktkl.MaxSoQuyetDinh(1);
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;


                tb_KHENTHUONG_KYLUAT kt = new tb_KHENTHUONG_KYLUAT();
                kt.SOQUYETDINH = so.ToString("00000") + @"/2024/QĐKT";
                //hd.NGAYBATDAU = dtNgayBatDau.Value;
                //hd.NGAYKETTHUC = dtNgayKetThuc.Value;
                kt.LYDO = txtLyDo.Text;
                kt.NGAY = dtNgay.Value;
                kt.NOIDUNG = txtNoiDung.Text;
                kt.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                kt.LOAI = 1;
                kt.CREATED_BY = 1;
                kt.CREATED_DATE = DateTime.Now;
                _ktkl.Add(kt);

            }
            else
            {
                var kt = _ktkl.getItem(_soQD);
                //hd.NGAYBATDAU = dtNgayBatDau.Value;
                //hd.NGAYKETTHUC = dtNgayKetThuc.Value;
                kt.LYDO = txtLyDo.Text;
                kt.NGAY = dtNgay.Value;
                kt.NOIDUNG = txtNoiDung.Text; ;
                kt.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                kt.UPDATED_BY = 1;
                kt.UPDATED_DATE = DateTime.Now;
                _ktkl.Update(kt);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soQD = (gvDanhSach.GetFocusedRowCellValue("SOQUYETDINH").ToString());
                var kt = _ktkl.getItem(_soQD);
                txtSoQD.Text = _soQD;
                //dtNgayBatDau.Value = hd.NGAYKETTHUC.Value;
                //dtNgayKetThuc.Value = hd.NGAYKETTHUC.Value;
                dtNgay.Value = kt.NGAY.Value;
                slkNhanVien.EditValue = kt.MANV;
                txtNoiDung.Text = kt.NOIDUNG;
                txtLyDo.Text = kt.LYDO;
                //_lstHD = _hdld.getItemFull(_soHD);
            }
        }
    }
}