using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Recursos.App_Code;

namespace XF.Recursos.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : MasterDetailPage
    {
		public MainPage ()
		{
			InitializeComponent ();

            menuPage.ListaMenu.ItemSelected += async (sender, e) =>
            {

                var item = e.SelectedItem as OpcoesMenu;
                if(item != null)
                {

                    this.Detail = new NavigationPage(((Page)Activator.CreateInstance(item.TargetType)));

                    menuPage.ListaMenu.SelectedItem = null;
                    this.IsPresented = false;

                }


            };

		}

        //private void ListaMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
    }
}