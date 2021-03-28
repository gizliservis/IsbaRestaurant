using IsbaRestaurant.Business.Managers;
using IsbaRestaurant.Business.Services;
using IsbaRestaurant.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public ITelefonService TelefonService{ get; set; }
        public IAdresService AdresService { get; set; }
        

        private bool disposedValue;
        public RestaurantWorker(string connectionString=null)
        {
            _uow =new RestaurantUnitOfWork(connectionString);
            UrunService = new UrunManager(_uow);
            TanimService = new TanimManager(_uow);
            PorsiyonService = new PorsiyonManager(_uow);
            EkMalzemeService = new EkMalzemeManager(_uow);
            MusteriService = new MusteriManager(_uow);
            TelefonService = new TelefonManager(_uow);
            AdresService = new AdresManager(_uow);

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
