﻿using System;
using System.Collections;

namespace DoFactory.GangOfFour.Flyweight.Structural
{
    /// <summary>
    /// The 'Flyweight' abstract class
    /// </summary>
    abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }

    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable(); // used to store concrete classes

        // Constructor
        public FlyweightFactory()
        {
            flyweights.Add("X", new ConcreteFlyweight());
            flyweights.Add("Y", new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key)
        {
            return ((Flyweight)flyweights[key]);
        }
    }

    /// <summary>
    /// The 'ConcreteFlyweight' class
    /// </summary>
    class ConcreteFlyweight : Flyweight 
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
        }
    }
    
    /// <summary>
    /// MainApp startup class for Structural 
    /// Flyweight Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Arbitrary extrinsic state
            int extrinsicstate = 22;

            FlyweightFactory factory = new FlyweightFactory();

            // Work with different flyweight instances
            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            ConcreteFlyweight fu = new ConcreteFlyweight();

            fu.Operation(--extrinsicstate);

            // Wait for user
            Console.ReadKey();
        }
    }
}