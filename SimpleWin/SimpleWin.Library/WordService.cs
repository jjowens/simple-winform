using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWin.Library
{
    public class WordService
    {

        public string LoadText()
        {
            var dirPath = Assembly.GetExecutingAssembly().Location;
            dirPath = Path.GetDirectoryName(dirPath);

            //string filePath = Path.GetFullPath(Path.Combine(dirPath, "\\texts\\loremipsum.txt"));
            string tempPath = Path.Combine(dirPath.ToString(), "texts\\loremipsum.txt");
            string filePath = Path.GetFullPath(tempPath);

            string bodyText = File.ReadAllText(filePath);

            return bodyText;
        }


        public string ReverseWords(string bodyText)
        {
            List<string> words = new List<string>();
            words = bodyText.Split(' ').ToList();

            words.Reverse();

            string result = String.Join(" ", words);

            return result;
        }

    }
}
