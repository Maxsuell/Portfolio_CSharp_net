using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BEndCsharp_Teste1.Services;
using Microsoft.AspNetCore.Mvc;

namespace BEndCsharp_Teste1.Controllers
{
    public class SellersController : Controller
    {
        private SellerService _SellerService;

        public SellersController (SellerService sellerService)
        {
            _SellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _SellerService.FindAll();
            return View(list);
        }
    }
}