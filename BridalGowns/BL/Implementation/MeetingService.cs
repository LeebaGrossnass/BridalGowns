using BL.API;
using BL.DTO;
using DAL;
using DAL.API;
using DAL.Implementation;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementation
{
    public class MeetingService : IMeetingService
    {

        MeetingRepo meetings;
        public MeetingService(DALManager manager)
        {
            this.meetings = manager.meetingRepo;
        }

        public MeetingDTO Add(MeetingDTO meeting)
        {
            Meeting m = new Meeting();
            m.ClientId = meeting.ClientId;
            m.MeetingTime = meeting.MeetingTime;
            meetings.Add(m);
            return meeting;
        }

        public MeetingDTO Delete(DateTime time)
        {
            Meeting m = meetings.Delete(time);
            return new MeetingDTO() { MeetingTime = time, ClientId =m.ClientId};
        }

        public MeetingDTO Get(DateTime time)
        {
            Meeting m = meetings.Get(time);
            if (m == null)
            {
                return null;
            }
            MeetingDTO meeting = new MeetingDTO(m.ClientId, m.MeetingTime);
            return meeting;
        }

        public List<MeetingDTO> GetAll()
        {
            List<Meeting> list = meetings.GetAll();
            List<MeetingDTO> result = new List<MeetingDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new MeetingDTO(list[i].ClientId, list[i].MeetingTime));
            }
            return result;
        }

        public MeetingDTO Update(MeetingDTO meeting)
        {
            Meeting m = new Meeting();
            m.ClientId = meeting.ClientId;
            m.MeetingTime = meeting.MeetingTime;
            meetings.Update(m);
            return meeting;
        }
    }
}
