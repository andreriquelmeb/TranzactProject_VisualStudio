using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Xml.Linq;

namespace TranzactProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
   
        }


        [Test]
        public void Compra()
        {
            IWebDriver driver = new ChromeDriver(@"C:\driver");
            //Ir a la URL
            driver.Navigate().GoToUrl("https://demo.evershop.io/");
            Thread.Sleep(500);
            //Maximizar el navegador
            driver.Manage().Window.Maximize();
            Thread.Sleep(500);
            //Hacer click en icono de Login
            IWebElement log = driver.FindElement(By.XPath("//a[@href='/account/login']"));
            log.Click();
            Thread.Sleep(500);
            //Hacer click en Create account
            IWebElement create = driver.FindElement(By.XPath("//a[@href='/account/register']"));
            create.Click();
            Thread.Sleep(500);
            //Escribir nombre completo
            IWebElement nombre = driver.FindElement(By.Name("full_name"));
            nombre.SendKeys("Luis Perez");
            //Escribir email
            IWebElement correo = driver.FindElement(By.Name("email"));
            correo.SendKeys("luis.perez@gmail.com");
            //Escribir password
            IWebElement clave = driver.FindElement(By.Name("password"));
            clave.SendKeys("123456");
            Thread.Sleep(1000);
            //Hacer click en el boton Sign Up
            IWebElement boto = driver.FindElement(By.XPath("//button[@type='button']"));
            boto.Click();
            Thread.Sleep(1000);
            //Hacer click en la zapatilla 1
            IWebElement zap1 = driver.FindElement(By.XPath("//a[@href='/product/lite-racer-adapt-3.0-shoes']"));
            zap1.Click();
            Thread.Sleep(500);
            //Hacer Click en talla S 
            IWebElement tall1 = driver.FindElement(By.XPath("//a[@href='https://demo.evershop.io/product/lite-racer-adapt-3.0-shoes?size=25']"));
            tall1.Click();
            Thread.Sleep(500);
            //Hacer Click en el color White
            IWebElement col1 = driver.FindElement(By.XPath("//a[@href='https://demo.evershop.io/product/lite-racer-adapt-3.0-shoes?size=25&color=18']"));
            col1.Click();
            Thread.Sleep(500);
            //Ingresar la cantidad 4
            IWebElement cant1 = driver.FindElement(By.Name("qty"));
            cant1.Clear();
            cant1.SendKeys("4");
            Thread.Sleep(500);
            //Hacer Click en el boton Add to cart
            IWebElement boton = driver.FindElement(By.XPath("//button[@type='button']"));
            boton.Click();
            Thread.Sleep(1200);
            //Hacer Click en el boton everShop para ir al inicio
            IWebElement home = driver.FindElement(By.XPath("//a[@href='/']"));
            home.Click();
            Thread.Sleep(500);
            //Hacer click en la zapatilla 2
            IWebElement zap2 = driver.FindElement(By.XPath("//a[@href='/product/alphaboost-shoes']"));
            zap2.Click();
            Thread.Sleep(500);
            //Hacer Click en talla X
            IWebElement tall2 = driver.FindElement(By.XPath("//a[@href='https://demo.evershop.io/product/alphaboost-shoes?size=4']"));
            tall2.Click();
            Thread.Sleep(500);
            //Hacer Click en el color Purple
            IWebElement col2 = driver.FindElement(By.XPath("//a[@href='https://demo.evershop.io/product/alphaboost-shoes?size=4&color=27']"));
            col2.Click();
            Thread.Sleep(500);
            //Ingresar la cantidad 3
            IWebElement cant2 = driver.FindElement(By.Name("qty"));
            cant2.Clear();
            cant2.SendKeys("3");
            Thread.Sleep(500);
            //Hacer Click en el boton Add to cart
            IWebElement boton2 = driver.FindElement(By.XPath("//button[@type='button']"));
            boton2.Click();
            Thread.Sleep(1200);
            //Hacer Click en el boton everShop para ir al inicio
            IWebElement home2 = driver.FindElement(By.XPath("//a[@href='/']"));
            home2.Click();
            Thread.Sleep(500);
            //Hacer click en la zapatilla 3
            IWebElement zap3 = driver.FindElement(By.XPath("//a[@href='/product/strutter-shoes']"));
            zap3.Click();
            Thread.Sleep(500);
            //Hacer Click en talla XL
            IWebElement tall3 = driver.FindElement(By.XPath("//a[@href='https://demo.evershop.io/product/strutter-shoes?size=26']"));
            tall3.Click();
            Thread.Sleep(500);
            //Hacer Click en el color Grey
            IWebElement col3 = driver.FindElement(By.XPath("//a[@href='https://demo.evershop.io/product/strutter-shoes?size=26&color=23']"));
            col3.Click();
            Thread.Sleep(500);
            //Ingresar la cantidad 2
            IWebElement cant3 = driver.FindElement(By.Name("qty"));
            cant3.Clear();
            cant3.SendKeys("2");
            Thread.Sleep(500);
            //Hacer Click en el boton Add to cart
            IWebElement boton3 = driver.FindElement(By.XPath("//button[@type='button']"));
            boton3.Click();
            Thread.Sleep(1200);
            //Hacer Click en el boton View cart
            IWebElement cart = driver.FindElement(By.ClassName("add-cart-popup-button"));
            cart.Click();
            Thread.Sleep(500);
            //Hacer Click en el boton Checkout
            IWebElement check = driver.FindElement(By.XPath("//a[@href='/checkout']"));
            check.Click();
            Thread.Sleep(500);
            //Completar los datos de Shipping Address
            IWebElement nombre2 = driver.FindElement(By.XPath("//input[@placeholder='Full Name']"));
            nombre2.SendKeys("Andre Riquelme");
            IWebElement telf = driver.FindElement(By.Name("address[telephone]"));
            telf.SendKeys("995004900");
            IWebElement addr = driver.FindElement(By.Name("address[address_1]"));
            addr.SendKeys("Av. Peru 123");
            IWebElement city = driver.FindElement(By.Name("address[city]"));
            city.SendKeys("Lima");
            SelectElement country = new SelectElement(driver.FindElement(By.Id("address[country]")));
            country.SelectByValue("US");
            SelectElement prov = new SelectElement(driver.FindElement(By.Id("address[province]")));
            prov.SelectByValue("US-CA");
            IWebElement postc = driver.FindElement(By.Name("address[postcode]"));
            postc.SendKeys("12345");
            Thread.Sleep(1200);
            //Hacer click en la opcion de Free shipping
            IWebElement ship = driver.FindElement(By.ClassName("radio-unchecked"));
            ship.Click();
            Thread.Sleep(1500);
            //Hacer click en el boton Continue to payment
            IWebElement boton4 = driver.FindElement(By.XPath("//button[@type='button']"));
            boton4.Click();
            Thread.Sleep(1500);
            //Hacer click en la opcion de Tarjeta Mastercard/Visa
            IWebElement visa = driver.FindElement(By.ClassName("feather-circle"));
            visa.Click();
            Thread.Sleep(1000);
            //Hacer click en el boton Test success
            IWebElement boton5 = driver.FindElement(By.XPath("//button[@class='button interactive outline']"));
            boton5.Click();
            Thread.Sleep(300);

            /* NO PUDE INGRESAR LOS DATOS DE LA TARJETA
            //Ingresar numero de tarjeta
            IWebElement card = driver.FindElement(By.XPath("//input[@name='cardnumber']"));
            card.SendKeys("4242 4242 4242 4242");
            //Ingresar año y mes de expiracion
            IWebElement exp = driver.FindElement(By.XPath("//input[@name='exp-date']"));
            exp.SendKeys("04/24");
            //Ingresar codigo CVC
            IWebElement cvc = driver.FindElement(By.XPath("//input[@name='cvc']"));
            cvc.SendKeys("242");
            */

            Thread.Sleep(1000);
            //Hacer click en el boton Place Order
            IWebElement boton6 = driver.FindElement(By.XPath("//button[@class='button primary']"));
            boton6.Click();

        }

    }
}