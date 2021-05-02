
namespace IsbaRestaurant.Mutfak
{
    partial class FrmMutfak
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridUrunHareketleri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHareketTip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorsiyon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlAdisyonHareket = new DevExpress.XtraGrid.GridControl();
            this.gridEkMalzeme = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAdisyonHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdisyonDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGarson = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunHareketleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAdisyonHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEkMalzeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdisyonHareket)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUrunHareketleri
            // 
            this.gridUrunHareketleri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHareketTip,
            this.colUrunAdi,
            this.colPorsiyon,
            this.colBirim,
            this.colMiktar});
            this.gridUrunHareketleri.GridControl = this.gridControlAdisyonHareket;
            this.gridUrunHareketleri.Name = "gridUrunHareketleri";
            this.gridUrunHareketleri.OptionsView.ShowGroupPanel = false;
            this.gridUrunHareketleri.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridUrunHareketleri_MasterRowGetChildList);
            this.gridUrunHareketleri.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridUrunHareketleri_MasterRowGetRelationName);
            this.gridUrunHareketleri.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridUrunHareketleri_MasterRowGetRelationCount);
            // 
            // colHareketTip
            // 
            this.colHareketTip.Caption = "Hareket Tip";
            this.colHareketTip.FieldName = "UrunHareketTip";
            this.colHareketTip.Name = "colHareketTip";
            this.colHareketTip.OptionsColumn.AllowEdit = false;
            this.colHareketTip.Visible = true;
            this.colHareketTip.VisibleIndex = 0;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 1;
            // 
            // colPorsiyon
            // 
            this.colPorsiyon.Caption = "Porsiyon";
            this.colPorsiyon.FieldName = "Porsiyon";
            this.colPorsiyon.Name = "colPorsiyon";
            this.colPorsiyon.OptionsColumn.AllowEdit = false;
            this.colPorsiyon.Visible = true;
            this.colPorsiyon.VisibleIndex = 2;
            // 
            // colBirim
            // 
            this.colBirim.Caption = "Birim";
            this.colBirim.FieldName = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.AllowEdit = false;
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 3;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.DisplayFormat.FormatString = "N0";
            this.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 4;
            // 
            // gridControlAdisyonHareket
            // 
            this.gridControlAdisyonHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridUrunHareketleri;
            gridLevelNode1.RelationName = "Ürün Hareketleri";
            gridLevelNode2.LevelTemplate = this.gridEkMalzeme;
            gridLevelNode2.RelationName = "Ek Malzeme";
            this.gridControlAdisyonHareket.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gridControlAdisyonHareket.Location = new System.Drawing.Point(0, 0);
            this.gridControlAdisyonHareket.MainView = this.gridAdisyonHareket;
            this.gridControlAdisyonHareket.Name = "gridControlAdisyonHareket";
            this.gridControlAdisyonHareket.Size = new System.Drawing.Size(960, 520);
            this.gridControlAdisyonHareket.TabIndex = 11;
            this.gridControlAdisyonHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridEkMalzeme,
            this.gridAdisyonHareket,
            this.gridUrunHareketleri});
            // 
            // gridEkMalzeme
            // 
            this.gridEkMalzeme.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdi});
            this.gridEkMalzeme.GridControl = this.gridControlAdisyonHareket;
            this.gridEkMalzeme.Name = "gridEkMalzeme";
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adi";
            this.colAdi.FieldName = "EkMalzemeAdi";
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 0;
            // 
            // gridAdisyonHareket
            // 
            this.gridAdisyonHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTarih,
            this.colAdisyonDurum,
            this.colMusteri,
            this.colMasaAdi,
            this.colGarson});
            this.gridAdisyonHareket.GridControl = this.gridControlAdisyonHareket;
            this.gridAdisyonHareket.Name = "gridAdisyonHareket";
            this.gridAdisyonHareket.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridAdisyonHareket.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded;
            this.gridAdisyonHareket.OptionsDetail.ShowDetailTabs = false;
            this.gridAdisyonHareket.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridAdisyonHareket_MasterRowGetChildList);
            this.gridAdisyonHareket.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridAdisyonHareket_MasterRowGetRelationName);
            this.gridAdisyonHareket.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridAdisyonHareket_MasterRowGetRelationCount);
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.DisplayFormat.FormatString = "T";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 0;
            this.colTarih.Width = 133;
            // 
            // colAdisyonDurum
            // 
            this.colAdisyonDurum.Caption = "Durumu";
            this.colAdisyonDurum.FieldName = "AdisyonDurum";
            this.colAdisyonDurum.Name = "colAdisyonDurum";
            this.colAdisyonDurum.OptionsColumn.AllowEdit = false;
            this.colAdisyonDurum.Visible = true;
            this.colAdisyonDurum.VisibleIndex = 1;
            this.colAdisyonDurum.Width = 133;
            // 
            // colMusteri
            // 
            this.colMusteri.Caption = "Müşteri Adı";
            this.colMusteri.FieldName = "MusteriAdi";
            this.colMusteri.Name = "colMusteri";
            this.colMusteri.OptionsColumn.AllowEdit = false;
            this.colMusteri.Visible = true;
            this.colMusteri.VisibleIndex = 2;
            this.colMusteri.Width = 433;
            // 
            // colMasaAdi
            // 
            this.colMasaAdi.Caption = "Masa";
            this.colMasaAdi.FieldName = "MasaAdi";
            this.colMasaAdi.Name = "colMasaAdi";
            this.colMasaAdi.OptionsColumn.AllowEdit = false;
            this.colMasaAdi.Visible = true;
            this.colMasaAdi.VisibleIndex = 3;
            this.colMasaAdi.Width = 37;
            // 
            // colGarson
            // 
            this.colGarson.Caption = "Garson";
            this.colGarson.FieldName = "GarsonAdi";
            this.colGarson.Name = "colGarson";
            this.colGarson.OptionsColumn.AllowEdit = false;
            this.colGarson.Visible = true;
            this.colGarson.VisibleIndex = 4;
            this.colGarson.Width = 98;
            // 
            // FrmMutfak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 520);
            this.Controls.Add(this.gridControlAdisyonHareket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMutfak";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunHareketleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAdisyonHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEkMalzeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdisyonHareket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlAdisyonHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUrunHareketleri;
        private DevExpress.XtraGrid.Columns.GridColumn colHareketTip;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colPorsiyon;
        private DevExpress.XtraGrid.Columns.GridColumn colBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Views.Card.CardView gridEkMalzeme;
        private DevExpress.XtraGrid.Views.Grid.GridView gridAdisyonHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colAdisyonDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteri;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colGarson;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
    }
}

