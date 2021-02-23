using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace OOP_Køen
{
    class Logic
    {
        Queue<Guest> guests = new Queue<Guest>();
        public string ShowAll()
        {
            string text = "";
            guests.Enqueue(new Guest() { Age = 25, Name = "John" });
            guests.Enqueue(new Guest() { Age = 24, Name = "Barbara" });
            guests.Enqueue(new Guest() { Age = 24, Name = "Phil" });
            guests.Enqueue(new Guest() { Age = 23, Name = "Fred" });
            guests.Enqueue(new Guest() { Age = 26, Name = "Hanah" });
            guests.Enqueue(new Guest() { Age = 27, Name = "Cindy" });
            Debug.WriteLine("Full guest list in the queue:");
            foreach (Guest guest in guests)
            {
                text += $"{guest.Name} {guest.Age}";

            }
            return text;


        }
        public string AddGuest(string userinput, int ageinput)
        {
            guests.Enqueue(new Guest() { Age = ageinput, Name = userinput });

            return "Guest is now added";
        }
        public string DeleteGuest()
        {
            string text = "";
            Guest firstToLeave = guests.Dequeue();
            text = $"First to leave {firstToLeave.Name}";

            return text;
        }
        public string SoonToLeave()
        {
            string text = "";
            Guest soonToLeave = guests.Peek();
            text = $"Just checking who'll leave next: {soonToLeave.Name}";

            return text;
        }
        public string ShowNumberOfGuest()
        {
            string text = "";
            text = $"There is: {guests.Count} Guest on the list";

            return text;
        }
        public string FindItem()
        {
            ShowAll();

            Guest findperson = guests.ElementAt(1);

            return findperson.Name;
        }
        

    }
}
