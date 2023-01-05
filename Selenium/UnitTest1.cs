//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
//using System;
//using System.Threading;

//namespace Selenium
//{    
//    public class Tests
//    {
//        public WebDriver driver;
//        [SetUp]
//        public void Setup()
//        {
//        }

//        [Test]
//        public void Test1()
//        {
//            Console.Write("test case started ");
//            ChromeOptions options = new ChromeOptions();
//            options.AddArguments("--user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/92.0.4515.107 Safari/537.36");
//            //create the reference for the browser  
//            var driver = new ChromeDriver();
//            // navigate to URL  
//            driver.Navigate().GoToUrl("https://photos.google.com/");
//            driver.Manage().Window.Maximize();
//            Thread.Sleep(5000);
//            IWebElement ele1 = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div[2]/div[1]/div[2]/div[1]/a"));
//            ele1.Click();
//            Thread.Sleep(2000);
//            IWebElement userName = driver.FindElement(By.XPath("//*[@id=\"identifierId\"]"));
//            userName.SendKeys("amudeep.jaggi@gmail.com");            
//            IWebElement nextBtn = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/button/span"));            
//            nextBtn.Click();
//            Thread.Sleep(2000);
//            IWebElement pwd = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input"));
//            pwd.SendKeys("Noren@101011");            
//            nextBtn.Click();
//            Thread.Sleep(2000);
//            //Thread.Sleep(3000);
//            ////close the browser  
//            //driver.Close();
//            //Console.Write("test case ended ");
//        }
//    }
//}