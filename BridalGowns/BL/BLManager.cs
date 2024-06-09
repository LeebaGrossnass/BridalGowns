using BL.API;
using BL.Implementation;
using DAL;
using DAL.Implementation;
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
        public ClientService clientService { get; }
        public CrownService crownService { get; }
        public GownService gownService { get; }
        public MeetingScheduleService meetingScheduleService { get; }
        public MeetingService meetingService { get; }
        public OrdersScheduleService ordersScheduleService { get; }
        public OrderService orderService { get; }
        public AccessRightService accessRightService { get; }


        public BLManager(string connString)
        {
            ServiceCollection services = new();
            //services.AddScoped<DALManager>();

            services.AddScoped(d => new DALManager(connString));
            services.AddScoped< IClientService, ClientService>();
            services.AddScoped<ICrownService, CrownService>();
            services.AddScoped<IGownService, GownService>();
            services.AddScoped<IMeetingScheduleService, MeetingScheduleService>();
            services.AddScoped<IMeetingService, MeetingService>();
            services.AddScoped<IOrderService,OrderService>();
            services.AddScoped<IOrdersScheduleService, OrdersScheduleService>();
            services.AddScoped<IAccessRightService, AccessRightService>();
            

            ServiceProvider servicesProvider = services.BuildServiceProvider();
            clientService = (ClientService)servicesProvider.GetRequiredService<IClientService>();
            crownService = (CrownService)servicesProvider.GetRequiredService<ICrownService>();
            gownService = (GownService)servicesProvider.GetRequiredService<IGownService>();
            meetingScheduleService = (MeetingScheduleService)servicesProvider.GetRequiredService<IMeetingScheduleService>();
            meetingService = (MeetingService)servicesProvider.GetRequiredService<IMeetingService>();
            ordersScheduleService = (OrdersScheduleService)servicesProvider.GetRequiredService<IOrdersScheduleService>();
            orderService = (OrderService)servicesProvider.GetRequiredService<IOrderService>();
            accessRightService = (AccessRightService)servicesProvider.GetRequiredService<IAccessRightService>();
        }
    
    }
}
