using IsbaRestaurant.Core.Functions;
using IsbaRestaurant.UI.BackOffice.Garson;
using IsbaRestaurant.UI.BackOffice.Masa;
using IsbaRestaurant.UI.BackOffice.Musteri;
using IsbaRestaurant.UI.BackOffice.OdemeTuru;
using IsbaRestaurant.UI.BackOffice.Urun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IsbaRestaurant.UI.BackOffice.AnaMenu
{
    public partial class FrmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
            if (!ConnectionStringInfo.Check())
            {
                FrmSetupConnection form = new FrmSetupConnection();
                form.ShowDialog();
            }

        }

        private void btnUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrun form = new FrmUrun();
            form.MdiParent = this;
            form.Show();
        }

        private void btnMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMusteri form = new FrmMusteri();
            form.MdiParent = this;
            form.Show();
        }

        private void btnMasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMasa form = new FrmMasa();
            form.MdiParent = this;
            form.Show();
        }

        private void btnGarson_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGarson form = new FrmGarson();
                form.MdiParent = this;
            form.Show();
        }

        private void btnOdemeTur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOdemeTuru form = new FrmOdemeTuru();
            form.MdiParent = this;
            form.Show();
        }
    }
}
