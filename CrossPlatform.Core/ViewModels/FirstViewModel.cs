using System;
using System.Collections.Generic;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using CrossPlatform.Core.Models;
using CrossPlatform.Core.Services;

namespace CrossPlatform.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
        private readonly IKittenService _kittenService;

        private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}


        private List<Kitten> _kittens ;
        public List<Kitten> Kittens
        {
            get { return _kittens; }
            set { _kittens = value; RaisePropertyChanged(() => Kittens); }
        }

        public ICommand ShowKittenCommand
        {
            get{ return new MvxCommand<Kitten>(DoShowKitten);}
        }

        private void DoShowKitten(Kitten kitten)
        {
            ShowViewModel<SecondViewModel>(new {name = kitten.Name});
        }

        public FirstViewModel(IKittenService kittenService)
        {
            _kittenService = kittenService;
        }

        public void Init()
        {
            Kittens = _kittenService.GetKittens();
        }


    }
}
