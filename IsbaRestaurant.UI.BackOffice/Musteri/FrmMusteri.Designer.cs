
namespace IsbaRestaurant.UI.BackOffice.Musteri
{
    partial class FrmMusteri
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.controlMenu = new IsbaRestaurant.UserControls.ControlAnaMenuAlt();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlMusteri = new DevExpress.XtraGrid.GridControl();
            this.gridMusteri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSirket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.controlMenu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 421);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(960, 81);
            this.groupControl1.TabIndex = 3;
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
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(960, 46);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Müşteriler";
            // 
            // gridControlMusteri
            // 
            this.gridControlMusteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMusteri.Location = new System.Drawing.Point(0, 46);
            this.gridControlMusteri.MainView = this.gridMusteri;
            this.gridControlMusteri.Name = "gridControlMusteri";
            this.gridControlMusteri.Size = new System.Drawing.Size(960, 375);
            this.gridControlMusteri.TabIndex = 4;
            this.gridControlMusteri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMusteri});
            // 
            // gridMusteri
            // 
            this.gridMusteri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdi,
            this.colSoyadi,
            this.colSirket,
            this.colKartNo});
            this.gridMusteri.GridControl = this.gridControlMusteri;
            this.gridMusteri.Name = "gridMusteri";
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 1;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 2;
            // 
            // colSirket
            // 
            this.colSirket.Caption = "Şirket Adı";
            this.colSirket.FieldName = "Sirket";
            this.colSirket.Name = "colSirket";
            this.colSirket.Visible = true;
            this.colSirket.VisibleIndex = 3;
            // 
            // colKartNo
            // 
            this.colKartNo.Caption = "Kart No";
            this.colKartNo.FieldName = "KartNo";
            this.colKartNo.Name = "colKartNo";
            this.colKartNo.Visible = true;
            this.colKartNo.VisibleIndex = 0;
            // 
            // FrmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 502);
            this.Controls.Add(this.gridControlMusteri);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmMusteri";
            this.Text = "FrmMusteri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlMusteri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMusteri;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colSirket;
        private DevExpress.XtraGrid.Columns.GridColumn colKartNo;
        private UserControls.ControlAnaMenuAlt controlMenu;
    }
}