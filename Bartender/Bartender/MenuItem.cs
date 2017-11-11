using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bartender
{
    public class MenuItem
    {
        /*I would like to point out, the reason these are all collections is because of the 
         * database system. This application will likely not ship with deletion options. Instead,
         * every row in every table has an ACTIVE field for whether or not it should be used. */

        private List<MenuItemRow> Headers;
        private List<StepsRow> Steps;
        private List<IngredientsRow> Ingredients;
        private List<ImageRow> Images;

        /// <summary>
        /// This class is dedicated to storing all the information for each item entry.
        /// </summary>
        /// <param name="headers"></param>
        /// <param name="steps"></param>
        /// <param name="ingredients"></param>
        /// <param name="images"></param>
        public MenuItem(List<MenuItemRow> headers, List<StepsRow> steps, List<IngredientsRow>  ingredients, List<ImageRow> images)
        {
            Headers = headers;
            Steps = steps;
            Ingredients = ingredients;
            Images = images;
        }

        /// <summary>
        /// This class is dedicated to storing all the information for each item entry.
        /// </summary>
        public MenuItem()
        {
            Headers = new List<MenuItemRow>();
            Steps = new List<StepsRow>(); ;
            Ingredients = new List<IngredientsRow>();
            Images = new List<ImageRow>();
        }

        /// <summary>
        /// This method returns the first active MenuItemRow with the name, type, number of steps, 
        /// and activity level of the header.
        /// </summary>
        /// <returns></returns>
        public MenuItemRow getHeader()
        {
            foreach (MenuItemRow item in Headers)
            {
                if (item.Active == EnumContainer.ActivityLevel.Active)
                {
                    return item; 
                }
            }

            throw new Exception(Message.MENU_ITEM_ROW_INVALID);
        }

        /// <summary>
        /// Adds a MenuItem row to the MenuItemRow attribute.
        /// </summary>
        /// <param name="row"></param>
        public void addMenuItemRow(MenuItemRow row)
        {
            Headers.Add(row);
        }

        /// <summary>
        /// Adds a StepsRow to the StepsRow attribute.
        /// </summary>
        /// <param name="row"></param>
        public void addStepsRow(StepsRow row)
        {
            Steps.Add(row);
        }

        /// <summary>
        /// Adds a ImageRow to the ImageRow attribute.
        /// </summary>
        /// <param name="row"></param>
        public void addImageRow(ImageRow row)
        {
            Images.Add(row);
        }

        /// <summary>
        /// Adds a IngredientsRow to the IngredientsRow attribute.
        /// </summary>
        /// <param name="row"></param>
        public void addIngredientsRow(IngredientsRow row)
        {
            Ingredients.Add(row);
        }

        /// <summary>
        /// THis method returns a list of all active step number/descpription pairs sorted, in order, by step number.
        /// </summary>
        /// <returns></returns>
        public List<string> getSteps()
        {
            List<string> steps = new List<string>();

            foreach (StepsRow row in Steps)
            {
                if (row.Active == EnumContainer.ActivityLevel.Active)
                    steps.Add(row.StepNum.ToString() + " " + row.StepDescription);//new Step(row.StepNum, row.StepDescription));
            }

            steps.Sort();
            //steps.Sort(((x, y) => x.StepNum.CompareTo(y.StepNum)); 

            return steps;
        }

        /// <summary>
        /// This method returns all active ingredients in no given order.
        /// </summary>
        /// <returns></returns>
        public List<IngredientsRow> getIngredients()
        {
            List<IngredientsRow> ingredients = new List<IngredientsRow>();

            foreach (IngredientsRow row in Ingredients)
            {
                if (row.Active == EnumContainer.ActivityLevel.Active)
                    ingredients.Add(row);
            }

            return ingredients;
        }


        /// <summary>
        /// This method returns the first active ImagesRow with the name, image, and activity 
        /// level of the header.
        /// </summary>
        /// <returns></returns>
        public MenuItemRow getImage()
        {
            foreach (MenuItemRow item in Headers)
            {
                if (item.Active == EnumContainer.ActivityLevel.Active)
                {
                    return item;
                }
            }

            throw new Exception(Message.IMAGE_ROW_INVALID);
        }

        /// <summary>
        /// Determines if the MenuItem stores any object that implements the abstract Row class.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public bool hasRow(Row row)
        {
            if (row.GetType() == typeof(MenuItem))
                return Headers.Contains(row);
            else if (row.GetType() == typeof(StepsRow))
                return Steps.Contains(row);
            else if (row.GetType() == typeof(IngredientsRow))
                return Ingredients.Contains(row);
            else if (row.GetType() == typeof(ImageRow))
                return Images.Contains(row);

            throw new Exception(Message.MENU_ITEM_NO_TYPE);
        }

        /*
        #region subclasses
        public class Step
        {
            public int StepNum = -1;
            public string Description = "";

            /// <summary>
            /// This class is designated to hold each step number/step description pair.
            /// </summary>
            /// <param name="stepNum"></param>
            /// <param name="description"></param>
            public Step(int stepNum, string description)
            {
                StepNum = stepNum;
                Description = description;
            }
        }

        #endregion
        */
    }
}
