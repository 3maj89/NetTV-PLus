//using PageUtilities;
//using System;
//using TechTalk.SpecFlow;

//namespace Support
//{
//    [Binding]
//      public class Annotations
//    {
//        private readonly PageUtils _pageUtils;

//        public Annotations(PageUtils pageUtils)
//        {
//            _pageUtils = pageUtils;
//        }

//        [BeforeScenario("web")]
//        public void OpenBrowser()
//        {
//            _pageUtils.Open();
//        }

//        [AfterScenario("web")]
//        public void CloseBrowser()
//        {
//            _pageUtils.Close();
//        }

//        [AfterTestRun]
//        public static void CloseCachedBrowsers()
//        {
//            pageUtils.CloseCachedBrowsers();
//        }
//    }
//}
