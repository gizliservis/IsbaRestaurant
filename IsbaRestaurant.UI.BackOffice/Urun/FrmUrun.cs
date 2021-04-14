using DevExpress.XtraEditors;
using IsbaRestaurant.Business.Workers;
using IsbaRestaurant.Core.Extensions;
using IsbaRestaurant.UI.BackOffice.Fotograf;
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
    public partial class FrmUrun : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmUrun()
        {
            InitializeComponent();
            listele();
        }

 
        void listele()
        {
            worker.UrunService.Load(null,c=>c.UrunGrup);
            gridControlUrunler.DataSource = worker.UrunService.BindingList();
        }
        private void controlMenu_ButonEkle(object sender, EventArgs e)
        {
            FrmUrunIslem form = new FrmUrunIslem(new Entities.Tables.Urun());
            form.ShowDialog();
            if (form.Eklendi)
            {
                listele();
            }
        }

        private void controlMenu_ButonDuzenle(object sender, EventArgs e)
        {
            if (gridUrunler.GetFocusedRow()==null)
            {
                return;
            }
            FrmUrunIslem form = new FrmUrunIslem((Entities.Tables.Urun)gridUrunler.GetFocusedRow());
            form.ShowDialog();
            if (form.Eklendi)
            {
                listele();
            }
        }

        private void controlMenu_ButonGuncelle(object sender, EventArgs e)
        {
            listele();
        }

        private void controlMenu_ButonSil(object sender, EventArgs e)
        {
            if (gridUrunler.GetFocusedRow() == null)
            {
                return;
            }
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İster misiniz ?","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                gridUrunler.DeleteSelectedRows();
                listele();
            }
        
        }

        private void controlMenu_ButonKapat(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFotografEkle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           Entities.Tables.Urun entity = (Entities.Tables.Urun)gridUrunler.GetFocusedRow();
            FrmImageEditor form = new FrmImageEditor();
            form.ShowDialog();
            if (form.ReturnedImage!=null)
            {
                entity.Fotograf = form.ReturnedImage.ImageToByteArray();
                worker.Commit();
                gridUrunler.RefreshData();
            }
        }
    }
}