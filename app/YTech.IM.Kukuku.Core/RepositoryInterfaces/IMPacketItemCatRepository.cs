using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport.NHibernate;
using YTech.IM.Kukuku.Core.Master;

namespace YTech.IM.Kukuku.Core.RepositoryInterfaces
{
    public interface IMPacketItemCatRepository : INHibernateRepositoryWithTypedId<MPacketItemCat, string>
    {
        IEnumerable<MPacketItemCat> GetPagedItemList(string orderCol, string orderBy, int pageIndex, int maxRows, ref int totalRows, string packetId);
        IList<MPacketItemCat> GetByPacketId(string packetId);
    }
}
