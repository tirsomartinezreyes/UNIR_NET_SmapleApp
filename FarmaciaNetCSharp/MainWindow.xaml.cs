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
using System.Net;

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
                

                string titulo = "Pedido al distribuidor " + getDistribuidor();
                string texto = medicamentoCantidad.Text + " unidades del " + getTipoMedicamento() + " " + medicamentoNombre.Text;
                string direccion = (getDestino());

                System.Diagnostics.Trace.WriteLine(titulo);
                System.Diagnostics.Trace.WriteLine(texto);
                System.Diagnostics.Trace.WriteLine(direccion);

                Window1 resumen = new Window1(titulo, texto, direccion);
                resumen.Show();

                //System.Diagnostics.Trace.WriteLine(medicamentoNombre.Text);
                //System.Diagnostics.Trace.WriteLine(getTipoMedicamento());
                //System.Diagnostics.Trace.WriteLine(medicamentoCantidad.Text);
                //System.Diagnostics.Trace.WriteLine(getDistribuidor());
                //System.Diagnostics.Trace.WriteLine(getDestino());
            }
        }
        
        private Boolean validar() {
            Boolean resultado = true;
            
            if (resultado && !IsAlphaNum(medicamentoNombre.Text)) {
                medicamentoValidacion.Content = "Ingrese el nombre del medicamento correctamente";
                resultado = false;
            }

            if (resultado && getTipoMedicamento() == "") {

                medicamentoValidacion.Content = "Seleccione el tipo de medicamento";
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

        private string getTipoMedicamento() {
            string response = "";

            if (medicamentoTipo.SelectedIndex >-1) { 
                response = medicamentoTipo.SelectedValue.ToString();
            }
            return response;
        }
        private string getDistribuidor() {
            string response = "";

            if ((bool)medicamentoDistribuidor1.IsChecked)
            {
                return medicamentoDistribuidor1.Content.ToString();
            }

            if ((bool)medicamentoDistribuidor2.IsChecked)
            {
                return medicamentoDistribuidor2.Content.ToString(); ;
            }

            if ((bool)medicamentoDistribuidor3.IsChecked)
            {
                return medicamentoDistribuidor3.Content.ToString(); ;
            }
            return response;
        }

        private string getDestino() {
            string response = "";

            if ((bool)medicamentoEntregaPrincipal.IsChecked)
            {
                response = response + "para la farmacia situada en Calle de la Rosa n.28";
            }

            if ((bool)medicamentoEntregaSecundaria.IsChecked)
            {
                if (response != ""){
                    response = response + " y ";
                }

                response = response + "para la farmacia situada en Calle Alcazabilla n.3";
            }

            return response;
        }
        

    }
}
