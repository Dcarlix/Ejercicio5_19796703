namespace Ejercicio519796703
{
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// En este ejercicio hacemos que un boton que a la hora de darle click cambara el mensaje que nos va a mostrar, tambien hacemos que el color de la letra, el fondo, el borde, su grosor y los detalles de como se ve el boton cambien a como lo hemos personalizado
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           
        }

		private void Button_Clicked(object sender, EventArgs e)
		{
            (sender as Button).Text = "Presionme de Nuevo";
        }
    }

}
