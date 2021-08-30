using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Artech_API_370.Entities.Payments
{
    public class PaymentType
    {

        [Key]
        public int PaymentTypeID { get; set; }
        public string PaymentTypeDescription { get; set; }
    }
}
