namespace Practica11Ej3
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Algoritmo que se ejecuta al hacer clic en el botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCounterClicked(object sender, EventArgs e)
        {
            //Si el entry nombre contiene caractéres
           if (eNombre.Text != null)
           {
                //Si los entries peso y altura contienen caractéres
                if (ePeso.Text != null && eAltura.Text != null)
                {
                    //Usamos un try
                    try
                    {
                        //Creamos las variables nombre, peso y altura
                        string name = eNombre.Text;
                        double peso = Convert.ToDouble(ePeso.Text), altura = Convert.ToDouble(eAltura.Text);
                        //Mostramos las variables en el label datos, haciendo las conversiones requeridas
                        lbDatos.Text = name + "\r\nPesa : " + (peso * 2.20462).ToString() + "Kg \r\nY mide : " + (altura * 100).ToString() + "cm";
                    }
                    //Si hay una exepcion mostramos esta alerta
                    catch
                    {
                        DisplayAlert("Error", "Revise los datos introducidos", "Ok");
                    }
                    
                }
                //Si no, mostramos esta alerta
                else
                {
                    DisplayAlert("Error", "Ingrese el peso y la altura del dinosaurio", "Ok");
                }
           }
            //Si no, mostramos esta alerta
            else
            {
                DisplayAlert("Error", "Ingrese un nombre para el dinosaurio", "Ok");
           }
        }
    }

}
