using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace Bartender
{
    public partial class MainForm : Form
    {
        string FILENAME = "MenuItems.sqlite";
        private List<MenuItem> menuItems = new List<MenuItem>();

        public MainForm()
        {
            InitializeComponent();
            new SQLiteController().runSetup(FILENAME);
        }

        /// <summary>
        /// Loads the controls with values from the database.
        /// </summary>
        private void loadControls(EnumContainer.Type type)
        {
            //TODO: consider removing check
            if ((new SQLiteController()).fileExists(FILENAME))
            {
                List<MenuItem> menuItems = getMenuItems(type);

                foreach (MenuItem item in menuItems)
                {
                    lbMenuItems.Items.Add(item.getHeader().Name);
                }

                lbMenuItems.SelectedIndex = 0;

                List<string> steps = getMenuItemRef(menuItems, lbMenuItems.SelectedItem.ToString()).getSteps();
                addStringsToListBox(lbInstructions, steps);
            }
        }

        /// <summary>
        /// Adds a list of strings to a specified listBox.
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="items"></param>
        private void addStringsToListBox(ListBox listBox, List<string> items)
        {
            foreach(string item in items)
            {
                listBox.Items.Add(item);
            }
        }

        /// <summary>
        /// Gets the reference to the menu item using to the specified name.
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private MenuItem getMenuItemRef(List<MenuItem> menuItems, string name)
        {
            foreach (MenuItem item in menuItems)
            {
                if (item.getHeader().Name == name)
                    return item;
            }

            return null;
        }

        /// <summary>
        /// Gets a group of menu items from the SQLiteController according to type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private List<MenuItem> getMenuItems(EnumContainer.Type type)
        {
            SQLiteController controller = new SQLiteController();
            return controller.getMenuItems(FILENAME, type);
        }

        /// <summary>
        /// Removes the selected name from the specified list box. Returns the 
        /// removed item's string name.
        /// </summary>
        /// <returns></returns>
        private string removelbItem(ListBox listBox)
        {
            string menuItemName = listBox.SelectedItem.ToString();
            int currentIndex = listBox.SelectedIndex;

            listBox.Items.Remove(listBox.SelectedItem);
            setSelectedIndex(listBox, currentIndex);

            return menuItemName;
        }

        /// <summary>
        /// Sets the preview image to the image path and name concatenated into a location.
        /// </summary>
        /// <param name="location"></param>
        private void setPreviewImage(string location)
        {
            pbViewer.Image = Image.FromFile(location);
        }

        /// <summary>
        /// Sets the selected index of the listbox to the provided index if it is within the range of 
        /// available item indexes.
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="index"></param>
        private void setSelectedIndex(ListBox listBox, int index)
        {
            if (index <= listBox.Items.Count - 1)
                listBox.SelectedIndex = index;
            else
                listBox.SelectedIndex = 0;
        }

        /// <summary>
        /// This is the event that is triggered when File>View>Image is clicked. It brings up an image 
        /// viewer of whatever the selected image is.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ImageViewer im = new ImageViewer(null);
            im.Show();
        }
    }
}
