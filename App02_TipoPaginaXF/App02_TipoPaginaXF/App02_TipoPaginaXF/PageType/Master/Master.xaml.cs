﻿using App02_TipoPaginaXF.PageType.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.PageType.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void MudarPagina1(object sender, EventArgs args)
        {
            Detail = new NavigationPage (new Page1());
            IsPresented = false;
        }

        private void MudarPagina2(object sender, EventArgs args)
        {
            Detail = new Page2();
            IsPresented = false;
        }

        private void MudarPagina3(object sender, EventArgs args)
        {
            Detail = new Content();
            IsPresented = false;
        }
    }
}