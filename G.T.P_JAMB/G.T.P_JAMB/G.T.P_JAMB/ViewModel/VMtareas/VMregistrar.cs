using G.T.P_JAMB.Model;
using G.T.P_JAMB.Datos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace G.T.P_JAMB.ViewModel.VMtareas
{
    public class VMregistrar : BaseViewModel
    {

        #region VARIABLE
        string _TxtTitulo;
        string _TxtDescripcion;
        string _TxtEstatus;
        #endregion
        #region CONSTRUCTOR 
        public VMregistrar(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion
        #region OBJETOS
        public string TxtTitulo
        {
            get { return _TxtTitulo; }
            set { SetValue(ref _TxtTitulo, value); }

        }
        public string TxtDescripcion
        {
            get { return _TxtDescripcion; }
            set { SetValue(ref _TxtDescripcion, value); }
        
        }
        public string TxtEstatus
        {
            get { return _TxtEstatus; }
            set { SetValue(ref _TxtEstatus, value); }   
        }
        #endregion
        #region PROCESOS
        public async Task Insertar()
        {
            var funcion = new Dtareas();
            var parametros = new Mtareas();
            parametros.Titulo = TxtTitulo; 
            parametros.Descripcion = TxtDescripcion;
            parametros.Estatus = TxtEstatus;
            await funcion.InsertarTarea(parametros);  
        }
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        #endregion
        #region COMANDOS
        public ICommand Insertarcommand => new Command(async () => await Insertar());
        public ICommand RegresarCommand => new Command(async () => await Volver());
        #endregion
    }
}
