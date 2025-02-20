﻿using OpenQA.Selenium;
using qaMarsSpecflow.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace qaMarsSpecflow.Pages

{
    class LanguagePage
    {
        private static IWebElement ClickAddNewLanguagesBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement LanguagesTextBox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        private static IWebElement LanguageslevelDropDown => Driver.driver.FindElement(By.XPath("//select[@name='level']"));
        private static IWebElement LanguageslevelClick => Driver.driver.FindElement(By.XPath("//option[@value='Basic']"));
        private static IWebElement AddLanguagesBtn => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
        private static IWebElement EditLanguagesBtn => Driver.driver.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
        private static IWebElement EditLanguagesTextBox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        private static IWebElement EditLanguageslevelDropDown => Driver.driver.FindElement(By.XPath("//select[@name='level']']"));
        private static IWebElement EditLanguageslevelClick => Driver.driver.FindElement(By.XPath("//option[@value='Fluent']"));
        private static IWebElement UpdateLanguagesBtn => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement DeleteLanguagesBtn => Driver.driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));

  /*  //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select
        */
    public static void AddLanguage()
        {

            Thread.Sleep(5000);
         ClickAddNewLanguagesBtn.Click();
            LanguagesTextBox.SendKeys(ExcelLibHelper.ReadData(2, "Language"));
            LanguageslevelDropDown.Click();
            LanguageslevelClick.Click();
            AddLanguagesBtn.Click();
        }
        public static void EditLanguage()
        {
            Thread.Sleep(6000);  EditLanguagesBtn.Click();
            LanguagesTextBox.Clear();
            LanguagesTextBox.SendKeys(ExcelLibHelper.ReadData(3, "Language"));
            LanguageslevelDropDown.Click();
            EditLanguageslevelClick.Click();
            UpdateLanguagesBtn.Click();

        }
        public static void DeleteLanguage()
        {
            Thread.Sleep(6000);

            DeleteLanguagesBtn.Click();
        }
    }
}

    