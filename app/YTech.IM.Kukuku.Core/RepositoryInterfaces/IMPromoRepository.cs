﻿using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport.NHibernate;
using YTech.IM.Kukuku.Core.Master;

namespace YTech.IM.Kukuku.Core.RepositoryInterfaces
{
    public interface IMPromoRepository : INHibernateRepositoryWithTypedId<MPromo, string>
    {
        IEnumerable<MPromo> GetPagedPromoList(string orderCol, string orderBy, int pageIndex, int maxRows, ref int totalRows);

        MPromo GetActivePromoByDate(System.DateTime searchDate);
    }
}
