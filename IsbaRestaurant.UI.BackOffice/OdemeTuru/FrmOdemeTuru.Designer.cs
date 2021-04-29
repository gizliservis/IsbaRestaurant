
namespace IsbaRestaurant.UI.BackOffice.OdemeTuru
{
    partial class FrmOdemeTuru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeTuru));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.controlMenu = new IsbaRestaurant.UserControls.ControlAnaMenuAlt();
            this.gridControlOdemeTuru = new DevExpress.XtraGrid.GridControl();
            this.gridOdemeTuru = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdemeTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeTuru)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.controlMenu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 421);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(960, 81);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Menü";
            // 
            // controlMenu
            // 
            this.controlMenu.ButtonFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.controlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMenu.Location = new System.Drawing.Point(2, 23);
            this.controlMenu.Name = "controlMenu";
            this.controlMenu.Size = new System.Drawing.Size(956, 56);
            this.controlMenu.TabIndex = 0;
            this.controlMenu.ButonEkle += new System.EventHandler(this.controlMenu_ButonEkle);
            this.controlMenu.ButonDuzenle += new System.EventHandler(this.controlMenu_ButonDuzenle);
            this.controlMenu.ButonSil += new System.EventHandler(this.controlMenu_ButonSil);
            this.controlMenu.ButonGuncelle += new System.EventHandler(this.controlMenu_ButonGuncelle);
            this.controlMenu.ButonKapat += new System.EventHandler(this.controlMenu_ButonKapat);
            // 
            // gridControlOdemeTuru
            // 
            this.gridControlOdemeTuru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOdemeTuru.Location = new System.Drawing.Point(0, 46);
            this.gridControlOdemeTuru.MainView = this.gridOdemeTuru;
            this.gridControlOdemeTuru.Name = "gridControlOdemeTuru";
            this.gridControlOdemeTuru.Size = new System.Drawing.Size(960, 375);
            this.gridControlOdemeTuru.TabIndex = 10;
            this.gridControlOdemeTuru.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridOdemeTuru});
            // 
            // gridOdemeTuru
            // 
            this.gridOdemeTuru.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdi,
            this.colOdemeTuru,
            this.colAciklama});
            this.gridOdemeTuru.GridControl = this.gridControlOdemeTuru;
            this.gridOdemeTuru.Name = "gridOdemeTuru";
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.OptionsColumn.AllowEdit = false;
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 0;
            this.colAdi.Width = 240;
            // 
            // colOdemeTuru
            // 
            this.colOdemeTuru.Caption = "Ödeme Türü";
            this.colOdemeTuru.FieldName = "OdemeTur.Adi";
            this.colOdemeTuru.Name = "colOdemeTuru";
            this.colOdemeTuru.OptionsColumn.AllowEdit = false;
            this.colOdemeTuru.Visible = true;
            this.colOdemeTuru.VisibleIndex = 1;
            this.colOdemeTuru.Width = 230;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            this.colAciklama.Width = 377;
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
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Ödeme Türleri";
            // 
            // FrmOdemeTuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 502);
            this.Controls.Add(this.gridControlOdemeTuru);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmOdemeTuru.IconOptions.Image")));
            this.Name = "FrmOdemeTuru";
            this.Text = "Ödeme Türü";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdemeTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeTuru)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.ControlAnaMenuAlt controlMenu;
        private DevExpress.XtraGrid.GridControl gridControlOdemeTuru;
        private DevExpress.XtraGrid.Views.Grid.GridView gridOdemeTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}