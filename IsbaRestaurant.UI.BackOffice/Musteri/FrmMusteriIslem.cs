﻿using DevExpress.XtraEditors;
using IsbaRestaurant.Business.Workers;
using IsbaRestaurant.Entities.Enums;
using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsbaRestaurant.UI.BackOffice.Musteri
{
    public partial class FrmMusteriIslem : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        Entities.Tables.Musteri _musteriEntity;
        Telefon _telefonEntity;
        Adres _adresEntity;
        public bool Kaydedildi = false;
        public FrmMusteriIslem(Entities.Tables.Musteri musteriEntity)
        {
            InitializeComponent();
            _musteriEntity = musteriEntity;
            if (_musteriEntity.Id == Guid.Empty)
            {
                _musteriEntity.Id = Guid.NewGuid();
            }
            worker.TelefonService.Load(c => c.MusteriId == _musteriEntity.Id);
            gridControlTelefon.DataSource = worker.TelefonService.BindingList();
            worker.AdresService.Load(c => c.MusteriId == _musteriEntity.Id);
            gridControlAdres.DataSource = worker.AdresService.BindingList();
            lookTelefonTip.Properties.DataSource = Enum.GetValues(typeof(TelefonAdresTip));
            lookAdresTip.Properties.DataSource = Enum.GetValues(typeof(TelefonAdresTip));
            MusteriBindng();
        }
        void MusteriBindng()
        {
            txtMusteriAdi.DataBindings.Clear();
            txtMusteriSoyadi.DataBindings.Clear();
            txtSirketAdi.DataBindings.Clear();
            txtKartNo.DataBindings.Clear();
            txtMusteriAciklama.DataBindings.Clear();

            txtMusteriAdi.DataBindings.Add("Text", _musteriEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMusteriSoyadi.DataBindings.Add("Text", _musteriEntity, "Soyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSirketAdi.DataBindings.Add("Text", _musteriEntity, "Sirket", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKartNo.DataBindings.Add("Text", _musteriEntity, "KartNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMusteriAciklama.DataBindings.Add("Text", _musteriEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        void TelefonBinding()
        {
            txtTelefonNumarasi.DataBindings.Clear();
            txtTelefonAciklama.DataBindings.Clear();
            lookTelefonTip.DataBindings.Clear();

            txtTelefonNumarasi.DataBindings.Add("Text", _telefonEntity, "Telefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            lookTelefonTip.DataBindings.Add("EditValue", _telefonEntity, "TelefonTip", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTelefonAciklama.DataBindings.Add("Text", _telefonEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        void AdresBinding()
        {
            txtIl.DataBindings.Clear();
            txtIlce.DataBindings.Clear();
            txtSemt.DataBindings.Clear();
            txtAdres.DataBindings.Clear();
            lookAdresTip.DataBindings.Clear();

            txtIl.DataBindings.Add("Text", _adresEntity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            lookAdresTip.DataBindings.Add("EditValue", _adresEntity, "TelefonAdresTip", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _adresEntity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _adresEntity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _adresEntity, "Adresi", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void controlMenuTelefon_EkleClick(object sender, EventArgs e)
        {
            _telefonEntity = new Telefon();
            _telefonEntity.MusteriId = _musteriEntity.Id;
            controlMenuTelefon.KayitAc = true;
            groupTelefonBilgi.Visible = true;
            groupAltMenu.Enabled = false;
            TelefonBinding();

        }

        private void controlMenuTelefon_DuzenleClick(object sender, EventArgs e)
        {
            if (gridTelefon.GetFocusedRow()==null)
            {
                return;
            }
            _telefonEntity = (Telefon)gridTelefon.GetFocusedRow();
            controlMenuTelefon.KayitAc = true;
            groupTelefonBilgi.Visible = true;
            groupAltMenu.Enabled = false;
            TelefonBinding();
        }

        private void controlMenuTelefon_SilClick(object sender, EventArgs e)
        {
            if (gridTelefon.GetFocusedRow() == null)
            {
                return;
            }
            if (MessageBox.Show("Seçili Olan Kaydı Silmek İstediğinize Eminmisiniz","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                gridTelefon.DeleteSelectedRows();
            }
        }

        private void controlMenuTelefon_KaydetClick(object sender, EventArgs e)
        {
            worker.TelefonService.AddOrUpdate(_telefonEntity);
            controlMenuTelefon.KayitAc = false;
            groupTelefonBilgi.Visible = false;
            groupAltMenu.Enabled = true;
        }

        private void controlMenuTelefon_VazgecClick(object sender, EventArgs e)
        {
            controlMenuTelefon.KayitAc = false;
            groupTelefonBilgi.Visible = false;
            groupAltMenu.Enabled = true;
        }

        private void controlMenuAdres_EkleClick(object sender, EventArgs e)
        {
            controlMenuAdres.KayitAc = true;
            groupAdresBilgi.Visible = true;
            _adresEntity = new Adres();
            _adresEntity.MusteriId = _musteriEntity.Id;
            groupAltMenu.Enabled = false;
            AdresBinding();

        }

        private void controlMenuAdres_DuzenleClick(object sender, EventArgs e)
        {
            if (gridAdres.GetFocusedRow()==null)
            {
                return;
            }
            controlMenuAdres.KayitAc = true;
            groupAdresBilgi.Visible = true;
            _adresEntity = (Adres)gridAdres.GetFocusedRow();
            groupAltMenu.Enabled = false;
            AdresBinding();
        }

        private void controlMenuAdres_SilClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Kaydı Silmek İstediğinize Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridAdres.DeleteSelectedRows();
            }
        }

        private void controlMenuAdres_KaydetClick(object sender, EventArgs e)
        {
            worker.AdresService.AddOrUpdate(_adresEntity);
            controlMenuAdres.KayitAc = false;
            groupAdresBilgi.Visible = true;
            groupAltMenu.Enabled = true;
        }

        private void controlMenuAdres_VazgecClick(object sender, EventArgs e)
        {
            controlMenuAdres.KayitAc = false;
            groupAdresBilgi.Visible = false;
            groupAltMenu.Enabled = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            worker.MusteriService.AddOrUpdate(_musteriEntity);
            worker.Commit();
            Kaydedildi = true;
            Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}