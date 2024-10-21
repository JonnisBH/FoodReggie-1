using System;
using FoodReggie_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodReggie_1.Controllers;

public class ItemController : Controller{
    public IActionResult Table(){
        var items = new List<Item>();
        var item1 = new Item{
            ItemId = 1,
            Name = "Kebab",
            Price = 69
        };
        var item2 = new Item{
            ItemId = 2,
            Name = "Hamburger",
            Price = 89
        };
        items.Add(item1);
        items.Add(item2);
        ViewBag.CurrentViewName = "Food menu";
        return View(items);
    }
}