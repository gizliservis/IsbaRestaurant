using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Views.Grid;
using IsbaRestaurant.Business.Workers;
using IsbaRestaurant.Core.Functions;
using IsbaRestaurant.Core.Monitors;
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
   
        Guid adisyonId = Guid.Empty;
        RestaurantWorker worker = new RestaurantWorker();
        SqlMonitor<UrunHareket> urunHareketMonitor = new SqlMonitor<UrunHareket>("UrunHareketleri", c => c.SiparisDurum == Entities.Enums.SiparisDurum.Hazirlaniyor);
        public FrmMutfak()
        {
            InitializeComponent();
            AdisyonListele();
            urunHareketMonitor.OnChange += UrunHareketChanged;
        }
        private int GetRowHandle()
        {
            if (adisyonId == Guid.Empty) return 0;
            for (int i = 0; i < gridAdisyonHareket.RowCount; i++)
            {
                if ((Guid)gridAdisyonHareket.GetRowCellValue(i,colAdisyonId)==adisyonId)
                {
                return i;
                }

            }
            return 0;
            
        }
        private void UrunHareketChanged()
        {
            Invoke((MethodInvoker)delegate { AdisyonListele(); });  
        }

        void AdisyonListele()
        {
            Guid[] adisyonListe= worker.UrunHareketService.Select(c => c.SiparisDurum == Entities.Enums.SiparisDurum.Hazirlaniyor, c => c.AdisyonId).Distinct().ToArray();
            gridControlAdisyonHareket.DataSource = worker.AdisyonService.MutfakAdisyonHareketGetir(adisyonListe);
            int rowHandle = GetRowHandle();
            gridAdisyonHareket.ExpandMasterRow(rowHandle);
            gridAdisyonHareket.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            gridUrunHareketleri.SelectRow(rowHandle);
            gridAdisyonHareket.SelectRow(rowHandle);
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
            AdisyonListele();
            gridAdisyonHareket.CollapseMasterRow(gridAdisyonHareket.FocusedRowHandle);
            gridAdisyonHareket.ExpandMasterRow(gridAdisyonHareket.FocusedRowHandle);
        }

        private void repoAdisyonServiseHazir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MutfakAdisyonHareketDto entity = (MutfakAdisyonHareketDto)gridAdisyonHareket.GetFocusedRow();
            worker.UrunHareketService.Select(c=>c.AdisyonId==entity.AdisyonId,c=>c).ForEach(c => c.SiparisDurum = Entities.Enums.SiparisDurum.ServiseHazir);
            worker.Commit();
            AdisyonListele();
            gridAdisyonHareket.CollapseMasterRow(gridAdisyonHareket.FocusedRowHandle);
            gridAdisyonHareket.ExpandMasterRow(gridAdisyonHareket.FocusedRowHandle);
        }

        private void gridAdisyonHareket_RowClick(object sender, RowClickEventArgs e)
        {
            adisyonId =(Guid)gridAdisyonHareket.GetRowCellValue(e.RowHandle, colAdisyonId);
            gridAdisyonHareket.ExpandMasterRow(e.RowHandle);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
