using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MOD3_ACT1.ViewModel;

namespace MOD3_ACT1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageView : ContentPage
    {
        public PageView()
        {
            InitializeComponent();
            BindingContext = new StudentViewModel();
        }
    }
}