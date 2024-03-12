using DAL.API;
using DAL.Implementation;
using DAL.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLManager
    {
        public ClientRepo clientRepo { get; }
        public CrownRepo crownRepo { get; }
        public GownRepo gownRepo { get; }
        public MeetingRepo meetingRepo { get; }
        public OrderRepo orderRepo { get; }
        public SceduleRepo sceduleRepo { get; }

        public BLManager()
        {
            ServiceCollection services = new();

        }
    
    }
}
