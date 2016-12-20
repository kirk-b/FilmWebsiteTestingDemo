using OpenQA.Selenium.Chrome;

namespace FunctionalTests.PageModel
{
    public class FilmWishlistSite
    {
        public readonly Homepage Homepage;
        public readonly DetailsPage DetailsPage;
        public readonly Filmpage Filmpage;

        public FilmWishlistSite(ChromeDriver driver, string baseUrl)
        {
            Homepage = new Homepage(driver, baseUrl);
            DetailsPage = new DetailsPage(driver, baseUrl);
            Filmpage = new Filmpage(driver, baseUrl);
        }
    }
}