using DevExpress.XtraEditors;
using IsbaRestaurant.Business.Workers;
using IsbaRestaurant.Entities.Tables;
using IsbaRestaurant.UI.BackOffice.Tanim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IsbaRestaurant.UI.BackOffice.Urun
{
    public partial class FrmUrunIslem : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        private Entities.Tables.Urun _urunEntity;
        private Porsiyon _PorsiyonEntity;
        private EkMalzeme _ekMalzemeEntity;
        public FrmUrunIslem(Entities.Tables.Urun urunEntity)
        {
            InitializeComponent();
            _urunEntity = urunEntity;
            if (_urunEntity.Id == Guid.Empty)
            {
                _urunEntity.Id = Guid.NewGuid();
            }
            worker.PorsiyonService.Load(c => c.UrunId == urunEntity.Id); ;
            gridControlPorsiyon.DataSource = worker.PorsiyonService.BindingList();
            worker.EkMalzemeService.Load(c => c.UrunId == urunEntity.Id);
            gridControlEkMalzeme.DataSource = worker.EkMalzemeService.BindingList();
            UrunBinding();
        }
        void UrunBinding()
        {
            txtBarkod.DataBindings.Clear();
            txtUrunAdi.DataBindings.Clear();
            txtUrunAciklama.DataBindings.Clear();
            picUrunFoto.DataBindings.Clear();
            txtBarkod.DataBindings.Add("Text", _urunEntity, "Barkod", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUrunAdi.DataBindings.Add("Text", _urunEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUrunAciklama.DataBindings.Add("Text", _urunEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
             picUrunFoto.DataBindings.Add("EditValue", _urunEntity, "Fotograf", false, DataSourceUpdateMode.OnPropertyChanged);

        }
        void PorsiyonBinding()
        {
            txtPorsiyonAdi.DataBindings.Clear();
            txtPorsiyonFiyat.DataBindings.Clear();
            txtEkMalzemeCarpan.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();
            txtPorsiyonAdi.DataBindings.Add("Text", _PorsiyonEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPorsiyonFiyat.DataBindings.Add("Value", _PorsiyonEntity, "Fiyat", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEkMalzemeCarpan.DataBindings.Add("Value", _PorsiyonEntity, "EkMalzemeCarpan", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _PorsiyonEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        void EkmalzemeBinding()
        {
            txtEkmalzemeAdi.DataBindings.Clear();
            txtEkMalzemeFiyat.DataBindings.Clear();
            txtEkMalzemeAciklama.DataBindings.Clear();
            txtEkmalzemeAdi.DataBindings.Add("Text", _ekMalzemeEntity, "EkmalzemeAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEkMalzemeFiyat.DataBindings.Add("Value", _ekMalzemeEntity, "Fiyat", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEkMalzemeAciklama.DataBindings.Add("Text", _ekMalzemeEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void controlMenuPorsiyon_EkleClick(object sender, EventArgs e)
        {
            controlMenuPorsiyon.KayitAc = true;
            groupPorsiyonBilgi.Visible = true;
            _PorsiyonEntity = new Porsiyon();
            _PorsiyonEntity.UrunId = _urunEntity.Id;
            PorsiyonBinding();
        }

        private void controlMenuPorsiyon_DuzenleClick(object sender, EventArgs e)
        {
            controlMenuPorsiyon.KayitAc = true;
            groupPorsiyonBilgi.Visible = true;
            _PorsiyonEntity = (Porsiyon)gridPorsiyon.GetFocusedRow();
            PorsiyonBinding();
        }

        private void controlMenuPorsiyon_SilClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstermisiniz.", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridPorsiyon.DeleteSelectedRows();
            }
        }

        private void controlMenuPorsiyon_KaydetClick(object sender, EventArgs e)
        {
            controlMenuPorsiyon.KayitAc = false;
            groupPorsiyonBilgi.Visible = false;
            worker.PorsiyonService.AddOrUpdate(_PorsiyonEntity);
        }

        private void controlMenuPorsiyon_VazgecClick(object sender, EventArgs e)
        {
            controlMenuPorsiyon.KayitAc = false;
            groupPorsiyonBilgi.Visible = false;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            worker.UrunService.AddOrUpdate(_urunEntity);
            worker.Commit();
            Close();
        }

        private void controlMenuEkMalzeme_EkleClick(object sender, EventArgs e)
        {
            controlMenuEkMalzeme.KayitAc = true;
            groupEkmalzemeBilgi.Visible = true;
            _ekMalzemeEntity = new EkMalzeme();
            _ekMalzemeEntity.UrunId = _urunEntity.Id;
            EkmalzemeBinding();
        }

        private void controlMenuEkMalzeme_DuzenleClick(object sender, EventArgs e)
        {
            controlMenuEkMalzeme.KayitAc = true;
            groupEkmalzemeBilgi.Visible = true;
            _ekMalzemeEntity = (EkMalzeme)gridMalzeme.GetFocusedRow();
            EkmalzemeBinding();
        }

        private void controlMenuEkMalzeme_SilClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstermisiniz.", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridMalzeme.DeleteSelectedRows();
            }
        }

        private void controlMenuEkMalzeme_KaydetClick(object sender, EventArgs e)
        {
            controlMenuEkMalzeme.KayitAc = false;
            groupEkmalzemeBilgi.Visible = false;
            worker.EkMalzemeService.AddOrUpdate(_ekMalzemeEntity);
        }

        private void controlMenuEkMalzeme_VazgecClick(object sender, EventArgs e)
        {
            controlMenuEkMalzeme.KayitAc = false;
            groupEkmalzemeBilgi.Visible = false;

        }

        private void txtKategori_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form = new FrmTanim(Entities.Enums.TanimTip.UrunGrup);
            form.ShowDialog();
            if (form.Secildi)
            {
                txtKategori.Text = form.tanimEntity.Adi;
                _urunEntity.UrunGrupId = form.tanimEntity.Id;
            }
        }

        private void txtBirim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form = new FrmTanim(Entities.Enums.TanimTip.Birim);
            form.ShowDialog();
            if (form.Secildi)
            {
                txtBirim.Text = form.tanimEntity.Adi;
                _PorsiyonEntity.BirimId = form.tanimEntity.Id;
            }
        }
    }
}