using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace Tests.UI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Application application = Application.Launch(@"e:\ORT_projects\WinForms\CodePrototype\PaintApp\PaintApp\bin\Debug\PaintApp.exe");
            Window window = application.GetWindow("Paint", InitializeOption.NoCache);

            //var menu = window.MenuBar.MenuItem("File");

            //menu.Click();

            var menuBar = window.MenuBar;

            var menu = menuBar.MenuItem("File");

            //Assert.AreNotEqual(menu.SubMenu(SearchCriteria.ByText("Quit")), null);

            menu.SubMenu(SearchCriteria.ByText("Save")).Click();

        }
    }
}
