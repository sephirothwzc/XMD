using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XMD1.Page;

namespace XMD1
{
    /// <summary>
    /// 主界面
    /// </summary>
    public class MDPage: MasterDetailPage
    {
        /// <summary>
        /// 导航
        /// </summary>
        public Dictionary<string, NavigationPage> Pages { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public MDPage()
        {
            //初始化导航
            Pages = new Dictionary<string, NavigationPage>();

            Master = new MenuPage(this)
            {
                Title="Neusoft-demo"
            };
            BindingContext = new NavigationPage()
            {
                Title = "NEUSOFT-demo"
            };
            //setup home page
            var dgpage = new NavigationPage(new ContentPage() { Title="我是主页"});
            Detail = dgpage;
            Pages.Add("主页", dgpage);
        }

        /// <summary>
        /// 导航窗体
        /// </summary>
        /// <param name="displayName"></param>
        internal async void NavigateAsync(string displayName)
        {
            NavigationPage newPage;
            NavigationPage tpage;
            if (!Pages.Any(p => p.Key.Equals(displayName)))
            {
                switch (displayName)
                {
                    case "DataGridPage":
                        tpage = new NavigationPage(new DxpDataGrid());
                        Pages.Add(displayName, tpage);
                        break;
                    case "DataGridPageStyle":
                        tpage = new NavigationPage(new DxpDataGridStyle());
                        Pages.Add(displayName, tpage);
                        break;
                    case "WebClientPage":
                        tpage = new NavigationPage(new WebClientPage());
                        Pages.Add(displayName, tpage);
                        break;
                    case "Multilingualism":
                        tpage = new NavigationPage(new Multilingualism());
                        Pages.Add(displayName, tpage);
                        break;
                }
            }
            newPage = Pages[displayName];
            if (newPage == null)
                return;

            //pop to root for Windows Phone
            if (Detail != null && Device.OS == TargetPlatform.WinPhone)
            {
                await Detail.Navigation.PopToRootAsync();
            }

            Detail = newPage;

            if (Device.Idiom != TargetIdiom.Tablet)
                IsPresented = false;
        }
    }
}
