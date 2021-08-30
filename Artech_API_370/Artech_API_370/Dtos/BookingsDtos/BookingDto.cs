using Artech_API_370.Dtos.ArtClassesDtos;
using Artech_API_370.Dtos.UsersDtos;
using BinaryBrainsAPI.Dtos.ArtClassesDtos;
using BinaryBrainsAPI.Dtos.PaymentsDtos;
using BinaryBrainsAPI.Dtos.UsersDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinaryBrainsAPI.Dtos.BookingsDtos
{
    public class BookingDto
    {
        public int BookingID { get; set; }
        public DateTime BookingDateTime { get; set; }

        public string BookingStatus { get; set; }

        public int? BookingNotificationID { get; set; }
        public BookingNotificationDto BookingNotification { get; set; }

        public int ArtClassID { get; set; }
        public ArtClassDto ArtClass { get; set; }

        public int UserID { get; set; }
        public UserDto User { get; set; }
    }
}
