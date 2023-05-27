using System;

namespace StoreLibrary
{
    [Serializable]
    public class Guitars 
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}