using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selecao_Stefanini.Page_Objects.Action;
using System;
using TechTalk.SpecFlow;

namespace Selecao_Stefanini
{
    [Binding]
    public class AutenticacaoDeUsuarioSteps
    {
        static IWebDriver _driver;
        static LoginAction _la;

        #region INJEÇÃO DEPENDENCIAS
        [BeforeTestRun]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _la = new LoginAction(_driver);

        }
        #endregion

        [Given(@"que eu insiro meu usuario e senha validos")]
        public void GivenEuInsiroMeuUsuarioESenhaValidos()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=my-account");
            _la.InserirUsuario("c@teste.com.br");
            _la.InserirSenha("123456");
        }

        [Given(@"que eu insiro meu usuario e senha invalidos")]
        public void GivenEuInsiroMeuUsuarioESenhaInvalidos()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=my-account");
            _la.InserirUsuario("erro@teste.com.br");
            _la.InserirSenha("0979273981");
        }

        [Given(@"clico no botao Sign in")]
        public void WhenClicoNoBotaoSignIn()
        {
            _la.ClicarBotaoSignIn();
        }
        
        [When(@"valido que fui redirecionada para tela myaccount")]
        public void ThenValidoQueFuiRedirecionadaParaTelaMyaccount()
        {
            _la.ValidarTelaMyAccount();
        }

        [Then(@"valido que fui redirecionada para tela home")]
        public void ThenValidoQueFuiRedirecionadaParaTelaHome()
        {
            _la.ValidarTelaHome();
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php?mylogout=");
        }

        [Then(@"valido erro ao efetuar o login")]
        public void ThenValidoErroAoEfetuarOLogin()
        {
            _la.ValidarErroLogin();
            _driver.Close();
        }
    }
}
