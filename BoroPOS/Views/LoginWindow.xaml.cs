using BoroPOS.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BoroPOS.Views
{
    /// <summary>
    /// Lógica de interacción para LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void SoloNumeros(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !e.Text.All(char.IsDigit);
        }

        private void Minimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Cerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private bool passwordVisible = false;

        private void MostrarPassword_Click(object sender, RoutedEventArgs e)
        {
            if (!passwordVisible)
            {
                txtPasswordVisible.Text = txtPasswordOculto.Password;
                txtPasswordOculto.Visibility = Visibility.Collapsed;
                txtPasswordVisible.Visibility = Visibility.Visible;
                passwordVisible = true;
            }
            else
            {
                txtPasswordOculto.Password = txtPasswordVisible.Text;
                txtPasswordVisible.Visibility = Visibility.Collapsed;
                txtPasswordOculto.Visibility = Visibility.Visible;
                passwordVisible = false;
            }
        }

        private void Entrar_Click(object sender, RoutedEventArgs e)
        {
            var empleadoId = txtEmpleadoId.Text;
            var pin = txtPasswordOculto.Password;

            if (string.IsNullOrEmpty(empleadoId) || string.IsNullOrEmpty(pin)) 
            {
                MessageBox.Show("Por Favor ingresa tu Empleado ID y tu PIN");
                return;
            }

            var service = new EmpleadoService();
            var empleado = service.BuscarPorCredenciales(empleadoId, pin);

            if (empleado == null)
            {
                MessageBox.Show("Empleado ID o PIN incorrectos.");
                return;
            }

            MessageBox.Show($"Bienvenido, {empleado.Nombre}!");
        }
    }
}
