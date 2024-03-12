using DAL.API;
using DAL.Implementation;
using DAL.Models;
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
        public CrownRepo crownRepo { get; }
        public GownRepo gownRepo { get; }
        public MeetingRepo meetingRepo { get; }
        public OrderRepo orderRepo { get; }
        public SceduleRepo sceduleRepo { get; }
        public DALManager() 
        {
            ServiceCollection services = new();

            services.AddDbContext<BridalContext>();
            services.AddScoped<IClientRepo, ClientRepo>();
            services.AddScoped<ICrownRepo, CrownRepo>();
            services.AddScoped<IGownRepo, GownRepo>();
            services.AddScoped<IMeetingRepo, MeetingRepo>();
            services.AddScoped<IOrderRepo, OrderRepo>();
            services.AddScoped<ISceduleRepo, SceduleRepo>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();

            clientRepo = serviceProvider.GetRequiredService<ClientRepo>();
            crownRepo = serviceProvider.GetRequiredService<CrownRepo>();
            gownRepo = serviceProvider.GetRequiredService<GownRepo>();
            meetingRepo = serviceProvider.GetRequiredService<MeetingRepo>();
            orderRepo = serviceProvider.GetRequiredService<OrderRepo>();
            sceduleRepo = serviceProvider.GetRequiredService<SceduleRepo>();
        }
    }
}
