﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test4.Startup))]
namespace test4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // from local
            // test from web
            ConfigureAuth(app);
        }
    }
}
