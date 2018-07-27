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

        [When(@"faco o log off")]
        public void WhenFacoOLogOff()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php?mylogout=");
        }

        [When(@"finalizo minha compra")]
        public void WhenFinalizoMinhaCompra()
        {
            _cia.AcessarSummary();
            _cia.Summary();
            _cia.Login("a@teste.com.br", "123456");
            _cia.Address("Ariel Cintra", "Porto Digital", "Recife, Alaska 99571", "United States", "997452892");
            _cia.Shipping();
            _cia.Payment();
        }
        
        [When(@"insiro meu login")]
        public void WhenInsiroMeuLogin()
        {
            _cia.Login("a@teste.com.br", "123456");
        }
        
        [When(@"acesso a tela para finalizar minha compra")]
        public void WhenAcessoATelaParaFinalizarMinhaCompra()
        {
            _cia.AcessarSummary();
        }
        
        [When(@"volto para tela home")]
        public void WhenVoltoParaTelaHome()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            _cia.ValidarTelaHome();
        }
        
        [When(@"adiciono itens na my wishlist")]
        public void WhenAdicionoItensNaMyWishlist()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            _cia.AdicionarItensMyWishList();
        }
        
        [When(@"valido que fui rediricionado para a pagina home")]
        public void WhenValidoQueFuiRediricionadoParaAPaginaHome()
        {
            _cia.ValidarTelaHome();
        }
        
        [When(@"realizo login")]
        public void WhenVoltoParaTelaDeLogin()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            _cia.Login("a@teste.com.br", "123456");
        }
        
        [Then(@"valido que minha compra foi finalizada com sucesso")]
        public void ThenValidoQueMinhaCompraFoiFinalizadaComSucesso()
        {
            _cia.ValidarFinalizacaoCOmpra();
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php?mylogout=");
        }
        
        [Then(@"incluo mais itens no carrinho")]
        public void ThenIncluoMaisIntensNoCarrinho()
        {
            _cia.AdicionarMaisItensCarrinho();
        }
        
        [Then(@"valido que estou na tela da my wishlist")]
        public void ThenValidoQueEstouNaTelaDaMyWishlist()
        {
            _cia.ValidarTelaMyWishList();
            _driver.Close();
        }
    }
}
