using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.ML;
using WebApplication9.Models;
using WebApplication9ML.Model;
using Microsoft.AspNetCore.Http;
namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        private CUSERSLENOVODOCUMENTSDBMYONLINESHOPPINGMDFContext _context;

        public HomeController(CUSERSLENOVODOCUMENTSDBMYONLINESHOPPINGMDFContext context)
        {
            _context = context;
        }

       /* public ActionResult Index(string search, int? page)
        {
            HomeIndexViewModel model = new HomeIndexViewModel();
            return View(model.CreateModel(search, 2, page));
        }*/
        public Dictionary<int, string> getMembers()
        {
            Dictionary<int, string> temp = _context.TblMembers.ToDictionary(c => c.MemberId, x => x.FirstName);
            return temp;
        }
        public Dictionary<string,int> getid()
        {
            Dictionary<string, int> x = _context.TblCategory.ToDictionary(c => c.CategoryName, x => x.CategoryId);
            return x;
        }
        public IActionResult Index()
        {
            return View(_context.TblProduct.ToList());
        }
        
      
        public IActionResult ProductSearch(string name)
        {
           
       
            List<TblProduct> a = _context.TblProduct.Where(a => a.ProductName == name).ToList();

            return View("Index",a);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Ratings(int productId)

        {
            if (HttpContext.Session.GetString("UserID") == null)
               return  RedirectToAction("Login", "Register");
            else if (HttpContext.Session.GetString("UserID") == "Admin")
                return RedirectToAction("Category", "Admin");
            TblProduct tbl = _context.TblProduct.Where(i => i.ProductId == productId).First();
            ViewBag.name = tbl.ProductName;
            ViewBag.image = tbl.ProductImage;
            ViewBag.users = getMembers();
            TempData["id"] = productId;
            List<TblCustomerRatings> x;
            
            if (_context.TblCustomerRatings.Where(i => i.ProductId == productId) != null)
            {
                x = _context.TblCustomerRatings.Where(i => i.ProductId == productId).ToList();
            
            }
            else
            {
                x = null;
              
            }
          
                ViewBag.Comments = x;
            return View();
        }
        [HttpPost]
        public IActionResult Ratings(int productId,ModelInput input)
        {
          
                MLContext mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(@"..\WebApplication9ML.Model\MLModel.zip", out var modelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
            input.Year = DateTime.Now.Year;
            ModelOutput result = predEngine.Predict(input);
           // tbl.MemberId = 1;
            //tbl.ProductId = 1;
            ViewBag.result = result;
           
            //tbl.Rating = Convert.ToInt32(result.Score);
            TblCustomerRatings x = new TblCustomerRatings();
            x.MemberId = Convert.ToInt32(HttpContext.Session.GetString("id"));
            x.ProductId = Convert.ToInt32(TempData["id"]);
            x.Comment = input.Comment;
            x.Rating = System.Math.Abs(Convert.ToInt32(result.Score));
            _context.TblCustomerRatings.Add(x);
            _context.SaveChanges();
            List<TblCustomerRatings> m = _context.TblCustomerRatings.Where(i => i.ProductId == Convert.ToInt32(TempData["id"])).ToList();
            ViewBag.Comments = m;
            productId = Convert.ToInt32(TempData["id"]);
            return RedirectToAction("Ratings", new { productId} );
        }
    }
}
