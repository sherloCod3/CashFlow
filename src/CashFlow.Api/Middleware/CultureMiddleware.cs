using System.Globalization;

namespace CashFlow.Api.Middleware;

public class CultureMiddleware
{
	private readonly RequestDelegate _next;

	public CultureMiddleware(RequestDelegate next)
	{
		_next = next;
	}

	public async Task Invoke(HttpContext context)
	{
		var culture = context.Request.Headers.AcceptLanguage.FirstOrDefault();

		var cultureInfo = new CultureInfo("en");

		if (string.IsNullOrWhiteSpace(culture) == false)
		{
			// Extract the first culture from the Accept-Language header (e.g., "en-US,en;q=0.9" -> "en-US")
			var cultureName = culture.Split(',')[0].Split(';')[0].Trim();

			try
			{
				cultureInfo = new CultureInfo(cultureName);
			}
			catch (CultureNotFoundException)
			{
				// Fallback to "en" if the provided culture is invalid or unsupported
			}
		}

		CultureInfo.CurrentCulture = cultureInfo;
		CultureInfo.CurrentUICulture = cultureInfo;

		await _next(context);
	}
}
