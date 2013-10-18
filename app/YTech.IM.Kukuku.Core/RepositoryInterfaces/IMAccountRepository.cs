using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport.NHibernate;
using YTech.IM.Kukuku.Core.Master;

namespace YTech.IM.Kukuku.Core.RepositoryInterfaces
{
    public interface IMAccountRepository : INHibernateRepositoryWithTypedId<MAccount, string>
    {
        IEnumerable<MAccount> GetPagedAccountList(string orderCol, string orderBy, int pageIndex, int maxRows, ref int totalRows, MAccountCat accountCat);
        IList<MAccount> GetByAccountCat(MAccountCat accountCat);
    }
}
