using BusinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public int TBookingCount()
        {
            return _bookingDal.BookingCount();
        }

        public void TBookingStatusApprovedChange(Booking booking)
        {
            _bookingDal.BookingStatusChangeApproved(booking);
        }

        public void TBookingStatusApprovedChange2(int id)
        {
            _bookingDal.BookingStatusChangeApproved2(id); 
        }

        public void TBookingStatusChangeApproved3(int id)
        {
            _bookingDal.BookingStatusChangeApproved3(id);
        }

        public void TBookingStatusChangeAwait(int id)
        {
           _bookingDal.BookingStatusChangeAwait(id);
        }

        public void TBookingStatusChangeCancel(int id)
        {
            _bookingDal.BookingStatusChangeCancel(id);
        }

        public List<Booking> TBookingTake4List()
        {
            return _bookingDal.BookingTake4List();
        }

        public void TDelete(Booking p)
        {
           _bookingDal.Delete(p);
        }

        public Booking TGetById(int id)
        {
            return _bookingDal.GetById(id);
        }

        public List<Booking> TGetList()
        {
           return _bookingDal.GetList();
        }

        public void TInsert(Booking p)
        {
            _bookingDal.Insert(p);
        }

        public void TUpdate(Booking p)
        {
            _bookingDal.Update(p);
        }
    }
}
