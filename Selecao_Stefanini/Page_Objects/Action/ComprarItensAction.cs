using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Selecao_Stefanini.Helpers;
using Selecao_Stefanini.Page_Objects.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selecao_Stefanini.Page_Objects.Action
{
    public class ComprarItensAction : ComprarItensPage
    {
        IWebDriver _driver;
        LoginAction _la;

        String ValorCompraTotal = "";


        #region Inicialização driver
        public ComprarItensAction(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        #endregion

        public void ValidarTelaHome()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(_driver.Title.Equals("My Store"));
        }

        public void AdicionarItensCarrinho()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            product1.Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            btnAddToCart.Click();

            Thread.Sleep(3000);
            Assert.IsTrue(lbAddedToCartSucess.Displayed);

            _driver.Navigate().Back();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            product2.Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            btnAddToCart.Click();

            Thread.Sleep(3000);
            Assert.IsTrue(lbAddedToCartSucess.Displayed);
        }

        public void AdicionarMaisItensCarrinho()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            product3.Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            btnAddToCart.Click();

            Thread.Sleep(3000);
            Assert.IsTrue(lbAddedToCartSucess.Displayed);
        }

            public void AdicionarItensMyWishList()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            product1.Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            btnAddToWiishList.Click();
        }

        public void AcessarSummary()
        {
            Thread.Sleep(1000);
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=order");
        }

        public void Summary()
        {
            Thread.Sleep(2000);
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=order&step=1");
        }

        public void Login(String usr, String psswd)
        {
            _la = new LoginAction(_driver);
            _la.InserirUsuario(usr);
            _la.InserirSenha(psswd);

            _la.ClicarBotaoSignIn();
        }

        public void Address(String name, String address, String city, String Country, String number)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            #region DELIVERY VALIDATION
            String nameUsr = _driver.FindElement(By.XPath("//*[@id='address_delivery']/li[2]")).Text;
            Assert.IsTrue(nameUsr.Equals(name));

            String addressUsr = _driver.FindElement(By.XPath("//*[@id='address_delivery']/li[3]")).Text;
            Assert.IsTrue(addressUsr.Equals(address));

            String cityUsr = _driver.FindElement(By.XPath("//*[@id='address_delivery']/li[4]")).Text;
            Assert.IsTrue(cityUsr.Equals(city));

            String countryUsr = _driver.FindElement(By.XPath("//*[@id='address_delivery']/li[5]")).Text;
            Assert.IsTrue(countryUsr.Equals(Country));

            String numberUsr = _driver.FindElement(By.XPath("//*[@id='address_delivery']/li[6]")).Text;
            Assert.IsTrue(numberUsr.Equals(number));
            #endregion

            #region BILLING VALIDATION
            String nameUsrPers = _driver.FindElement(By.XPath("//*[@id='address_invoice']/li[2]")).Text;
            Assert.IsTrue(nameUsrPers.Equals(name));

            String addressUsrPers = _driver.FindElement(By.XPath("//*[@id='address_delivery']/li[3]")).Text;
            Assert.IsTrue(addressUsrPers.Equals(address));

            String cityUsrPers = _driver.FindElement(By.XPath("//*[@id='address_delivery']/li[4]")).Text;
            Assert.IsTrue(cityUsrPers.Equals(city));

            String countryUsrPer = _driver.FindElement(By.XPath("//*[@id='address_delivery']/li[5]")).Text;
            Assert.IsTrue(countryUsrPer.Equals(Country));

            String numberUsrPer = _driver.FindElement(By.XPath("//*[@id='address_delivery']/li[6]")).Text;
            Assert.IsTrue(numberUsrPer.Equals(number));
            #endregion

            btnProceedAddress.Click();
        }

        public void Shipping()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            btnAgree.Click();

            btnProceedCarrier.Click();
        }

        public void Payment()
        {
            String valorCompra = lbValorCompraTotal.Text;
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php?fc=module&module=bankwire&controller=payment");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            String amount = lbAmount.Text;

            Assert.IsTrue(valorCompra.Equals(amount));
            amount = ValorCompraTotal;
            btnConfirmOrder.Click();
        }

        public void ValidarFinalizacaoCOmpra()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            String valorFinal = _driver.FindElement(By.ClassName("price")).Text;

            Assert.IsTrue(lbOrderComplete.Text.Equals("Your order on My Store is complete."));
            Assert.IsTrue(valorFinal.Equals(ValorCompraTotal));
        }

        public void ValidarTelaMyWishList()
        {
            Assert.IsFalse(_driver.Title.Equals("My Store"));
        }
    }
}
