using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Selenium.Internal.SeleniumEmulation;
using OpenQA.Selenium.Internal;

namespace PlakaComex_Selenium
{
    public static class Util
    {
        public static void SetAttribute(this IWebElement element, string attributeName, string value)
        {
            
            IWrapsDriver wrappedElement = element as IWrapsDriver;
            if (wrappedElement == null)
                throw new ArgumentException("element", "Element must wrap a web driver");

            IWebDriver driver = wrappedElement.WrappedDriver;
            IJavaScriptExecutor javascript = driver as IJavaScriptExecutor;
            if (javascript == null)
                throw new ArgumentException("element", "Element must wrap a web driver that supports javascript execution");

            javascript.ExecuteScript("arguments[0].setAttribute(arguments[1], arguments[2])", element, attributeName, value);
        }

        public static void Highlight(this IWebElement element)
        {
            const int wait = 150;
            string orig = element.GetAttribute("style");
            SetAttribute(element, "style", "color: yellow; border: 3px solid red; background-color: black;");
            Thread.Sleep(wait);
            SetAttribute(element, "style", "color: black; border: 3px solid black; background-color: yellow;");
            Thread.Sleep(wait);
            SetAttribute(element, "style", "color: yellow; border: 3px solid red; background-color: black;");
            Thread.Sleep(wait);
            SetAttribute(element, "style", "color: black; border: 3px solid black; background-color: yellow;");
            Thread.Sleep(wait);
            SetAttribute(element, "style", orig);
        }

    }
}
