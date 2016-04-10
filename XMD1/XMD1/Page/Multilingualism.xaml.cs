using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XMD1.Page
{
    /// <summary>
    /// 多语言窗体
    /// </summary>
    public partial class Multilingualism : ContentPage
    {
        public Multilingualism()
        {
            InitializeComponent();

            this.enbtn.Clicked += Enbtn_Clicked;
        }

        /// <summary>
        /// 英文按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enbtn_Clicked(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 中文按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zhclicked(object sender, EventArgs e)
        {
            
        }
    }
}
