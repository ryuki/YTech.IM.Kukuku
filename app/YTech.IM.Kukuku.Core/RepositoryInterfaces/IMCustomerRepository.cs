using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport.NHibernate;
using YTech.IM.Kukuku.Core.Master;

namespace YTech.IM.Kukuku.Core.RepositoryInterfaces
{
    public interface IMCustomerRepository : INHibernateRepositoryWithTypedId<MCustomer, string>
    {
        IEnumerable<MCustomer> GetPagedCustomerList(string orderCol, string orderBy, int pageIndex, int maxRows, ref int totalRows, string searchBy, string searchText);

        IEnumerable<MCustomer> GetByMonthDOB(string month);
    }
}
