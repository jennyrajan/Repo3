using System;
using System.Diagnostics.Contracts;
using System.Web.Http;

namespace JenCompany1.Moon.Controllers
{
	public class AppMoonController : ApiController
	{
		[HttpGet]
		[Route("api/AppMoon")]
		public String Get()
		{
			Contract.Ensures(Contract.Result<String>() != null);

			return "Hello API App!";
		}
	}
}
