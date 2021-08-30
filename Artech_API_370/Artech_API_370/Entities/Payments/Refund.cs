using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Artech_API_370.Entities.Payments
{
    public class Refund
    {
        [Key]
        public int RefundID { get; set; }
        public string RefundStatus { get; set; }
    }
}
