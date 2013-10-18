using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using SharpArch.Data.NHibernate;
using YTech.IM.Kukuku.Core.Master;
using YTech.IM.Kukuku.Core.RepositoryInterfaces;

namespace YTech.IM.Kukuku.Data.Repository
{
    public class MAccountCatRepository : NHibernateRepositoryWithTypedId<MAccountCat, string>, IMAccountCatRepository
    {
    }
}
