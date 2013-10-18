using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using SharpArch.Data.NHibernate;
using YTech.IM.Kukuku.Core.Master;
using YTech.IM.Kukuku.Core.RepositoryInterfaces;
using YTech.IM.Kukuku.Core.Transaction.Accounting;

namespace YTech.IM.Kukuku.Data.Repository
{
    public class TJournalRefRepository : NHibernateRepositoryWithTypedId<TJournalRef, string>, ITJournalRefRepository
    {
    }
}
