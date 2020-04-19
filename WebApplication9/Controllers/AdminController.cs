using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace WebApplication9.Controllers
{
    public class AdminController : Controller
    {
        private CUSERSLENOVODOCUMENTSDBMYONLINESHOPPINGMDFContext _context;

        public AdminController(CUSERSLENOVODOCUMENTSDBMYONLINESHOPPINGMDFContext context)
        {
            _context = context;
        }
        public List<SelectListItem> GetCategory()
        {
            List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> list = new List<SelectListItem>();
            var cat = _context.TblCategory.ToList();
            foreach (var item in cat)
            {
                list.Add(new SelectListItem { Value = item.CategoryId.ToString(), Text = item.CategoryName });
            }
            return list;
        }
        public IActionResult Category()
        {
            if (HttpContext.Session.GetString("UserID") == "Admin")
                return View(_context.TblCategory.Where(x => x.IsDelete == false).ToList());
            else
                return RedirectToAction("Index", "Home");
        }
        public ActionResult UpdateCategory(int categoryId)
        {
            return View(_context.TblCategory.Where(x=>x.CategoryId == categoryId).FirstOrDefault());
          
        }
        public async  Task<IActionResult> DeleteCategory(int? categoryId)
        {
            var category = await _context.TblCategory.SingleOrDefaultAsync(m => m.CategoryId == categoryId);
            _context.TblCategory.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction("Category");

           /* if (ModelState.IsValid)
            {
                TblCategory tbl = _context.TblCategory.Where(i => i.CategoryId == categoryId) as TblCategory;
                _context.TblCategory.Remove(tbl);
                _context.SaveChanges();
            }*/
           // return RedirectToAction("Category");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateCategory(TblCategory tbl)
        {
            if (ModelState.IsValid)
            {
                _context.TblCategory.Update(tbl);
                _context.SaveChanges();
                return RedirectToAction("Category");
            }
            return View("Category");
        }
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(TblCategory tbl)
        {
            _context.TblCategory.Add(tbl);
            _context.SaveChanges();
            return RedirectToAction("Category");
        }

        public ActionResult Product()
        {
            if (HttpContext.Session.GetString("UserID") == "Admin")
            {
                List<TblProduct> all = _context.TblProduct.Where(i => i.IsActive == true).ToList();
                return View(all);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            //return View(unitofwork.GetRepositoryInstance<Tbl_Product>().GetProduct());
        }
        public ActionResult ProductEdit(int productId)
        {
            ViewBag.CategoryList = GetCategory();
            return View(_context.TblProduct.Where(i=>i.ProductId==productId).FirstOrDefault());
        }

        [HttpPost]
        public async Task<IActionResult> ProductEditAsync(TblProduct tbl, IFormFile file)
        {
            string pic = null;

            if (file != null)
            {
                pic = file.FileName;
                var path = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot","ProductImg",
                            file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            tbl.ProductImage = file != null ? pic : tbl.ProductImage;
            tbl.ModifiedDate = DateTime.Now;
            _context.TblProduct.Update(tbl);
                _context.SaveChanges();
            return RedirectToAction("Product");
        }
        public ActionResult ProductAdd()
        {
            ViewBag.CategoryList = GetCategory();
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> ProductAddAsync(TblProduct tbl, IFormFile file)
        {
            string pic = file.FileName;
            if (file == null || file.Length == 0)
                return Content("file not selected");

            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot","ProductImg",
                        file.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            tbl.ProductImage = pic;
            tbl.CreatedDate = DateTime.Now;
            _context.TblProduct.Add(tbl);
            _context.SaveChanges();
            return RedirectToAction("Product");
        }

        public ActionResult DeleteProduct(int productId)
        {
            if (ModelState.IsValid)
            {
                TblProduct tbl = (TblProduct)_context.TblProduct.Where(i => i.ProductId == productId);
                _context.TblProduct.Remove(tbl);
                _context.SaveChanges();
            }
            return RedirectToAction("Product");

        }
    }
}