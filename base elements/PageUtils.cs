//driver
//wait
//metoda koja unosi random tekst?
//URL

namespace PageUtilities{

public abstract class Utilities{}
}
/*
https://elementalselenium.com/tips/37-oop
https://www.guru99.com/page-object-model-pom-page-factory-in-selenium-ultimate-guide.html
https://www.guru99.com/selenium-csharp-tutorial.html

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