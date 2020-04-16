﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP.Models;

namespace TP03Module05.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        public ActionResult Index()
        {
            List<Chat> listeChat = new List<Chat>();
            listeChat = Chat.GetMeuteDeChats();
            return View(listeChat);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            Chat chat = new Chat();
            chat = Chat.GetMeuteDeChats().FirstOrDefault(a=>a.Id == id);
            return View(chat);
        }

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            Chat chat = new Chat();
            chat = Chat.GetMeuteDeChats().FirstOrDefault(a => a.Id == id);
            return View(chat);
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
