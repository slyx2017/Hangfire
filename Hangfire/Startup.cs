using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire;
using Hangfire.SqlServer;
using System.Collections.Generic;
using System.Diagnostics;
using Hangfire.Dashboard;
using Hangfire.Annotations;
using Common.LogHelper;

//[assembly: OwinStartup(typeof(WebApplication1.Startup))]

namespace WebApplication1
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var options = new DashboardOptions
            {
                Authorization = new[] { new HangfireAuthorizationFilter() }
            };
            GlobalConfiguration.Configuration.UseSqlServerStorage("HangFire");
            
            app.UseHangfireDashboard("/hangfire", options);
            app.UseHangfireServer();

            RecurringJob.AddOrUpdate(() => Test(), Cron.Minutely());
        }
        public class HangfireAuthorizationFilter : IDashboardAuthorizationFilter
        {

            public bool Authorize([NotNull] DashboardContext context)
            {

                //int res = OperatorHelper.Instance.IsOnLine().stateCode;

                //var userinfo = LoginUserInfo.Get();

                //if (res != 1 && !userinfo.account.Equals("system"))
                //    return false;
                //else
                    return true;
            }
        }
        public void Test()
        {
            var log = LogFactory.GetLogger("");
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //Debug.WriteLine(date + " AAAA");
            log.Info("Log:" + date);
        }
    }
}
