using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UTB.Eshop.Nagy.Domain.Abstraction;
using UTB.Eshop.Nagy.Domain.Implementation;
using UTB.Eshop.Nagy.Web.Models.Database;
using UTB.Eshop.Nagy.Web.Models.Entities;
using UTB.Eshop.Nagy.Web.Models.Identity;
using UTB.Eshop.Nagy.Web.Models.ViewModels;

namespace UTB.Eshop.Nagy.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin) + ", " + nameof(Roles.Manager))]
    public class ProductsController : Controller
    {
        private readonly EshopDbContext _context;
		IFileUpload fileUpload;
		ICheckFileContent checkFileContent;
		ICheckFileLength checkFileLength;

		public ProductsController(EshopDbContext context, IFileUpload fileUpload, ICheckFileContent checkFileContent, ICheckFileLength checkFileLength)
        {
            _context = context;
			this.fileUpload = fileUpload;
			this.checkFileContent = checkFileContent;
			this.checkFileLength = checkFileLength;
		}

        // GET: Admin/Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        // GET: Admin/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Products/Create
        public IActionResult Create()
        {
            return View();
        }

		// POST: Admin/Products/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		public async Task<IActionResult> Create(ProductItemImageRequired product)
		{
			ModelState.Remove(nameof(Product.imageSrc));
			ModelState.Remove(nameof(Product.DescriptionImageSrc));
			if (ModelState.IsValid)
			{
				if (checkFileLength.CheckFileLength(product.Image, 2_000_000) && checkFileLength.CheckFileLength(product.DescImage, 2_000_000))
				{
					fileUpload.ContentType = "image";
					fileUpload.FileLength = 2_000_000;
					product.imageSrc = await fileUpload.FileUploadAsync(product.Image, Path.Combine("img", "product", "homeImg"));
					product.DescriptionImageSrc = await fileUpload.FileUploadAsync(product.DescImage, Path.Combine("img", "product", "descriptionImg"));

					ModelState.Clear();
					if (TryValidateModel(product))
					{
						_context.Products.Add(product);
						_context.SaveChanges();
						return RedirectToAction(nameof(Index));
					}
				}
                return NotFound();
			}

			return View(product);
		}

		// GET: Admin/Products/Edit/5
		public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

		// POST: Admin/Products/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		public async Task<IActionResult> Edit(Product product)
		{
			Product productItem = _context.Products.FirstOrDefault(proItem => proItem.ID == product.ID);

			if (productItem != null)
			{

				ModelState.Remove(nameof(Product.imageSrc));
				ModelState.Remove(nameof(Product.DescriptionImageSrc));
				if (ModelState.IsValid)
                {
					if (product.Image != null)
                    {
						if (checkFileLength.CheckFileLength(product.Image, 2_000_000))
                        {
                            fileUpload.ContentType = "image";
							fileUpload.FileLength = 2_000_000;
							if (_context.Products.Count(m => m.imageSrc == productItem.imageSrc) == 1)
							{
								System.IO.File.Delete("wwwroot" + productItem.imageSrc);
							}
							product.imageSrc = await fileUpload.FileUploadAsync(product.Image, Path.Combine("img", "product", "homeImg"));

							productItem.imageSrc = product.imageSrc;
							ModelState.Clear();
						}
						else
							return View(product);
					}
					if (product.DescImage != null)
					{
						if (checkFileLength.CheckFileLength(product.DescImage, 2_000_000))
						{
							fileUpload.ContentType = "image";
							fileUpload.FileLength = 2_000_000;
							product.DescriptionImageSrc = await fileUpload.FileUploadAsync(product.DescImage, Path.Combine("img", "product", "descriptionImg"));

							if (_context.Products.Count(m => m.DescriptionImageSrc == productItem.DescriptionImageSrc) == 1)
							{
								System.IO.File.Delete("wwwroot" + productItem.DescriptionImageSrc);
							}

							productItem.DescriptionImageSrc = product.DescriptionImageSrc;
							ModelState.Clear();
						}
						else
							return View(product);
					}

					productItem.NameEN = product.NameEN;
					productItem.NameCZ = product.NameCZ;
					productItem.Price = product.Price;
					productItem.discountPrice = product.discountPrice;
                    productItem.DescriptionCZ = product.DescriptionCZ;
					productItem.DescriptionEN = product.DescriptionEN;
                    productItem.Warranty = product.Warranty;
					_context.SaveChanges();

					return RedirectToAction(nameof(Index));
				}
				else
					return View(product);
			}

			return NotFound();
		}

		// GET: Admin/Products/Delete/5
		public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            if(_context.Products.FirstOrDefault(m => m.imageSrc == product.imageSrc) == null)
            {
				System.IO.File.Delete("wwwroot" + product.imageSrc);
			}

			if (_context.Products.FirstOrDefault(m => m.DescriptionImageSrc == product.DescriptionImageSrc) == null)
			{
				System.IO.File.Delete("wwwroot" + product.DescriptionImageSrc);
			}

			return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ID == id);
        }
    }
}
