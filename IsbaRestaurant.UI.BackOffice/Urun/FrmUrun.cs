using DevExpress.XtraEditors;
using IsbaRestaurant.Business.Workers;
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
    }
}