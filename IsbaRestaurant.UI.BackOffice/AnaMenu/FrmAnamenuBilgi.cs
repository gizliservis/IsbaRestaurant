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

namespace IsbaRestaurant.UI.BackOffice.AnaMenu
{
    public partial class FrmAnamenuBilgi : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmAnamenuBilgi()
        {
            InitializeComponent();
            chartEnCokSatanUrunler.Series[0].DataSource = worker.UrunHareketService.EnCokSatanUrunleriGetir();
            chartEnCokSatanUrunler.Series[0].ArgumentDataMember = "UrunAdi";
            chartEnCokSatanUrunler.Series[0].ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            chartEnCokSatanUrunler.Series[0].ValueDataMembers.AddRange(new[] {"AdetToplam"});

            chartHaftalikSatis.Series[0].DataSource = worker.OdemeHareketService.HaftalikKazancıGetir();
            chartHaftalikSatis.Series[0].ArgumentDataMember = "Gun";
            chartHaftalikSatis.Series[0].ValueDataMembers.AddRange(new[] { "ToplamKazanc"} );

            chartAylikkazanc.Series[0].DataSource = worker.OdemeHareketService.AylikKazancıGetir();
            chartAylikkazanc.Series[0].ArgumentDataMember = "Tarih";
            chartAylikkazanc.Series[0].ValueDataMembers.AddRange(new[] { "ToplamKazanc" });


            chartYillikKazanc.Series[0].DataSource = worker.OdemeHareketService.YillikKazancıGetir();
            chartYillikKazanc.Series[0].ArgumentDataMember = "Ay";
            chartYillikKazanc.Series[0].ValueDataMembers.AddRange(new[] { "ToplamKazanc" });
        }
    }
}