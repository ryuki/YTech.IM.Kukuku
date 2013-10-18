using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport.NHibernate;
using YTech.IM.Kukuku.Core.Master;

namespace YTech.IM.Kukuku.Core.RepositoryInterfaces
{
    public interface IMItemUomRepository : INHibernateRepositoryWithTypedId<MItemUom, string>
    {
        MItemUom GetByItem(MItem item);
    }
}
