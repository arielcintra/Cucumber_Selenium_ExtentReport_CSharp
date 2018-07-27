using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Selecao_Stefanini.Helpers;
using Selecao_Stefanini.Page_Objects.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecao_Stefanini.Page_Objects.Action
{
    public class LoginAction : LoginPage
    {
        IWebDriver _driver;

        #region Inicialização driver
        public LoginAction(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        #endregion

        public void ValidarTelaLogin()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Assert.IsTrue(lbLoginAuth.Displayed);
        }

        #region Ações para cadastrar usuário
        public void InserirEmailNovoCadastro(String email)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Assert.IsTrue(lbLoginAuth.Displayed);
            txtEmail.SendKeys(email);
        }

        public void ClicarBotaoCadastrarUsuario()
        {
            btnCreate.Click();
        }
        #endregion

        #region Ações para realizar login
        public void InserirUsuario(String usr)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            txtUser.SendKeys(usr);
        }

        public void InserirSenha(String psswd)
        {
            txtPassword.SendKeys(psswd);
        }

        public void ClicarBotaoSignIn()
        {
            btnLogin.Click();
        }
        #endregion

        public void ValidarTelaMyAccount()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Assert.IsTrue(_driver.FindElement(By.XPath("//*[@id='center_column']/h1")).Displayed);
            _driver.FindElement(By.XPath("//*[@id='center_column']/ul/li/a/span")).Click();
        }

        public void ValidarTelaHome()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Assert.IsTrue(_driver.Title.Equals("My Store"));
        }

        public void ValidarErroLogin()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            String errorDescription = _driver.FindElement(By.XPath("//*[@id='center_column']/div[1]/ol/li")).Text;
            Assert.IsTrue(errorDescription.Equals("Authentication failed."));
        }
    }
}
