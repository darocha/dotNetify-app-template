﻿using DotNetify;

namespace ViewModels
{
   public class HomeVM : BaseVM
   {
      public string PageTitle => "Home";

      public string Selected => "tab-lunch";

      public HomeVM()
      {
      }
   }
}