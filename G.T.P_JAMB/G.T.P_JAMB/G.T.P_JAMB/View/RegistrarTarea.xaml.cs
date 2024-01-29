using G.T.P_JAMB.ViewModel.VMtareas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace G.T.P_JAMB.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrarTarea : ContentPage
    {
        public RegistrarTarea()
        {
            InitializeComponent();
            BindingContext = new VMregistrar(Navigation);
        }
    }
}