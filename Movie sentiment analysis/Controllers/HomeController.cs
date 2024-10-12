using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Movie_sentiment_analysis.Models;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;

namespace Movie_sentiment_analysis.Controllers
{
	public class HomeController : Controller
	{
		private readonly HttpClient _httpClient;

		public HomeController(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
        public async Task<IActionResult> Predict(string review)
        {
            var json = JsonConvert.SerializeObject(new { features = review });
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://fares7elsadek-movie-sentiment-analysis-flaskapp.hf.space/predict", content);
            if (response.IsSuccessStatusCode)
            {
                var resultJson = await response.Content.ReadAsStringAsync();
                var predictionResult = JsonConvert.DeserializeObject<dynamic>(resultJson);
                string prediction = predictionResult.prediction;
                ViewBag.Result = prediction;
                if(prediction == "positive")
                {
                    ViewBag.AlertClass = "alert-success";
                }
                else
                {
                    ViewBag.AlertClass = "alert-danger";
                }
                return View("Index");
            }
            ViewBag.Error = "Failed to predict sentiment. Please try again.";
            return View("Index");
        }



    }
}
