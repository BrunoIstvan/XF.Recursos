using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Recursos.App_Code;

namespace XF.Recursos.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuView : ContentPage
	{

        public ListView ListaMenu { get { return lstMenu; } }

		public MenuView ()
		{
			InitializeComponent ();

            ListarMenus();
		}

        private void ListarMenus()
        {

            ObservableCollection<OpcoesMenu> menuItens = new ObservableCollection<OpcoesMenu>();

            menuItens.Add(new OpcoesMenu()
            {
                Descricao = "Home",
                Icone = "https://addons.thunderbird.net/user-media/addon_icons/329/329485-64.png?modified=1354206023",
                TargetType = typeof(HomeView)
            });

            menuItens.Add(new OpcoesMenu()
            {
                Descricao = "Configuração",
                Icone = "https://cdn0.iconfinder.com/data/icons/pixelo/32/settings.png",
                TargetType = typeof(ConfigPage)
            });



            lstMenu.ItemsSource = menuItens;


        }

    }
}