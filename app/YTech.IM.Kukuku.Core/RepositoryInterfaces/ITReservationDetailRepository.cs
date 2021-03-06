﻿using System;
using System.Collections;
using System.Collections.Generic;
using SharpArch.Core.PersistenceSupport.NHibernate;
using YTech.IM.Kukuku.Core.Master;
using YTech.IM.Kukuku.Core.Transaction;
using YTech.IM.Kukuku.Core.Transaction.Inventory;
using YTech.IM.Kukuku.Core.Transaction.Reservation;

namespace YTech.IM.Kukuku.Core.RepositoryInterfaces
{
    public interface ITReservationDetailRepository : INHibernateRepositoryWithTypedId<TReservationDetail, string>
    {
    }
}
