using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport.NHibernate;
using YTech.IM.Kukuku.Core.Master;
using YTech.IM.Kukuku.Core.Transaction;
using YTech.IM.Kukuku.Core.Transaction.Accounting;

namespace YTech.IM.Kukuku.Core.RepositoryInterfaces
{
    public interface ITJournalRefRepository : INHibernateRepositoryWithTypedId<TJournalRef, string>
    {
    }
}
