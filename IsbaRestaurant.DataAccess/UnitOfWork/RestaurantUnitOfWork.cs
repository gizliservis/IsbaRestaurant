﻿using IsbaRestaurant.Core.Functions;
using IsbaRestaurant.DataAccess.Contexts.Restaurant;
using IsbaRestaurant.DataAccess.Dals;
using IsbaRestaurant.DataAccess.Dals.Base;
using IsbaRestaurant.DataAccess.Functions;
using IsbaRestaurant.DataAccess.Interfaces;
using IsbaRestaurant.DataAccess.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.DataAccess.UnitOfWork
{
    public class RestaurantUnitOfWork : IUnitOfWork
    {
        private bool disposedValue;

        private readonly RestaurantContext _context;

        public IUrunDal UrunDal { get; set; }
        public ITanimDal TanimDal { get; set; }
        public IPorsiyonDal PorsiyonDal { get; set; }
        public IEkMalzemeDal EkMalzemeDal { get; set; }
        public IMusteriDal MusteriDal { get; set; }
        public ITelefonDal TelefonDal { get; set; }
        public IAdresDal AdresDal { get; set; }
        public IAdisyonDal AdisyonDal { get; set; }
        public IEkMalzemeHareketDal EkMalzemeHareketDal { get; set; }
        public IGarsonDal GarsonDal { get; set; }
        public IMasaDal MasaDal { get; set; }
        public IUrunHareketDal UrunHareketDal { get; set; }
        public IOdemeTuruDal OdemeTuruDal { get; set; }
        public IOdemeHareketDal OdemeHareketDal { get; set; }
        public IUrunNotDal UrunNotDal { get; set; }



        public RestaurantUnitOfWork(string connectionString = null)
        {
            if (connectionString == null)
            {
                _context = new RestaurantContext(ConnectionStringInfo.Get());
            }
            else
            {
                _context = new RestaurantContext(connectionString);
            }

            UrunDal = new UrunDal(_context);
            TanimDal = new TanimDal(_context);
            PorsiyonDal = new PorsiyonDal(_context);
            EkMalzemeDal = new EkMalzemeDal(_context);
            MusteriDal = new MusteriDal(_context);
            TelefonDal = new TelefonDal(_context);
            AdresDal = new AdresDal(_context);
            AdisyonDal = new AdisyonDal(_context);
            EkMalzemeHareketDal = new EkMalzemeHareketDal(_context);
            GarsonDal = new GarsonDal(_context);
            MasaDal = new MasaDal(_context);
            UrunHareketDal = new UrunHareketDal(_context);
            OdemeTuruDal = new OdemeTuruDal(_context);
            OdemeHareketDal = new OdemeHareketDal(_context);
            UrunNotDal = new UrunNotDal(_context);


        }
        public bool Commit()
        {
            EntityBaseInfo.Add(_context);
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public void DetectChanges()
        {
            _context.ChangeTracker.DetectChanges();
        }

        public bool HasChanges()
        {
            return _context.ChangeTracker.HasChanges();
        }

        IRepository<TEntity> IUnitOfWork.Dal<TEntity>()
        {
            return new Repository<TEntity>(_context);
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
        // ~RestaurantUnitOfWork()
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
