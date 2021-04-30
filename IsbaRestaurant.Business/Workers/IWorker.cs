using System;

namespace IsbaRestaurant.Business.Workers
{
    public interface IWorker : IDisposable
    {
        bool HasChanges();
        void DetectChanges();
        bool Commit();
    }
}
