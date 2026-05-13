using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    public class MenuPackageRepository
    {
        private List<MenuPackage> menuPackages = new List<MenuPackage>();
        public void AddMenuPackage(MenuPackage menuPackage)
        {
            menuPackages.Add(menuPackage);
        }
        public List<MenuPackage> GetAllMenuPackages()
        {
            return menuPackages;
        }
    }
}
