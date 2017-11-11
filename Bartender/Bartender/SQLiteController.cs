using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System;


namespace Bartender
{
    public class SQLiteController
    {
        //TODO: Consider taking out all the file exists and table exists since the startup check was created.

        /// <summary>
        /// This method is a startup method that checks to see if the database is created and initialized.
        /// </summary>
        /// <param name="fileName"></param>
        public void runSetup(string fileName)
        {
            if (fileName != null)
            {
                if (!File.Exists(fileName))
                {
                    createFile(fileName);

                    foreach (string tableName in Enum.GetNames(typeof(EnumContainer.TableNames)))
                    {
                        createTable(fileName, tableName);
                    }
                }
            }
        }

        /// <summary>
        /// Gets multiple Menu Items from datasource fileName and table tableName based on the desired type.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public List<MenuItem> getMenuItems(string fileName, EnumContainer.Type type)
        {
             List<Row> data = new List<Row>();

            if (fileExists(fileName))
            {
                //TODO: Write SELECT stamement builder
            }



            return buildMenuItemList(data);
        }

        /// <summary>
        /// Builds the list of all Menu Items with all available information for only the active fields.
        /// </summary>
        /// <returns></returns>
        private List<MenuItem> buildMenuItemList(List<Row> rows)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach(MenuItemRow menuItemRow in rows)
            {
                if (menuItemRow.Active == EnumContainer.ActivityLevel.Active)
                {
                    //TODO: Finish writing thie menuitem row combiner.
                   // menuItems.Add(new MenuItem(menuItemRow, null, null, null));
                }
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

            if (fileExists(fileName))
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
            //if (menuItem.getIndex() > -1)
            //{
            //    if (fileExists(fileName, tableName))
            //    {
            //        // TODO: Write INSERT statement builder
            //    }

            //}
            //else
            //    MessageBox.Show(Message.ALREADY_EXIST + ' ' + Message.CREATE_NEW);

        }

        /// <summary>
        /// Updates existing item if it exists. Otherwise, it inserts it.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="tableName"></param>
        /// <param name="menuItem"></param>
        public void updateItem(string fileName, string tableName, MenuItem menuItem)
        {
            //if (fileExists(fileName, tableName))
            //{
            //    OldMenuItem currentMenuItem = getMenuItem(fileName, tableName, menuItem.getName());

            //    if (currentMenuItem != null)
            //    {
            //        // TODO: Write UPDATE statement builder
            //    }
            //    else
            //    {
            //        insertMenuItem(fileName, tableName, menuItem);
            //    }
            //}
        }

        /// <summary>
        /// Returns boolean based on if the file and table exists according to filename and tablename.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public bool fileExists(string fileName)
        {
            if (fileName != null)
            {
                if (File.Exists(fileName))
                {
                    return true;
                }
            }

            throw new Exception(Message.NO_FILE_FOUND);
        }

        /// <summary>
        /// Executes previously build SQL statement passed to it. Returns a MenuItem if applicable, 
        /// otherwise returns null.
        /// </summary>
        /// <param name="statement"></param>
        /// <returns></returns>
        private List<Row> execute(string fileName, string statement, EnumContainer.TableNames tableName)
        {
            SQLiteCommand command;
            SQLiteDataReader reader = null;

            // TODO: Create command and commit and execute statement
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + fileName + ";Version=3;"))
            {
                connection.Open();

                command = new SQLiteCommand(statement, connection);

                if (!statement.ToUpper().Contains(Enum.GetName(typeof(EnumContainer.Statements), EnumContainer.Statements.SELECT).ToString()))
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
        private List<Row> parseReader(SQLiteDataReader reader, EnumContainer.TableNames tableName)
        {
            List<Row> rows = new List<Row>();

            while (reader.Read())
            {
                if (tableName == EnumContainer.TableNames.MenuItem)
                {
                    rows.Add(new MenuItemRow(
                        reader[EnumContainer.MenuItemColumns.Name.ToString()].ToString(),
                        (EnumContainer.Type)int.Parse(reader[EnumContainer.MenuItemColumns.Type.ToString()].ToString()),
                        int.Parse(reader[EnumContainer.MenuItemColumns.NumSteps.ToString()].ToString()),
                        reader[EnumContainer.MenuItemColumns.Tags.ToString()].ToString(),
                        (EnumContainer.ActivityLevel)int.Parse(reader[EnumContainer.MenuItemColumns.Active.ToString()].ToString())));
                }
                else if (tableName == EnumContainer.TableNames.Steps)
                {
                    rows.Add(new StepsRow(
                        reader[EnumContainer.StepsColumns.Name.ToString()].ToString(),
                        int.Parse(reader[EnumContainer.StepsColumns.StepNum.ToString()].ToString()),
                        reader[EnumContainer.StepsColumns.Description.ToString()].ToString(),
                        (EnumContainer.ActivityLevel)int.Parse(reader[EnumContainer.StepsColumns.Active.ToString()].ToString())));
                }
                else if (tableName == EnumContainer.TableNames.Ingredients)
                {
                    rows.Add(new IngredientsRow(
                        reader[EnumContainer.IngredientColumns.Name.ToString()].ToString(),
                        reader[EnumContainer.IngredientColumns.Ingredient.ToString()].ToString(),
                        int.Parse(reader[EnumContainer.IngredientColumns.UnitCount.ToString()].ToString()),
                        reader[EnumContainer.IngredientColumns.Unit.ToString()].ToString(),
                        (EnumContainer.ActivityLevel)int.Parse(reader[EnumContainer.IngredientColumns.Active.ToString()].ToString())));
                }
                else if (tableName == EnumContainer.TableNames.Images)
                {
                    rows.Add(new ImageRow(
                        reader[EnumContainer.ImagesColumns.Name.ToString()].ToString(),
                        (byte[])reader[EnumContainer.ImagesColumns.Image.ToString()],
                        null,
                        (EnumContainer.ActivityLevel)int.Parse(reader[EnumContainer.ImagesColumns.Active.ToString()].ToString())));
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
        private void deleteItem(string fileName, string tableName, MenuItem menuItem)
        {
            if (fileExists(fileName))
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

            if (fileExists(fileName))
            {
                // TODO: Create SELECT UNIQUE statment builder
            }

            return uniqueItems;
        }
    }
}
