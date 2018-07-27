using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selecao_Stefanini.Page_Objects.Action;
using System;
using System.Reflection;
using TechTalk.SpecFlow;

namespace Selecao_Stefanini.Features.Steps_Definitions
{
    [Binding]
    public class CriacaoDeUmNovoUsuarioSteps
    {
        static IWebDriver _driver;
        static LoginAction _la;
        static CadastrarAction _ca;

        [BeforeTestRun]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _la = new LoginAction(_driver);
            _ca = new CadastrarAction(_driver);

           _driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=my-account");
        }

        [Given(@"que estou na tela de login")]
        public void GivenQueEstouNaTelaDeLogin()
        {
            _la.ValidarTelaLogin();
        }

        [Given(@"eu insiro meu email")]
        public void GivenEuInsiroMeuEmail()
        {
            _la.InserirEmailNovoCadastro("stefaniniatuomation@teste.com.br");
        }

        [Given(@"clico no botao CRIAR CONTA")]
        public void GivenClicoNoBotaoCRIARCONTA()
        {
            _la.ClicarBotaoCadastrarUsuario();
        }

        [When(@"eu cadastrar meus dados validos")]
        public void WhenEuCadastrarMeusDadosValidos()
        {
            _ca.SelectMrsTitle();
            _ca.InsertFirstName("Ariel");
            _ca.InsertLastName("Cintra");
            _ca.InsertPsswd("123456");
            _ca.SelectDateofBirth("30", "1", "1995");
            _ca.InsertAddress("Porto Digital");
            _ca.InsertCity("Recife");
            _ca.SelectState("2");
            _ca.InsertZipCode("99571");
            _ca.InsertMobilePhone("997452892");
            _ca.ClickRegisterButton();
        }

        [Then(@"valido que os meus dados cadastrados estao corretos")]
        public void ThenValidoQueOsMeusDadosCadastradosEstaoCorretos()
        {
            _ca.ValidoDadosCadastradosAddress("http://automationpractice.com/index.php?controller=addresses", "Ariel", "Cintra", "Porto Digital", "Recife", "Alaska", "99571");
            _ca.ValidoDadosCadastradosPersonal("http://automationpractice.com/index.php?controller=identity", "Ariel", "Cintra", "stefaniniatuomation@teste.com.br");
            _driver.Close();
        }
    }
}
