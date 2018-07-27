using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecao_Stefanini.Page_Objects.Page
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        #region VALIDAÇÃO QUE ESTÁ NA TELA DE LOGIN
        [FindsBy(How = How.Id, Using = "center_column")]
        public IWebElement lbLoginAuth;
        #endregion

        #region OBJETOS PARA CRIAR NOVO USUÁRIO
        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement txtEmail;

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        public IWebElement btnCreate;
        #endregion

        #region OBJETOS PARA REALIZAR LOGIN
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtUser;

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement txtPassword;

        [FindsBy(How = How.ClassName, Using = "lost_password")]
        public IWebElement btnForgotPassword;

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement btnLogin;
        #endregion

        #region OBJETOS PARA ESQUECI SENHA
        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/div/h1")]
        public IWebElement lbForgotPsswd;

        [FindsBy(How = How.XPath, Using = "//*[@id='form_forgotpassword']/fieldset/p/button/span")]
        public IWebElement btnForgotPsswd;
        #endregion

        public LoginPage(IWebDriver driver)
        {
           this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

    }
}
