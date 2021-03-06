﻿
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMutfak));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridUrunHareketleri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHareketTip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorsiyon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiseHazir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoUrunHareketServisHazir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colEkMalzeme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlAdisyonHareket = new DevExpress.XtraGrid.GridControl();
            this.gridAdisyonHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdisyonDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGarson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdisyonServiseHazir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoAdisyonServiseHazir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.colAdisyonId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunHareketleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUrunHareketServisHazir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAdisyonHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdisyonHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAdisyonServiseHazir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridUrunHareketleri
            // 
            this.gridUrunHareketleri.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridUrunHareketleri.Appearance.Row.Options.UseFont = true;
            this.gridUrunHareketleri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHareketTip,
            this.colUrunAdi,
            this.colPorsiyon,
            this.colBirim,
            this.colMiktar,
            this.colServiseHazir,
            this.colEkMalzeme});
            this.gridUrunHareketleri.GridControl = this.gridControlAdisyonHareket;
            this.gridUrunHareketleri.Name = "gridUrunHareketleri";
            this.gridUrunHareketleri.OptionsView.ShowGroupPanel = false;
            // 
            // colHareketTip
            // 
            this.colHareketTip.Caption = "Hareket";
            this.colHareketTip.FieldName = "SiparisDurum";
            this.colHareketTip.Name = "colHareketTip";
            this.colHareketTip.OptionsColumn.AllowEdit = false;
            this.colHareketTip.Visible = true;
            this.colHareketTip.VisibleIndex = 0;
            this.colHareketTip.Width = 80;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 1;
            this.colUrunAdi.Width = 335;
            // 
            // colPorsiyon
            // 
            this.colPorsiyon.Caption = "Porsiyon";
            this.colPorsiyon.FieldName = "Porsiyon";
            this.colPorsiyon.Name = "colPorsiyon";
            this.colPorsiyon.OptionsColumn.AllowEdit = false;
            this.colPorsiyon.Visible = true;
            this.colPorsiyon.VisibleIndex = 2;
            this.colPorsiyon.Width = 60;
            // 
            // colBirim
            // 
            this.colBirim.Caption = "Birim";
            this.colBirim.FieldName = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.AllowEdit = false;
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 3;
            this.colBirim.Width = 33;
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
            this.colMiktar.Width = 50;
            // 
            // colServiseHazir
            // 
            this.colServiseHazir.Caption = "Servise Hazır";
            this.colServiseHazir.ColumnEdit = this.repoUrunHareketServisHazir;
            this.colServiseHazir.Name = "colServiseHazir";
            this.colServiseHazir.Visible = true;
            this.colServiseHazir.VisibleIndex = 6;
            this.colServiseHazir.Width = 74;
            // 
            // repoUrunHareketServisHazir
            // 
            this.repoUrunHareketServisHazir.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repoUrunHareketServisHazir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repoUrunHareketServisHazir.Name = "repoUrunHareketServisHazir";
            this.repoUrunHareketServisHazir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repoUrunHareketServisHazir.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoUrunHareketServisHazir_ButtonClick);
            // 
            // colEkMalzeme
            // 
            this.colEkMalzeme.Caption = "Ek Malzeme";
            this.colEkMalzeme.FieldName = "EkMalzeme";
            this.colEkMalzeme.Name = "colEkMalzeme";
            this.colEkMalzeme.OptionsColumn.AllowEdit = false;
            this.colEkMalzeme.Visible = true;
            this.colEkMalzeme.VisibleIndex = 5;
            this.colEkMalzeme.Width = 303;
            // 
            // gridControlAdisyonHareket
            // 
            this.gridControlAdisyonHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridUrunHareketleri;
            gridLevelNode1.RelationName = "Ürün Hareketleri";
            this.gridControlAdisyonHareket.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlAdisyonHareket.Location = new System.Drawing.Point(0, 39);
            this.gridControlAdisyonHareket.MainView = this.gridAdisyonHareket;
            this.gridControlAdisyonHareket.Name = "gridControlAdisyonHareket";
            this.gridControlAdisyonHareket.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoUrunHareketServisHazir,
            this.repoAdisyonServiseHazir});
            this.gridControlAdisyonHareket.Size = new System.Drawing.Size(960, 481);
            this.gridControlAdisyonHareket.TabIndex = 11;
            this.gridControlAdisyonHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridAdisyonHareket,
            this.gridUrunHareketleri});
            // 
            // gridAdisyonHareket
            // 
            this.gridAdisyonHareket.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.gridAdisyonHareket.Appearance.Row.Options.UseFont = true;
            this.gridAdisyonHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTarih,
            this.colAdisyonDurum,
            this.colMusteri,
            this.colMasaAdi,
            this.colGarson,
            this.colAdisyonServiseHazir,
            this.colAdisyonId});
            this.gridAdisyonHareket.GridControl = this.gridControlAdisyonHareket;
            this.gridAdisyonHareket.Name = "gridAdisyonHareket";
            this.gridAdisyonHareket.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridAdisyonHareket.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded;
            this.gridAdisyonHareket.OptionsDetail.ShowDetailTabs = false;
            this.gridAdisyonHareket.OptionsView.ShowDetailButtons = false;
            this.gridAdisyonHareket.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridAdisyonHareket_RowClick);
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
            // colAdisyonServiseHazir
            // 
            this.colAdisyonServiseHazir.Caption = "Servise hazır";
            this.colAdisyonServiseHazir.ColumnEdit = this.repoAdisyonServiseHazir;
            this.colAdisyonServiseHazir.Name = "colAdisyonServiseHazir";
            this.colAdisyonServiseHazir.Visible = true;
            this.colAdisyonServiseHazir.VisibleIndex = 5;
            // 
            // repoAdisyonServiseHazir
            // 
            this.repoAdisyonServiseHazir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.repoAdisyonServiseHazir.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repoAdisyonServiseHazir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repoAdisyonServiseHazir.Name = "repoAdisyonServiseHazir";
            this.repoAdisyonServiseHazir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repoAdisyonServiseHazir.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoAdisyonServiseHazir_ButtonClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnKapat);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(960, 39);
            this.panelControl1.TabIndex = 12;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(887, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(71, 35);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // colAdisyonId
            // 
            this.colAdisyonId.Caption = "Id";
            this.colAdisyonId.FieldName = "AdisyonId";
            this.colAdisyonId.Name = "colAdisyonId";
            // 
            // FrmMutfak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 520);
            this.Controls.Add(this.gridControlAdisyonHareket);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMutfak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunHareketleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoUrunHareketServisHazir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAdisyonHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdisyonHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAdisyonServiseHazir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridAdisyonHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colAdisyonDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteri;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colGarson;
        private DevExpress.XtraGrid.Columns.GridColumn colServiseHazir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoUrunHareketServisHazir;
        private DevExpress.XtraGrid.Columns.GridColumn colAdisyonServiseHazir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoAdisyonServiseHazir;
        private DevExpress.XtraGrid.Columns.GridColumn colEkMalzeme;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraGrid.Columns.GridColumn colAdisyonId;
    }
}

