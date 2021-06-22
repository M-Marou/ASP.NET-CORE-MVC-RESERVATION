using Moq;
using System;
using Xunit;
using YCReservations.Controllers;
using YCReservations.Models;
using YCReservations.Services;

namespace XUnitTest
{
    public class ReservationTypeTest
    {
        #region Property  
        public Mock<IReservationTypeService> mock = new Mock<IReservationTypeService>();
        #endregion

        [Fact]
        public async void GetReservationTypebyId() 
        {
            mock.Setup(p => p.GetReservationTypebyId(1)).ReturnsAsync("JK");
            ReservationController res = new ReservationController(mock.Object);
            string result = await res.GetReservationTypebyId(1);
            Assert.Equal("JK", result);
        }

        [Fact]
        public async void GetEmployeeDetails()
        {
            var ResType = new ReservationType()
            {
                TypeId = 1,
                ResType = "JK",
                NumberOfPeople = 60
            };
            mock.Setup(p => p.GetReservationTypeDetails(1)).ReturnsAsync(ResType);
            ReservationController det = new ReservationController(mock.Object);
            var result = await det.GetReservationTypeDetails(1);
            Assert.True(ResType.Equals(result));
        }
    }
}
