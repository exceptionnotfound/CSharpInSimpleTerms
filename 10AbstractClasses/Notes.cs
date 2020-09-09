using System;
using System.Collections.Generic;
using System.Text;

namespace _10AbstractClasses
{
    public interface IValuable
    {
        decimal Value { get; set; }
    }

    public interface IHardness
    {
        double Hardness { get; set; }
    }

    public abstract class Gem2
    {
        public abstract string Color { get; set; }
    }

    public class LapisLazuli : Gem2, IHardness, IValuable
    {
        public decimal Value { get; set; }
        public double Hardness { get; set; }

        public override string Color { get; set; }

        public LapisLazuli()
        {
            Value = 80M;
            Hardness = 5.5;
            Color = "Deep, ocean blue";
        }
    }

public class Silica : Gem2, IHardness
{
    public double Hardness { get; set; }

    public override string Color { get; set; }

    public Silica()
    {
        Hardness = 2.5;
        Color = "Rainbow, reflects light";
    }
}
}
