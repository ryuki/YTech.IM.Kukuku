using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport.NHibernate;
using YTech.IM.Kukuku.Core.Master;
using YTech.IM.Kukuku.Core.Transaction.Inventory;

namespace YTech.IM.Kukuku.Core.RepositoryInterfaces
{
    public interface ITShiftRepository : INHibernateRepositoryWithTypedId<TShift, string>
    {
        TShift GetLastShiftByDate(System.DateTime? shiftDate);

        TShift GetByDateAndShiftNo(System.DateTime? shiftDate, int? shiftNo);
    }
}
