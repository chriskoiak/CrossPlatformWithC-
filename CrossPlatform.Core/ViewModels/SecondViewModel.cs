using System.Collections.Generic;
using System.Linq;
using Cirrious.MvvmCross.ViewModels;
using CrossPlatform.Core.Models;
using CrossPlatform.Core.Services;

namespace CrossPlatform.Core.ViewModels
{
    public class SecondViewModel 
		: MvxViewModel
    {
        private readonly IKittenService _kittenService;

        private int _price = 0;
        public int Price
        {
            get { return _price; }
            set { _price = value; RaisePropertyChanged(() => Price); }
        }

        public SecondViewModel(IKittenService kittenService)
        {
            _kittenService = kittenService;
        }

        public void Init(string name)
        {
            Price = _kittenService.GetKittens().FirstOrDefault(k => k.Name == name).Price;
        }


    }
}
