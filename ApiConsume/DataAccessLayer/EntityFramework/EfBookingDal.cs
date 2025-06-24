using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepositories<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {
        }

        public int BookingCount()
        {
           var context = new Context();
            return(context.bookings.Count());
        }

        public void BookingStatusChangeApproved(Booking booking)
        {
            var context = new Context();
            var value = context.bookings.Where(x => x.BookingId == booking.BookingId).FirstOrDefault();
            value.Status = "Oyalandi";
            context.SaveChanges();
        }

        public void BookingStatusChangeApproved2(int id)
        {
           var context =new Context();
            var value = context.bookings.Find(id);
            value.Status = "Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusChangeApproved3(int id)
        {
            var context = new Context();
            var value = context.bookings.Find(id);
            value.Status = "Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusChangeAwait(int id)
        {
           var context = new Context();
            var value = context.bookings.Find(id);
            value.Status = "Müşteri Aranacak";
            context.SaveChanges();
        }

        public void BookingStatusChangeCancel(int id)
        {
           var context =new Context();
            var value = context.bookings.Find(id);
            value.Status = "Iptal Edildi";
            context.SaveChanges();
        }

        public List<Booking> BookingTake4List()
        {
            var context = new Context();
            var value = context.bookings.Take(4).ToList();
            return value;
        }
    }
}
