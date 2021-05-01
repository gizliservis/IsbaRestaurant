
namespace IsbaRestaurant.UI.BackOffice.OdemeHareketleri
{
    partial class FrmOdemeHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeHareketleri));
            this.gridControlOdemeHareket = new DevExpress.XtraGrid.GridControl();
            this.gridOdemeHareketleri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOdemeTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeSekli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateGunSecim = new DevExpress.XtraEditors.DateEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dateGunsecim2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.controlMenu = new IsbaRestaurant.UserControls.ControlAnaMenuAlt();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdemeHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeHareketleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunsecim2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunsecim2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlOdemeHareket
            // 
            this.gridControlOdemeHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOdemeHareket.Location = new System.Drawing.Point(0, 101);
            this.gridControlOdemeHareket.MainView = this.gridOdemeHareketleri;
            this.gridControlOdemeHareket.Name = "gridControlOdemeHareket";
            this.gridControlOdemeHareket.Size = new System.Drawing.Size(960, 320);
            this.gridControlOdemeHareket.TabIndex = 14;
            this.gridControlOdemeHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridOdemeHareketleri});
            // 
            // gridOdemeHareketleri
            // 
            this.gridOdemeHareketleri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOdemeTarih,
            this.colSaat,
            this.colOdemeTuru,
            this.colOdemeSekli,
            this.colOdemeTutar});
            this.gridOdemeHareketleri.GridControl = this.gridControlOdemeHareket;
            this.gridOdemeHareketleri.GroupCount = 1;
            this.gridOdemeHareketleri.Name = "gridOdemeHareketleri";
            this.gridOdemeHareketleri.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colOdemeTuru, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colOdemeTarih
            // 
            this.colOdemeTarih.Caption = "Ödeme Tarihi";
            this.colOdemeTarih.DisplayFormat.FormatString = "d";
            this.colOdemeTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOdemeTarih.FieldName = "EklenmeTarihi";
            this.colOdemeTarih.Name = "colOdemeTarih";
            this.colOdemeTarih.OptionsColumn.AllowEdit = false;
            this.colOdemeTarih.Visible = true;
            this.colOdemeTarih.VisibleIndex = 0;
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
            // 
            // colOdemeTuru
            // 
            this.colOdemeTuru.Caption = "Ödeme Türü";
            this.colOdemeTuru.FieldName = "OdemeTuru.Adi";
            this.colOdemeTuru.Name = "colOdemeTuru";
            this.colOdemeTuru.OptionsColumn.AllowEdit = false;
            this.colOdemeTuru.Visible = true;
            this.colOdemeTuru.VisibleIndex = 2;
            // 
            // colOdemeSekli
            // 
            this.colOdemeSekli.Caption = "Ödeme Şekli";
            this.colOdemeSekli.FieldName = "OdemeTuru.OdemeTur.Adi";
            this.colOdemeSekli.Name = "colOdemeSekli";
            this.colOdemeSekli.OptionsColumn.AllowEdit = false;
            this.colOdemeSekli.Visible = true;
            this.colOdemeSekli.VisibleIndex = 2;
            // 
            // colOdemeTutar
            // 
            this.colOdemeTutar.Caption = "Tutar";
            this.colOdemeTutar.DisplayFormat.FormatString = "C2";
            this.colOdemeTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOdemeTutar.FieldName = "Tutar";
            this.colOdemeTutar.Name = "colOdemeTutar";
            this.colOdemeTutar.OptionsColumn.AllowEdit = false;
            this.colOdemeTutar.Visible = true;
            this.colOdemeTutar.VisibleIndex = 3;
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
            this.panelControl1.Location = new System.Drawing.Point(0, 56);
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
            this.labelControl1.Size = new System.Drawing.Size(960, 56);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Adisyon Hareketleri";
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
            // FrmOdemeHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 502);
            this.Controls.Add(this.gridControlOdemeHareket);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmOdemeHareketleri.IconOptions.Image")));
            this.Name = "FrmOdemeHareketleri";
            this.Text = "Ödeme Hareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdemeHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeHareketleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunsecim2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunsecim2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
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
        private DevExpress.XtraGrid.GridControl gridControlOdemeHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridOdemeHareketleri;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeSekli;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTutar;
    }
}