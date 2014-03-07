using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrossPlatform.Core.Models;

namespace CrossPlatform.Core.Services
{
    public class KittenService : IKittenService
    {
        private List<Kitten> _kittens;

        public KittenService()
        {
            _kittens = new List<Kitten>();

            for (int i = 0; i < 20; i++)
            {
                _kittens.Add(new Kitten()
                {
                    Name = "Kitty-" + i,
                    ImageUrl = string.Format("http://placekitten.com/{0}/{0}", Random(20) + 300),
                    Price = RandomPrice()
                });
            }
        }

        public List<Kitten> GetKittens()
        {
            return _kittens;
        }

        private readonly Random _random = new Random();
        protected int Random(int count)
        {
            return _random.Next(count);
        }

        protected int RandomPrice()
        {
            return Random(23) + 3;
        }
    }
}
