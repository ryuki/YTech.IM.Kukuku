using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport.NHibernate;
using YTech.IM.Kukuku.Core.Master;

namespace YTech.IM.Kukuku.Core.RepositoryInterfaces
{
    public interface IMPacketCommRepository : INHibernateRepositoryWithTypedId<MPacketComm, string>
    {
        IEnumerable<MPacketComm> GetPagedPacketCommList(string orderCol, string orderBy, int pageIndex, int maxRows, ref int totalRows, string employeeId);

        IList<MPacketComm> GetByEmployeeId(string employeeId);

        MPacketComm GetByEmployeeAndPacket(MEmployee emp, MPacket packet);
    }
}
