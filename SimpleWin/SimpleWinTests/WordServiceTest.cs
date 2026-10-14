using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SimpleWin.Library;

namespace SimpleWinTests
{
    [TestClass]
    public class WordServiceTest
    {
        string _input = "The quick brown fox jumps over the lazy dog";

        [TestMethod]
        public void ReverseWords()
        {
            string expected = "dog lazy the over jumps fox brown quick The";

            WordService wordService = new WordService();

            string result = wordService.ReverseWords(_input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReverseLetters()
        {
            string expected = "ehT kciuq nworb xof spmuj revo eht yzal god";

            WordService wordService = new WordService();

            string result = wordService.ReverseLetters(_input);

            Assert.AreEqual(expected, result);
        }
    }
}
