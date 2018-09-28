using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangulCharToSound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangulCharToSound.Tests
{
    [TestClass()]
    public class MainFormTests
    {
        [TestMethod()]
        public void choseongSingleToJongseongTest()
        {
            //Arrange
            MainForm testForm = new MainForm();

            char[] testInput = new char[] { 'ᆨ', 'ᆫ', 'ᆮ', 'ᆯ', 'ᆷ', 'ᆸ', 'ᆺ', 'ᆼ', 'ᆽ', 'ᆾ', 'ᆿ', 'ᇀ', 'ᇁ', 'ᇂ' };
            char[] expected = new char[] { 'ᄀ', 'ᄂ', 'ᄃ', 'ᄅ', 'ᄆ', 'ᄇ', 'ᄉ', 'ᄋ', 'ᄌ', 'ᄎ', 'ᄏ', 'ᄐ', 'ᄑ', 'ᄒ' };


            int testArrLen = testInput.Length;

            char[] result = new char[testArrLen];

            for(int i = 0; i < testArrLen; i++)
            {
                result[i] = testForm.choseongSingleToJongseong(testInput[i]);
            }

            CollectionAssert.AreEqual(expected, result);

        }
    }
}