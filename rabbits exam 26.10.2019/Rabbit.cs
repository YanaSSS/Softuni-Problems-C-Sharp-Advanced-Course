﻿namespace Rabbits
{
    public class Rabbit
    {
        public Rabbit(string name, string species)
        {
            this.Name = name;
            this.Species = species;
            this.Available = true;
        }

        public string Name { get; set; }
        public string Species { get; set; }
        public bool Available { get; set; }

        //"Rabbit ({species}): {name}"
        public override string ToString()
        {
            return $"Rabbit ({this.Species}): {this.Name}";
        }
    }
}
