using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            //string url = "https://www.youtube.com/watch?v=SBnolu7SAHgst";
            //var list = new List<string>();
            //for (int i = 0; i < 10000; i++)
            //{
            //    list.Add(url);
            //}

            //Parallel.ForEach(list, new ParallelOptions {MaxDegreeOfParallelism = 3}, (temp) =>
            //{
            //    using (var tab = new ChromeDriver())
            //    {
            //        tab.Navigate().GoToUrl(temp);
            //        Thread.Sleep(10000);
            //    }
                
            //});

            string url = "http://orteil.dashnet.org/cookieclicker/";
            using (var chromeDriver = new ChromeDriver())
            {
                chromeDriver.Navigate().GoToUrl(url);
                var bigCookie = chromeDriver.FindElementById("bigCookie");
                while (true)
                {          
                    bigCookie.Click();
                }

            }

            LetsPlayAGame();

        }

        static void GoogleSearch()
        {
            using (var chromeDriver = new ChromeDriver())
            {
                chromeDriver.Navigate().GoToUrl("https://www.google.com/");
                var element = chromeDriver.FindElementByName("q");
                element.Click();
                element.SendKeys("This is how to google search with selenium");
                element.SendKeys(Keys.Enter);
                Thread.Sleep(10000);
            }
        }

        static void AmazonSearchAndSelect()
        {
            using (var chromeDriver = new ChromeDriver())
            {
                chromeDriver.Navigate().GoToUrl("https://www.amazon.com/");
                var element = chromeDriver.FindElementById("twotabsearchtextbox");
                element.SendKeys("Robot army");
                element.SendKeys(Keys.Enter);
                chromeDriver.FindElementByXPath("//*[@id=\"result_0\"]/div/div/div/div[2]/div[2]").Click();
                Thread.Sleep(10000);
            }
        }

        static void LetsPlayAGame()
        {
            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("http://www.addictinggames.com/");
            chromeDriver.FindElementByXPath("//*[@id=\"agContent\"]/div[1]/div/div[1]/div/div[1]/div/a/img").Click();

        }
        //static void CoolUsesForSelenium()
        //{
        //    var chromeDriver = new ChromeDriver();
        //    chromeDriver.Navigate().GoToUrl("https://www.youtube.com");
        //    var element = chromeDriver.FindElementById("search");
        //    element.SendKeys("Cool Uses of Selenium WebDriver");
        //    element.SendKeys(Keys.Enter);
        //    Thread.Sleep(3000);
        //    chromeDriver.FindElementByLinkText("/watch?v=X9eLWkZBKgQ").Click();
        //    Thread.Sleep(3000);
        //    chromeDriver.FindElementByXPath("//*[@id=\"movie_player\"]/div[24]/div[2]/div[2]/button[8]");
        //}
    }
}
