using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Reporting.WebForms;
using SharpArch.Core;
using SharpArch.Web.NHibernate;
using YTech.IM.Kukuku.Core.Master;
using YTech.IM.Kukuku.Core.RepositoryInterfaces;
using YTech.IM.Kukuku.Core.Transaction;
using YTech.IM.Kukuku.Core.Transaction.Accounting;
using YTech.IM.Kukuku.Core.Transaction.Inventory;
using YTech.IM.Kukuku.Data.Repository;
using YTech.IM.Kukuku.Enums;
using YTech.IM.Kukuku.Web.Controllers.ViewModel;

namespace YTech.IM.Kukuku.Web.Controllers.Transaction
{
    public class Mutation : AbstractTransaction
    {
        #region Overrides of AbstractTransaction

        public override void SaveJournal(TTrans trans, decimal totalHPP)
        {

        }

        #endregion
    }
}
