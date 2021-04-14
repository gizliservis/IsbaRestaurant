
namespace IsbaRestaurant.UI.BackOffice.Fotograf
{
    partial class FrmImageEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImageEditor));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAc = new DevExpress.XtraEditors.SimpleButton();
            this.btnKamera = new DevExpress.XtraEditors.SimpleButton();
            this.btnCevir = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAktar = new DevExpress.XtraEditors.SimpleButton();
            this.zoomTrackBarControl1 = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.spinEdit1);
            this.panelControl1.Controls.Add(this.zoomTrackBarControl1);
            this.panelControl1.Controls.Add(this.btnAktar);
            this.panelControl1.Controls.Add(this.btnKapat);
            this.panelControl1.Controls.Add(this.btnCevir);
            this.panelControl1.Controls.Add(this.btnKamera);
            this.panelControl1.Controls.Add(this.btnAc);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(749, 52);
            this.panelControl1.TabIndex = 0;
            // 
            // btnAc
            // 
            this.btnAc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAc.ImageOptions.Image")));
            this.btnAc.Location = new System.Drawing.Point(2, 2);
            this.btnAc.Name = "btnAc";
            this.btnAc.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAc.Size = new System.Drawing.Size(87, 48);
            this.btnAc.TabIndex = 0;
            this.btnAc.Text = "Aç";
            // 
            // btnKamera
            // 
            this.btnKamera.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKamera.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKamera.ImageOptions.Image")));
            this.btnKamera.Location = new System.Drawing.Point(89, 2);
            this.btnKamera.Name = "btnKamera";
            this.btnKamera.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKamera.Size = new System.Drawing.Size(87, 48);
            this.btnKamera.TabIndex = 1;
            this.btnKamera.Text = "Kamera";
            // 
            // btnCevir
            // 
            this.btnCevir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCevir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCevir.ImageOptions.Image")));
            this.btnCevir.Location = new System.Drawing.Point(176, 2);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCevir.Size = new System.Drawing.Size(86, 48);
            this.btnCevir.TabIndex = 2;
            this.btnCevir.Text = "Çevir";
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(660, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(87, 48);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            // 
            // btnAktar
            // 
            this.btnAktar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAktar.ImageOptions.Image")));
            this.btnAktar.Location = new System.Drawing.Point(575, 2);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAktar.Size = new System.Drawing.Size(85, 48);
            this.btnAktar.TabIndex = 4;
            this.btnAktar.Text = "Aktar";
            // 
            // zoomTrackBarControl1
            // 
            this.zoomTrackBarControl1.EditValue = 100;
            this.zoomTrackBarControl1.Location = new System.Drawing.Point(268, 21);
            this.zoomTrackBarControl1.Name = "zoomTrackBarControl1";
            this.zoomTrackBarControl1.Properties.Maximum = 500;
            this.zoomTrackBarControl1.Properties.Middle = 250;
            this.zoomTrackBarControl1.Properties.SmallChangeUseMode = DevExpress.XtraEditors.Repository.SmallChangeUseMode.ArrowKeysAndMouse;
            this.zoomTrackBarControl1.Size = new System.Drawing.Size(235, 16);
            this.zoomTrackBarControl1.TabIndex = 5;
            this.zoomTrackBarControl1.Value = 100;
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(509, 18);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Properties.MaxValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spinEdit1.Size = new System.Drawing.Size(60, 22);
            this.spinEdit1.TabIndex = 6;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 52);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
            this.pictureEdit1.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomingOperationMode = DevExpress.XtraEditors.Repository.ZoomingOperationMode.MouseWheel;
            this.pictureEdit1.Size = new System.Drawing.Size(749, 413);
            this.pictureEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.AppearancePressed.Options.UseTextOptions = true;
            this.labelControl1.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(0, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(300, 200);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "300X200\r\nLütfen Kesmek İstediğiniz Bölümü Çerçeve İçine Alınız";
            // 
            // FrmImageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 465);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmImageEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmImageEditor";
            this.Load += new System.EventHandler(this.FrmImageEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.ZoomTrackBarControl zoomTrackBarControl1;
        private DevExpress.XtraEditors.SimpleButton btnAktar;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnCevir;
        private DevExpress.XtraEditors.SimpleButton btnKamera;
        private DevExpress.XtraEditors.SimpleButton btnAc;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}