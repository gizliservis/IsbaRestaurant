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

namespace IsbaRestaurant.UI.BackOffice.Garson
{
    public partial class FrmGarson : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmGarson()
        {
            InitializeComponent();
            listele();
        }
       void listele()
        {
            worker.GarsonService.Load(null);
            gridControlGarson.DataSource = worker.GarsonService.BindingList();
        }

        private void controlMenu_ButonEkle(object sender, EventArgs e)
        {
            FrmGarsonIslem form = new FrmGarsonIslem(new Entities.Tables.Garson());
            form.ShowDialog();
            if (form.kaydedildi)
            {
                listele();
            }
        }

        private void controlMenu_ButonDuzenle(object sender, EventArgs e)
        {
            if (gridGarson.GetFocusedRow()==null)
            {
                return;
            }
            FrmGarsonIslem form = new FrmGarsonIslem((Entities.Tables.Garson)gridGarson.GetFocusedRow());
            form.ShowDialog();
            if (form.kaydedildi)
            {
                listele();
            }
        }

        private void controlMenu_ButonSil(object sender, EventArgs e)
        {
            if (gridGarson.GetFocusedRow() == null)
            {
                return;
            }
            if (MessageBox.Show("Seçili Olan Kaydı Silmek İstediğinize Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridGarson.DeleteSelectedRows();
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