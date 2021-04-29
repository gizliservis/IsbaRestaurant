
namespace IsbaRestaurant.UI.BackOffice.Masa
{
    partial class FrmMasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasa));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.controlMenu = new IsbaRestaurant.UserControls.ControlAnaMenuAlt();
            this.gridControlMasa = new DevExpress.XtraGrid.GridControl();
            this.gridMasa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKonum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKapasite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMasa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.controlMenu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 421);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(960, 81);
            this.groupControl1.TabIndex = 6;
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
            // gridControlMasa
            // 
            this.gridControlMasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMasa.Location = new System.Drawing.Point(0, 46);
            this.gridControlMasa.MainView = this.gridMasa;
            this.gridControlMasa.Name = "gridControlMasa";
            this.gridControlMasa.Size = new System.Drawing.Size(960, 375);
            this.gridControlMasa.TabIndex = 7;
            this.gridControlMasa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMasa});
            // 
            // gridMasa
            // 
            this.gridMasa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasaAdi,
            this.colKonum,
            this.colKapasite,
            this.colAciklama});
            this.gridMasa.GridControl = this.gridControlMasa;
            this.gridMasa.Name = "gridMasa";
            // 
            // colMasaAdi
            // 
            this.colMasaAdi.Caption = "Masa Adı";
            this.colMasaAdi.FieldName = "Adi";
            this.colMasaAdi.Name = "colMasaAdi";
            this.colMasaAdi.OptionsColumn.AllowEdit = false;
            this.colMasaAdi.Visible = true;
            this.colMasaAdi.VisibleIndex = 0;
            this.colMasaAdi.Width = 240;
            // 
            // colKonum
            // 
            this.colKonum.Caption = "Konumu";
            this.colKonum.FieldName = "Konum.Adi";
            this.colKonum.Name = "colKonum";
            this.colKonum.OptionsColumn.AllowEdit = false;
            this.colKonum.Visible = true;
            this.colKonum.VisibleIndex = 1;
            this.colKonum.Width = 230;
            // 
            // colKapasite
            // 
            this.colKapasite.Caption = "Kapasite";
            this.colKapasite.FieldName = "Kapasite";
            this.colKapasite.Name = "colKapasite";
            this.colKapasite.OptionsColumn.AllowEdit = false;
            this.colKapasite.Visible = true;
            this.colKapasite.VisibleIndex = 2;
            this.colKapasite.Width = 88;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 3;
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
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Masalar";
            // 
            // FrmMasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 502);
            this.Controls.Add(this.gridControlMasa);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmMasa.IconOptions.Image")));
            this.Name = "FrmMasa";
            this.Text = "Masalar";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMasa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.ControlAnaMenuAlt controlMenu;
        private DevExpress.XtraGrid.GridControl gridControlMasa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMasa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colKonum;
        private DevExpress.XtraGrid.Columns.GridColumn colKapasite;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
    }
}