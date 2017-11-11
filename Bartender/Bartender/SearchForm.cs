using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bartender
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();

            rBBoth.Checked = true;
        }

        /// <summary>
        /// This event resets the other two radio buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rBRecipe_CheckedChanged(object sender, EventArgs e)
        {
            if (rBRecipe.Checked)
            {
                rBDrink.Checked = false;
                rBBoth.Checked = false;
            }
        }

        /// <summary>
        /// This event resets the other two radio buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rBDrink_CheckedChanged(object sender, EventArgs e)
        {
            if(rBDrink.Checked)
            {
                rBRecipe.Checked = false;
                rBBoth.Checked = false;
            }
        }

        /// <summary>
        /// This event resets the other two radio buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rBBoth_CheckedChanged(object sender, EventArgs e)
        {
            if (rBBoth.Checked)
            {
                rBRecipe.Checked = false;
                rBDrink.Checked = false;
            }
        }

        private void bViewAll_Click(object sender, EventArgs e)
        {

        }

        private void bSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
