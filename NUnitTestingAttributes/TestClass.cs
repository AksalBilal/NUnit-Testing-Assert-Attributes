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
            driver = new ChromeDriver("C:\\Users\\bilal\\.nuget\\packages\\selenium.chrome.webdriver\\76.0.0\\driver");//driverin tan�mlanmas�
            driver.Navigate().GoToUrl("https://www.google.com");//driver �zerinde url y�nlendirmesi yapma
        }
        [Test]
        public void TestingDoSearch()
        {

            IWebElement TextArea = driver.FindElement(By.XPath("//*[@class='gLFyf gsfi']"));//input alan�n�n yakalanmas�
            TextArea.SendKeys("Selenium c#");//input alan�na de�er g�ndermek
            TextArea.SendKeys(Keys.Enter);
            //chrome driver ile google de arama yapma
        }
        [Test]
        public void TestingAreEqual()
        {
           int Actual = Base.Topla(9,23);
           Assert.AreEqual(32,Actual);//�ki de�erin e�it olup olmad���n� kar��la�t�r�r.E�it ise test ba�ar�l� de�il ise ba�ar�s�z olur.
           
        }
        [Test]
        public void TestingAreNotEqual()
        {
            int Actual = Base.Topla(9, 2220);
            Assert.AreNotEqual(2729,Actual);//�ki de�erin e�it olmamama durumunu inceler.E�it de�il  ise test ba�ar�l� e�it  ise ba�ar�s�z olur.

        }
        [Test]
        public void TestingAreSame()
        {
            BaseClass base2 = new BaseClass();
            BaseClass base3 = base2;//bellekteki adresleri ayn�
            Assert.AreSame(base2, base3); //De�erlerin tam olarak ayn� oldu�unu kontrol eder -referans bellekteki ayn� nesneyi g�sterirse test ba�ar�l� olur.
        }

        [Test]
        public void TestingNotAreSame()
        {
            BaseClass base2 = new BaseClass();
            BaseClass base3 = new BaseClass() ;//bellekteki adresleri ayn�
            Assert.AreNotSame(base2, base3);//De�erlerin tam olarak ayn� oldu�unu kontrol eder -referans bellekteki farkl� nesneyi g�sterirse test ba�ar�l� olur.
        }
        [Test]
        public void TestingIsTrue()
        {
            Assert.IsTrue(Base.Sorgula(9, 8));//Boolean deger true ise test ba�ar�l� false ise ba�ar�s�z olur.
        }
        [Test]
        public void TestingIsFalse()
        {
            Assert.IsFalse(Base.Sorgula(12, 58));//Boolean deger false ise test ba�ar�l� true ise ba�ar�s�z olur.
        }
        [Test]
        public void TestingFail()
        {
            Assert.Fail("Fail");//Her zaman ba�ar�s�z test d�ner
        }
        [Test]
        public void TestingGreater()
        {
            Assert.Greater(10,9);//2 de�er aras�nda b�y�kl�k kar��la�t�rmas� yapar 1. de�er 2.de�erden b�y�kse test ba�ar�l� olur.
        }
        [Test]
        public void TestingLess()
        {
            Assert.Less(5, 9);//2 de�er aras�nda k���kl�k kar��la�t�rmas� yapar 1. de�er 2.de�erden k���kse test ba�ar�l� olur.
        }

        BaseClass baseClass;//Nesneyi tan�mlad�m ama de�er atamas� yapmad�m
        [Test]
        public void TestingIsNull()
        {
            
            Assert.IsNull(baseClass);//g�nderilen nesnenin null olup olmamas�n� inceler. Nesnenin de�eri null ise test ba�ar�l� olur de�il ise test ba�ar�l� olur.
        }
        BaseClass baseclass=new BaseClass();//Nesneyi tan�mlad�m ve atama yapt�m
        [Test]
        public void TestingIsNotNull()
        {

            Assert.IsNotNull(baseclass);//g�nderilen nesnenin null olmamas�n� inceler. Nesnenin de�eri null de�il ise test ba�ar�l� olur null ise test ba�ar�l� olur.
        }
        [Test]
        public void TestingZero()
        {
            Assert.Zero(0);//g�nderilen de�erin 0 olup olmamas�n� inceler. 0 ise test ba�ar�l� olur. 
        }
        [Test]
        public void TestingNotZero()
        {
            Assert.NotZero(1);//g�nderilen de�erin 0 olmamas�n� inceler. 0 de�il ise test ba�ar�l� olur. 
        }

        [Test]
        public void TestingFalse()
        {
            Assert.False(9<5);//g�nderilen boolean ifadenin false olma durumunu inceler.False olursa test ba�ar�l� olur.
        }
        [Test]
        public void TestingTrue()
        {
            Assert.True(9>5);//g�nderilen boolean ifadenin true olma durumunu inceler.True olursa test ba�ar�l� olur.
        }
        [Test]
        public void TestingPositive()
        {
            Assert.Positive(9);//g�nderilen de�erin positive olma durumunu inceler.positive olursa test ba�ar�l� olur.
        }
        [Test]
        public void TestingNegative()
        {
            Assert.Negative(-9);//g�nderilen de�erin Negative olma durumunu inceler.Negative olursa test ba�ar�l� olur.
        }
        BaseClass baseClass2;//Nesneyi tan�mlad�m ama de�er atamas� yapmad�m
        [Test]
        public void TestingNull()
        {
            Assert.Null(baseClass2);//g�nderilen nesnenin null olup olmamas�n� inceler. Nesnenin de�eri null ise test ba�ar�l� olur de�il ise test ba�ar�l� olur.
        }
        BaseClass baseclass2 = new BaseClass();//Nesneyi tan�mlad�m ve atama yapt�m
        [Test]
        public void TestingNotNull()
        {
            Assert.NotNull(baseclass2);//g�nderilen nesnenin null olmamas�n� inceler. Nesnenin de�eri null de�il ise test ba�ar�l� olur null ise test ba�ar�l� olur.
        }

        [Test]
        public void TestingIsEmpty()
        {
            Assert.IsEmpty("");//Girilen string de�erin empty olma durumunu inceler.Empty ise test ba�ar�l� olur.
        }
        [Test]
        public void TestingIsPass()
        {
            Assert.Pass("Succesful");//Her Durumda testin ba�ar�l� olmas�n� sa�lar
        }

        [Test]
        public void TestingIsWarn()
        {
            Assert.Warn("Warning Message");//verilen mesaj� kullanarak bir uyar� yay�nlar
        }
        [Test]
        public void TestingMultiple()
        {
            Assert.Multiple(() =>//Birden fazla durumu ayn� metod i�erisinde kontrol etmek i�in kullan�lan y�ntemdir.
            {
                Assert.AreEqual(25, baseclass.Topla(20, 5), "Real part");
                Assert.AreEqual(45, baseclass.Topla(20, 25), "Imaginary part");
            }); 
        }
        
        [OneTimeTearDown]
        public void CloseDriver()
        {//�lk test metodu �al���p bittikten sonra bu metod tek seferli�ine �al���r.
            driver.Manage().Cookies.DeleteAllCookies();//
            driver.Close();//Sadece ilk test metodu �al���p driver ile i�i bittikten sonra driveri kapatma i�lemi burda yap�labilir.
        }
        [TearDown]
        public void CloseAllDriver()
        {
            //her bir test metodu �al���p bittikten hemen sonra bu metod �al���r.
            int value = 5;//farkl� test ko�malar�nda kullanaca��m�z bir de�i�kenin de�erini bu metod i�inde belirleyebiliriz.
        }

    }
}
