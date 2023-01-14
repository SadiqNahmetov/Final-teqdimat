﻿using FinalProject.Data;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{

    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
           
            IEnumerable<Slider> sliders = await _context.Sliders.Where(m => !m.IsDeleted).ToListAsync();
            IEnumerable<Service> services = await _context.Services.Where(m => !m.IsDeleted).ToListAsync();
            IEnumerable<InstagramPhoto> instagramPhotos = await _context.InstagramPhotos.Where(m => !m.IsDeleted).ToListAsync();
            IEnumerable<Brand> brands = await _context.Brands.Where(m => !m.IsDeleted).ToListAsync();
            IEnumerable<Feature> features = await _context.Features.Where(m => !m.IsDeleted).ToListAsync();
            
            IEnumerable<Product> products = await _context.Products.Where(m => !m.IsDeleted)
                .Include(m => m.ProductImages)
                .Include(m => m.Brand)
                .Include(m => m.Category)
                .Include(m => m.ProductSizes)
                .ToListAsync(); 


            HomeVM model = new HomeVM
            {
                Sliders = sliders,
                Services = services,
                InstagramPhotos = instagramPhotos,
                Brands = brands,
                Features = features,
                Products = products,

               
            };


            return View(model);
        }


        public IActionResult Search(string search)
        {
            List<Product> searchName = _context.Products.Where(s => !s.IsDeleted && s.Name.Trim().Contains(search.Trim())).Include(m => m.ProductImages).ToList();
            return PartialView("_Search", searchName);
        }

    }
}
