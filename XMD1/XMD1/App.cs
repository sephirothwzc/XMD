using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonCLR;

using Xamarin.Forms;
using XMD1.Page;

namespace XMD1
{
    public class App : Application
    {
        /// <summary>
        /// 公共webclient
        /// </summary>
        public static IWebClient_clr webclient { get; set; }

        public App()
        {
            // The root page of your application
            //MainPage = new MDPage();
            MainPage = new CXFAGrid();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
