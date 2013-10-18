using SharpArch.Core.PersistenceSupport.NHibernate;
using SharpArch.Data.NHibernate;
using YTech.IM.Kukuku.Core.Master;
using YTech.IM.Kukuku.Core.RepositoryInterfaces;

namespace YTech.IM.Kukuku.Data.Repository
{
    public class RefAddressRepository : NHibernateRepositoryWithTypedId<RefAddress, string>, IRefAddressRepository
    {
    }
}
