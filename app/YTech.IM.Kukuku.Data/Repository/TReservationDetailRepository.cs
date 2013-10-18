using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using SharpArch.Data.NHibernate;
using YTech.IM.Kukuku.Core.Master;
using YTech.IM.Kukuku.Core.RepositoryInterfaces;
using YTech.IM.Kukuku.Core.Transaction;
using YTech.IM.Kukuku.Core.Transaction.Reservation;
using YTech.IM.Kukuku.Enums;

namespace YTech.IM.Kukuku.Data.Repository
{
    public class TReservationDetailRepository : NHibernateRepositoryWithTypedId<TReservationDetail, string>, ITReservationDetailRepository
    {
    }
}
