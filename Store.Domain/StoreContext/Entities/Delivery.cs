using Store.Domain.StoreContext.Enums;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Store.Domain.StoreContext.Entities
{
    public class Delivery
    {
        public Delivery(DateTime estimatedDeliveryDate)
        {
            CreateDate = DateTime.Now;
            EstimatedDeliveryDate = estimatedDeliveryDate;
            Status = EDeliveryStatus.Waitting;
        }

        public DateTime CreateDate { get; private set; }
        public DateTime EstimatedDeliveryDate { get; private set; }
        public EDeliveryStatus Status { get; set; }
    }
}
