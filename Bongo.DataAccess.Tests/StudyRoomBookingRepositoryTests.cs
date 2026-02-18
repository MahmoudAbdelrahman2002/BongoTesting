using Bongo.DataAccess.Repository;
using Bongo.Models.Model;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bongo.DataAccess
{
    [TestFixture]
    public class StudyRoomBookingRepositoryTests
    {
        private StudyRoomBooking studyRoomBooking1;
        private StudyRoomBooking studyRoomBooking2;
        private DbContextOptions<ApplicationDbContext> options;
        public StudyRoomBookingRepositoryTests()
        {
            studyRoomBooking1 = new StudyRoomBooking
            {
                FirstName = "Mahmoud",
                LastName = "Salem",
                BookingId = 11,
                Date = new DateTime(2024, 6, 15),
                StudyRoomId = 1,
                Email = "mahmoud@gmail.com"



            };
            studyRoomBooking2 = new StudyRoomBooking
            {
                FirstName = "Ahmed",
                LastName = "Ali",
                BookingId = 12,
                Date = new DateTime(2024, 6, 15),
                StudyRoomId = 2,
                Email = "sas@gmail.com"
            };
        }
        [SetUp]
        public void Setup()
        {
             options = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase(databaseName: "TestDatabase").Options;
        }
        [Test]
        public void SaveBooking_Book1_CheckValuesFromDataBase()
        {
            
           

            //act
            using (var context = new ApplicationDbContext(options))
            {
                
                var repository = new StudyRoomBookingRepository(context);
                repository.Book(studyRoomBooking1);
            }
            //assert
            using (var context = new ApplicationDbContext(options))
            {
               
                var bookingFromDb = context.StudyRoomBookings.FirstOrDefault(b => b.BookingId == studyRoomBooking1.BookingId);
                Assert.IsNotNull(bookingFromDb);
                Assert.AreEqual(studyRoomBooking1.FirstName, bookingFromDb.FirstName);
                Assert.AreEqual(studyRoomBooking1.LastName, bookingFromDb.LastName);
                Assert.AreEqual(studyRoomBooking1.Date, bookingFromDb.Date);
                Assert.AreEqual(studyRoomBooking1.StudyRoomId, bookingFromDb.StudyRoomId);
                Assert.AreEqual(studyRoomBooking1.Email, bookingFromDb.Email);
            }
           
            
        }
        [Test]
        public void GetAllBooking_BookingOneAndTwo_CheckBothFromDataBase()
        {
            var expectedResult = new List<StudyRoomBooking> { studyRoomBooking1, studyRoomBooking2 };
            //arrange
            

            using (var context = new ApplicationDbContext(options))
            {
                context.StudyRoomBookings.AddRange(expectedResult);
                context.SaveChanges();
            }
            var actualResult = new List<StudyRoomBooking>();
            //act
            using (var context = new ApplicationDbContext(options))
            {
                var repository = new StudyRoomBookingRepository(context);
                actualResult = repository.GetAll(null).ToList();
            }   
            

            //assert
            using (var context = new ApplicationDbContext(options))
            {
                var comparer = new BookingComparer();
                CollectionAssert.AreEqual(expectedResult, actualResult, comparer);




            }
        }
    }
   public class BookingComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var booking1 = x as StudyRoomBooking;
            var booking2 = y as StudyRoomBooking;
            if (booking1 == null || booking2 == null)
                throw new ArgumentException("Objects being compared must be of type StudyRoomBooking.");
            int result = booking1.BookingId.CompareTo(booking2.BookingId);
            if (result != 0) return result;
            result = string.Compare(booking1.FirstName, booking2.FirstName, StringComparison.Ordinal);
            if (result != 0) return result;
            result = string.Compare(booking1.LastName, booking2.LastName, StringComparison.Ordinal);
            if (result != 0) return result;
            result = booking1.Date.CompareTo(booking2.Date);
            if (result != 0) return result;
            result = booking1.StudyRoomId.CompareTo(booking2.StudyRoomId);
            if (result != 0) return result;
            return string.Compare(booking1.Email, booking2.Email, StringComparison.Ordinal);
        }


    }

}
