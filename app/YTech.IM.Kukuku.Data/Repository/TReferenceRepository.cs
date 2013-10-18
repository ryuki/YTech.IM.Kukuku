using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using SharpArch.Data.NHibernate;
using YTech.IM.Kukuku.Core.Master;
using YTech.IM.Kukuku.Core.RepositoryInterfaces;
using YTech.IM.Kukuku.Core.Transaction;
using YTech.IM.Kukuku.Enums;

namespace YTech.IM.Kukuku.Data.Repository
{
    public class TReferenceRepository : NHibernateRepositoryWithTypedId<TReference, string>, ITReferenceRepository
    {
        public TReference GetByReferenceType(EnumReferenceType referenceType)
        {
            ICriteria criteria = Session.CreateCriteria(typeof(TReference));
            criteria.Add(Expression.Eq("ReferenceType", referenceType.ToString()));
            criteria.SetCacheable(true);
            return criteria.UniqueResult() as TReference;
        }
    }
}
