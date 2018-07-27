using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selecao_Stefanini.Helpers;
using Selecao_Stefanini.Page_Objects.Action;
using System;
using TechTalk.SpecFlow;

namespace Selecao_Stefanini
{
    [Binding]
    public class CompraItensAction
    {
        static IWebDriver _driver;
        static ComprarItensAction _cia;
        

        [BeforeTestRun]
        public static void Setup()
        {
            _driver = new ChromeDriver();
            _cia = new ComprarItensAction(_driver);

        }

        [Given(@"que estou na tela home")]
        public void GivenQueEstouNaTelaHome()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            _cia.ValidarTelaHome();
        }
        
        [When(@"adiciono itens no carrinho")]
        public void WhenAdicionoItensNoCarrinho()
        {
            _cia.AdicionarItensCarrinho();
        }
        
        [When(@"finalizo minha compra")]
        public void WhenFinalizoMinhaCompra()
        {
            _cia.Summary();
            _cia.Login("a@teste.com.br", "123456");
            _cia.Address("Ariel Cintra", "Porto Digital", "Recife, Alaska 99571", "United States", "997452892");
            _cia.Shipping();
            _cia.Payment();
        }
        
        [When(@"insiro meu login")]
        public void WhenInsiroMeuLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"acesso a tela para finalizar minha compra")]
        public void WhenAcessoATelaParaFinalizarMinhaCompra()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"volto para tela home")]
        public void WhenVoltoParaTelaHome()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"adiciono itens na my wishlist")]
        public void WhenAdicionoItensNaMyWishlist()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"valido que fui rediricionado para a pagina home")]
        public void WhenValidoQueFuiRediricionadoParaAPaginaHome()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"volto para tela de login")]
        public void WhenVoltoParaTelaDeLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"insiro meu usuario e senha")]
        public void WhenInsiroMeuUsuarioESenha()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"clico no botao Sign in")]
        public void WhenClicoNoBotaoSignIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"valido que minha compra foi finalizada com sucesso")]
        public void ThenValidoQueMinhaCompraFoiFinalizadaComSucesso()
        {
            _cia.ValidarFinalizacaoCOmpra();
            _driver.Close();
        }
        
        [Then(@"incluo mais itens no carrinho")]
        public void ThenIncluoMaisIntensNoCarrinho(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"valido que estou na tela da my wishlist")]
        public void ThenValidoQueEstouNaTelaDaMyWishlist()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
