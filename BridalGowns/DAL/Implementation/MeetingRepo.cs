using DAL.API;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    public class MeetingRepo : IMeetingRepo
    {

        BridalContext context;
        public MeetingRepo(BridalContext context)
        {
            this.context = context;
        }

        public Meeting Add(Meeting meeting)
        {
            context.Meetings.Add(meeting);
            context.SaveChanges();
            return meeting;
        }

        public Meeting Delete(DateTime time)
        {
            try
            {
                var meetingToDelete = context.Meetings.Where(m => m.MeetingTime == time).FirstOrDefault();
                context.Meetings.Remove(meetingToDelete);
                context.SaveChanges();
                return meetingToDelete;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in deleting meeting in time: {time}");
            }
        }

        public Meeting Get(DateTime time)
        {
            try
            {
                return context.Meetings.Where(m => m.MeetingTime == time).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single meeting {time} data");
            }
        }

        public List<Meeting> GetAll()
        {
            return context.Meetings.ToList();
        }

        public Meeting Update(Meeting meeting)
        {
            foreach (Meeting m in context.Meetings.ToList())
            {
                if (m.Code == meeting.Code)
                {
                    m.MeetingTime = meeting.MeetingTime;
                    break;
                }
            }
            context.SaveChanges();
            return meeting;
        }
    }
}
