﻿using BO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apresentacao.Controllers
{
    public class BookController : Controller
    {

        public ActionResult Index()
        {
            var bookBO = new BookBO();
            ViewBag.BooksList = bookBO.BookList();
            return View();
        }

        public ActionResult Edit(BookBE bookBE)
        {
            BookBO bookBO = new BookBO();           
            bookBO.EditBook(bookBE);
            return RedirectToAction("Index", "Book");
        }

        public ActionResult OpenEdit(int id)
        {
            BookBO bookBO = new BookBO();
            var book = bookBO.GetBookById(id);

            return View("Edit", book);
        }

        public ActionResult Add(BookBE bookBE)
        {
            BookBO bookBO = new BookBO();
            bookBO.AddBook(bookBE);
            return RedirectToAction("Index", "Book");
        }

        public ActionResult OpenAdd()
        {            
            return View("Add");
        }


        public ActionResult Delete(BookBE bookBE)
        {
            BookBO bookBO = new BookBO();
            bookBO.DeleteBook(bookBE);
            return RedirectToAction("Index", "Book");
        }

        //public ActionResult Borrow(int id)
        //{
        //    return View();
        //}

        //public ActionResult Book(int id)
        //{
        //    return View();
        //}             

    }
}