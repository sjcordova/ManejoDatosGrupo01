using ManejoDatosGrupo01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDatosGrupo01.Interfaces
{
    public interface IEstudianteUDLARepository
    {
        IEnumerable<EstudianteUDLA> DevuelveListadoEstudiantes();
        EstudianteUDLA DevuelveEstudianteUDLA(int id);
        bool CrearEstudianteUDLA(EstudianteUDLA estudiante);
        bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante);
        bool EliminarEstudianteUDLA(int id);
    }
}
