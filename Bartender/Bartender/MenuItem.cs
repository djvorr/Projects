using System.Collections.Generic;

namespace Bartender
{
    public abstract class MenuItem
    {
        List<string> Steps;
        bool HasChanged;
        string ImageLocation;
        string Name;
        int Index;

        public MenuItem(string location, string name)
        {
            ImageLocation = location;
            Name = name;
        }

        /// <summary>
        /// Adds a single step to the end of the current steps list.
        /// </summary>
        /// <param name="step"></param>
        public void addStep(string step)
        {
            Steps.Add(step);
        }

        /// <summary>
        /// Sets the new list of steps as the recipe steps. Overrites any existing steps.
        /// </summary>
        /// <param name="steps"></param>
        public void setSteps(List<string> steps)
        {
            Steps = steps;
        }

        /// <summary>
        /// Adds new steps to the existing ones.
        /// </summary>
        /// <param name="steps"></param>
        public void addSteps(List<string> steps)
        {
            Steps.AddRange(steps);
        }

        /// <summary>
        /// Sets the hasChanged status to true.
        /// </summary>
        public void changedStatusTrue()
        {
            HasChanged = true;
        }

        /// <summary>
        /// Gets the path of the image location inclusive of the name and extension.
        /// </summary>
        /// <returns></returns>
        public string getImageLocation()
        { return ImageLocation; }

        /// <summary>
        /// Returns a list of all the current steps.
        /// </summary>
        /// <returns></returns>
        public List<string> getSteps()
        { return Steps; }

        /// <summary>
        /// Returns true if the information has changed, otherwise returns false;
        /// </summary>
        /// <returns></returns>
        public bool getChangedStatus()
        { return HasChanged; }

        /// <summary>
        /// Returns the user's name for the menu item.
        /// </summary>
        /// <returns></returns>
        public string getName()
        { return Name; }

        /// <summary>
        /// Returns the assigned index location of the menu item.
        /// </summary>
        /// <returns></returns>
        public int getIndex()
        { return Index; }
    }
}
