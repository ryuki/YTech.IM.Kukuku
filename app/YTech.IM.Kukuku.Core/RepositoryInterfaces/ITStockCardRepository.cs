using System;
using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport.NHibernate;
using YTech.IM.Kukuku.Core.Master;
using YTech.IM.Kukuku.Core.Transaction;
using YTech.IM.Kukuku.Core.Transaction.Inventory;

namespace YTech.IM.Kukuku.Core.RepositoryInterfaces
{
    public interface ITStockCardRepository : INHibernateRepositoryWithTypedId<TStockCard, string>
    {
        IList<TStockCard> GetByDateItemWarehouse(DateTime? dateFrom, DateTime? dateTo, MItem item, MWarehouse warehouse);
    }
}
