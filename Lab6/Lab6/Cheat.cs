using System;

namespace Lab6
{
    public class Cheat
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Version { get; set; }

        public Cheat()
        {
            Name = "None";
            Author = "None";
            Version = 1;
        }

        public virtual void NextVersion() => Version++;

        public Cheat(string name, string author, int version)
        {
            Name = name;
            Author = author;
            Version = version;
        }

        public Cheat(string name) : this(name, "None", 1) { }

        public override string ToString()
        {
            return string.Format($"Name: {Name} | Author: {Author} | Version: {Version}");
        }
    }

    public class CheatException : ArgumentException
    {
        public double Value { get; }
        public CheatException(string message, double val) : base(message)
        {
            Value = val;
        }
    }
}