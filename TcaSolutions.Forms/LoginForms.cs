using TcaSolutions.Data.Interfaces;
using TcaSolutions.Services.Interfaces;
using TcaSolutions.Shared.DTOs;
using TcaSolutions.Shared.Enums;
using TcaSolutions.Shared.ViewModels;

namespace TcaSolutions.Forms
{
    public partial class LoginForms : Form
    {
        private readonly IAuthenticationServices _iAuthenticationServices;
        private readonly ILoginDefault _iLoginDefault;

        public LoginForms(IAuthenticationServices iAuthenticationServices, ILoginDefault iLoginDefault)
        {
            _iAuthenticationServices = iAuthenticationServices;
            _iLoginDefault = iLoginDefault;
            VerifyLoginDefault();
            InitializeComponent();
        }

        private async Task VerifyLoginDefault()
        {
            await _iLoginDefault.CreateDefaultLogin();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void enterButton_Click(object sender, EventArgs e)
        {
            LoginViewModel loginViewModel = new LoginViewModel()
            {
                User = textBoxUser.Text,
                Password = textBoxPassword.Text,
            };

            ServiceResponseDTO<EnumLogin> servicesResposeDTO = await _iAuthenticationServices.Login(loginViewModel);

            if (servicesResposeDTO.GenericData == EnumLogin.Authorized)
            {
                MainForms mainForms = new MainForms();
                mainForms.Show();
            }
            else
            {
                MessageBox.Show($"Senha ou usuário incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}