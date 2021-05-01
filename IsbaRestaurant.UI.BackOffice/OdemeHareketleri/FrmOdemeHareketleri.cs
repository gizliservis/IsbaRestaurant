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

namespace IsbaRestaurant.UI.BackOffice.OdemeHareketleri
{
    public partial class FrmOdemeHareketleri : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmOdemeHareketleri()
        {
            InitializeComponent();
            dateGunSecim.DateTime = DateTime.Now;
            dateGunsecim2.DateTime = DateTime.Now;
            listele(DateTime.Now, DateTime.Now);
        }
        void listele(DateTime baslangic,DateTime bitis)
        {
            gridControlOdemeHareket.DataSource = worker.OdemeHareketService.OdemeHareketListesiGetir(baslangic, bitis);

        }

        private void dateGunSecim_SelectionChanged(object sender, EventArgs e)
        {
            if (dateGunSecim.DateTime > dateGunsecim2.DateTime)
            {
                dateGunsecim2.DateTime = dateGunSecim.DateTime;
            }
            listele(dateGunSecim.DateTime, dateGunsecim2.DateTime);
        }

        private void dateGunsecim2_SelectionChanged(object sender, EventArgs e)
        {
            if (dateGunSecim.DateTime > dateGunsecim2.DateTime)
            {
                dateGunSecim.DateTime = dateGunsecim2.DateTime;
            }
            listele(dateGunSecim.DateTime, dateGunsecim2.DateTime);
        }
    }
}