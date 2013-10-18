using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport.NHibernate;
using YTech.IM.Kukuku.Core.Master;

namespace YTech.IM.Kukuku.Core.RepositoryInterfaces
{
    public interface IMAccountRefRepository : INHibernateRepositoryWithTypedId<MAccountRef, string>
    {

        MAccountRef GetByRefTableId(Enums.EnumReferenceTable enumReferenceTable, string warehouseId);
    }
}
