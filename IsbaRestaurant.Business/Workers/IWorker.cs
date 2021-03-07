﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.Business.Workers
{
    public interface IWorker:IDisposable
    {
        bool HasChanges();
        void DetectChanges();
        bool Commit();
    }
}