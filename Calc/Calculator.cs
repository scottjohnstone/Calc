using System;
using WindowsAppDriver.Driver;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        private readonly WinAppDriver _driver;

        public Calculator(WinAppDriver driver)
        {
            _driver = driver;

        }

        public void EnterNumber(string number)
        {
            foreach (char c in number)
            {
                _driver.Current.FindElementByAccessibilityId("num" + c + "Button").Click();
            }
        }

        public void EnterSign(string sign)
        {
            _driver.Current.FindElementByAccessibilityId(sign + "Button").Click();
        }

        public void NavigateToStandard()
        {
            _driver.Current.FindElementByName("Open Navigation").Click();
            _driver.Current.FindElementByName("Scientific Calculator").Click();
        }

        public string GetTitle()
        {
            return _driver.Current.FindElementByAccessibilityId("Header").Text.Trim();
        }


        public string GetResult()
        {
            return _driver.Current.FindElementByAccessibilityId("CalculatorResults").Text.Trim().Replace("Display is ", "");
        }
    }
}

