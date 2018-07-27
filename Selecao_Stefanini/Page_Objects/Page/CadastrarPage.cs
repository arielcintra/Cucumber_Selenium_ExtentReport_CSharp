using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecao_Stefanini.Page_Objects.Page
{
    public class CadastrarPage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//*[@id='id_gender2']")]
        public IWebElement rdbIdGenderMrs;

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        public IWebElement txtFirstName;

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        public IWebElement txtLastName;

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtEmail;

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement txtPassword;

        [FindsBy(How = How.Id, Using = "days")]
        public IWebElement selBday;

        [FindsBy(How = How.Id, Using = "months")]
        public IWebElement selBMonth;

        [FindsBy(How = How.Id, Using = "years")]
        public IWebElement selBYear;

        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement txtAddress;

        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement txtCity;

        [FindsBy(How = How.Id, Using = "id_state")]
        public IWebElement selState;

        [FindsBy(How = How.Id, Using = "postcode")]
        public IWebElement txtPostCode;

        [FindsBy(How = How.Id, Using = "id_country")]
        public IWebElement selCountry;

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        public IWebElement txtPhoneMobile;

        [FindsBy(How = How.Id, Using = "alias")]
        public IWebElement txtAddressForFutherInfo;

        [FindsBy(How = How.Id, Using = "submitAccount")]
        public IWebElement btnSubmit;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/h1")]
        public IWebElement lbMyAccount;

        public CadastrarPage(IWebDriver driver)
        {
           this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

    }
}
