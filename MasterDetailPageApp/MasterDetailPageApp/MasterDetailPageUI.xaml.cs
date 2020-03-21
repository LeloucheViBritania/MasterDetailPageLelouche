using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailPageApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPageUI : MasterDetailPage
    {
        public MasterDetailPageUI()
        {
            InitializeComponent();
            Detail = new NavigationPage(new DashboardPageNanBank());
            IsPresented = false;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new DashboardPageNanBank());
            IsPresented = false;
        }
    }
}