using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPCPROTOTYPEREFRAG.Shared.ApiOpkald;
using BPCPROTOTYPEREFRAG.Shared.Model;

namespace BPCPROTOTYPEREFRAG.Client.ViewModel
{
    public class BookingVM
    {
        public List<Booking> Bookings { get; set; } = new List<Booking>();
        private BookingMetodeApi dbBookingMetodeApi = new BookingMetodeApi();

        public async Task GetBookings()
        {
            Bookings = await dbBookingMetodeApi.GetAllBookings();
        }
    }
}
