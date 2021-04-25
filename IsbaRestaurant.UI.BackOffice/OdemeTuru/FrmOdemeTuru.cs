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

namespace IsbaRestaurant.UI.BackOffice.OdemeTuru
{
    public partial class FrmOdemeTuru : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmOdemeTuru()
        {
            InitializeComponent();
            Listele();
        }
        void Listele()
        {
            worker.OdemeTuruService.Load(null,c=>c.OdemeTur);
            gridControlOdemeTuru.DataSource = worker.OdemeTuruService.BindingList();
        }
        private void controlMenu_ButonEkle(object sender, EventArgs e)
        {
            FrmOdemeTuruIslem form = new FrmOdemeTuruIslem(new Entities.Tables.OdemeTuru());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void controlMenu_ButonDuzenle(object sender, EventArgs e)
        {
            Entities.Tables.OdemeTuru entity = (Entities.Tables.OdemeTuru)gridOdemeTuru.GetFocusedRow();
            if (entity==null)
            {
                return;
            }
            FrmOdemeTuruIslem form = new FrmOdemeTuruIslem(entity);
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void controlMenu_ButonGuncelle(object sender, EventArgs e)
        {
            Listele();
        }

        private void controlMenu_ButonSil(object sender, EventArgs e)
        {
            if (gridOdemeTuru.GetFocusedRow() == null)
            {
                return;
            }
            if (MessageBox.Show("Seçili Olan Kaydı Silmek İstediğinize Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridOdemeTuru.DeleteSelectedRows();
                worker.Commit();
            }
        }

        private void controlMenu_ButonKapat(object sender, EventArgs e)
        {
            Close();
        }
    }
}