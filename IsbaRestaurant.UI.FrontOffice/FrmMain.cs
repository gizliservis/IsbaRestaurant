﻿using DevExpress.XtraEditors;
using IsbaRestaurant.Core.Extensions;
using IsbaRestaurant.Business.Workers;
using IsbaRestaurant.Entities.Dtos;
using IsbaRestaurant.Entities.Enums;
using IsbaRestaurant.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IsbaRestaurant.Entities.Tables;
using DevExpress.XtraGrid.Views.Layout;
using System.Data.Entity;

namespace IsbaRestaurant.UI.FrontOffice
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        enum KeypadIslem
        {
            Yok,
            FiyatDegistir,
            Iade,
            Ikram,
            Bol,
            Indirim

        }
        RestaurantWorker worker = new RestaurantWorker();
        UrunHareket urunHareketEntity;
        private KeypadIslem keypadIslem = KeypadIslem.Yok;
        public FrmMain()
        {
            InitializeComponent();
            KategoriButtonOlustur();
            gridControl1.DataSource = worker.UrunHareketService.BindingList();
            MasaButtonOlustur();

        }
        void MasaButtonOlustur()
        {
            foreach (var konum in worker.TanimService.GetList(c=>c.TanimTip==TanimTip.Konum))
            {
                ControlKonumButton button = new ControlKonumButton
                {
                    Name = konum.Id.ToString(),
                    Text = konum.Adi,
                    Height = 72,
                    Width = 130,
                    GroupIndex=1,
                    Masalar=worker.MasaService.GetList(c=>c.KonumId==konum.Id)

                };
                button.CheckedChanged += KonumSecim;
                flowKonum.Controls.Add(button);
            }
        }

        private void KonumSecim(object sender, EventArgs e)
        {
            ControlKonumButton button = (ControlKonumButton)sender;
            flowMasalar.Controls.Clear();
            foreach (var masa in button.Masalar)
            {
                SimpleButton masaButton = new SimpleButton
                {
                    Name = masa.Id.ToString(),
                    Text = masa.Adi,
                    Height = 150,
                    Width = 150
                };
                flowMasalar.Controls.Add(masaButton);
            }
        }

        private void MiktarArttir(int sayi)
        {
            UrunHareket row = (UrunHareket)layoutView1.GetFocusedRow();
            if (row==null)
            {
                return;
            }
            if (sayi<0&&row.Miktar<=1)
            {
                return;
            }
            row.Miktar +=sayi;
            layoutView1.RefreshData();
        }
        private void KategoriButtonOlustur()
        {
            foreach (var Kategori in worker.TanimService.Select(c => c.TanimTip == TanimTip.UrunGrup, c => new KategoriDto { Id = c.Id, Adi = c.Adi }).ToList())
            {
                ControlKategoriButton button = new ControlKategoriButton
                {
                    Name = Kategori.Id.ToString(),
                    Text = Kategori.Adi,
                    Id = Kategori.Id,
                    Urunler = worker.UrunService.GetList(c => c.UrunGrupId == Kategori.Id, c => c.Porsiyonlar, c => c.EkMalzemeler),
                    GroupIndex = 1,
                    Height = 60,
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    Width = flowKategori.Width - 6
                };
                button.CheckedChanged += KategoriSecim;
                flowKategori.Controls.Add(button);
            }
        }

        private void KategoriSecim(object sender, EventArgs e)
        {
            flowKategoriUrunleri.Controls.Clear();
            ControlKategoriButton button = (ControlKategoriButton)sender;
            foreach (var item in button.Urunler)
            {

                ControlKategoriUrun urunButton = new ControlKategoriUrun
                {

                    Name = item.Id.ToString(),
                    UrunAdi = item.Adi,
                    Id = item.Id,
                    UrunImage = item.Fotograf.ByteArrayToImage(),
                    Height = 160,
                    Width = 160,
                    Porsiyonlar = item.Porsiyonlar,
                    EkMalzemeler = item.EkMalzemeler


                };
                urunButton.ButtonClick += UrunClick;
                flowKategoriUrunleri.Controls.Add(urunButton);

            }
        }

        private void UrunClick(object sender, EventArgs e)
        {

            ControlKategoriUrun button = (ControlKategoriUrun)sender;
            if (!button.Porsiyonlar.Any())
            {
                MessageBox.Show("Bu Ürüne Atanmış Bir Porsiyon Bulunamadı");
                return;
            }
            btnKategoriyeDon.Visible = true;
            flowPorsiyon.Controls.Clear();
            urunHareketEntity = new UrunHareket();
            //Silinecek
            Adisyon entity = new Adisyon();
            entity.Id = Guid.NewGuid();
            worker.AdisyonService.Add(entity);
            urunHareketEntity.AdisyonId = entity.Id;
            //Silinecek
            urunHareketEntity.Id = Guid.NewGuid();
            urunHareketEntity.UrunId = button.Id;
            urunHareketEntity.Miktar = txtMiktar.Value;
            urunHareketEntity.UrunHareketTip = UrunHareketTip.Satis;
            navigationKategori.SelectedPage = pageUrunPorsiyon;
            foreach (var porsiyon in button.Porsiyonlar)
            {
                ControlPorsiyonButton porsiyonButton = new ControlPorsiyonButton
                {
                    Name = porsiyon.Id.ToString(),
                    Text = porsiyon.Adi + "\n" + porsiyon.Fiyat.ToString("C2"),
                    Fiyat = porsiyon.Fiyat,
                    EkMalzemeCarpan = porsiyon.EkMalzemeCarpan,
                    Id = porsiyon.Id,
                    Height = 200,
                    Width = 200,
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    EkMalzemeler = button.EkMalzemeler


                };
                porsiyonButton.Click += PorsiyonClick;
                flowPorsiyon.Controls.Add(porsiyonButton);
            }
            if (button.Porsiyonlar.Count() == 1)
            {
                ControlPorsiyonButton buttonPorsiyon = (ControlPorsiyonButton)flowPorsiyon.Controls[0];
                buttonPorsiyon.PerformClick();
            }

        }

        private void PorsiyonClick(object sender, EventArgs e)
        {

            ControlPorsiyonButton button = (ControlPorsiyonButton)sender;
            urunHareketEntity.PorsiyonId = button.Id;
            urunHareketEntity.BirimFiyat = button.Fiyat;
            txtPorsiyonTutar.Value = button.Fiyat;
            if (!button.EkMalzemeler.Any())
            {

                UrunHareketEkle();
                navigationKategori.SelectedPage = pageKategoriUrunler;
                return;
            }
            EkMalzemeButtonOlustur(button.EkMalzemeCarpan,button.EkMalzemeler);
            txtToplamTutar.Value = txtPorsiyonTutar.Value + txtEkMalzemeTutar.Value;

           

        }
        void EkMalzemeButtonOlustur(decimal EkMalzemeCarpan,IEnumerable<EkMalzeme> EkmalzemeList)
        {
            flowEkMalzeme.Controls.Clear();
            foreach (var malzeme in EkmalzemeList)
            {

                ControlEkMalzemeButton MalzemeButton = new ControlEkMalzemeButton
                {
                    Name = malzeme.Id.ToString(),
                    Text = malzeme.EkmalzemeAdi + "\n" + (malzeme.Fiyat * EkMalzemeCarpan).ToString("C2"),
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    Height = 200,
                    Width = 200,
                    Id = malzeme.Id,
                    Fiyat = malzeme.Fiyat * EkMalzemeCarpan
                };
                MalzemeButton.CheckedChanged += MalzemeCheckedChanged;
                flowEkMalzeme.Controls.Add(MalzemeButton);
            }

            navigationKategori.SelectedPage = pageEkMalzeme;
        }

        private void MalzemeCheckedChanged(object sender, EventArgs e)
        {
            EkMalzemeHesapla();
        }

        private void btnEkMalzemeOnay_Click(object sender, EventArgs e)
        {
            foreach (ControlEkMalzemeButton button in flowEkMalzeme.Controls)
            {
                if (button.Checked)
                {
                    
                    worker.EkMalzemeHareketService.AddOrUpdate(new EkMalzemeHareket
                    {
                        Id = Guid.NewGuid(),
                        UrunHareketId = urunHareketEntity.Id,
                        EkMalzemeId = button.Id,
                        Fiyat = button.Fiyat
                    }) ;
                }
                else
                {
                    worker.EkMalzemeHareketService.EntityStateChange(c => c.UrunHareketId == urunHareketEntity.Id && c.EkMalzemeId == button.Id, EntityState.Deleted);
                }
            }
            EkMalzemeHesapla();
            urunHareketEntity.BirimFiyat = txtToplamTutar.Value;
            UrunHareketEkle();
            navigationKategori.SelectedPage = pageKategoriUrunler;
            txtMiktar.Value = 1;
        }
        void UrunHareketEkle()
        {
            btnKategoriyeDon.Visible = false;
            worker.UrunHareketService.AddOrUpdate(urunHareketEntity);
            worker.UrunService.Load(c => c.Id == urunHareketEntity.UrunId);
            worker.PorsiyonService.Load(c => c.Id == urunHareketEntity.PorsiyonId);
            Guid id = urunHareketEntity.Porsiyon.BirimId;
            worker.TanimService.Load(c => c.Id == id);
            layoutView1.RefreshData();
        }
        void EkMalzemeHesapla()
        {
            txtEkMalzemeTutar.Value = 0;
            foreach (ControlEkMalzemeButton button in flowEkMalzeme.Controls)
            {
                if (button.Checked)
                {
                    txtEkMalzemeTutar.Value += button.Fiyat;
                }
            }
            txtToplamTutar.Value = txtPorsiyonTutar.Value + txtEkMalzemeTutar.Value;
                
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
       
            
     
        }

        private void layoutView1_CustomCardStyle(object sender, DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCardStyleEventArgs e)
        {
            LayoutView view = (LayoutView)sender;
            UrunHareket row = (UrunHareket)view.GetRow(e.RowHandle);
            if (view.FocusedRowHandle == e.RowHandle)
            {
                e.Appearance.BackColor = Color.DarkSeaGreen;
                return;
            }
            switch (row.UrunHareketTip)
            {
                case UrunHareketTip.Satis:
                    e.Appearance.BackColor = Color.PaleTurquoise;
                    break;
                case UrunHareketTip.Iptal:
                    e.Appearance.BackColor = Color.Tomato;
                    break;
                case UrunHareketTip.Ikram:
                    e.Appearance.BackColor = Color.MediumSpringGreen;
                    break;
                default:
                    break;
            }
        }

        private void KeyPadSend(object sender, EventArgs e)
        {
            SimpleButton button = (SimpleButton)sender;
            txtMiktar.Focus();
            SendKeys.Send(button.Text);
        }

        private void btnKategoriyeDon_Click(object sender, EventArgs e)
        {
            navigationKategori.SelectedPage = pageKategoriUrunler;
            btnKategoriyeDon.Visible = false;
            txtPorsiyonTutar.Value = 0;
            txtEkMalzemeTutar.Value = 0;
            txtMiktar.Value = 1;
        }

        private void btnMiktarArttir_Click(object sender, EventArgs e)
        {
            MiktarArttir(1);
        }

        private void btnMiktarAzalt_Click(object sender, EventArgs e)
        {
            MiktarArttir(-1);
        }

        private void btnFiyatDegistir_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow()==null)
            {
                return;
            }
            keypadIslem = KeypadIslem.FiyatDegistir;
            txtMiktar.Value = 0;
            txtMiktar.BackColor = Color.Green;
            txtMiktar.Properties.NullValuePrompt = "Lütfen Yeni Fiyat Giriniz";
        }

        private void btnKeypadOk_Click(object sender, EventArgs e)
        {
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            switch (keypadIslem)
            {
            
                case KeypadIslem.FiyatDegistir:
                    hareketEntity.BirimFiyat = txtMiktar.Value;
                    layoutView1.RefreshData();
                    break;
                case KeypadIslem.Iade:
                    if (hareketEntity.Miktar ==txtMiktar.Value)
                    {
                        hareketEntity.UrunHareketTip = UrunHareketTip.Iptal;
                    }
                    else if (hareketEntity.Miktar < txtMiktar.Value)
                    {
                        MessageBox.Show($"{hareketEntity.Miktar} Miktarından Daha Fazla İade Yapılamaz");
                        return;
                    }
                    else
                    {
                        UrunHareket yeniEntity = hareketEntity.Clone();
                        yeniEntity.Id = Guid.NewGuid();
                        yeniEntity.UrunHareketTip = UrunHareketTip.Iptal;
                        yeniEntity.Miktar = txtMiktar.Value;
                        worker.UrunHareketService.AddOrUpdate(yeniEntity);
                        hareketEntity.Miktar -= txtMiktar.Value;
                        
                        
                    }
                    layoutView1.RefreshData();
                    break;
                case KeypadIslem.Ikram:
                    if (hareketEntity.Miktar==txtMiktar.Value)
                    {
                        hareketEntity.UrunHareketTip = UrunHareketTip.Ikram;

                    }
                    else if (hareketEntity.Miktar<txtMiktar.Value)
                    {
                        MessageBox.Show($"{hareketEntity.Miktar} Miktarından Daha Fazla İkram Yapılamaz");
                    }
                    else
                    {
                        UrunHareket yeniEntity = hareketEntity.Clone();
                        yeniEntity.Id = Guid.NewGuid();
                        yeniEntity.UrunHareketTip = UrunHareketTip.Ikram;
                        yeniEntity.Miktar = txtMiktar.Value;
                        worker.UrunHareketService.AddOrUpdate(yeniEntity);
                        hareketEntity.Miktar -= txtMiktar.Value;
                    }
                    
                    layoutView1.RefreshData();
                    break;
                case KeypadIslem.Bol:
                    if (hareketEntity.Miktar == txtMiktar.Value)
                    {
                        MessageBox.Show("Miktar Alanı İle Yeni Girilen Alan Eşit Olamaz");


                    }
                    else
                    {
                        UrunHareket yeniEntity = hareketEntity.Clone();
                        yeniEntity.Id = Guid.NewGuid();
                        yeniEntity.Miktar = txtMiktar.Value;
                        worker.UrunHareketService.AddOrUpdate(yeniEntity);
                        hareketEntity.Miktar -= txtMiktar.Value;
                    }
                    layoutView1.RefreshData();

                    break;
                case KeypadIslem.Indirim:
                    if (txtMiktar.Value<0 || txtMiktar.Value>100)
                    {
                        MessageBox.Show("Girdiğiniz İndirim Oranı 0 İle 100 Arasında Olmalı");
                        return;
                    }
                    hareketEntity.Indirim = txtMiktar.Value;
                    layoutView1.RefreshData();
                    break;
                
            }
            keypadIslem = KeypadIslem.Yok;
            txtMiktar.Value = 1;
            txtMiktar.BackColor = Color.White;
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null) return;
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (hareketEntity.UrunHareketTip == UrunHareketTip.Iptal)
            {
                MessageBox.Show("Seçtiğiniz Ürün Zaten İptal Edilmiş");
            }

            else if (hareketEntity.Miktar == 1)
            {
                hareketEntity.UrunHareketTip = UrunHareketTip.Iptal;
                layoutView1.RefreshData();
            }
            else
            {
                keypadIslem = KeypadIslem.Iade;
                txtMiktar.BackColor = Color.YellowGreen;
                txtMiktar.Properties.NullValuePrompt = "Lürfen İade Edilecek Miktarı Giriniz..";
            }
        }

        private void btnIkram_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null) return;
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (hareketEntity.Miktar==1)
            {
                hareketEntity.UrunHareketTip = UrunHareketTip.Ikram;
                layoutView1.RefreshData();
            }
            else
            {
                keypadIslem = KeypadIslem.Ikram;
                txtMiktar.BackColor = Color.Green;
                txtMiktar.Properties.NullValuePrompt = "Lütfen İkram Edilecek Miktarı Giriniz";
            }

        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null) return;
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (hareketEntity.Miktar==1)
            {
                MessageBox.Show("Miktarınız Bölünmeye Uygun Değil");
            }
            else
            {
                keypadIslem = KeypadIslem.Bol;
                txtMiktar.BackColor = Color.Green;
                txtMiktar.Properties.NullValuePrompt = "Lütfen Bölünecek miktarı Giriniz";
            }

        }

        private void btnEkMalzeme_Click(object sender, EventArgs e)
        {
            urunHareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (urunHareketEntity==null)
            {
                return;
            }
            Porsiyon porsiyonEntity = worker.PorsiyonService.Get(c => c.Id == urunHareketEntity.PorsiyonId);
            IEnumerable<EkMalzeme> ekMalzemeList = worker.EkMalzemeService.GetList(c => c.UrunId == urunHareketEntity.UrunId);
            EkMalzemeButtonOlustur(porsiyonEntity.EkMalzemeCarpan, ekMalzemeList);
            List<EkMalzemeHareket> HareketList = worker.EkMalzemeHareketService.BindingList().ToList();
            foreach (var hareket in HareketList.Where(c => c.UrunHareketId == urunHareketEntity.Id).ToList())
            {
                ControlEkMalzemeButton button = (ControlEkMalzemeButton)flowEkMalzeme.Controls.Find(hareket.EkMalzemeId.ToString(), true)[0];
                button.Checked = true;
            }
        }

        private void btnIndirim_Click(object sender, EventArgs e)
        {
            UrunHareket entity= (UrunHareket)layoutView1.GetFocusedRow();
            if (entity==null)
            {
                return;
            }
            keypadIslem = KeypadIslem.Indirim;
            txtMiktar.BackColor = Color.Red;
            txtMiktar.Properties.NullValuePrompt = "Lütfen İndirim Oranını Giriniz";
        }
    }
}
