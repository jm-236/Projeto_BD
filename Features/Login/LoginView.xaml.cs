using System;
using System.Threading.Tasks;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Npgsql;
using patrimonioDB.Shared.Database;
using patrimonioDB.Shared.Utils;

namespace patrimonioDB.Features.Login
{
    public sealed partial class LoginView : Page
    {
        public LoginView()
        {
            this.InitializeComponent();
        }

        private async void EntrarButton_Click(object sender, RoutedEventArgs e)
        {
            // Esconder mensagens anteriores
            MensagemErro.Visibility = Visibility.Collapsed;
            MensagemSucesso.Visibility = Visibility.Collapsed;

            // Validação básica de campos vazios
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MostrarErro("Por favor, informe o email.");
                return;
            }

            if (string.IsNullOrWhiteSpace(SenhaPasswordBox.Password))
            {
                MostrarErro("Por favor, informe a senha.");
                return;
            }

            // Mostrar loading
            LoadingRing.IsActive = true;
            LoadingRing.Visibility = Visibility.Visible;
            EntrarButton.IsEnabled = false;

            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    MostrarSucesso($"Conectado ao banco! Estado: {connection.State}");
                
                }
            }
            
            catch (NpgsqlException ex)
            {
                MostrarErro($"Npgsql Error:\n{ex.Message}\nCode: {ex.ErrorCode}\nSqlState: {ex.SqlState}");
            }
            catch (Exception ex)
            {
                MostrarErro($"Error: {ex.Message}\n{ex.StackTrace}");
            }
            finally
            {
                // Esconder loading
                LoadingRing.IsActive = false;
                LoadingRing.Visibility = Visibility.Collapsed;
                EntrarButton.IsEnabled = true;
            }
        }

        private void MostrarErro(string mensagem)
        {
            MensagemErro.Text = mensagem;
            MensagemErro.Visibility = Visibility.Visible;
        }

        private void MostrarSucesso(string mensagem)
        {
            MensagemSucesso.Text = mensagem;
            MensagemSucesso.Visibility = Visibility.Visible;
        }
    }
}
