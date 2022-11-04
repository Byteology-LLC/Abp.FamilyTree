using Species.Organisms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Human.Humanity
{
    public class Human : Organism
    {
        //extra human properties to track.
        public string HairColor { get; set; }
        public string EyeColor { get; set; }

        public Human() : base() { }
        public Human(Guid id) : base(id) { }
    }
}
