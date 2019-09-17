//driver
//wait
//metoda koja unosi random tekst?
//URL
//http://testerstories.com/2015/10/using-c-with-selenium-webdriver/
//https://elementalselenium.com/tips/37-oop
//https://www.guru99.com/page-object-model-pom-page-factory-in-selenium-ultimate-guide.html
//https://www.guru99.com/selenium-csharp-tutorial.html
//https://www.toptal.com/selenium/test-automation-in-selenium-using-page-object-model-and-page-factory
//http://www.authorcode.com/creating-a-class-library-with-c-and-net-core-in-visual-studio-code/
//https://dev.to/dotnet/how-you-can-get-started-with-net-core-and-c-in-vs-code-30gc
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using System;

namespace PageUtilities{

  

public abstract class Utilities{

  //  IWebDriver driver = new ChromeDriver();

    }
}


/*


public class PageUtilities {
    
    public static WebDriver initWebDriver(WebDriver driver){
        System.setProperty("webdriver.chrome.driver", "/Users/qa/Desktop/workspace/chromedriver");
          driver = new ChromeDriver();
          driver.manage().window().maximize();
          return  driver;//moras vratiti driver sa kojim radis jer se on poziva prilikom svake metode
    }
    public static String getRandomText(){
        return "Nevena" + (int)(Math.random() * 1000);
    }
//    
//    public static String getRandomEditedText(){
//        return "IzmenjenNaslov" + (int)(Math.random()*1000);
//    }
    
    public static String getRandomUrl(){
        return "http://Proizvoljantekst" + (int)(Math.random() * 1000) + ".com";
    }
}

*/