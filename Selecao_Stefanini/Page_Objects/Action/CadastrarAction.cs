using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selecao_Stefanini.Helpers;
using Selecao_Stefanini.Page_Objects.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecao_Stefanini.Page_Objects.Action
{
    public class CadastrarAction : CadastrarPage
    {
        IWebDriver _driver;

        #region Inicialização driver
        public CadastrarAction(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        #endregion

        #region PERSONAL INFORMATION
        public void SelectMrsTitle()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            rdbIdGenderMrs.Click();
        }

        public void InsertFirstName(String firstName)
        {
            txtFirstName.SendKeys(firstName);
        }

        public void InsertLastName(String lasttName)
        {
            txtLastName.SendKeys(lasttName);
        }

        public void VerifyEmail(String email)
        {
            var usr = txtEmail.Text;

            Assert.IsTrue(usr.Equals(email));
        }

        public void InsertPsswd(String psswd)
        {
            txtPassword.SendKeys(psswd);
        }

        public void SelectDateofBirth(String day, String month, String year)
        {
            var bDay = new SelectElement(selBday);
            bDay.SelectByValue(day);

            var bMonth = new SelectElement(selBMonth);
            bMonth.SelectByValue(month);

            var bYear = new SelectElement(selBYear);
            bYear.SelectByValue(year);
        }
        #endregion

        #region YOUR ADDRESS
        public void InsertAddress(String address)
        {
            txtAddress.SendKeys(address);
        }

        public void InsertCity(String city)
        {
            txtCity.SendKeys(city);
        }

        public void SelectState(String state)
        {
            var stateCb = new SelectElement(selState);
            stateCb.SelectByValue(state);
        }

        public void InsertZipCode(String zipCode)
        {
            txtPostCode.SendKeys(zipCode);
        }

        public void InsertMobilePhone(String mobPhone)
        {
            txtPhoneMobile.SendKeys(mobPhone);
        }

        public void ClickRegisterButton()
        {
            btnSubmit.Click();
        }
        #endregion

        public void ValidoDadosCadastradosAddress(String urlAddress, String firstName, String lastName, String address,
            String city, String state, String zipCode)
        {
            _driver.Navigate().GoToUrl(urlAddress);

            String fullName = _driver.FindElement(By.XPath("//*[@id='center_column']/div[1]/div/div/ul/li[2]")).Text;
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Assert.IsTrue(fullName.Equals(firstName + " " + lastName));

            String address1 = _driver.FindElement(By.XPath("//*[@id='center_column']/div[1]/div/div/ul/li[4]")).Text;
            Assert.IsTrue(address1.Equals(address));

            String fullAddress = _driver.FindElement(By.XPath("//*[@id='center_column']/div[1]/div/div/ul/li[5]")).Text;
            Assert.IsTrue(fullAddress.Equals(city + ", " + state + " " + zipCode));

            //clicar no botão para voltar pra your account
            _driver.FindElement(By.XPath("//*[@id='center_column']/ul/li[1]/a")).Click();
        }

        public void ValidoDadosCadastradosPersonal(String urlPersonal, String firstName, String lastName, String email)
        {
            _driver.Navigate().GoToUrl(urlPersonal);

            String primeiroNome = _driver.FindElement(By.Id("firstname")).GetAttribute("value");
            String ultimoNome = _driver.FindElement(By.Id("lastname")).GetAttribute("value");
            String emailValor = txtEmail.GetAttribute("value");

            Assert.IsTrue(primeiroNome.Equals(firstName));
            Assert.IsTrue(ultimoNome.Equals(lastName));
            Assert.IsTrue(emailValor.Equals(email));

            //clicar no botão para voltar pra your account
            _driver.FindElement(By.XPath("//*[@id='center_column']/ul/li[1]/a")).Click();
        }
    }
}
