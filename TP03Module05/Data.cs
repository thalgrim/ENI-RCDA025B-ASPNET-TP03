using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP.Models;

namespace TP03Module05
{
    public class Data
    {
        private static Data _instance;
        static readonly object instanceLock = new object();

        private List<Chat> listeChats = new List<Chat>();
        private Data()
        {
            listeChats=Chat.GetMeuteDeChats();
        }

        public static Data Instance
        {
            get
            {
                if (_instance == null) //Les locks prennent du temps, il est préférable de vérifier d'abord la nullité de l'instance.
                {
                    lock (instanceLock)
                    {
                        if (_instance == null) //on vérifie encore, au cas où l'instance aurait été créée entretemps.
                            _instance = new Data();
                    }
                }
                return _instance;
            }
        }

        
        


       
    }
}