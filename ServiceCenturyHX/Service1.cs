using Chanjet.TP.OpenAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace ServiceCenturyHX
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        public void OnStart()
        {
            OpenAPI api = new OpenAPI("", new Credentials() {
                AppKey = "",
                AppSecret=""
            });
        }

        protected override void OnStop()
        {

        }
    }
}
