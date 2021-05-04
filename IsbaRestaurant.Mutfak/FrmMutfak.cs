﻿using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Views.Grid;
using IsbaRestaurant.Business.Workers;
using IsbaRestaurant.Core.Functions;
using IsbaRestaurant.Entities.Dtos.Mutfak;
using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient.Where;

namespace IsbaRestaurant.Mutfak
{
    public partial class FrmMutfak : DevExpress.XtraEditors.XtraForm
    {
        private Expression<Func<UrunHareket, bool>> filter;
        SqlTableDependency<UrunHareket> urunHareketDependency;
        RestaurantWorker worker = new RestaurantWorker();
        public FrmMutfak()
        {
            InitializeComponent();
            filter = c => c.SiparisDurum == Entities.Enums.SiparisDurum.Hazirlaniyor;
         urunHareketDependency=new SqlTableDependency<UrunHareket>(ConnectionStringInfo.Get(), "UrunHareketleri", filter: 
       new SqlTableDependencyFilter<UrunHareket>(filter));
            urunHareketDependency.OnChanged += Changed;
            urunHareketDependency.Start();
            AdisyonListele();
        }

        private void Changed(object sender, RecordChangedEventArgs<UrunHareket> e)
        {
            AdisyonListele();
        }

        void AdisyonListele()
        {
         Guid[] adisyonListe= worker.UrunHareketService.Select(c => c.SiparisDurum == Entities.Enums.SiparisDurum.Hazirlaniyor, c => c.AdisyonId).Distinct().ToArray();
            gridControlAdisyonHareket.DataSource = worker.AdisyonService.MutfakAdisyonHareketGetir(adisyonListe);
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

        private void repoUrunHareketServisHazir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView view = (GridView)gridControlAdisyonHareket.FocusedView;
            MutfakUrunHareketDto entity = (MutfakUrunHareketDto)view.GetFocusedRow();
            UrunHareket urunHareketEntity = worker.UrunHareketService.Get(c => c.Id == entity.Id);
            urunHareketEntity.SiparisDurum = Entities.Enums.SiparisDurum.ServiseHazir;
            worker.UrunHareketService.Update(urunHareketEntity);
            worker.Commit();
            gridAdisyonHareket.CollapseMasterRow(gridAdisyonHareket.FocusedRowHandle);
            gridAdisyonHareket.ExpandMasterRow(gridAdisyonHareket.FocusedRowHandle);
        }

        private void repoAdisyonServiseHazir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MutfakAdisyonHareketDto entity = (MutfakAdisyonHareketDto)gridAdisyonHareket.GetFocusedRow();
           // worker.UrunHareketService.Load(c => c.AdisyonId == entity.AdisyonId);
            worker.UrunHareketService.Select(c=>c.AdisyonId==entity.AdisyonId,c=>c).ForEach(c => c.SiparisDurum = Entities.Enums.SiparisDurum.ServiseHazir);
            worker.Commit();
            gridAdisyonHareket.CollapseMasterRow(gridAdisyonHareket.FocusedRowHandle);
            gridAdisyonHareket.ExpandMasterRow(gridAdisyonHareket.FocusedRowHandle);
        }

        private void gridAdisyonHareket_RowClick(object sender, RowClickEventArgs e)
        {
            gridAdisyonHareket.ExpandMasterRow(e.RowHandle);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
