using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport.NHibernate;
using YTech.IM.Kukuku.Core.Master;

namespace YTech.IM.Kukuku.Core.RepositoryInterfaces
{
    public interface IMPacketRepository : INHibernateRepositoryWithTypedId<MPacket, string>
    {
        IEnumerable<MPacket> GetPagedPacketList(string orderCol, string orderBy, int pageIndex, int maxRows, ref int totalRows);

        IEnumerable<MPacket> GetPagedPacketList(string orderCol, string orderBy, int pageIndex, int maxRows, ref int totalRows, string packetId, string packetName);
    }
}
