using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport.NHibernate;
using YTech.IM.Kukuku.Core.Master;

namespace YTech.IM.Kukuku.Core.RepositoryInterfaces
{
    public interface IMSupplierRepository : INHibernateRepositoryWithTypedId<MSupplier, string>
    {
        IEnumerable<MSupplier> GetPagedSupplierList(string orderCol, string orderBy, int pageIndex, int maxRows, ref int totalRows);

    }
}
