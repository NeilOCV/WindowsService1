using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        public void OnDebug()
        {
            OnStart(null);
        }
        protected override void OnStart(string[] args)
        {
            System.IO.File.Create(@"C:\Service\Test\" + string.Format("{0:yyyyMMddhhmmss}", DateTime.Now) + " - Start.txt");
        }

        protected override void OnStop()
        {
            System.IO.File.Create(@"C:\Service\Test\" + string.Format("{0:yyyyMMddhhmmss}", DateTime.Now) + " - Stop.txt");
        }
    }
}
