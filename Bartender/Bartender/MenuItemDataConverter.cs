using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bartender
{
    /// <summary>
    /// Converts approvriate rows into filled out menuitems
    /// </summary>
    static class MenuItemDataConverter
    {

        /// <summary>
        /// Converts the list of all rows to a list of MenuItems
        /// </summary>
        /// <returns></returns>
        static public List<MenuItem> buildMenuItemList(List<Row> rows)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            buildMenuItems(rows, menuItems);
            addStepsToMenuItems(rows, menuItems);
            addImagesToMenuItems(rows, menuItems);
            addIngredientsToMenuItems(rows, menuItems);

            return menuItems;
        }

        /// <summary>
        /// This method puts together the list of all MenuItemRows in MenuItem form.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="menuItems"></param>
        static private void buildMenuItems(List<Row> rows, List<MenuItem> menuItems)
        {
            foreach (MenuItemRow row in rows)
            {
                foreach (MenuItem menuItem in menuItems)
                {
                    //if a menuItem that the row would fit has already been created
                    if (findExistingMenuItem(row, menuItems))
                    {
                        //and it doesn't already have such a row
                        if (!menuItem.hasRow(row))
                            menuItem.addMenuItemRow(row);
                    }
                    else
                    {
                        //create a menuitem that will work and go ahead and add the row
                        MenuItem newItem = new MenuItem();

                        menuItems.Add(newItem);
                    }
                }
            }
        }

        /// <summary>
        /// Adds the accomodating steps to each menuitem.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="menuItems"></param>
        static private void addStepsToMenuItems(List<Row> rows, List<MenuItem> menuItems)
        {
            foreach (StepsRow row in rows)
            {
                foreach (MenuItem menuItem in menuItems)
                {
                    if (row.Name == menuItem.getHeader().Name)
                        menuItem.addStepsRow(row);
                }
            }
        }

        /// <summary>
        /// Adds the accomodating images to each menuitem.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="menuItems"></param>
        static private void addImagesToMenuItems(List<Row> rows, List<MenuItem> menuItems)
        {
            foreach (ImageRow row in rows)
            {
                foreach (MenuItem menuItem in menuItems)
                {
                    if (row.Name == menuItem.getHeader().Name)
                        menuItem.addImageRow(row);
                }
            }
        }

        /// <summary>
        /// Adds the accomodating ingredients to each menuitem.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="menuItems"></param>
        static private void addIngredientsToMenuItems(List<Row> rows, List<MenuItem> menuItems)
        {
            foreach (IngredientsRow row in rows)
            {
                foreach (MenuItem menuItem in menuItems)
                {
                    if (row.Name == menuItem.getHeader().Name)
                        menuItem.addIngredientsRow(row);
                }
            }
        }

        /// <summary>
        /// This method searches all menu Items for a menu item that the give row would fit in. 
        /// If an applicable menu item is found, true is returned.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="menuItems"></param>
        /// <returns></returns>
        static private bool findExistingMenuItem(MenuItemRow row, List<MenuItem> menuItems)
        {
            foreach (MenuItem menuItem in menuItems)
            {
                if (menuItem.getHeader().Name == row.Name)
                    return true;
            }

            return false;
        }
    }
}
