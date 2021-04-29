
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
            this.txtZoom = new DevExpress.XtraEditors.SpinEdit();
            this.zoomTrackBarControl1 = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.btnAktar = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnCevir = new DevExpress.XtraEditors.SimpleButton();
            this.btnKamera = new DevExpress.XtraEditors.SimpleButton();
            this.btnAc = new DevExpress.XtraEditors.SimpleButton();
            this.picFoto = new DevExpress.XtraEditors.PictureEdit();
            this.lblCerceve = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtZoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtZoom);
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
            // txtZoom
            // 
            this.txtZoom.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtZoom.Location = new System.Drawing.Point(509, 18);
            this.txtZoom.Name = "txtZoom";
            this.txtZoom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtZoom.Properties.Appearance.Options.UseFont = true;
            this.txtZoom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtZoom.Properties.MaxValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtZoom.Size = new System.Drawing.Size(60, 22);
            this.txtZoom.TabIndex = 6;
            this.txtZoom.EditValueChanged += new System.EventHandler(this.txtZoom_EditValueChanged);
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
            this.zoomTrackBarControl1.ValueChanged += new System.EventHandler(this.zoomTrackBarControl1_ValueChanged);
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
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
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
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
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
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
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
            this.btnKamera.Click += new System.EventHandler(this.btnKamera_Click);
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
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // picFoto
            // 
            this.picFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFoto.Location = new System.Drawing.Point(2, 2);
            this.picFoto.Name = "picFoto";
            this.picFoto.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
            this.picFoto.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
            this.picFoto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picFoto.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.picFoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picFoto.Properties.ZoomingOperationMode = DevExpress.XtraEditors.Repository.ZoomingOperationMode.MouseWheel;
            this.picFoto.Size = new System.Drawing.Size(745, 409);
            this.picFoto.TabIndex = 1;
            this.picFoto.ZoomPercentChanged += new System.EventHandler(this.picFoto_ZoomPercentChanged);
            // 
            // lblCerceve
            // 
            this.lblCerceve.AppearancePressed.Options.UseTextOptions = true;
            this.lblCerceve.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCerceve.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCerceve.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblCerceve.Location = new System.Drawing.Point(2, 2);
            this.lblCerceve.Name = "lblCerceve";
            this.lblCerceve.Size = new System.Drawing.Size(300, 200);
            this.lblCerceve.TabIndex = 2;
            this.lblCerceve.Text = "300X200\r\nLütfen Kesmek İstediğiniz Bölümü Çerçeve İçine Alınız";
            this.lblCerceve.Visible = false;
            this.lblCerceve.Click += new System.EventHandler(this.lblCerceve_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lblCerceve);
            this.panelControl2.Controls.Add(this.picFoto);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 52);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(749, 413);
            this.panelControl2.TabIndex = 3;
            // 
            // FrmImageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 465);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmImageEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resim Editör";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtZoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SpinEdit txtZoom;
        private DevExpress.XtraEditors.ZoomTrackBarControl zoomTrackBarControl1;
        private DevExpress.XtraEditors.SimpleButton btnAktar;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnCevir;
        private DevExpress.XtraEditors.SimpleButton btnKamera;
        private DevExpress.XtraEditors.SimpleButton btnAc;
        private DevExpress.XtraEditors.PictureEdit picFoto;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        public DevExpress.XtraEditors.LabelControl lblCerceve;
    }
}