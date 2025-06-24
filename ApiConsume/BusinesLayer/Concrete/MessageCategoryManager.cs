using BusinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDal _messageCategoryDal;

        public MessageCategoryManager(IMessageCategoryDal messageCategoryDal)
        {
            _messageCategoryDal = messageCategoryDal;
        }

        public void TDelete(MessageCategory p)
        {
            _messageCategoryDal.Delete(p);
        }

        public MessageCategory TGetById(int id)
        {
           return _messageCategoryDal.GetById(id);
        }

        public List<MessageCategory> TGetList()
        {
            return _messageCategoryDal.GetList();
        }

        public void TInsert(MessageCategory p)
        {
            _messageCategoryDal.Insert(p);
        }

        public void TUpdate(MessageCategory p)
        {
            _messageCategoryDal.Update(p);
        }
    }
}
