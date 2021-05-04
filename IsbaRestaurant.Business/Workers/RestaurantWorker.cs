using IsbaRestaurant.Business.Managers;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using System;

namespace IsbaRestaurant.Business.Workers
{
    public class RestaurantWorker : IWorker
    {
        private IUnitOfWork _uow;
        public IUrunService UrunService { get; set; }
        public ITanimService TanimService { get; set; }
        public IPorsiyonService PorsiyonService { get; set; }
        public IEkMalzemeService EkMalzemeService { get; set; }
        public IMusteriService MusteriService { get; set; }
        public ITelefonService TelefonService { get; set; }
        public IAdresService AdresService { get; set; }
        public IAdisyonService AdisyonService { get; set; }
        public IEkMalzemeHareketService EkMalzemeHareketService { get; set; }
        public IGarsonService GarsonService { get; set; }
        public IMasaService MasaService { get; set; }
        public IUrunHareketService UrunHareketService { get; set; }
        public IOdemeTuruService OdemeTuruService { get; set; }
        public IOdemeHareketService OdemeHareketService { get; set; }
        public IUrunNotService UrunNotService { get; set; }


        private bool disposedValue;
        public RestaurantWorker(string connectionString = null)
        {
            _uow = new RestaurantUnitOfWork(connectionString);
            UrunService = new UrunManager(_uow);
            TanimService = new TanimManager(_uow);
            PorsiyonService = new PorsiyonManager(_uow);
            EkMalzemeService = new EkMalzemeManager(_uow);
            MusteriService = new MusteriManager(_uow);
            TelefonService = new TelefonManager(_uow);
            AdresService = new AdresManager(_uow);
            AdisyonService = new AdisyonManager(_uow);
            EkMalzemeHareketService = new EkMalzemeHareketManager(_uow);
            GarsonService = new GarsonManager(_uow);
            MasaService = new MasaManager(_uow);
            UrunHareketService = new UrunHareketManager(_uow);
            OdemeTuruService = new OdemeTuruManager(_uow);
            OdemeHareketService = new OdemeHareketManager(_uow);
            UrunNotService = new UrunNotManager(_uow);

        }
        public bool Commit()
        {
            return _uow.Commit();
        }

        public void DetectChanges()
        {
            _uow.DetectChanges();
        }

        public bool HasChanges()
        {
            return _uow.HasChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: yönetilen durumu (yönetilen nesneleri) atın
                }

                // TODO: yönetilmeyen kaynakları (yönetilmeyen nesneleri) serbest bırakın ve sonlandırıcıyı geçersiz kılın
                // TODO: büyük alanları null olarak ayarlayın
                disposedValue = true;
            }
        }

        // // TODO: sonlandırıcıyı yalnızca 'Dispose(bool disposing)' içinde yönetilmeyen kaynakları serbest bırakacak kod varsa geçersiz kılın
        // ~RestaurantWorker()
        // {
        //     // Bu kodu değiştirmeyin. Temizleme kodunu 'Dispose(bool disposing)' metodunun içine yerleştirin.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Bu kodu değiştirmeyin. Temizleme kodunu 'Dispose(bool disposing)' metodunun içine yerleştirin.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
