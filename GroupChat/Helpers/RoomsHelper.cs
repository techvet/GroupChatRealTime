using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupChat.Helpers
{
    public class RoomsHelper
    {
        public static List<string> GetCurrentRooms()
        {
            var rooms = new List<string>();
            rooms.Add("SQL Developers");
            rooms.Add("Javascript Developers");
            rooms.Add("Java Developers");
            return rooms;
        }
    }
}