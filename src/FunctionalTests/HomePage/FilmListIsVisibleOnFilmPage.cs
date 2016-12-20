using NUnit.Framework;
using TestHelpers;

namespace FunctionalTests.HomePage
{
    [TestFixture]
    class FilmListIsVisibleOnFilmPage
    {
        [Test]
        public void WhenNavigatingToTheHomePageThenTheListOfFilmsIsVisible()
        {
            SqlHelper.TruncateFilmsTable();
            SqlHelper.AddFilm("Spider-Man Homecoming", 2017);

            var homepage = BrowserContext.Site.Homepage;
            homepage.GoToPage();
            homepage.ClickOnListFilms();

            Assert.That(BrowserContext.Site.Filmpage.FirstFilmTitleText(), Is.EqualTo("Spider-Man Homecoming"));
            Assert.That(BrowserContext.Site.Filmpage.FirstFilmYearText(), Is.EqualTo("2017"));
        }
    }
}
