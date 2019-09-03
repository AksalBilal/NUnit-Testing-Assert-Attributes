using NUnit.Framework;
using NUnitTestingAttributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Tests
{
    public class Tests
    {
       public IWebDriver driver;
        BaseClass Base = new BaseClass(); 

      
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            driver = new ChromeDriver("C:\\Users\\bilal\\.nuget\\packages\\selenium.chrome.webdriver\\76.0.0\\driver");//driverin tanýmlanmasý
            driver.Navigate().GoToUrl("https://www.google.com");//driver üzerinde url yönlendirmesi yapma
        }
        [Test]
        public void TestingDoSearch()
        {

            IWebElement TextArea = driver.FindElement(By.XPath("//*[@class='gLFyf gsfi']"));//input alanýnýn yakalanmasý
            TextArea.SendKeys("Selenium c#");//input alanýna deðer göndermek
            TextArea.SendKeys(Keys.Enter);
            //chrome driver ile google de arama yapma
        }
        [Test]
        public void TestingAreEqual()
        {
           int Actual = Base.Topla(9,23);
           Assert.AreEqual(32,Actual);//Ýki deðerin eþit olup olmadýðýný karþýlaþtýrýr.Eþit ise test baþarýlý deðil ise baþarýsýz olur.
           
        }
        [Test]
        public void TestingAreNotEqual()
        {
            int Actual = Base.Topla(9, 2220);
            Assert.AreNotEqual(2729,Actual);//Ýki deðerin eþit olmamama durumunu inceler.Eþit deðil  ise test baþarýlý eþit  ise baþarýsýz olur.

        }
        [Test]
        public void TestingAreSame()
        {
            BaseClass base2 = new BaseClass();
            BaseClass base3 = base2;//bellekteki adresleri ayný
            Assert.AreSame(base2, base3); //Deðerlerin tam olarak ayný olduðunu kontrol eder -referans bellekteki ayný nesneyi gösterirse test baþarýlý olur.
        }

        [Test]
        public void TestingNotAreSame()
        {
            BaseClass base2 = new BaseClass();
            BaseClass base3 = new BaseClass() ;//bellekteki adresleri ayný
            Assert.AreNotSame(base2, base3);//Deðerlerin tam olarak ayný olduðunu kontrol eder -referans bellekteki farklý nesneyi gösterirse test baþarýlý olur.
        }
        [Test]
        public void TestingIsTrue()
        {
            Assert.IsTrue(Base.Sorgula(9, 8));//Boolean deger true ise test baþarýlý false ise baþarýsýz olur.
        }
        [Test]
        public void TestingIsFalse()
        {
            Assert.IsFalse(Base.Sorgula(12, 58));//Boolean deger false ise test baþarýlý true ise baþarýsýz olur.
        }
        [Test]
        public void TestingFail()
        {
            Assert.Fail("Fail");//Her zaman baþarýsýz test döner
        }
        [Test]
        public void TestingGreater()
        {
            Assert.Greater(10,9);//2 deðer arasýnda büyüklük karþýlaþtýrmasý yapar 1. deðer 2.deðerden büyükse test baþarýlý olur.
        }
        [Test]
        public void TestingLess()
        {
            Assert.Less(5, 9);//2 deðer arasýnda küçüklük karþýlaþtýrmasý yapar 1. deðer 2.deðerden küçükse test baþarýlý olur.
        }

        BaseClass baseClass;//Nesneyi tanýmladým ama deðer atamasý yapmadým
        [Test]
        public void TestingIsNull()
        {
            
            Assert.IsNull(baseClass);//gönderilen nesnenin null olup olmamasýný inceler. Nesnenin deðeri null ise test baþarýlý olur deðil ise test baþarýlý olur.
        }
        BaseClass baseclass=new BaseClass();//Nesneyi tanýmladým ve atama yaptým
        [Test]
        public void TestingIsNotNull()
        {

            Assert.IsNotNull(baseclass);//gönderilen nesnenin null olmamasýný inceler. Nesnenin deðeri null deðil ise test baþarýlý olur null ise test baþarýlý olur.
        }
        [Test]
        public void TestingZero()
        {
            Assert.Zero(0);//gönderilen deðerin 0 olup olmamasýný inceler. 0 ise test baþarýlý olur. 
        }
        [Test]
        public void TestingNotZero()
        {
            Assert.NotZero(1);//gönderilen deðerin 0 olmamasýný inceler. 0 deðil ise test baþarýlý olur. 
        }

        [Test]
        public void TestingFalse()
        {
            Assert.False(9<5);//gönderilen boolean ifadenin false olma durumunu inceler.False olursa test baþarýlý olur.
        }
        [Test]
        public void TestingTrue()
        {
            Assert.True(9>5);//gönderilen boolean ifadenin true olma durumunu inceler.True olursa test baþarýlý olur.
        }
        [Test]
        public void TestingPositive()
        {
            Assert.Positive(9);//gönderilen deðerin positive olma durumunu inceler.positive olursa test baþarýlý olur.
        }
        [Test]
        public void TestingNegative()
        {
            Assert.Negative(-9);//gönderilen deðerin Negative olma durumunu inceler.Negative olursa test baþarýlý olur.
        }
        BaseClass baseClass2;//Nesneyi tanýmladým ama deðer atamasý yapmadým
        [Test]
        public void TestingNull()
        {
            Assert.Null(baseClass2);//gönderilen nesnenin null olup olmamasýný inceler. Nesnenin deðeri null ise test baþarýlý olur deðil ise test baþarýlý olur.
        }
        BaseClass baseclass2 = new BaseClass();//Nesneyi tanýmladým ve atama yaptým
        [Test]
        public void TestingNotNull()
        {
            Assert.NotNull(baseclass2);//gönderilen nesnenin null olmamasýný inceler. Nesnenin deðeri null deðil ise test baþarýlý olur null ise test baþarýlý olur.
        }

        [Test]
        public void TestingIsEmpty()
        {
            Assert.IsEmpty("");//Girilen string deðerin empty olma durumunu inceler.Empty ise test baþarýlý olur.
        }
        [Test]
        public void TestingIsPass()
        {
            Assert.Pass("Succesful");//Her Durumda testin baþarýlý olmasýný saðlar
        }

        [Test]
        public void TestingIsWarn()
        {
            Assert.Warn("Warning Message");//verilen mesajý kullanarak bir uyarý yayýnlar
        }
        [Test]
        public void TestingMultiple()
        {
            Assert.Multiple(() =>//Birden fazla durumu ayný metod içerisinde kontrol etmek için kullanýlan yöntemdir.
            {
                Assert.AreEqual(25, baseclass.Topla(20, 5), "Real part");
                Assert.AreEqual(45, baseclass.Topla(20, 25), "Imaginary part");
            }); 
        }
        
        [OneTimeTearDown]
        public void CloseDriver()
        {//Ýlk test metodu çalýþýp bittikten sonra bu metod tek seferliðine çalýþýr.
            driver.Manage().Cookies.DeleteAllCookies();//
            driver.Close();//Sadece ilk test metodu çalýþýp driver ile iþi bittikten sonra driveri kapatma iþlemi burda yapýlabilir.
        }
        [TearDown]
        public void CloseAllDriver()
        {
            //her bir test metodu çalýþýp bittikten hemen sonra bu metod çalýþýr.
            int value = 5;//farklý test koþmalarýnda kullanacaðýmýz bir deðiþkenin deðerini bu metod içinde belirleyebiliriz.
        }

    }
}
