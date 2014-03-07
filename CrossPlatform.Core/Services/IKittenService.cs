using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrossPlatform.Core.Models;

namespace CrossPlatform.Core.Services
{
    public interface IKittenService
    {
        List<Kitten> GetKittens();
    }
}
