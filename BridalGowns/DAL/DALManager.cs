using DAL;
using DAL.API;
using DAL.Implementation;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALManager
    {
        public ClientRepo clientRepo { get; }
        public ColorRepo colorRepo { get; }
        public CrownRepo crownRepo { get; }
        public GownRepo gownRepo { get; }
        public MeetingScheduleRepo meetingScheduleRepo { get; }
        public MeetingRepo meetingRepo { get; }
        public OrderRepo orderRepo { get; }
        public OrdersScheduleRepo ordersScheduleRepo { get; }
        public AccessRightRepo accessRightRepo { get; }
        public DALManager(string connString) 
        {
            ServiceCollection services = new();

            services.AddDbContext<BridalContext>((op => op.UseSqlServer(connString)));
            services.AddScoped<IClientRepo, ClientRepo>();
            services.AddScoped<IColorRepo, ColorRepo>();
            services.AddScoped<ICrownRepo, CrownRepo>();
            services.AddScoped<IGownRepo, GownRepo>();
            services.AddScoped<IMeetingScheduleRepo, MeetingScheduleRepo>();
            services.AddScoped<IMeetingRepo, MeetingRepo>();
            services.AddScoped<IOrderRepo, OrderRepo>();    
            services.AddScoped<IOrdersScheduleRepo, OrdersScheduleRepo>();
            services.AddScoped<IAccessRightRepo, AccessRightRepo>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();

            clientRepo = (ClientRepo)serviceProvider.GetRequiredService<IClientRepo>();
            colorRepo = (ColorRepo)serviceProvider.GetRequiredService<IColorRepo>();
            crownRepo = (CrownRepo)serviceProvider.GetRequiredService<ICrownRepo>();
            gownRepo = (GownRepo)serviceProvider.GetRequiredService<IGownRepo>();
            meetingScheduleRepo = (MeetingScheduleRepo)serviceProvider.GetService<IMeetingScheduleRepo>();
            meetingRepo = (MeetingRepo)serviceProvider.GetRequiredService<IMeetingRepo>();
            orderRepo = (OrderRepo)serviceProvider.GetRequiredService<IOrderRepo>();
            ordersScheduleRepo = (OrdersScheduleRepo)serviceProvider.GetRequiredService<IOrdersScheduleRepo>();
            accessRightRepo = (AccessRightRepo)serviceProvider.GetRequiredService<IAccessRightRepo>();
        }
    }
}



