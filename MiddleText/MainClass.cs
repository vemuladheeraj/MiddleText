namespace MiddleText
{
    public class MainClass
    {
        /// <summary>
        /// This will return the text between the startText and endText.
        /// </summary>
        /// <param name="enireText"></param>
        /// <param name="startText"></param>
        /// <param name="endText"></param>
        /// <returns>String</returns>
        public static string GetText(string enireText,string startText,string endText)
        {
            int startIndex = enireText.IndexOf(startText);
            int endIndex = enireText.IndexOf(endText,startIndex);

            if (startIndex != -1 && endIndex != -1)
            {
                return enireText.Substring(startIndex + startText.Length, endIndex - startIndex - startText.Length);               
            }
            return String.Empty;
        }

        /// <summary>
        /// This will return the text between the startText(Ignoring the characters based on skipStartIndex) and endText 
        /// </summary>
        /// <param name="enireText"></param>
        /// <param name="startText"></param>
        /// <param name="endText"></param>
        /// <param name="skipStartIndex"></param>
        /// <returns>String</returns>
        public static string GetText(string enireText, string startText, string endText,int skipStartIndex)
        {
            int startIndex = enireText.IndexOf(startText,skipStartIndex);
            int endIndex = enireText.IndexOf(endText, startIndex);

            if (startIndex != -1 && endIndex != -1)
            {
                return enireText.Substring(startIndex + startText.Length, endIndex - startIndex - startText.Length);
            }
            return String.Empty;
        }
    }
}