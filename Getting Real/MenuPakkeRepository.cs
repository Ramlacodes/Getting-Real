using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    public class MenuPakkeRepository
    {
        private List<MenuPakke> menuPakker = new List<MenuPakke>();
        public void AddMenuPakke(MenuPakke menuPakke)
        {
            menuPakker.Add(menuPakke);
        }
        public List<MenuPakke> GetAllMenuPakker()
        {
            return menuPakker;
        }
    }
}
