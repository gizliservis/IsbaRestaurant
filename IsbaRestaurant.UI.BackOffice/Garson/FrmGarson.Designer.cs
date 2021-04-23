
namespace IsbaRestaurant.UI.BackOffice.Garson
{
    partial class FrmGarson
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
            this.gridControlGarson = new DevExpress.XtraGrid.GridControl();
            this.gridGarson = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.controlMenu = new IsbaRestaurant.UserControls.ControlAnaMenuAlt();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGarson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGarson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlGarson
            // 
            this.gridControlGarson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGarson.Location = new System.Drawing.Point(0, 46);
            this.gridControlGarson.MainView = this.gridGarson;
            this.gridControlGarson.Name = "gridControlGarson";
            this.gridControlGarson.Size = new System.Drawing.Size(960, 375);
            this.gridControlGarson.TabIndex = 7;
            this.gridControlGarson.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridGarson});
            // 
            // gridGarson
            // 
            this.gridGarson.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdi,
            this.colSoyadi,
            this.colAciklama});
            this.gridGarson.GridControl = this.gridControlGarson;
            this.gridGarson.Name = "gridGarson";
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 0;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 1;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
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
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Garsonlar";
            // 
            // FrmGarson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 502);
            this.Controls.Add(this.gridControlGarson);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmGarson";
            this.Text = "FrmGarson";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGarson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGarson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlGarson;
        private DevExpress.XtraGrid.Views.Grid.GridView gridGarson;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.ControlAnaMenuAlt controlMenu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}