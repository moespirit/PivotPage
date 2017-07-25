using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Yinyue200.Controls.PivotPage;

namespace PivotPageNewDemo
{
	public partial class MainPage : PivotPage
    {
		public MainPage()
		{
			InitializeComponent();
            Headers = new string[] { "1", "2" };
            Views = Views.ToArray();//暴力方法强行让内部发现属性值已经变化
        }
	}
    public static class PivotPageHelper
    {
        public static void Dispose(this Yinyue200.Controls.PivotPage.PivotPage page)
        {
#if ANDROID
            foreach(var one in page.Views)
            {
                var renderer = Platform.GetRenderer(one);
                if (renderer != null)
                {
                    renderer.View.RemoveFromParent();
                }
            }
#endif
        }
    }
}
