using ManejoDatosGrupo01.Interfaces;
using ManejoDatosGrupo01.Models;
using ManejoDatosGrupo01.Repositories;

namespace ManejoDatosGrupo01
{
    public partial class MainPage : ContentPage
    {
        IEstudianteUDLARepository _estudianteUDLARepository;
        EstudianteUDLA estudiante = new EstudianteUDLA();

        public MainPage()
        {
            _estudianteUDLARepository = new EstudianteUDLAPorArchivosRepository();
            InitializeComponent();


            estudiante = _estudianteUDLARepository.DevuelveEstudianteUDLA(1);

            BindingContext = estudiante;
        }



        private async void GuardarEstudiante_Clicked(object sender, EventArgs e)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA
            {
                Id = Int32.Parse(editor_id.Text),
                Nombre = editor_nombre.Text,
                Carrera = editor_carrera.Text,
            };

            bool guardar_estudiante = _estudianteUDLARepository.CrearEstudianteUDLA(estudiante);

            if (guardar_estudiante)
            {
                await DisplayAlert("Alerta", "Todo Posi", "OK");
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Alerta", "Negado mi pana", "OK");
            }

        }

    }

}
