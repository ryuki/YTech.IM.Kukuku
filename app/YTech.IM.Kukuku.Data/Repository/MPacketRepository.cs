using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using SharpArch.Data.NHibernate;
using YTech.IM.Kukuku.Core.Master;
using YTech.IM.Kukuku.Core.RepositoryInterfaces;

namespace YTech.IM.Kukuku.Data.Repository
{
    public class MPacketRepository : NHibernateRepositoryWithTypedId<MPacket, string>, IMPacketRepository
    {
        #region IMPacketRepository Members

        public IEnumerable<MPacket> GetPagedPacketList(string orderCol, string orderBy, int pageIndex, int maxRows, ref int totalRows)
        {
            ICriteria criteria = Session.CreateCriteria(typeof(MPacket));

            //calculate total rows
            totalRows = Session.CreateCriteria(typeof(MPacket))
                .SetProjection(Projections.RowCount())
                .FutureValue<int>().Value;

            //get list results
            criteria.SetMaxResults(maxRows)
              .SetFirstResult((pageIndex - 1) * maxRows)
              .AddOrder(new Order(orderCol, orderBy.Equals("asc") ? true : false))
              ;

            IEnumerable<MPacket> list = criteria.List<MPacket>();
            return list;
        }

        public IEnumerable<MPacket> GetPagedPacketList(string orderCol, string orderBy, int pageIndex, int maxRows, ref int totalRows, string packetId, string packetName)
        {
            ICriteria criteria = CreateNewCriteria(packetId, packetName);

            //calculate total rows
            totalRows = criteria
                .SetProjection(Projections.RowCount())
                .FutureValue<int>().Value;

            //get list results
            criteria = CreateNewCriteria(packetId, packetName);
            criteria.SetMaxResults(maxRows)
              .SetFirstResult((pageIndex - 1) * maxRows)
              .AddOrder(new Order(orderCol, orderBy.Equals("asc") ? true : false))
              ;

            IEnumerable<MPacket> list = criteria.List<MPacket>();
            return list;
        }

        private ICriteria CreateNewCriteria(string packetId, string packetName)
        {
            ICriteria criteria = Session.CreateCriteria(typeof(MPacket));
            if (!string.IsNullOrEmpty(packetId))
            {
                criteria.Add(Expression.Like("Id", packetId, MatchMode.Anywhere));
            }
            if (!string.IsNullOrEmpty(packetName))
            {
                criteria.Add(Expression.Like("PacketName", packetName, MatchMode.Anywhere));
            }
            return criteria;
        }

        #endregion
    }
}
