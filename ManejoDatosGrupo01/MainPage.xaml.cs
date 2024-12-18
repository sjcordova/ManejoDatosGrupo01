using ManejoDatosGrupo01.Interfaces;
using ManejoDatosGrupo01.Models;
using ManejoDatosGrupo01.Repositories;
using ManejoDatosGrupo01.ViewModels;

namespace ManejoDatosGrupo01
{
    public partial class MainPage : ContentPage
    {
        //IEstudianteUDLARepository _estudianteUDLARepository;
        //EstudianteUDLA estudiante = new EstudianteUDLA();

        public MainPage()
        {
            /*_estudianteUDLARepository = new EstudianteUDLASQLiteRepository();
            InitializeComponent();


            estudiante = _estudianteUDLARepository.DevuelveEstudianteUDLA(1);

            BindingContext = estudiante;*/

            InitializeComponent();
            var viewModel = new EstudianteUDLAViewModel();
            BindingContext = viewModel;

            viewModel.ShowAlert += async () =>
            {
                await DisplayAlert("Alerta", "¡Se ha cambiado el mensaje!", "OK");
            };
        }



        /*private async void GuardarEstudiante_Clicked(object sender, EventArgs e)
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

        }*/

    }

}
