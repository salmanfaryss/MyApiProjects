using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Abstract
{
    public interface IBookingService:IGenericService<Booking>
    {
        void TBookingStatusApprovedChange(Booking booking);
        void TBookingStatusApprovedChange2(int id);
        void TBookingStatusChangeApproved3(int id);
        void TBookingStatusChangeCancel(int id);
        void TBookingStatusChangeAwait(int id);

        int TBookingCount();
        List<Booking> TBookingTake4List();
    }
}
