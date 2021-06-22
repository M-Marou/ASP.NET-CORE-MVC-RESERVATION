using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YCReservations.Models;

namespace YCReservations.Services
{
    public class ReservationTypeService : IReservationTypeService
    {
        #region Property  
        private readonly AppDbContext _appDbContext;
        #endregion

        #region Constructor  
        public ReservationTypeService(AppDbContext context)
        {
            _appDbContext = context;
        }
        #endregion

        public async Task<string> GetReservationTypebyId(int ResTypeID)
        {
            var name = await _appDbContext.ReservationType.Where(c => c.TypeId == ResTypeID).Select(d => d.ResType).FirstOrDefaultAsync();
            return name;
        }

        public async Task<ReservationType> GetReservationTypeDetails(int ResTypeID)
        {
            var det = await _appDbContext.ReservationType.FirstOrDefaultAsync(c => c.TypeId == ResTypeID);
            return det;
        }
    }
}
