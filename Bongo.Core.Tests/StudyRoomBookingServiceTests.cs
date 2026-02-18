using Bongo.Core.Services;
using Bongo.DataAccess.Repository.IRepository;
using Bongo.Models.Model;
using Bongo.Models.Model.VM;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bongo.Core
{
    [TestFixture]
    public class StudyRoomBookingServiceTests
    {
        private StudyRoomBooking _request;
        private List<StudyRoom> _availableStudyRooms;
        private Mock<IStudyRoomBookingRepository> _studyRoomBookingRepositoryMock;
        private Mock<IStudyRoomRepository> _studyRoomRepositoryMock;

        private StudyRoomBookingService _bookingService;
        [SetUp]
        public void Setup()
        {
            _studyRoomBookingRepositoryMock = new Mock<IStudyRoomBookingRepository>();
            _studyRoomRepositoryMock = new Mock<IStudyRoomRepository>();
            _bookingService = new StudyRoomBookingService(_studyRoomBookingRepositoryMock.Object, _studyRoomRepositoryMock.Object);
            _request = new StudyRoomBooking
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "a;cwk@gmail.com",
                Date = DateTime.Now,

            };
            _availableStudyRooms = new List<StudyRoom>
            {
                new StudyRoom { Id=10, RoomName = "Room A",RoomNumber="A202" },
                new StudyRoom { Id=20, RoomName = "Room B",RoomNumber="B202" }
            };
            _studyRoomRepositoryMock.Setup(repo => repo.GetAll()).Returns(_availableStudyRooms);
        }
        [Test]
        public void GetAllBooking_InvokeMethod_CheckIfReposIsCalled()
        {
            _bookingService.GetAllBooking();
            _studyRoomBookingRepositoryMock.Verify(repo => repo.GetAll(null), Times.Once);

        }

        [Test]
        public void BookStudyRoom_NullRequest_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _bookingService.BookStudyRoom(null));
        }

        [Test]
        public void BookStudyRoom_RoomAvailable_BooksRoomSuccessfully()
        {
            StudyRoomBooking savedStudyRoom;
            _studyRoomBookingRepositoryMock.Setup(repo => repo.Book(It.IsAny<StudyRoomBooking>()))
                .Callback<StudyRoomBooking>(booking => savedStudyRoom = booking);
            //act
            var result = _bookingService.BookStudyRoom(_request);
            //assert
            Assert.IsNotNull(result);
        }
        [Test]
        public void BookStudyRoom_NoRoomAvailable_ReturnsNoRoomAvailableCode()
        {
            _studyRoomBookingRepositoryMock.Setup(repo => repo.GetAll(It.IsAny<DateTime>())).Returns(new List<StudyRoomBooking>
            {
                new StudyRoomBooking { StudyRoomId = 10, Date = _request.Date },
                new StudyRoomBooking { StudyRoomId = 20, Date = _request.Date }
            });
            var result = _bookingService.BookStudyRoom(_request);
            Assert.IsNotNull(result);
            Assert.AreEqual(StudyRoomBookingCode.NoRoomAvailable, result.Code);
        }
    }
}

