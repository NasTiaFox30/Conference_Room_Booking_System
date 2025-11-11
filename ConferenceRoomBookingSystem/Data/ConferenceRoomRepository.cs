using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using ConferenceRoomBookingSystem.Models;

namespace ConferenceRoomBookingSystem.Data
{
    public class ConferenceRoomRepository
    {
        private readonly DatabaseHelper dbHelper;
        public ConferenceRoomRepository() => dbHelper = new DatabaseHelper();

        public List<ConferenceRoom> GetAllRooms()
        {
            var rooms = new List<ConferenceRoom>();
            
            return rooms;
        }

    }
}