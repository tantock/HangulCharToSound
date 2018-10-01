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

        MainForm testForm = new MainForm();
        [TestMethod()]
        public void choseongSingleToJongseongTest()
        {
            //Arrange

            char[] testInput = new char[] { 'ᆨ', 'ᆫ', 'ᆮ', 'ᆯ', 'ᆷ', 'ᆸ', 'ᆺ', 'ᆼ', 'ᆽ', 'ᆾ', 'ᆿ', 'ᇀ', 'ᇁ', 'ᇂ' };
            char[] expected = new char[] { 'ᄀ', 'ᄂ', 'ᄃ', 'ᄅ', 'ᄆ', 'ᄇ', 'ᄉ', 'ᄋ', 'ᄌ', 'ᄎ', 'ᄏ', 'ᄐ', 'ᄑ', 'ᄒ' };


            int testArrLen = testInput.Length;

            char[] result = new char[testArrLen];

            //Act
            for(int i = 0; i < testArrLen; i++)
            {
                result[i] = testForm.choseongSingleToJongseong(testInput[i]);
            }

            //Assert
            CollectionAssert.AreEqual(expected, result);

        }

        [TestMethod()]
        public void splitChoseongDoubleConsonantTest()
        {
            //Arrange

            char[] testInput = new char[] { 'ᆪ', 'ᆬ', 'ᆭ', 'ᆰ', 'ᆱ', 'ᆲ', 'ᆳ', 'ᆴ', 'ᆵ', 'ᆶ', 'ᆹ' };

            char[][] expected = new char[][] { new char[] { 'ᆨ', 'ᆺ' }, new char[] { 'ᆫ' , 'ᆽ' }, new char[] { 'ᆫ', 'ᇂ' }, new char[] { 'ᆯ', 'ᆨ' }, new char[] { 'ᆯ', 'ᆷ' }, new char[] { 'ᆯ', 'ᆸ' }, new char[] { 'ᆯ', 'ᆺ' }, new char[] { 'ᆯ', 'ᇀ' }, new char[] { 'ᆯ', 'ᇁ' }, new char[] { 'ᆯ', 'ᇂ' }, new char[] { 'ᆸ', 'ᆺ' } };

            int testArrLen = testInput.Length;

            char[][] result = new char[testArrLen][];

            //Act
            for(int i = 0; i < testArrLen; i++)
            {
                result[i] = testForm.splitChoseongDoubleConsonant(testInput[i]);
            }

            //Assert
            for(int i = 0; i < testArrLen; i++)
            {
                CollectionAssert.AreEqual(expected[i], result[i]);
            }
            
        }
    }
}