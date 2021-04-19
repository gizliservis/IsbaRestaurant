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

namespace IsbaRestaurant.UI.BackOffice.Masa
{
    public partial class FrmMasa : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmMasa()
        {
            InitializeComponent();
            listele();
        }
        void listele()
        {
            worker.MasaService.Load(null, c => c.Konum);
            gridControlMasa.DataSource = worker.MasaService.BindingList();
        }

        private void controlMenu_ButonEkle(object sender, EventArgs e)
        {
            FrmMasaIslem form = new FrmMasaIslem(new Entities.Tables.Masa());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                listele();
            }
        }
        private void controlMenu_ButonDuzenle(object sender, EventArgs e)
        {
            if (gridMasa.GetFocusedRow()==null)
            {
                return;
            }
            FrmMasaIslem form = new FrmMasaIslem((Entities.Tables.Masa)gridMasa.GetFocusedRow());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                listele();
            }
        }
        private void controlMenu_ButonSil(object sender, EventArgs e)
        {
            if (gridMasa.GetFocusedRow() == null)
            {
                return;
            }
            if (MessageBox.Show("Seçili Olan Kaydı Silmek İstediğinize Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridMasa.DeleteSelectedRows();
                worker.Commit();
            }
        }

        private void controlMenu_ButonGuncelle(object sender, EventArgs e)
        {
            listele();
        }

        private void controlMenu_ButonKapat(object sender, EventArgs e)
        {
            Close();
        }
    }
}