﻿using OpenQA.Selenium;
using qaMarsSpecflow.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace qaMarsSpecflow.Pages
{
    class SkillsPage
    {

        private static IWebElement ClickSkillsTab => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
        private static IWebElement AddNewSkillsBtn => Driver.driver.FindElement(By.XPath("//div[@class='ui teal button']"));
        private static IWebElement SkillsTextBox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        private static IWebElement SkillslevelDropDown => Driver.driver.FindElement(By.XPath("//select[@name='level']"));
        
         private static IWebElement SkillslevelClick => Driver.driver.FindElement(By.XPath("//option[@value='Expert']"));

        ////option[@value='Beginner']
        // private static IWebElement SkillslevelClick => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
        private static IWebElement AddSkillsBtn => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));

        private static IWebElement EditSkillsBtn => Driver.driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
        private static IWebElement UpdateSkillsBtn => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement DeleteSkillsBtn => Driver.driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));


        public static void AddSkills()
        {
            System.Threading.Thread.Sleep(5000);
            ClickSkillsTab.Click();
            AddNewSkillsBtn.Click();
            SkillsTextBox.SendKeys(ExcelLibHelper.ReadData(2, "Skills"));
            SkillslevelDropDown.Click();
            SkillslevelClick.Click();
            AddSkillsBtn.Click();
        }
        public static void EditSkills()
        {
            System.Threading.Thread.Sleep(5000);
            ClickSkillsTab.Click();
            EditSkillsBtn.Click();
            SkillsTextBox.Clear();
            SkillsTextBox.SendKeys(ExcelLibHelper.ReadData(3, "Skills"));
            SkillslevelDropDown.Click();
            SkillslevelClick.Click();
            UpdateSkillsBtn.Click();
        }
        public static void DeleteSkills()
        {
            System.Threading.Thread.Sleep(5000);
            ClickSkillsTab.Click();
            DeleteSkillsBtn.Click();

        }

    }
}

   