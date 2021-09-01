using BinaryBrainsAPI.Dtos.BookingsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Dtos.PaymentsDtos
{
    public class PaymentDto
    {
        public int PaymentID { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDateTime { get; set; }
        public int PaymentTypeID { get; set; }
        public PaymentTypeDto PaymentType { get; set; }

        public int PaymentStatusID { get; set; }
        public PaymentStatusDto PaymentStatus { get; set; }

        public int RefundID { get; set; }
        public RefundDto Refund { get; set; }


        public int BookingID { get; set; }
        public BookingDto Booking { get; set; }
    }
}
