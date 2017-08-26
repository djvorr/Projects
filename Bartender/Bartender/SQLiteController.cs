using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Bartender
{
    class SQLiteController
    {
        enum Columns {Index, Location, StepNumber, Step};
        public enum ReservedSymbols {Delimiter = '^'};
        enum Statements {SELECT };

        /// <summary>
        /// Gets all Menu Items from datasource fileName and table tableName.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public List<MenuItem> getMenuItems(string fileName, string tableName)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            if (tableExists(fileName, tableName))
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

            if (tableExists(fileName, tableName))
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
                if (tableExists(fileName, tableName))
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
            if (tableExists(fileName, tableName))
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
        private bool tableExists(string fileName, string tableName)
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
        private List<string> execute(string fileName, string statement)
        {
            SQLiteCommand command;
            SQLiteDataReader reader = null;

            // TODO: Create command and commit and execute statement
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + fileName + ";Version=3;"))
            {
                connection.Open();

                command = new SQLiteCommand(statement, connection);

                if (!statement.ToUpper().Contains(Statements.SELECT.ToString()))
                    command.ExecuteNonQuery();
                else
                    reader = command.ExecuteReader();

                connection.Close();

                if (reader != null)
                    return readData(reader);
            }

            return null;
        }

        /// <summary>
        /// Reades the data from the parser. Returns menuItem(s) in ^-delimited list of strings.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private List<string> readData(SQLiteDataReader reader)
        {
            List<string> menuItems = new List<string>();

            while (reader.Read())
            {
                menuItems.Add(
                    reader[Columns.Index.ToString()].ToString() +
                    ReservedSymbols.Delimiter.ToString() +
                    reader[Columns.Location.ToString()].ToString() +
                    ReservedSymbols.Delimiter.ToString() +
                    reader[Columns.StepNumber.ToString()].ToString() +
                    ReservedSymbols.Delimiter.ToString() +
                    reader[Columns.Step.ToString()].ToString());
            }

            return menuItems;
        }

        /// <summary>
        /// Creates a SQLite file if it doesn't already exist. Returns true if created, otherwise 
        /// returns false.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private bool createFile(string fileName)
        {
            if(!File.Exists(fileName))
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
            if (tableExists(fileName, tableName))
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

            if (tableExists(fileName, tableName))
            {
                // TODO: Create SELECT UNIQUE statment builder
            }

            return uniqueItems;
        }
    }
}
