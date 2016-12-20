using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FunctionalTests.PageModel
{
    public class Filmpage
    {
        private readonly ChromeDriver _driver;
        private readonly string _baseUrl;

        public Filmpage(ChromeDriver driver, string baseUrl)
        {
            _driver = driver;
            _baseUrl = baseUrl;
        }

        public string FirstFilmTitleText() => FirstFilmTitle().Text;
        public string FirstFilmYearText() => FindElementByCssSelector("tbody tr td:nth-child(2)").Text;
        public void ClickAddFilm() => AddFilmButton().Click();
        public void GoToPage() => _driver.Navigate().GoToUrl(Url());
        public void EnterFilmNameIntoAddControl(string name) => AddFilmTitleBox().SendKeys(name);
        public void EnterFilmYearIntoAddControl(int year) => AddFilmYearBox().SendKeys(year.ToString());
        public string GetDuplicateError() => DuplicateError().Text;
        public void ClickOnFirstFilm() => FirstFilmTitle().Click();

        private IWebElement FirstFilmTitle() => FindElementByCssSelector("tbody tr td");
        private IWebElement AddFilmTitleBox() => FindElementByCssSelector("input[name='Title']");
        private IWebElement AddFilmYearBox() => FindElementByCssSelector("input[name='Year']");
        private IWebElement AddFilmButton() => FindElementByCssSelector("input[type='submit']");
        private IWebElement DuplicateError() => FindElementByCssSelector(".alert-warning");

        private IWebElement FindElementByCssSelector(string cssSelector) => _driver.FindElementByCssSelector(cssSelector);

        public string Url() => $"{_baseUrl}films/list";
    }
}