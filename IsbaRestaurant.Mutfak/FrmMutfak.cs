using DevExpress.XtraGrid.Views.Grid;
using IsbaRestaurant.Business.Workers;
using IsbaRestaurant.Entities.Dtos.Mutfak;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IsbaRestaurant.Mutfak
{
    public partial class FrmMutfak : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmMutfak()
        {
            InitializeComponent();
            gridControlAdisyonHareket.DataSource = worker.AdisyonService.MutfakAdisyonHareketGetir();
        }

        private void gridAdisyonHareket_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridAdisyonHareket_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Ürün Hareketleri";
        }

        private void gridAdisyonHareket_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView view = (GridView)sender;
            MutfakAdisyonHareketDto entity = (MutfakAdisyonHareketDto)view.GetRow(e.RowHandle);
            e.ChildList = worker.AdisyonService.MutfakUrunHareketGetir(entity.AdisyonId);
         
        }

        private void gridUrunHareketleri_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridUrunHareketleri_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Ek Malzeme";
        }

        private void gridUrunHareketleri_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView view = (GridView)sender;
            MutfakUrunHareketDto entity = (MutfakUrunHareketDto)view.GetRow(e.RowHandle);
            e.ChildList = worker.AdisyonService.MutfakEkMalzemeHareketGetir(entity.Id);
        }
    }
}
