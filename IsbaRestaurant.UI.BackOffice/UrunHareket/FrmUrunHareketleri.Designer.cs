
namespace IsbaRestaurant.UI.BackOffice.UrunHareket
{
    partial class FrmUrunHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunHareketleri));
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateGunSecim = new DevExpress.XtraEditors.DateEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dateGunsecim2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.controlMenu = new IsbaRestaurant.UserControls.ControlAnaMenuAlt();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridUrunHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUrunHareketTip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorsiyon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEkMalzemeliFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlUrunHareket = new DevExpress.XtraGrid.GridControl();
            this.colEkMalzemeTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunsecim2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunsecim2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunHareket)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(453, 16);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Arasında";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl3.Location = new System.Drawing.Point(521, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(100, 32);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Tarih :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.Location = new System.Drawing.Point(2, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 32);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tarih :";
            // 
            // dateGunSecim
            // 
            this.dateGunSecim.EditValue = null;
            this.dateGunSecim.Location = new System.Drawing.Point(108, 7);
            this.dateGunSecim.Name = "dateGunSecim";
            this.dateGunSecim.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.dateGunSecim.Properties.Appearance.Options.UseFont = true;
            this.dateGunSecim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGunSecim.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGunSecim.Size = new System.Drawing.Size(321, 32);
            this.dateGunSecim.TabIndex = 0;
            this.dateGunSecim.SelectionChanged += new System.EventHandler(this.dateGunSecim_SelectionChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.dateGunsecim2);
            this.panelControl1.Controls.Add(this.dateGunSecim);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 46);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(960, 45);
            this.panelControl1.TabIndex = 15;
            // 
            // dateGunsecim2
            // 
            this.dateGunsecim2.EditValue = null;
            this.dateGunsecim2.Location = new System.Drawing.Point(627, 6);
            this.dateGunsecim2.Name = "dateGunsecim2";
            this.dateGunsecim2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.dateGunsecim2.Properties.Appearance.Options.UseFont = true;
            this.dateGunsecim2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGunsecim2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGunsecim2.Size = new System.Drawing.Size(321, 32);
            this.dateGunsecim2.TabIndex = 0;
            this.dateGunsecim2.SelectionChanged += new System.EventHandler(this.dateGunsecim2_SelectionChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(960, 46);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Ürün Hareketleri";
            // 
            // controlMenu
            // 
            this.controlMenu.ButtonFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.controlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMenu.Location = new System.Drawing.Point(2, 23);
            this.controlMenu.Name = "controlMenu";
            this.controlMenu.Size = new System.Drawing.Size(956, 56);
            this.controlMenu.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.controlMenu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 421);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(960, 81);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Menü";
            // 
            // gridUrunHareket
            // 
            this.gridUrunHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUrunHareketTip,
            this.colSaat,
            this.colTarih,
            this.colUrunAdi,
            this.colPorsiyon,
            this.colBirim,
            this.colMiktar,
            this.colBirimFiyat,
            this.colEkMalzemeTutar,
            this.colEkMalzemeliFiyat,
            this.colIndirim,
            this.colToplamTutar});
            this.gridUrunHareket.GridControl = this.gridControlUrunHareket;
            this.gridUrunHareket.GroupCount = 1;
            this.gridUrunHareket.Name = "gridUrunHareket";
            this.gridUrunHareket.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUrunAdi, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colUrunHareketTip
            // 
            this.colUrunHareketTip.Caption = "Hareket Tipi";
            this.colUrunHareketTip.FieldName = "UrunHareketTip";
            this.colUrunHareketTip.Name = "colUrunHareketTip";
            this.colUrunHareketTip.OptionsColumn.AllowEdit = false;
            this.colUrunHareketTip.Visible = true;
            this.colUrunHareketTip.VisibleIndex = 0;
            this.colUrunHareketTip.Width = 73;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Saat";
            this.colSaat.DisplayFormat.FormatString = "T";
            this.colSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaat.FieldName = "EklenmeTarihi";
            this.colSaat.Name = "colSaat";
            this.colSaat.OptionsColumn.AllowEdit = false;
            this.colSaat.Visible = true;
            this.colSaat.VisibleIndex = 1;
            this.colSaat.Width = 85;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "EklenmeTarihi";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 2;
            this.colTarih.Width = 85;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "Urun.Adi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 3;
            this.colUrunAdi.Width = 281;
            // 
            // colPorsiyon
            // 
            this.colPorsiyon.Caption = "Porsiyon";
            this.colPorsiyon.FieldName = "Porsiyon.Adi";
            this.colPorsiyon.Name = "colPorsiyon";
            this.colPorsiyon.OptionsColumn.AllowEdit = false;
            this.colPorsiyon.Visible = true;
            this.colPorsiyon.VisibleIndex = 3;
            this.colPorsiyon.Width = 49;
            // 
            // colBirim
            // 
            this.colBirim.Caption = "Birimi";
            this.colBirim.FieldName = "Porsiyon.Birim.Adi";
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.AllowEdit = false;
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 4;
            this.colBirim.Width = 38;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.DisplayFormat.FormatString = "N3";
            this.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 5;
            this.colMiktar.Width = 43;
            // 
            // colBirimFiyat
            // 
            this.colBirimFiyat.Caption = "Birim Fiyat";
            this.colBirimFiyat.DisplayFormat.FormatString = "C2";
            this.colBirimFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBirimFiyat.FieldName = "BirimFiyat";
            this.colBirimFiyat.Name = "colBirimFiyat";
            this.colBirimFiyat.OptionsColumn.AllowEdit = false;
            this.colBirimFiyat.Visible = true;
            this.colBirimFiyat.VisibleIndex = 6;
            this.colBirimFiyat.Width = 58;
            // 
            // colEkMalzemeliFiyat
            // 
            this.colEkMalzemeliFiyat.Caption = "İndirimsiz Fiyat";
            this.colEkMalzemeliFiyat.DisplayFormat.FormatString = "C2";
            this.colEkMalzemeliFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEkMalzemeliFiyat.FieldName = "EkMalzemeliBirimFiyat";
            this.colEkMalzemeliFiyat.Name = "colEkMalzemeliFiyat";
            this.colEkMalzemeliFiyat.OptionsColumn.AllowEdit = false;
            this.colEkMalzemeliFiyat.Visible = true;
            this.colEkMalzemeliFiyat.VisibleIndex = 7;
            this.colEkMalzemeliFiyat.Width = 84;
            // 
            // colIndirim
            // 
            this.colIndirim.Caption = "İndirim";
            this.colIndirim.DisplayFormat.FormatString = "\'%\'0.00";
            this.colIndirim.FieldName = "Indirim";
            this.colIndirim.Name = "colIndirim";
            this.colIndirim.OptionsColumn.AllowEdit = false;
            this.colIndirim.Visible = true;
            this.colIndirim.VisibleIndex = 9;
            this.colIndirim.Width = 58;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "ToplamTutar";
            this.colToplamTutar.DisplayFormat.FormatString = "C2";
            this.colToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 10;
            this.colToplamTutar.Width = 81;
            // 
            // gridControlUrunHareket
            // 
            this.gridControlUrunHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUrunHareket.Location = new System.Drawing.Point(0, 91);
            this.gridControlUrunHareket.MainView = this.gridUrunHareket;
            this.gridControlUrunHareket.Name = "gridControlUrunHareket";
            this.gridControlUrunHareket.Size = new System.Drawing.Size(960, 330);
            this.gridControlUrunHareket.TabIndex = 14;
            this.gridControlUrunHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUrunHareket});
            // 
            // colEkMalzemeTutar
            // 
            this.colEkMalzemeTutar.Caption = "Ek Malzeme Tutarı";
            this.colEkMalzemeTutar.FieldName = "EkMalzemeFiyat";
            this.colEkMalzemeTutar.Name = "colEkMalzemeTutar";
            this.colEkMalzemeTutar.OptionsColumn.AllowEdit = false;
            this.colEkMalzemeTutar.Visible = true;
            this.colEkMalzemeTutar.VisibleIndex = 8;
            // 
            // FrmUrunHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 502);
            this.Controls.Add(this.gridControlUrunHareket);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmUrunHareketleri";
            this.Text = "Ürün Hareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunsecim2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunsecim2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunHareket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateGunSecim;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit dateGunsecim2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private UserControls.ControlAnaMenuAlt controlMenu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUrunHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunHareketTip;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colPorsiyon;
        private DevExpress.XtraGrid.Columns.GridColumn colBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colEkMalzemeliFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirim;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.GridControl gridControlUrunHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colEkMalzemeTutar;
    }
}