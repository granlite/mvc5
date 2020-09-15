using muscshop.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace muscshop.Controllers
{
    public class StoreController : Controller
    {
        StoreContext _storeContext = new StoreContext();
        public ActionResult Index()
        {
            var genres = _storeContext.Genres;
            return View(genres);
        }
        public ActionResult Browse(string genre)
        {
            var genreModel = _storeContext.Genres.Where(x => x.Name == genre).FirstOrDefault();
            var albums = _storeContext.Albums.Where(x => x.Genre.Name == genre).ToList();
            genreModel.Albums = albums;
            return View(genreModel);
        }
        public ActionResult Detail(int id)
        {
            var albums = _storeContext.Albums.Where(x => x.AlbumId == id).FirstOrDefault();
            return View(albums);
        }
    }
}