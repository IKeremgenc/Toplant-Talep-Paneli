using EgeMeet.Bussines.Abstrack;
using EgeMeet.BussinesLayer.Abstrack;
using EgeMeet.DataAcsseslayer.Abstract;
using EgeMeet.DataAcsseslayer.Repositories;
using EgeMeet.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeMeet.BussinesLayer.Concrete
{
    public class EFMeetingRequestManager : IMeetinRequestService
    {
        private readonly IMeetingRequestDal _meetingRequestDal;

        public EFMeetingRequestManager(IMeetingRequestDal meetingRequestDal)
        {
            _meetingRequestDal = meetingRequestDal;
        }

        public void TDelete(Meeting t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(MeetingRequest t)
        {
            throw new NotImplementedException();
        }

        public Meeting TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Meeting> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Meeting t)
        {
            throw new NotImplementedException();
        }

        public void TInsert(MeetingRequest t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Meeting t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(MeetingRequest t)
        {
            throw new NotImplementedException();
        }

        MeetingRequest IGnericService<MeetingRequest>.TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<MeetingRequest> IGnericService<MeetingRequest>.TGetList()
        {
            throw new NotImplementedException();
        }
    }
}
