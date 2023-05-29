﻿using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Appium.Android;
using System.Threading;

namespace csharp_appium
{
    class Program
    {
        static void Main(string[] args)
        {
            AppiumOptions caps = new AppiumOptions();

            caps.AddAdditionalCapability("user", "ritamg");  //Add the LT Username
            caps.AddAdditionalCapability("accessKey", "e4vXxk64hYOIkG7gwld5Fsb5LpmhI8wq6J0LQ2KC9LSgJHc1N5");  //Add the LT Access key

            // Set URL of the application under test
            caps.AddAdditionalCapability("app", "lt://APP1016045801684506800601409"); //Add the App ID

            // Specify device and os_version
            caps.AddAdditionalCapability("deviceName", "Galaxy S21 Ultra 5G");  //Add the Device Details
            caps.AddAdditionalCapability("platformVersion", "11");
            caps.AddAdditionalCapability("platformName", "Android");
            caps.AddAdditionalCapability("isRealMobile", true);
            caps.AddAdditionalCapability("network", false);
            caps.AddAdditionalCapability("w3c", true);
            caps.AddAdditionalCapability("visual", true);
            caps.AddAdditionalCapability("video", true);
            caps.AddAdditionalCapability("project", "CSharp Sample Android");
            caps.AddAdditionalCapability("build", "CSharp Sample Android");
            caps.AddAdditionalCapability("name", "CSharp Sample Android");

            // Initialize the remote Webdriver using LambdaTest remote URL
            // and desired capabilities defined above
            AndroidDriver<AndroidElement> driver = new AndroidDriver<AndroidElement>(
                new Uri("https://mobile-hub.lambdatest.com/wd/hub"), caps);

            // Test case for the sample Android app.
            // If you have uploaded your app, update the test case here.
            AndroidElement color = (AndroidElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("color"))
            );
            color.Click();
            color.Click();

            AndroidElement text = (AndroidElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("Text"))
            );
            text.Click();

            AndroidElement toast = (AndroidElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("toast"))
            );
            toast.Click();

            AndroidElement nf = (AndroidElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("notification"))
            );
            nf.Click();

            AndroidElement gl = (AndroidElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("geoLocation"))
            );
            gl.Click();

            Thread.Sleep(5000);

            driver.Navigate().Back();

            AndroidElement st = (AndroidElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MobileBy.Id("speedTest"))
            );
            st.Click();

            Thread.Sleep(5000);

            driver.Navigate().Back();

           
