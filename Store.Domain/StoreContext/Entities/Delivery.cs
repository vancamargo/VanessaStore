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

        public void Ship()
        {
            // se a data de entrega for passado, não entregar
            Status = EDeliveryStatus.Shipped;
        }

        public void Cancel()
        {
            // se o status já estiver entrege nao pode cancelar
            Status = EDeliveryStatus.Canceled;
        }
    }
}
