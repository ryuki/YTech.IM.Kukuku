﻿using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using SharpArch.Data.NHibernate;
using YTech.IM.Kukuku.Core.Master;
using YTech.IM.Kukuku.Core.RepositoryInterfaces;
using YTech.IM.Kukuku.Core.Transaction;
using YTech.IM.Kukuku.Core.Transaction.Inventory;

namespace YTech.IM.Kukuku.Data.Repository
{
    public class TTransRepository : NHibernateRepositoryWithTypedId<TTrans, string>, ITTransRepository
    {
        public IList<TTrans> GetByWarehouseStatusTransBy(MWarehouse warehouse, string transStatus, string transBy)
        {
            ICriteria criteria = Session.CreateCriteria(typeof(TTrans));
            criteria.Add(Expression.Eq("TransStatus", transStatus));
            criteria.Add(Expression.Eq("WarehouseId", warehouse));
            criteria.Add(Expression.Eq("TransBy", transBy));
            criteria.SetCacheable(true);
            IList<TTrans> list = criteria.List<TTrans>();
            return list;
        }
    }
}
