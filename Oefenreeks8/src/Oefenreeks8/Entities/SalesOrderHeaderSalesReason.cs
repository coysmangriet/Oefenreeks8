using System;
using System.Collections.Generic;

namespace Oefenreeks8.Entities
{
    public partial class SalesOrderHeaderSalesReason
    {
        public int SalesOrderId { get; set; }
        public int SalesReasonId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual SalesOrderHeader SalesOrder { get; set; }
        public virtual SalesReason SalesReason { get; set; }
    }
}
