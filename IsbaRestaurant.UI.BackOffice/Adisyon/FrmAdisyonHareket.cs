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

namespace IsbaRestaurant.UI.BackOffice.Adisyon
{
    public partial class FrmAdisyonHareket : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmAdisyonHareket()
        {
            InitializeComponent();
            dateGunSecim.DateTime = DateTime.Now;
            listele(DateTime.Now);
        }
        void listele(DateTime tarih)
        {
            gridControlAdisyonHareket.DataSource = worker.AdisyonService.AdisyonHareketGetir(tarih);
        }
        private void dateGunSecim_SelectionChanged(object sender, EventArgs e)
        {
            listele(dateGunSecim.DateTime);
        }
    }
}