using System.Drawing;
using System.IO;

namespace Bartender
{
    public abstract class Row
    { }

    public class MenuItemRow : Row
    {
        public string Name = "";
        public EnumContainer.Type Type = EnumContainer.Type.Null;
        public int NumSteps = -1;
        public string Tags = "";
        public EnumContainer.ActivityLevel Active = EnumContainer.ActivityLevel.Null;

        /// <summary>
        /// This class is dedicated to holding the information parsed from the MenuItem table by row.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="numSteps"></param>
        /// <param name="path"></param>
        /// <param name="active"></param>
        public MenuItemRow(string name, EnumContainer.Type type, int numSteps, string tags, EnumContainer.ActivityLevel active)
        {
            Name = name;
            Type = type;
            NumSteps = numSteps;
            Tags = tags;
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

    public class ImageRow : Row
    {
        public string Name = "";
        public byte[] Bytes;
        public Image Img;
        public EnumContainer.ActivityLevel Active = EnumContainer.ActivityLevel.Null;

        /// <summary>
        /// This class is dedicated to holding the information parsed from the Images table by row.
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="img"></param>
        public ImageRow(string name, byte[] bytes, Image img, EnumContainer.ActivityLevel active)
        {
            Name = name;
            Bytes = bytes;
            Img = img;
            Active = active;

            if (bytes == null)
                Bytes = ImageToByte(Img, System.Drawing.Imaging.ImageFormat.Jpeg);
            else if (img == null)
                Img = ByteToImage(Bytes);
        }

        /// <summary>
        /// Converts an image to an array of bytes.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public byte[] ImageToByte(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }

        /// <summary>
        /// Converts an array of bytes into an image;
        /// </summary>
        /// <param name="imageBytes"></param>
        /// <returns></returns>
        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }
    }
}
