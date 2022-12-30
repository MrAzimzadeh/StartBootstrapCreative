using WebApp.Models;
namespace WebApp.ViewModels

{
    public class HomeVM
    {
        public Banner Banner { get; set; }
        public List<Service> Services { get; set; }

        public List<Portfolio> Portfolios { get; set; }

        public About Abouts { get; set; }

        // public List<TeamNetwork>  TeamNetwork { get; set; }

    }
}