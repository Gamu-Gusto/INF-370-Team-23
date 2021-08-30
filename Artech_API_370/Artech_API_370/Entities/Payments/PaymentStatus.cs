using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Artech_API_370.Entities.Payments
{
    public class PaymentStatus
    {
        [Key]
        public int PaymentStatusID { get; set; }
        public string PaymentStatusDescription { get; set; }
    }
}
