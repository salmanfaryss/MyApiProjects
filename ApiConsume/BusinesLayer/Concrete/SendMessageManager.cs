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
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;

        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public void TDelete(SendMessage p)
        {
            _sendMessageDal.Delete(p);
        }

        public SendMessage TGetById(int id)
        {
           return _sendMessageDal.GetById(id);
        }

        public List<SendMessage> TGetList()
        {
           return _sendMessageDal.GetList();
        }

        public int TGetSendMessageCount()
        {
           return _sendMessageDal.GetSendMessageCount();
        }

        public void TInsert(SendMessage p)
        {
           _sendMessageDal.Insert(p);
        }

        public void TUpdate(SendMessage p)
        {
            _sendMessageDal.Update(p);
        }
    }
}
