using System;

namespace HangulCharToSound
{
    /// <summary>
    /// Static class to manipulate hangul characters
    /// </summary>
    public static class Hangul
    {

        const int JongseongStart = 0x11A8;

        const int ChoseongStart = 0x1100;

        const int ChoseongJongseongDist = JongseongStart - ChoseongStart;

        public static char choseongSingleToJongseong(char c)
        {
            int charValue = (int)c;
            if (charValue < JongseongStart)
            {
                throw new ArgumentOutOfRangeException("Input char is not part of the choseong set.");
            }
            else
            {

                int shiftBack = charValue - ChoseongJongseongDist;
                //Case 1: 11A8 - 11A9 map to 1100 - 1101
                if (isBetween(charValue, 0x11A8 - 1, 0x11A9 + 1))
                {
                    return (char)translate(0x1100, 0x11A8, charValue);
                }

                //Case 2: 11AB map to 1102
                if (isBetween(charValue, 0x11AB - 1, 0x11AB + 1))
                {
                    return (char)(0x1102);
                }

                //Case 3: 11AE map to 1103
                if (isBetween(charValue, 0x11AE - 1, 0x11AE + 1))
                {
                    return (char)(0x1103);
                }

                //Case 4: 11AF map to 1105
                if (isBetween(charValue, 0x11AF - 1, 0x11AF + 1))
                {
                    return (char)(0x1105);
                }

                //Case 5: 11B7-11B8 map to 1106-1107
                if (isBetween(charValue, 0x11B7 - 1, 0x11B8 + 1))
                {
                    return (char)translate(0x1106, 0x11B7, charValue);
                }

                //Case 6: 11BA - 11BD map to 1109 - 110C
                if (isBetween(charValue, 0x11BA - 1, 0x11BD + 1))
                {
                    return (char)translate(0x1109, 0x11BA, charValue);
                }

                //Case 7: 11BE - 11C2 map to 110E - 1112
                if (isBetween(charValue, 0x11BE - 1, 0x11C2 + 1))
                {
                    return (char)translate(0x110E, 0x11BE, charValue);
                }

            }

            throw new NotImplementedException();

        }

        public static char[] splitChoseongDoubleConsonant(char c)
        {
            int charValue = (int)c;
            if (charValue < JongseongStart)
            {
                throw new ArgumentOutOfRangeException("Input char is not part of the choseong set.");
            }
            else if (charValue < 0x11AE)
            {
                switch (charValue)
                {
                    case 0x11AA:
                        return new char[] { 'ᆨ', 'ᆺ' };
                    case 0x11AC:
                        return new char[] { 'ᆫ', 'ᆽ' };
                    case 0x11AD:
                        return new char[] { 'ᆫ', 'ᇂ' };
                }

            }
            else
            {
                //char[] charArr = new char[] { 'ᆰ', 'ᆱ', 'ᆲ', 'ᆳ', 'ᆴ', 'ᆵ', 'ᆶ', 'ᆹ' };
                char[] charArr = new char[] { 'ᆨ', 'ᆷ', 'ᆸ', 'ᆺ', 'ᇀ', 'ᇁ', 'ᇂ' };

                int index = charValue - 0x11B0;

                if (index < 7)
                {
                    return new char[] { 'ᆯ', charArr[index] };
                }
                else
                {
                    return new char[] { charArr[2], charArr[3] };
                }


            }


            throw new NotImplementedException();

        }

        /// <summary>
        /// Returns an integer value relative to a new reference point on a number line
        /// </summary>
        /// <param name="newRef">New starting point</param>
        /// <param name="oldRef">Old starting point</param>
        /// <param name="oldValue">Value to translate</param>
        /// <returns></returns>
        private static int translate(int newRef, int oldRef, int oldValue)
        {
            return newRef + (oldValue - oldRef);
        }

        /// <summary>
        /// Checks if a value is between two bounds exclusively.
        /// </summary>
        /// <param name="value">Value to compare</param>
        /// <param name="lBoundExclusive">Lower exclusive bound</param>
        /// <param name="uBoundExclusive">Upper exclusive bound</param>
        /// <returns></returns>
        private static bool isBetween(int value, int lBoundExclusive, int uBoundExclusive)
        {
            if (value > lBoundExclusive && value < uBoundExclusive)
            {
                return true;
            }

            return false;
        }
    }
    
}