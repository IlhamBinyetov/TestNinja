﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanbeCancelledBy_UserIsAdmin_ExpectedBahavior()
        {
            //Arrange
            var reservation = new Reservation();




            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });



            //Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void CanbeCancelledBy_SameUserCancellingTheReservation_ReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            var result = reservation.CanBeCancelledBy(user);
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingThe_Reservation_ReturnFalse()
        {

            var reservation = new Reservation { MadeBy = new User() };
            var result = reservation.CanBeCancelledBy(new User());
            Assert.IsFalse(result);
        }

    }
}
