﻿using System;
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
    public class TReservationRepository : NHibernateRepositoryWithTypedId<TReservation, string>, ITReservationRepository
    {
        public IEnumerable<TReservation> GetPagedReservationList(string orderCol, string orderBy, int pageIndex, int maxRows, ref int totalRows, string reservationStatus)
        {
            ICriteria criteria = Session.CreateCriteria(typeof(TReservation));

            //calculate total rows
            totalRows = Session.CreateCriteria(typeof(TReservation))
                .Add(Expression.Eq("ReservationStatus", reservationStatus))
                .SetProjection(Projections.RowCount())
                .FutureValue<int>().Value;

            //get list results
            criteria.SetMaxResults(maxRows)
                .Add(Expression.Eq("ReservationStatus", reservationStatus))
              .SetFirstResult((pageIndex - 1) * maxRows)
              .AddOrder(new Order(orderCol, orderBy.Equals("asc") ? true : false))
              ;

            IEnumerable<TReservation> list = criteria.List<TReservation>();
            return list;
        }
    }
}
