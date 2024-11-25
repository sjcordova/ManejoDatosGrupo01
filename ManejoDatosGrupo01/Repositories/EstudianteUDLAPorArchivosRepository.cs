using ManejoDatosGrupo01.Interfaces;
using ManejoDatosGrupo01.Models;
using Newtonsoft.Json;

namespace ManejoDatosGrupo01.Repositories
{
    public class EstudianteUDLAPorArchivosRepository : IEstudianteUDLARepository
    {
        private string _fileName  = Path.Combine(FileSystem.AppDataDirectory, "estudiantes.txt");

        public bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(estudiante);
                File.WriteAllText(_fileName, json_data);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public EstudianteUDLA DevuelveEstudianteUDLA(int id)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA();

            if (File.Exists(_fileName))
            {
                string json_data = File.ReadAllText(_fileName);
                estudiante = JsonConvert.DeserializeObject<EstudianteUDLA>(json_data);
            }

            return estudiante;
        }

        public IEnumerable<EstudianteUDLA> DevuelveListadoEstudiantes()
        {
            throw new NotImplementedException();
        }

        public bool EliminarEstudianteUDLA(int id)
        {
            throw new NotImplementedException();
        }
    }
}
