using BL.API;
using BL.DTO;
using DAL;
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
    public class MeetingScheduleService : IMeetingScheduleService
    {

        MeetingScheduleRepo meetingSchedules;
        public MeetingScheduleService(DALManager manager)
        {
            this.meetingSchedules = manager.meetingScheduleRepo;
        }

        public MeetingScheduleDTO Add(MeetingScheduleDTO meetingSchedule)
        {
            OrderSchedule s = new OrderSchedule();
            s.Date = meetingSchedule.Date;
            s.MeetingCode = meetingSchedule.MeetingCode;
            meetingSchedules.Add(s);
            return meetingSchedule;
        }

        public MeetingScheduleDTO Delete(DateTime time)
        {
            OrderSchedule s = meetingSchedules.Delete(time);
            return new MeetingScheduleDTO() { Date = time,MeetingCode = s.MeetingCode };
           
        }
        public MeetingScheduleDTO Get(DateTime time)
        {
            OrderSchedule s = meetingSchedules.Get(time);
            if (s == null)
            {
                return null;
            }
            MeetingScheduleDTO schedule = new MeetingScheduleDTO(s.Date, s.MeetingCode);
            return schedule;
        }
        public List<MeetingScheduleDTO> GetAll()
        {
            List<OrderSchedule> list = meetingSchedules.GetAll();
            List<MeetingScheduleDTO> result = new List<MeetingScheduleDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new MeetingScheduleDTO(list[i].Date, list[i].MeetingCode));
            }
            return result;
        }

    }
}
