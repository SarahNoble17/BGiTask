using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BGiGitHubApp.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using BGiGitHubApp.Models.Data;
using System.Data;
using System.Xml;
using Microsoft.AspNetCore.Authorization;

namespace BGiGitHubApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id)
        {
            try
            {
                //If searchValue is supplied this is a call back
                if (id != null)
                {
                    return RedirectToAction("Results", new { id });
                }
                
                return View();
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Results(string id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                var apiPath = "https://api.github.com/users/" + id;

                using (var webClient = new WebClient())
                {
                    //Provide user agent to gain access to API
                    webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; " + "Windows NT 5.2; .NET CLR 1.0.3705;)");

                    //Get the raw JSON data from API
                    var rawJSON = webClient.DownloadString(apiPath);
                    var deserialised = JsonConvert.DeserializeObject<Users>(rawJSON);

                    //Get raw data for Repo Urls
                    var repoPath = deserialised.Repos_url;

                    if (rawJSON == null) return NotFound();
                    else return View(deserialised);
                }
            }
            catch
            {
                return BadRequest();
            }
        }
        

        public IActionResult Contact()
        {
            ViewData["Message"] = "My contact details.";

            return View();
        }
    }
}
