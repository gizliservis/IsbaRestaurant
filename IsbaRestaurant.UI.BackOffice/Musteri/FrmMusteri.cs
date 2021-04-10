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

namespace IsbaRestaurant.UI.BackOffice.Musteri
{
    public partial class FrmMusteri : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();

        public FrmMusteri()
        {
            InitializeComponent();
            listele();
        }


        void listele()
        {
            worker.MusteriService.Load(null);
            gridControlMusteri.DataSource = worker.MusteriService.BindingList();
        }

        private void controlMenu_ButonEkle(object sender, EventArgs e)
        {
            FrmMusteriIslem form = new FrmMusteriIslem(new Entities.Tables.Musteri());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                listele();
            }
        }

        private void controlMenu_ButonDuzenle(object sender, EventArgs e)
        {
            FrmMusteriIslem form = new FrmMusteriIslem((Entities.Tables.Musteri)gridMusteri.GetFocusedRow());
            form.ShowDialog();
            if (form.Kaydedildi)
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
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İster misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridMusteri.DeleteSelectedRows();
                listele();
            }
        }

        private void controlMenu_ButonKapat(object sender, EventArgs e)
        {
            Close();
        }
    }
}