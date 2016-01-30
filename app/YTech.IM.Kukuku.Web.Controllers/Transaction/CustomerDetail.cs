using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YTech.IM.Kukuku.Core.Master;

namespace YTech.IM.Kukuku.Web.Controllers.Transaction
{
    [Serializable]
    public class CustomerDetail 
    {
        public virtual string CustomerId { get; set; }
        public virtual decimal? CustomerMaxCredit { get; set; }
        public virtual decimal? CustomerServiceDisc { get; set; }
        public virtual decimal? CustomerProductDisc { get; set; }
        public virtual DateTime? CustomerJoinDate { get; set; }
        public virtual DateTime? CustomerLastBuy { get; set; }
        public virtual string CustomerMassageStrength { get; set; }
        public virtual string CustomerHealthProblem { get; set; }
        public virtual string CustomerStatus { get; set; }
        public virtual string CustomerDesc { get; set; }

        public virtual string PersonFirstName { get; set; }
        public virtual string PersonLastName { get; set; }
        public virtual DateTime? PersonDob { get; set; }
        public virtual string PersonPob { get; set; }
        public virtual string PersonGender { get; set; }
        public virtual string PersonPhone { get; set; }
        public virtual string PersonMobile { get; set; }
        public virtual string PersonEmail { get; set; }
        public virtual string PersonReligion { get; set; }
        public virtual string PersonRace { get; set; }
        public virtual string PersonIdCardType { get; set; }
        public virtual string PersonIdCardNo { get; set; }
        public virtual string PersonDesc { get; set; }

        public virtual string AddressLine1 { get; set; }
        public virtual string AddressLine2 { get; set; }
        public virtual string AddressLine3 { get; set; }
        public virtual string AddressPhone { get; set; }
        public virtual string AddressFax { get; set; }
        public virtual string AddressCity { get; set; }
        public virtual string AddressContact { get; set; }
        public virtual string AddressContactMobile { get; set; }
        public virtual string AddressEmail { get; set; }
    }
}
