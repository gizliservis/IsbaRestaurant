﻿using IsbaRestaurant.DataAccess.Dals.Base;
using IsbaRestaurant.DataAccess.Interfaces;
using IsbaRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaRestaurant.DataAccess.Dals
{
    public class UrunNotDal : Repository<UrunNot>, IUrunNotDal
    {
        public UrunNotDal(DbContext context) : base(context)
        {
        }
    }
}
