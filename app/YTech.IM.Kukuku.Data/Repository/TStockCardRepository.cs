﻿using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using NHibernate.Criterion;
using SharpArch.Data.NHibernate;
using YTech.IM.Kukuku.Core.Master;
using YTech.IM.Kukuku.Core.RepositoryInterfaces;
using YTech.IM.Kukuku.Core.Transaction;
using YTech.IM.Kukuku.Core.Transaction.Inventory;

namespace YTech.IM.Kukuku.Data.Repository
{
    public class TStockCardRepository : NHibernateRepositoryWithTypedId<TStockCard, string>, ITStockCardRepository
    {
        public IList<TStockCard> GetByDateItemWarehouse(DateTime? dateFrom, DateTime? dateTo, MItem item, MWarehouse warehouse)
        {
            ICriteria criteria = Session.CreateCriteria(typeof(TStockCard));
            if (dateFrom.HasValue && dateTo.HasValue)
            {
                criteria.Add(Expression.Between("StockCardDate", dateFrom, dateTo));
            }
            if (item != null)
            {
                criteria.Add(Expression.Eq("ItemId", item));
            }

            if (warehouse != null)
            {
                criteria.Add(Expression.Eq("WarehouseId", warehouse));
            }

            criteria.SetCacheable(true);
            IList<TStockCard> list = criteria.List<TStockCard>();
            return list;
        }
    }
}
