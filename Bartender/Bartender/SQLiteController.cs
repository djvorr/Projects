using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;


namespace Bartender
{
    public class SQLiteController
    {
        /// <summary>
        /// Gets multiple Menu Items from datasource fileName and table tableName based on the desired type.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public List<MenuItem> getMenuItems(string fileName, string tableName, EnumContainer.Type type)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            if (fileExists(fileName, tableName))
            {
                //TODO: Write SELECT stamement builder
            }


            return menuItems;
        }

        /// <summary>
        /// Gets a single item based on its name if it exists. Returns null if non-existent.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="tableName"></param>
        /// <param name="itemName"></param>
        /// <returns></returns>
        public MenuItem getMenuItem(string fileName, string tableName, string itemName)
        {
            MenuItem menuItem;

            if (fileExists(fileName, tableName))
            {
                // TODO: Write single row SELECT statement
            }



            return null;
        }

        /// <summary>
        /// Inserts a new menuItem into the database.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="tableName"></param>
        /// <param name="menuItem"></param>
        public void insertMenuItem(string fileName, string tableName, MenuItem menuItem)
        {
            if (menuItem.getIndex() > -1)
            {
                if (fileExists(fileName, tableName))
                {
                    // TODO: Write INSERT statement builder
                }

            }
            else
                MessageBox.Show(Message.ALREADY_EXIST + ' ' + Message.CREATE_NEW);

        }

        /// <summary>
        /// Updates existing item if it exists. Otherwise, it inserts it.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="tableName"></param>
        /// <param name="menuItem"></param>
        public void updateItem(string fileName, string tableName, MenuItem menuItem)
        {
            if (fileExists(fileName, tableName))
            {
                MenuItem currentMenuItem = getMenuItem(fileName, tableName, menuItem.getName());

                if (currentMenuItem != null)
                {
                    // TODO: Write UPDATE statement builder
                }
                else
                {
                    insertMenuItem(fileName, tableName, menuItem);
                }
            }
        }

        /// <summary>
        /// Returns boolean based on if the file and table exists according to filename and tablename.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public bool fileExists(string fileName, string tableName)
        {
            if (fileName != null)
            {
                if (File.Exists(fileName))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Executes previously build SQL statement passed to it. Returns a MenuItem if applicable, 
        /// otherwise returns null.
        /// </summary>
        /// <param name="statement"></param>
        /// <returns></returns>
        private List<Row> execute(string fileName, string statement, EnumContainer.TableName tableName)
        {
            SQLiteCommand command;
            SQLiteDataReader reader = null;

            // TODO: Create command and commit and execute statement
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + fileName + ";Version=3;"))
            {
                connection.Open();

                command = new SQLiteCommand(statement, connection);

                if (!statement.ToUpper().Contains(EnumContainer.Statements.SELECT.ToString()))
                    command.ExecuteNonQuery();
                else
                    reader = command.ExecuteReader();

                connection.Close();

                if (reader != null)
                {
                    return parseReader(reader, tableName);
                }
            }

            return null;
        }

        /// <summary>
        /// Reads the data from the parser. Returns a row of the appropriate type.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private List<Row> parseReader(SQLiteDataReader reader, EnumContainer.TableName tableName)
        {
            List<Row> rows = new List<Row>();

            while (reader.Read())
            {
                if (tableName == EnumContainer.TableName.MenuItem)
                {
                    rows.Add(new MenuItemRow(
                        reader[EnumContainer.MenuItemColumns.Name.ToString()].ToString(),
                        (EnumContainer.Type)int.Parse(reader[EnumContainer.MenuItemColumns.Type.ToString()].ToString()),
                        int.Parse(reader[EnumContainer.MenuItemColumns.NumSteps.ToString()].ToString()),
                        reader[EnumContainer.MenuItemColumns.Path.ToString()].ToString(),
                        (EnumContainer.ActivityLevel)int.Parse(reader[EnumContainer.MenuItemColumns.Active.ToString()].ToString())));
                }
                else if (tableName == EnumContainer.TableName.Steps)
                {
                    rows.Add(new StepsRow(
                        reader[EnumContainer.StepsColumns.Name.ToString()].ToString(),
                        int.Parse(reader[EnumContainer.StepsColumns.StepNum.ToString()].ToString()),
                        reader[EnumContainer.StepsColumns.Description.ToString()].ToString(),
                        (EnumContainer.ActivityLevel)int.Parse(reader[EnumContainer.StepsColumns.Active.ToString()].ToString())));
                }
                else if (tableName == EnumContainer.TableName.Ingredients)
                {
                    rows.Add(new IngredientsRow(
                        reader[EnumContainer.IngredientColumns.Name.ToString()].ToString(),
                        reader[EnumContainer.IngredientColumns.Ingredient.ToString()].ToString(),
                        int.Parse(reader[EnumContainer.IngredientColumns.UnitCount.ToString()].ToString()),
                        reader[EnumContainer.IngredientColumns.Unit.ToString()].ToString(),
                        (EnumContainer.ActivityLevel)int.Parse(reader[EnumContainer.IngredientColumns.Active.ToString()].ToString())));
                }
                else
                    throw new System.Exception(Message.PARSE_READER_ERROR);

            }

            return rows;
        }


        /// <summary>
        /// Creates a SQLite file if it doesn't already exist. Returns true if created, otherwise 
        /// returns false.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private bool createFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                SQLiteConnection.CreateFile(fileName);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Creates a table with table name tableName if it doesn't already exist. Returns true if 
        /// created, otherwise returns false.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        private bool createTable(string fileName, string tableName)
        {
            if (File.Exists(fileName))
            {
                // TODO: Create CREATE TABLE statement builder
                return true;
            }

            return false;
        }

        /// <summary>
        /// Deletes a single item from the database.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public void deleteItem(string fileName, string tableName, MenuItem menuItem)
        {
            if (fileExists(fileName, tableName))
            {
                // TODO: Create DELETE FROM TABLE statement builder
            }
        }

        /// <summary>
        /// Grabs all the unique items from a specified column
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="tableName"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        private List<string> getUnique(string fileName, string tableName, string columnName)
        {
            List<string> uniqueItems = new List<string>();

            if (fileExists(fileName, tableName))
            {
                // TODO: Create SELECT UNIQUE statment builder
            }

            return uniqueItems;
        }

        #region SubClasses

        public abstract class Row
        { }

        public class MenuItemRow : Row
        {
            public string Name = "";
            public EnumContainer.Type Type = EnumContainer.Type.Null;
            public int NumSteps = -1;
            public string Path = "";
            public EnumContainer.ActivityLevel Active = EnumContainer.ActivityLevel.Null;

            /// <summary>
            /// This class is dedicated to holding the information parsed from the MenuItem table by row.
            /// </summary>
            /// <param name="name"></param>
            /// <param name="type"></param>
            /// <param name="numSteps"></param>
            /// <param name="path"></param>
            /// <param name="active"></param>
            public MenuItemRow(string name, EnumContainer.Type type, int numSteps, string path, EnumContainer.ActivityLevel active)
            {
                Name = name;
                Type = type;
                NumSteps = numSteps;
                Path = path;
                Active = active;
            }
        }

        public class StepsRow : Row
        {
            public string Name = "";
            public int StepNum = -1;
            public string StepDescription = "";
            public EnumContainer.ActivityLevel Active = EnumContainer.ActivityLevel.Null;

            /// <summary>
            /// This class is dedicated to holding the information parsed from the Steps table by row.
            /// </summary>
            /// <param name="name"></param>
            /// <param name="type"></param>
            /// <param name="stepNum"></param>
            /// <param name="stepDesc"></param>
            /// <param name="active"></param>
            public StepsRow(string name, int stepNum, string stepDesc, EnumContainer.ActivityLevel active)
            {
                Name = name;
                StepNum = stepNum;
                StepDescription = stepDesc;
                Active = active;
            }
        }

        public class IngredientsRow : Row
        {
            public string Name = "";
            public string Ingredient = "";
            public int UnitCount = -1;
            public string Unit = "";
            public EnumContainer.ActivityLevel Active = EnumContainer.ActivityLevel.Null;

            /// <summary>
            /// This class is dedicated to holding the information parsed from the Ingredients table by row.
            /// </summary>
            /// <param name="name"></param>
            /// <param name="ingredient"></param>
            /// <param name="unitCount"></param>
            /// <param name="unit"></param>
            /// <param name="active"></param>
            public IngredientsRow(string name, string ingredient, int unitCount, string unit, EnumContainer.ActivityLevel active)
            {
                Name = name;
                Ingredient = ingredient;
                UnitCount = unitCount;
                Unit = unit;
                Active = active;
            }
        }
        #endregion
    }
}
