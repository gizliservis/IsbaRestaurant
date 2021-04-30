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

namespace IsbaRestaurant.UI.BackOffice.UrunHareket
{
    public partial class FrmUrunHareketleri : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmUrunHareketleri()
        {
            InitializeComponent();
            dateGunSecim.DateTime = DateTime.Now;
            dateGunsecim2.DateTime = DateTime.Now;
            Listele(DateTime.Now, DateTime.Now);
        }
        void Listele(DateTime baslangic,DateTime bitis)
        {
           gridControlUrunHareket.DataSource=worker.UrunHareketService.UrunHareketListesiGetir(baslangic, bitis);

        }

        private void dateGunSecim_SelectionChanged(object sender, EventArgs e)
        {
            if (dateGunSecim.DateTime > dateGunsecim2.DateTime)
            {
                dateGunsecim2.DateTime = dateGunSecim.DateTime;
            }
            Listele(dateGunSecim.DateTime, dateGunsecim2.DateTime);
        }

        private void dateGunsecim2_SelectionChanged(object sender, EventArgs e)
        {
            if (dateGunSecim.DateTime > dateGunsecim2.DateTime)
            {
                dateGunSecim.DateTime = dateGunsecim2.DateTime;
            }
            Listele(dateGunSecim.DateTime, dateGunsecim2.DateTime);
        }
    }
}