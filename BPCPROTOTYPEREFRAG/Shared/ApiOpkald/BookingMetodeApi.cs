using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BPCPROTOTYPEREFRAG.Shared.Model;
using Newtonsoft.Json;

namespace BPCPROTOTYPEREFRAG.Shared.ApiOpkald
{
    public class BookingMetodeApi : MetodeApi
    {
        public async Task<List<Booking>> GetAllBookings()
        {
            using (HttpClient client = new HttpClient())
            {
                string uri = $"{URL}booking";
                string content = await client.GetStringAsync(uri);
                List<Booking> newList = JsonConvert.DeserializeObject<List<Booking>>(content);
                return newList;
            }
        }
    }
}
