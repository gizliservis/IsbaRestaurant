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
            Indirim,
            OdemeBol

        }
        RestaurantWorker worker = new RestaurantWorker();
        UrunHareket urunHareketEntity;
        private Adisyon secilenAdisyon;
        private Masa secilenMasa;
        private KeypadIslem keypadIslem = KeypadIslem.Yok;
        public FrmMain()
        {
            InitializeComponent();
            KategoriButtonOlustur();
            MasaButtonOlustur();
            GarsonButtonOlustur();
            MusteriButtonOlustur();
            OdemeTuruButtonOlustur();
        }
        void OdemeTuruButtonOlustur()
        {
            foreach (var odemeTuru in worker.OdemeTuruService.GetList(null))
            {
                ControlOdemeTuruButton button = new ControlOdemeTuruButton
                {
                    Name = odemeTuru.Id.ToString(),
                    Text = odemeTuru.Adi,
                    OdemeTuruId = odemeTuru.Id,
                    Height = 50,
                    Width = 100,
                    Font = new Font("Tahoma", 8, FontStyle.Bold),
                    Appearance = { TextOptions = { WordWrap = DevExpress.Utils.WordWrap.Wrap } }
                };
                button.Click += OdemeButtonClick;
                flowOdemeTurleri.Controls.Add(button);
            }
        }

        private void OdemeButtonClick(object sender, EventArgs e)
        {
            ControlOdemeTuruButton button = (ControlOdemeTuruButton)sender;
            if (txtKalanTutar.Value == 0)
            {
                return;
            }
            if (txtOdemeTutari.Value<=0)
            {
                return;
            }
            worker.OdemeTuruService.Load(c => c.Id == button.OdemeTuruId);
            worker.OdemeHareketService.AddOrUpdate(new OdemeHareket
            {
                AdisyonId = secilenAdisyon.Id,
                OdemeTuruId = button.OdemeTuruId,
                Tutar = txtOdemeTutari.Value
            });
            UrunHareketToplamlariGetir();
            txtOdemeTutari.Value = 0;
            if (txtKalanTutar.Value<0)
            {
                lblMesaj.Visible = true;
               lblMesaj.Text=$"Müşteriye Ödenicek Para Üstü{Math.Abs(txtKalanTutar.Value).ToString("C2")}'dir";
            }
        }

        void MusteriButtonOlustur()
        {
            foreach (var musteri in worker.MusteriService.GetList(null))
            {
                ControlMusteriButton button = new ControlMusteriButton
                {
                    Name = musteri.Id.ToString(),
                    Text = $"{musteri.Adi} {musteri.Soyadi}",
                    Adi = musteri.Adi,
                    Soyadi = musteri.Soyadi,
                    MusteriId = musteri.Id,
                    MusteriTip = musteri.MusteriTip,
                    Height = 150,
                    Width = 150

                };
                button.Load();
                button.Click += MusteriSec;
                flowMusteri.Controls.Add(button);
            }
        }

        private void MusteriSec(object sender, EventArgs e)
        {
            ControlMusteriButton button = (ControlMusteriButton)sender;
            btnMusteri.MusteriId = button.MusteriId;
            btnMusteri.Adi = button.Adi;
            btnMusteri.Soyadi = button.Soyadi;
            btnMusteri.MusteriTip = button.MusteriTip;
            btnMusteri.Load();
            navigationKategori.SelectedPage = pageKategoriUrunler;
        }

        void GarsonButtonOlustur()
        {
            foreach (var garson in worker.GarsonService.GetList(null))
            {
                ControlGarsonCheckButton button = new ControlGarsonCheckButton
                {
                    Name = garson.Id.ToString(),
                    Text = $"{garson.Adi} {garson.Soyadi}",
                    Height = 150,
                    Width = 150,
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    GroupIndex = 1,
                    GarsonId = garson.Id,
                    Adi = garson.Adi,
                    Soyadi = garson.Soyadi
                };
                button.CheckedChanged += GarsonSecim;
                flowGarson.Controls.Add(button);
            }
        }

        private void GarsonSecim(object sender, EventArgs e)
        {
            ControlGarsonCheckButton button = (ControlGarsonCheckButton)sender;
            btnGarsonSecim.Adi = button.Adi;
            btnGarsonSecim.Soyadi = button.Soyadi;
            btnGarsonSecim.GarsonId = button.GarsonId;
            secilenAdisyon.GarsonId = button.GarsonId;
            navigationKategori.SelectedPage = pageKategoriUrunler;
        }

        void MasaButtonOlustur()
        {
            foreach (var konum in worker.TanimService.GetList(c => c.TanimTip == TanimTip.Konum))
            {
                ControlKonumButton button = new ControlKonumButton
                {
                    Name = konum.Id.ToString(),
                    Text = konum.Adi,
                    Height = 72,
                    Width = 130,
                    GroupIndex = 1,
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    Masalar = worker.MasaService.GetList(c => c.KonumId == konum.Id)

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
                ControlMasaButton masaButton = new ControlMasaButton()
                {
                    Name = masa.Id.ToString(),
                    Text = masa.Adi + "\n" + masa.Kapasite.ToString() + " Kişi",
                    Height = 150,
                    Width = 150,
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    MasaId = masa.Id
                };
                masaButton.Click += MasaSec;
                flowMasalar.Controls.Add(masaButton);
            }
            foreach (var adisyon in worker.AdisyonService.GetList(c => c.AdisyonAcik))
            {
                ControlMasaButton buttonMasa = flowMasalar.Controls.Cast<ControlMasaButton>().SingleOrDefault(c => c.MasaId == adisyon.MasaId);
                if (buttonMasa != null)
                {
                    buttonMasa.MasaDurum = MasaDurum.Dolu;
                    buttonMasa.AdisyonId = adisyon.Id;
                }

            }
        }

        private void MasaSec(object sender, EventArgs e)
        {
            ControlMasaButton button = (ControlMasaButton)sender;
            btnGarsonSecim.Visible = true;
            btnMusteri.Visible = true;
            gridControl1.DataSource = worker.UrunHareketService.BindingList();
            gridControlOdeme.DataSource = worker.OdemeHareketService.BindingList();
            navigationKategori.SelectedPage = pageKategoriUrunler;
            if (button.MasaDurum == MasaDurum.Bos)
            {
                secilenAdisyon = new Adisyon();
                secilenAdisyon.Id = Guid.NewGuid();
                secilenMasa = worker.MasaService.Get(c => c.Id == button.MasaId);
                secilenAdisyon.MasaId = button.MasaId;
                btnGarsonSecim.Text = "Garson Seçilmedi";
                button.AdisyonId = secilenAdisyon.Id;
                btnMusteri.Load();
                ToplamlarıSifirla();
                btnMusteri.Clear();

                navigationMain.SelectedPage = pageAdisyonAyrinti;
            }
            else if (button.MasaDurum == MasaDurum.Dolu)
            {
                worker.UrunHareketService.Load(c => c.AdisyonId == button.AdisyonId, c => c.Urun, c => c.Porsiyon, c => c.Porsiyon.Birim, c => c.EkMalzemeHareketleri);
                worker.AdisyonService.Load(c => c.Id == button.AdisyonId);
                worker.OdemeHareketService.Load(c => c.AdisyonId == button.AdisyonId, c => c.OdemeTuru);
                worker.EkMalzemeHareketService.Load(null);
                secilenAdisyon = worker.AdisyonService.Get(c => c.Id == button.AdisyonId);
                secilenMasa = worker.MasaService.Get(c => c.Id == button.MasaId);
                Garson garson = worker.GarsonService.Get(c => c.Id == secilenAdisyon.GarsonId);
                if (garson != null)
                {

                    btnGarsonSecim.Adi = garson.Adi;
                    btnGarsonSecim.Soyadi = garson.Soyadi;
                    btnGarsonSecim.GarsonId = garson.Id;
                }
                else
                {
                    btnGarsonSecim.Text = "Garson Seçilmedi";
                }
                if (secilenAdisyon.MusteriId != Guid.Empty)
                {
                    Musteri musteri = worker.MusteriService.Get(c => c.Id == secilenAdisyon.MusteriId);
                    if (musteri != null)
                    {
                        btnMusteri.MusteriId = musteri.Id;
                        btnMusteri.Adi = musteri.Adi;
                        btnMusteri.Soyadi = musteri.Soyadi;
                        btnMusteri.MusteriTip = musteri.MusteriTip;
                        btnMusteri.Load();

                    }
                }

                button.AdisyonId = secilenAdisyon.Id;
                navigationMain.SelectedPage = pageAdisyonAyrinti;
                layoutView1.RefreshData();
                UrunHareketToplamlariGetir();
            }
        }
        void ToplamlarıSifirla()
        {
            txtKalanTutar.Value = 0;
            txtOdemeTutari.Value = 0;
            txtOdenenTutar.Value = 0;
            txtToplamUrunHareketTutar.Value = 0;
            txtUrunHareketIndirimTutar.Value = 0;
            txtUrunhareketOdenecekTutar.Value = 0;
        }

        private void MiktarArttir(int sayi)
        {
            UrunHareket row = (UrunHareket)layoutView1.GetFocusedRow();
            if (row == null)
            {
                return;
            }
            if (sayi < 0 && row.Miktar <= 1)
            {
                return;
            }
            row.Miktar += sayi;
            layoutView1.RefreshData();
            UrunHareketToplamlariGetir();
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
            urunHareketEntity.AdisyonId = secilenAdisyon.Id;
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
            EkMalzemeButtonOlustur(button.EkMalzemeCarpan, button.EkMalzemeler);
            txtToplamTutar.Value = txtPorsiyonTutar.Value + txtEkMalzemeTutar.Value;



        }
        void EkMalzemeButtonOlustur(decimal EkMalzemeCarpan, IEnumerable<EkMalzeme> EkmalzemeList)
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
            EkMalzemeHesapla();
            urunHareketEntity.EkMalzemeFiyat = txtEkMalzemeTutar.Value;
            UrunHareketEkle();
            foreach (ControlEkMalzemeButton button in flowEkMalzeme.Controls)
            {
                if (button.Checked)
                {
                    if (!worker.EkMalzemeHareketService.Exist(c => c.UrunHareketId == urunHareketEntity.Id && c.EkMalzemeId == button.Id))
                    {
                        worker.EkMalzemeHareketService.AddOrUpdate(new EkMalzemeHareket
                        {
                            Id = Guid.NewGuid(),
                            UrunHareketId = urunHareketEntity.Id,
                            EkMalzemeId = button.Id,
                            Fiyat = button.Fiyat
                        });
                    }


                }
                else
                {
                    worker.EkMalzemeHareketService.EntityStateChange(c => c.UrunHareketId == urunHareketEntity.Id && c.EkMalzemeId == button.Id, EntityState.Deleted);
                }
            }

            navigationKategori.SelectedPage = pageKategoriUrunler;
            txtMiktar.Value = 1;

        }
        void UrunHareketEkle()
        {
            if (!worker.AdisyonService.Exist(c => c.Id == secilenAdisyon.Id))
            {
                worker.AdisyonService.AddOrUpdate(secilenAdisyon);
                worker.Commit();
            }

            btnKategoriyeDon.Visible = false;
            worker.UrunHareketService.AddOrUpdate(urunHareketEntity);
            worker.UrunService.Load(c => c.Id == urunHareketEntity.UrunId);
            worker.PorsiyonService.Load(c => c.Id == urunHareketEntity.PorsiyonId);
            Guid id = urunHareketEntity.Porsiyon.BirimId;
            worker.TanimService.Load(c => c.Id == id);
            layoutView1.RefreshData();
            UrunHareketToplamlariGetir();
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
            if (navigationKategori.SelectedPage == pageOdemeEkrani)
            {
                txtOdemeTutari.Focus();
                SendKeys.Send(button.Text);
            }
            else
            {
                txtMiktar.Focus();
                SendKeys.Send(button.Text);
            }

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
            if (layoutView1.GetFocusedRow() == null)
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
                    if (hareketEntity.Miktar == txtMiktar.Value)
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
                    if (hareketEntity.Miktar == txtMiktar.Value)
                    {
                        hareketEntity.UrunHareketTip = UrunHareketTip.Ikram;

                    }
                    else if (hareketEntity.Miktar < txtMiktar.Value)
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
                    if (txtMiktar.Value < 0 || txtMiktar.Value > 100)
                    {
                        MessageBox.Show("Girdiğiniz İndirim Oranı 0 İle 100 Arasında Olmalı");
                        return;
                    }
                    hareketEntity.Indirim = txtMiktar.Value;
                    layoutView1.RefreshData();
                    break;
                case KeypadIslem.OdemeBol:
                    txtOdemeTutari.Value = txtKalanTutar.Value / txtOdemeTutari.Value;
                    break;

            }
            keypadIslem = KeypadIslem.Yok;
            UrunHareketToplamlariGetir();
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
                UrunHareketToplamlariGetir();
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
            if (hareketEntity.Miktar == 1)
            {
                hareketEntity.UrunHareketTip = UrunHareketTip.Ikram;
                layoutView1.RefreshData();
                UrunHareketToplamlariGetir();
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
            if (hareketEntity.Miktar == 1)
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
            if (urunHareketEntity == null)
            {
                return;
            }
            Porsiyon porsiyonEntity = worker.PorsiyonService.Get(c => c.Id == urunHareketEntity.PorsiyonId);
            IEnumerable<EkMalzeme> ekMalzemeList = worker.EkMalzemeService.GetList(c => c.UrunId == urunHareketEntity.UrunId);
            txtPorsiyonTutar.Value = porsiyonEntity.Fiyat;
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
            UrunHareket entity = (UrunHareket)layoutView1.GetFocusedRow();
            if (entity == null)
            {
                return;
            }
            keypadIslem = KeypadIslem.Indirim;
            txtMiktar.BackColor = Color.Red;
            txtMiktar.Properties.NullValuePrompt = "Lütfen İndirim Oranını Giriniz";
        }

        private void btnSiparisKaydet_Click(object sender, EventArgs e)
        {

            if (layoutView1.RowCount == 0)
            {
                btnGarsonSecim.Visible = false;
                btnMusteri.Visible = false;
                navigationMain.SelectedPage = pageMasa;
                btnMusteri.Clear();
                return;
            }
            if (btnGarsonSecim.GarsonId == Guid.Empty)
            {
                MessageBox.Show("Lütfen Bir Garson Seçiniz");
                return;
            }
            btnGarsonSecim.Visible = false;
            btnMusteri.Visible = false;
            secilenAdisyon.GarsonId = btnGarsonSecim.GarsonId;
            if (btnMusteri.MusteriId != Guid.Empty)
            {
                secilenAdisyon.MusteriId = btnMusteri.MusteriId;
            }
            btnGarsonSecim.Clear();
            btnMusteri.Clear();
            worker.AdisyonService.AddOrUpdate(secilenAdisyon);
            ControlMasaButton button = (ControlMasaButton)flowMasalar.Controls.Find(secilenMasa.Id.ToString(), true)[0];
            if (txtKalanTutar.Value <= 0)
            {
                button.MasaDurum = MasaDurum.Bos;
                secilenAdisyon.AdisyonAcik = false;
                btnSiparisKaydet.Text = "Değişiklikleri\nKaydet";
                btnSiparisKaydet.ImageOptions.ImageIndex = 0;

            }
            else
            {
                button.MasaDurum = MasaDurum.Dolu;
                secilenAdisyon.AdisyonAcik = true;
            }

            worker.Commit();
            worker = new RestaurantWorker();
            gridControl1.DataSource = worker.UrunHareketService.BindingList();
            gridControlOdeme.DataSource = worker.OdemeHareketService.BindingList();
            lblMesaj.Visible = false; 
            navigationMain.SelectedPage = pageMasa;
        }

        private void btnGarsonSecim_Click(object sender, EventArgs e)
        {
            navigationKategori.SelectedPage = pageGarson;

        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            navigationKategori.SelectedPage = pageMusteri;
        }
        private void UrunHareketToplamlariGetir()
        {
            AdisyonToplamDto toplamlar = worker.AdisyonService.AdisyonToplamGetir();
            txtToplamUrunHareketTutar.Value = toplamlar.ToplamTutar;
            txtUrunHareketIndirimTutar.Value = toplamlar.IndirimTutar;
            txtUrunhareketOdenecekTutar.Value = toplamlar.OdenecekTutar;
            txtOdenenTutar.Value = toplamlar.OdenenTutar;
            txtKalanTutar.Value = toplamlar.KalanTutar;
            if (toplamlar.KalanTutar <= 0)
            {
                btnSiparisKaydet.ImageOptions.ImageIndex = 1;
                btnSiparisKaydet.Text = "Masayı\nKapat";
            }
            else
            {
                btnSiparisKaydet.ImageOptions.ImageIndex = 0;
                btnSiparisKaydet.Text = "Değişiklikleri\nKaydet";
            }
        }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            navigationKategori.SelectedPage = pageOdemeEkrani;
        }

        private void btnOdemeTumu_Click(object sender, EventArgs e)
        {
            txtOdemeTutari.Value = txtKalanTutar.Value;
        }

        private void btnOdemeYarim_Click(object sender, EventArgs e)
        {
            txtOdemeTutari.Value = txtKalanTutar.Value / 2;
        }

        private void btnOdemeCeyrek_Click(object sender, EventArgs e)
        {
            txtOdemeTutari.Value = txtKalanTutar.Value / 4;
        }

        private void btnOdemeN_Click(object sender, EventArgs e)
        {
            keypadIslem = KeypadIslem.OdemeBol;
            txtMiktar.Value = 0;
            txtMiktar.Properties.NullValuePrompt = "Lütfen Bölünecek Oranı Girin";
        }

        private void ParaClick(object sender, EventArgs e)
        {
            ControlParaButton button = (ControlParaButton)sender;
            txtOdemeTutari.Value += button.Deger;
        }

        private void btnKeypadBack_Click(object sender, EventArgs e)
        {
            if (navigationKategori.SelectedPage == pageOdemeEkrani)
            {
                txtOdemeTutari.Focus();
                SendKeys.Send("{BACKSPACE}");

            }
            else
            {
                txtMiktar.Focus();
                SendKeys.Send("{BACKSPACE}");
            }
        }
    }
}
