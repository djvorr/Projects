
namespace Bartender
{
    public class Message
    {
        public static string ALREADY_EXIST = "Error code 1000: A record of this already exists!";
        public static string CREATE_NEW = "Error code 1001: Consider creating a new item.";
        public static string PARSE_READER_ERROR = "Error code 1002: Error parsing row from the database.";
        public static string MENU_ITEM_ROW_INVALID = "Error code 1003: Error returning the MenuItemRow header.";
        public static string IMAGE_ROW_INVALID = "Error code 1004: Error returning the ImageRow image.";
        public static string NO_FILE_FOUND = "Error code 1005: No Database file found.";
    }
}
