using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Threading;

namespace FarmaciaNetCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ButtonBorrar_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("on Borrar");
            medicamentoNombre.Text = "";
            medicamentoTipo.SelectedIndex = 0;
            medicamentoCantidad.Text = "0";
            medicamentoDistribuidor1.IsChecked = false;
            medicamentoDistribuidor2.IsChecked = false;
            medicamentoDistribuidor3.IsChecked = false;
            medicamentoEntregaPrincipal.IsChecked = false;
            medicamentoEntregaSecundaria.IsChecked = false;
            limpiarMensajeDeError();
        }
        
        private void ButtonConfirmar_Click(object sender, RoutedEventArgs e)
        {
            limpiarMensajeDeError();
            if (validar())
            {

            }
        }
        
        private Boolean validar() {
            Boolean resultado = true;
            
            if (resultado && !IsAlphaNum(medicamentoNombre.Text)) {
                medicamentoValidacion.Content = "Ingrese el nombre del medicamento correctamente";
                resultado = false;
            }
          
            if (resultado && !IsNumPositivo(medicamentoCantidad.Text))
            {
                medicamentoValidacion.Content = "Ingrese la cantidad del medicamento correctamente";
                resultado = false;
            }

            if (resultado && !IsDistribuidorSeleccionado()) {
                medicamentoValidacion.Content = "No ha seleccionado un distribuidor";
                resultado = false;
            }

            if (resultado && !DestinoSeleccionado())
            {
                medicamentoValidacion.Content = "No ha seleccionado un destino";
                resultado = false;
            }

            if (!resultado)
            {
                System.Diagnostics.Trace.WriteLine("validación no satisfecha");
                System.Diagnostics.Trace.WriteLine(medicamentoValidacion.Content);

            }
           


            return resultado;

        }
                
        private void limpiarMensajeDeError()
        {
            System.Diagnostics.Trace.WriteLine("en limpiarMensajeDeError");
            medicamentoValidacion.Content = "";
        }

        
        private bool IsAlphaNum(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (!(char.IsLetter(str[i])) && (!(char.IsNumber(str[i]))))
                    return false;
            }

            return true;
        }
      
        private bool IsNumPositivo(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            Regex r = new Regex("^[0-9]*$");
            if (r.IsMatch(str))
            {
                int n = Int32.Parse(str);
                if (n > 0)
                {
                    return true;
                }
            }

            return false;
        }
        

        private bool IsDistribuidorSeleccionado()
        {
            if ((bool)medicamentoDistribuidor1.IsChecked) {
                return true;
            }

            if ((bool)medicamentoDistribuidor2.IsChecked)
            {
                return true;
            }

            if ((bool)medicamentoDistribuidor3.IsChecked)
            {
                return true;
            }

            return false;
        }
        
        private bool DestinoSeleccionado()
        {
            if ((bool)medicamentoEntregaPrincipal.IsChecked)
            {
                return true;
            }

            if ((bool)medicamentoEntregaSecundaria.IsChecked)
            {
                return true;
            }

            return false;
        }
        

    }
}
