using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPCPROTOTYPEREFRAG.Server.Managers;
using BPCPROTOTYPEREFRAG.Shared.Model;

namespace BPCPROTOTYPEREFRAG.Server.Controllers
{
    public class BookingController : Controller
    {
        BookingManager manager = new BookingManager();

        // GET: api/Booking
        [HttpGet]
        [Route("/api/[controller]")]
        public IEnumerable<Booking> Get()
        {
            return manager.GetAllBookings();
        }

        // GET: api/Booking/5
        [HttpGet("{id}", Name = "GetBooking")]
        public Booking Get(int id)
        {
            return manager.GetBookingFromId(id);
        }

        // POST: api/Booking
        [HttpPost]
        public bool Post([FromBody] Booking value)
        {
            return manager.CreateBooking(value);
        }

        // PUT: api/Booking/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Booking value)
        {
            return manager.UpdateBooking(value, id);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Booking Delete(int id)
        {
            return manager.DeleteBooking(id);
        }
    }
}