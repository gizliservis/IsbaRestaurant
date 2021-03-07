using DevExpress.XtraEditors;
using IsbaRestaurant.Business.Workers;
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
            if (_urunEntity.Id==Guid.Empty)
            {
                _urunEntity.Id = Guid.NewGuid();
            }
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
            picUrunFoto.DataBindings.Add("Image", _urunEntity, "Fotograf", false, DataSourceUpdateMode.OnPropertyChanged);

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
    }
}