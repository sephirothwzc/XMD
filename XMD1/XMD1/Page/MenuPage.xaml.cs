using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XMD1.Page
{
    /// <summary>
    /// 导航窗体
    /// </summary>
    public partial class MenuPage : ContentPage
    {
        public MenuPage(MDPage root)
        {
            InitializeComponent();

            //行选择事件
            this.EmployeeView.ItemSelected += (sender, e) =>
            {
                if (EmployeeView.SelectedItem == null)
                    return;

                root.NavigateAsync(((PageTypeGroup)e.SelectedItem).DisplayName);//((HomeMenuItem)e.SelectedItem).MenuType
            };
        }

        /// <summary>
        /// 初始化事件
        /// </summary>
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //初始化数据源
            this.EmployeeView.ItemsSource = new System.Collections.ObjectModel.ObservableCollection<PageTypeGroup>
            {
                new PageTypeGroup("DataGridPage"),
                new PageTypeGroup("DataGridPageStyle"),
                new PageTypeGroup("WebClientPage"),
                new PageTypeGroup("Multilingualism"),
            };
        }
    }

    /// <summary>
    /// 导航用分组
    /// </summary>
    public class PageTypeGroup
    {
        public string DisplayName { get; set; }

        public PageTypeGroup(string title)
        {
            DisplayName = title;
        }
    }
}
