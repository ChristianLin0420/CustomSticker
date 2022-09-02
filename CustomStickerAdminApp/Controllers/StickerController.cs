 
namespace CustomStickerAdminApp.Controllers  {

    using System;
    using Microsoft.AspNetCore.Mvc;
    using CustomStickerAdminApp.Models;

    public class StickerController : Controller { 

        private List<Sticker> stickers;

        public StickerController() {
        
        }

        public ActionResult Index() {  
            stickers = new List<Sticker> {
                new Sticker() { Id = "1", ImageUri = new Uri("http://"), Name = "Sticker 1", Keywords = new List<string>{"1", "2", "3", "4"}, Index = 1 },
                new Sticker() { Id = "2", ImageUri = new Uri("http://"), Name = "Sticker 2", Keywords = new List<string>{"1", "2", "3", "4"}, Index = 2 },
                new Sticker() { Id = "3", ImageUri = new Uri("http://"), Name = "Sticker 3", Keywords = new List<string>{"1", "2", "3", "4"}, Index = 3 },
                new Sticker() { Id = "4", ImageUri = new Uri("http://"), Name = "Sticker 4", Keywords = new List<string>{"1", "2", "3", "4"}, Index = 4 },
                new Sticker() { Id = "5", ImageUri = new Uri("http://"), Name = "Sticker 5", Keywords = new List<string>{"1", "2", "3", "4"}, Index = 5 }
            };

            ViewData["Title"] = stickers;

            return View();  
        }
    } 
}