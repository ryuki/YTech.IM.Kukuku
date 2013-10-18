using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport.NHibernate;
using YTech.IM.Kukuku.Core.Master;
using YTech.IM.Kukuku.Core.Transaction;
using YTech.IM.Kukuku.Core.Transaction.Inventory;

namespace YTech.IM.Kukuku.Core.RepositoryInterfaces
{
    public interface ITTransRepository : INHibernateRepositoryWithTypedId<TTrans, string>
    {
        IList<TTrans> GetByWarehouseStatusTransBy(MWarehouse warehouse, string transStatus, string transBy);

    }
}
