using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YCReservations.Models;

namespace YCReservations.Services
{
    public interface IReservationTypeService
    {
        Task<string> GetReservationTypebyId(int ResTypeID);
        Task<ReservationType> GetReservationTypeDetails(int ResTypeID);
    }
}
