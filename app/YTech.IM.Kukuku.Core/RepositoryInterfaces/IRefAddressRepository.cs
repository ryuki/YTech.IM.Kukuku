using SharpArch.Core.PersistenceSupport.NHibernate;
using YTech.IM.Kukuku.Core.Master;


namespace YTech.IM.Kukuku.Core.RepositoryInterfaces
{
    public interface IRefAddressRepository : INHibernateRepositoryWithTypedId<RefAddress, string>
    {
    }
}
