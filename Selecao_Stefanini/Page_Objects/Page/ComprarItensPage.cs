using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecao_Stefanini.Page_Objects.Page
{
    public class ComprarItensPage
    {
        private readonly IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "homefeatured")]
        public IWebElement divProducts;

        [FindsBy(How = How.XPath, Using = "//*[@id='homefeatured']/li[1]/div/div[1]/div/a[1]/img")]
        public IWebElement product1;

        [FindsBy(How = How.XPath, Using = "//*[@id='homefeatured']/li[2]/div/div[1]/div/a[1]/img")]

        public IWebElement product2;

        [FindsBy(How = How.XPath, Using = "//*[@id='homefeatured']/li[3]/div/div[1]/div/a[1]/img")]
        public IWebElement product3;

        [FindsBy(How = How.Name, Using = "Submit")]
        public IWebElement btnAddToCart;

        [FindsBy(How = How.ClassName, Using = "layer_cart_product_info")]
        public IWebElement lbAddedToCartSucess;

        [FindsBy(How = How.Id, Using = "wishlist_button")]
        public IWebElement btnAddToWiishList;

        [FindsBy(How = How.XPath, Using = "//*[@id='product']/div[2]/div/div/div/div/p")]
        public IWebElement lbAddedWishListSucess;

        [FindsBy(How = How.Id, Using = "total_price")]
        public IWebElement lbValorCompraTotal;

        [FindsBy(How = How.Id, Using = "amount")]
        public IWebElement lbAmount;

        [FindsBy(How = How.Name, Using = "processAddress")]
        public IWebElement btnProceedAddress;

        [FindsBy(How = How.Name, Using = "cgv")]
        public IWebElement btnAgree;

        [FindsBy(How = How.Name, Using = "processCarrier")]
        public IWebElement btnProceedCarrier;

        //pagamento: http://automationpractice.com/index.php?fc=module&module=bankwire&controller=payment
        //continuar comprando: http://automationpractice.com/index.php?controller=order&step=2

        [FindsBy(How = How.XPath, Using = "//*[@id='cart_navigation']/button")]
        public IWebElement btnConfirmOrder;

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/div/p/strong")]
        public IWebElement lbOrderComplete;

        //orders: http://automationpractice.com/index.php?controller=history

        public ComprarItensPage(IWebDriver driver)
        {
           this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

    }
}
