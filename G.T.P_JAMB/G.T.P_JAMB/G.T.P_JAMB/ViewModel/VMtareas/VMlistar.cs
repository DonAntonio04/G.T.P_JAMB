using G.T.P_JAMB.Datos;
using G.T.P_JAMB.Model;
using G.T.P_JAMB.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace G.T.P_JAMB.ViewModel.VMtareas
{
    public class VMlistar : BaseViewModel
    {

        #region VARIABLES
        string _Texto;
         Mtareas _Seleccionatarea;
        ObservableCollection<Mtareas> _Listatarea;
        #endregion
        #region CONSTRUCTOR
        public VMlistar(INavigation navigation)
        {
            Navigation = navigation;
            MostrarTarea();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Mtareas> Listatarea
        {
            get { return _Listatarea; }
            set
            {
                SetValue(ref _Listatarea, value);
                OnpropertyChanged();
            }
        }
        public Mtareas Seleccionatarea
        {
            get { return _Seleccionatarea; }
            set
            {
                if (_Seleccionatarea != value)
                {
                    _Seleccionatarea = value;
                }
            }
        }
        #endregion
        #region PROCESOS

        public async Task MostrarTarea()
        {
            var funcion = new Dtareas();
            var lista = await funcion.MostrarTarea();
            Listatarea = lista;
        }

        public async Task Iraregistro()
        {
            await Navigation.PushAsync(new RegistrarTarea());
        }
        //public async Task AbrirVistaEditar()
        //{
        //    await Navigation.PushAsync(new Eliminar(Seleccionapokemon));
        //}

        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());

        //public ICommand AbrirVistaEditarcommand => new Command(async () => await AbrirVistaEditar());

        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
