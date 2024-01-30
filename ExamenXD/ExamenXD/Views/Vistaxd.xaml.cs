using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenXD.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenXD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vistaxd : ContentPage
    {
        public Vistaxd()
        {
            InitializeComponent();
            BindingContext = new VMvistaxd(Navigation);
        }
    }
}