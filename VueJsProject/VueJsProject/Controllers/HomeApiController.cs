using Microsoft.AspNetCore.Mvc;

namespace VueJsProject.Controllers
{
    public class HomeApiController : Controller
    { 
		[HttpGet]
		public void DoSomething1()
		{
		}

		[HttpGet]
		public JsonResult DoSomething2()
		{
			return null;
		}

		[HttpPost]
		public JsonResult DoSomething3()
		{
			return null;
		}

		[HttpGet]
		public JsonResult DoSomething4()
		{
			throw new System.Exception("Some Error Message!");
		}
	}
}
