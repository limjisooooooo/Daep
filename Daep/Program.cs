using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daep
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LifetimeServices.LeaseTime = TimeSpan.FromSeconds(5);
            LifetimeServices.LeaseManagerPollTime = TimeSpan.FromSeconds(5);
            LifetimeServices.RenewOnCallTime = TimeSpan.FromSeconds(1);
            LifetimeServices.SponsorshipTimeout = TimeSpan.FromSeconds(5);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
