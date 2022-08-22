using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeSalaryCalculationSystem.Startup))]
namespace EmployeeSalaryCalculationSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
