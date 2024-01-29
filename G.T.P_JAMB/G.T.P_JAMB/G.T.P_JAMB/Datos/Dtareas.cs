using Firebase.Database;
using Firebase.Database.Query;
using G.T.P_JAMB.Conexion;
using G.T.P_JAMB.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace G.T.P_JAMB.Datos
{
    public class Dtareas
    {
        public async Task InsertarTarea(Mtareas parametros)
        {
            await Cconexioon.firebase
                .Child("Tareas")
                .PostAsync(new Mtareas()
                {
                    IdTarea = Guid.NewGuid(),
                    Titulo = parametros.Titulo,
                    Descripcion = parametros.Descripcion,
                    Estatus = parametros.Estatus,   
                }   
                );    
            
        }
        public async Task<ObservableCollection<Mtareas>>MostrarTarea()
        {
            var data = await Task.Run(() => Cconexioon.firebase
            .Child("Tareas")
            .AsObservable<Mtareas>()
            .AsObservableCollection());
            return data;
        }
    }
}

