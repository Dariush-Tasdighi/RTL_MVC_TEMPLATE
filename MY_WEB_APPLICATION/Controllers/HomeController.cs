namespace MY_WEB_APPLICATION.Controllers
{
	public partial class HomeController : Infrastructure.BaseController
	{
		public HomeController() : base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Index()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult About()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Contact()
		{
			return (View());
		}
	}
}
