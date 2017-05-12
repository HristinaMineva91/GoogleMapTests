using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMaps.HomePage
{
    public partial class HomePage : BasePage
    {
        public IWebElement LoginButton
        {
            get
            {
                var xpath = "//*[@id=\"gb_70\"]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement Email
        {
            get
            {
                var xpath = "//*[@id=\"identifierId\"]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement EmailNextButton
        {
            get
            {
                var xpath = "//*[@id=\"identifierNext\"]/content/span";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement PasswordNextButton
        {
            get
            {
                var xpath = "//*[@id=\"passwordNext\"]/content/span";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement Password
        {
            get
            {
                var xpath = "//*[@id=\"password\"]/div[1]/div/div[1]/input";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement DirectionButton
        {
            get
            {
                var xpath = "//*[@id=\"searchbox-directions\"]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement DirectionMenu
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div"));
            }
        }

        public IWebElement TransitButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"omnibox-directions\"]/div/div[2]/div/div/div[1]/div[3]/button/div[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"omnibox-directions\"]/div/div[2]/div/div/div[1]/div[3]/button/div[1]"));
            }
        }

        public IWebElement StartLocation
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"sb_ifc51\"]/input")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"sb_ifc51\"]/input"));
            }
        }

        public IWebElement FinalLocation
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"sb_ifc52\"]/input")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"sb_ifc52\"]/input"));
            }
        }

        public IWebElement TimeForTravelWithTransit
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div/div[2]/div[2]/div[1]/div")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div/div[2]/div[2]/div[1]/div"));
            }
        }
        public IWebElement DrivingButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"omnibox-directions\"]/div/div[2]/div/div/div[1]/div[2]/button/div[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"omnibox-directions\"]/div/div[2]/div/div/div[1]/div[2]/button/div[1]"));
            }
        }
        public IWebElement DistanceBetweenStartAndFinalLocationWithDriving
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div[1]/div[2]/div[1]/div[1]/div[2]/div")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div[1]/div[2]/div[1]/div[1]/div[2]/div"));
            }
        }
        public IWebElement WalkingButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"omnibox-directions\"]/div/div[2]/div/div/div[1]/div[4]/button/div[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"omnibox-directions\"]/div/div[2]/div/div/div[1]/div[4]/button/div[1]"));
            }
        }
        public IWebElement DistanceBetweenStartAndFinalLocationWithWalking
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div[1]/div[2]/div[3]/div[1]/div[2]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div[1]/div[2]/div[3]/div[1]/div[2]"));
            }
        }
        public IWebElement TimeBetweenStartAndFinalLocationWithWalking
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div[1]/div[2]/div[3]/div[1]/div[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div[1]/div[2]/div[3]/div[1]/div[1]"));
            }
        }
        public IWebElement CyclingButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"omnibox-directions\"]/div/div[2]/div/div/div[2]/div[1]/div[1]/button/div[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"omnibox-directions\"]/div/div[2]/div/div/div[2]/div[1]/div[1]/button/div[1]"));
            }
        }
        public IWebElement HighestAltitudeBetweenStartAndFinalLocationWithCycling
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div[1]/div[2]/div[3]/div[3]/div/div/span[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[5]/div[1]/div[2]/div[3]/div[3]/div/div/span[1]"));
            }
        }
        public IWebElement SendingButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[4]/div[2]/div[2]/button")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[4]/div[2]/div[2]/button"));
            }
        }
        public IWebElement PhoneModel
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"modal-dialog-widget\"]/div[2]/div/div[3]/div/div/div[1]/div[1]/div/span[3]/span[1]/span[1]/button")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"modal-dialog-widget\"]/div[2]/div/div[3]/div/div/div[1]/div[1]/div/span[3]/span[1]/span[1]/button"));
            }
        }
        public IWebElement CheckButton
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[4]/div[2]/div[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[2]/div/div/div[4]/div[2]/div[1]"));
            }
        }
        public IWebElement LeaveNowDropDownButton
        {
            get
            {
                var xpath = "//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/span/div/div/div/div[2]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement LeaveNowDropDownMenu
        {
            get
            {
                var xpath = "//*[@id=\":1\"]/div";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement TimeDropDownMenu
        {
            get
            {
                var xpath = "//input[@name=\"transit-time\"]"; 
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement OptionButton
        {
            get
            {
                var xpath = "//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/button[3]/span[1]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement CheckBusButton
        {
            get
            {
                var xpath = "//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/div[2]/div/div[3]/div[1]/div[1]/label";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement CheckTrainButton
        {
            get
            {
                var xpath = "//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/div[2]/div/div[3]/div[1]/div[3]/label";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement CheckFewerTransfersButton
        {
            get
            {
                var xpath = "//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/div[2]/div/div[3]/div[2]/label[2]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement CloseButton
        {
            get
            {
                var xpath = "//*[@id=\"pane\"]/div/div[2]/div/div/div[2]/button[3]/span[2]";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement ScheduleExplorerButton
        {
            get
            {
                var xpath = "//*[@id=\"pane\"]/div/div[2]/div/div/div[6]/button";
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                return this.Driver.FindElement(By.XPath(xpath));
            }
        }
        public IWebElement TimeScheduleExplorer
        {
            get
            {
                var className = "time-input"; 
                this.Wait.Until(ExpectedConditions.ElementExists(By.ClassName(className)));
                return this.Driver.FindElement(By.ClassName(className));
            }
        }
    }
}
