using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using SharpArch.Data.NHibernate;
using YTech.IM.Kukuku.Core.Master;
using YTech.IM.Kukuku.Core.RepositoryInterfaces;
using YTech.IM.Kukuku.Enums;

namespace YTech.IM.Kukuku.Data.Repository
{
    public class MAccountRefRepository : NHibernateRepositoryWithTypedId<MAccountRef, string>, IMAccountRefRepository
    {
        public MAccountRef GetByRefTableId(EnumReferenceTable enumReferenceTable, string warehouseId)
        {
            ICriteria criteria = Session.CreateCriteria(typeof(MAccountRef));
            criteria.Add(Expression.Eq("ReferenceTable", enumReferenceTable.ToString()));
            if (!string.IsNullOrEmpty(warehouseId))
            {
                criteria.Add(Expression.Eq("ReferenceId", warehouseId));
            }
            return criteria.UniqueResult<MAccountRef>();
        }
    }
}
