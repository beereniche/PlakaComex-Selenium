using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PlakaComex_Selenium
{
    [TestClass]
    public class PlakaComex
    {
        [TestMethod]
        public void Contacto_PlakaComex()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.plakacomex.com.mx/");
            driver.FindElement(By.XPath("//*[@id='head']/div/div[4]/div")).Click();
            IWebElement SubMenu = driver.FindElement(By.CssSelector(".txtnegro"));
            Util.Highlight(SubMenu);
            SubMenu.Click();
            driver.FindElement(By.CssSelector(".menu_producto")).Click();

            driver.FindElement(By.CssSelector(".menu_material")).Click();
            driver.FindElement(By.CssSelector(".menu_comprar")).Click();
            driver.FindElement(By.CssSelector(".menu_document")).Click();
            driver.FindElement(By.CssSelector(".menu_contacto")).Click();
            IWebElement MenuContacto = driver.FindElement(By.CssSelector(".menu_contacto"));
            Util.Highlight(MenuContacto);

            //Llenar Formulario - Contacto

            driver.FindElement(By.XPath("id('_fullname')")).SendKeys("Nombre Completo - Testing");
            driver.FindElement(By.XPath("id('_email')")).SendKeys("correo@testing.com");
            driver.FindElement(By.XPath("id('_phone')")).SendKeys("3122336740");
            driver.FindElement(By.XPath("id('_phone_extension')")).SendKeys("123");
            driver.FindElement(By.XPath("id('_mobile')")).SendKeys("3127556303");

            driver.FindElement(By.XPath("id('_occupation')")).SendKeys("Instalador");
            driver.FindElement(By.XPath("id('_location_state')")).SendKeys("Colima");
            driver.FindElement(By.XPath("id('_option_type')")).SendKeys("Ventas");
            driver.FindElement(By.XPath("id('_option_message')")).SendKeys("This is a message in order to test PlakaComex.com.mx Contact section...");

            driver.FindElement(By.XPath("id('_option_newsletter')")).Click();
            driver.FindElement(By.XPath("id('_option_accept_terms')")).Click();

            IWebElement SubmitButton = driver.FindElement(By.XPath("id('_submit')"));
            Util.Highlight(SubmitButton);
            
                        driver.Quit();
        }

        [TestMethod]
        public void Busqueda_PlakaComex()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.plakacomex.com.mx/");
            driver.FindElement(By.CssSelector("#search_box")).SendKeys("Plaka Comex");
            driver.FindElement(By.XPath("id('search_button')")).Click();
            string titulo = driver.Title.ToString();

            //if Assert.IsTrue(titulo == "Runtime Error")
            //{}

            //Boolean bandera = NUnit.Framework.StringAssert.DoesNotMatch(titulo, "Runtime Error");
            driver.Quit();
        }

        [TestMethod]
        public void Calculadora_PlakaComex()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://fujarsys.com/calculadora_plaka/basica.php");
            driver.FindElement(By.XPath("id('nombre_muro')")).SendKeys("Muro Comedor");
            driver.FindElement(By.XPath("id('altura')")).SendKeys("1.5");
            driver.FindElement(By.XPath("id('longitud')")).SendKeys("2.5");
            driver.FindElement(By.XPath("id('tipo_fachada1')")).SendKeys("Interior");
            driver.FindElement(By.XPath("id('5')")).Click();
            driver.FindElement(By.XPath("id('tipo_material1')")).SendKeys("Placas de yeso");
            driver.FindElement(By.XPath("id('5')")).Click();
            driver.FindElement(By.XPath("//div[@id='simple_form']/table/tbody/tr/td/div/button")).Click();
            IWebElement area = driver.FindElement(By.XPath("//div[@id='simple_form']/table/tbody/tr/td/div/button"));
            Util.Highlight(area);
            string Tot_area = driver.FindElement(By.XPath("id('area')")).GetAttribute("value");
            IWebElement txt = driver.FindElement(By.XPath("id('area')"));
            Util.Highlight(txt);
            //NUnit.Framework.StringAssert.IsMatch(Tot_area, "3.75");
            driver.Quit();
        }

        [TestMethod]
        public void Chrome_HP()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\admin\Documents\Instalables\Automation\SeleniumDriver");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://fujarsys.com/calculadora_plaka/basica.php");
            driver.FindElement(By.XPath("id('nombre_muro')")).SendKeys("Muro Comedor");
            driver.FindElement(By.XPath("id('altura')")).SendKeys("1.5");
            driver.FindElement(By.XPath("id('longitud')")).SendKeys("2.5");
            driver.FindElement(By.XPath("id('tipo_fachada1')")).SendKeys("Interior");
            driver.FindElement(By.XPath("id('5')")).Click();
            driver.FindElement(By.XPath("id('tipo_material1')")).SendKeys("Placas de yeso");
            driver.FindElement(By.XPath("id('5')")).Click();
            driver.FindElement(By.XPath("//div[@id='simple_form']/table/tbody/tr/td/div/button")).Click();
            IWebElement area = driver.FindElement(By.XPath("//div[@id='simple_form']/table/tbody/tr/td/div/button"));
            Util.Highlight(area);
            string Tot_area = driver.FindElement(By.XPath("id('area')")).GetAttribute("value");
            IWebElement txt = driver.FindElement(By.XPath("id('area')"));
            Util.Highlight(txt);
            //NUnit.Framework.StringAssert.IsMatch(Tot_area, "3.75");
           driver.Quit();
        }

    }
}
