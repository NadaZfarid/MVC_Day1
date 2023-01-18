namespace Day1.Models
{
    public static class GuestList
    {
        private static List<Guest> guests= new List<Guest>()

        {
            new Guest() {name="nada",email="nada@fg",phone=01214144,willattend=true},
            new Guest() {name="noha",email="noha@fg",phone=012554555,willattend=true}

        };

        public static List<Guest> Guests { get => guests; }
        public static void addguest(Guest guest)
        {
            guests.Add(guest);
        }
     public static void removeguest(Guest guest)
        {
            guests.Remove(guest);
        }
    }
}
