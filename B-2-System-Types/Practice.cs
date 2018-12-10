using System;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            string name = "Olga";
            string hasPhoto = "True";
            string flatNumber = "34";

            char sex = 'М';
            char place = '3';
            char hasFingerPrints = '0';

            bool hasFree2Pages = false;

            double visaPrice = 60;
            double photoPrice = 7.5;

            int birthYear = 2000;

            //1. CHAR CONVERSION 
            //1.1 CHAR to STRING

            string charToStringImplicit = sex;                        //IMPLICIT: NOT COMPILING
            string chartToStringExplicit = (string)sex;               //EXPLICIT: NOT COMPILING
            string charToStringUsingConverter = Convert.ToString(sex);  //CONVERT: "M"

            //1.2 CHAR to BOOL

           bool BoolToChar = (bool)hasFingerPrints;  //EXPLICIT: NOT COMPILING
           

            //1.3 CHAR to DECIMAL

            //1.4 CHAR to INT
            int CharToInt = (int)place;  //EXPLICIT 
            int CharToInt1 = place; //IMPLICIT
            int CharToInt3 = Convert.ToInt32(place);  //CONVERT

            //2. STRING CONVERSION

            //2.1 STRING to CHAR
            char StringToChar = name; //IMPLICIT: NOT COMPILING
            char StringToChar1 = (char)name; //EXPLICIT: NOT COMPILING
            char StringToChar2 = char.Parse("name"); //Parse

            //2.2 STRING to BOOL

            bool StringToBool = (bool)hasPhoto; //EXPLICIT: NOT COMPILING
            bool StringToBool2 = hasPhoto;//IMPLICIT: NOT COMPILING
            bool StringToBool3= Convert.ToBoolean(hasPhoto); //CONVERT
            Console.WriteLine(StringToBool3);


            //2.3 STRING to DECIMAL

            decimal STRINGtoDECIMAL = (decimal)flatNumber; //EXPLICIT: NOT COMPILING
            decimal STRINGtoDECIMAL1 =flatNumber; //IMPLICIT: NOT COMPILING
            decimal STRINGtoDECIMAL2 = Convert.ToDecimal(flatNumber); //CONVERT

            //2.4 STRING to INT

            int STRINGtoINT = (int)flatNumber;//EXPLICIT: NOT COMPILING
            int STRINGtoINT1 = flatNumber; //IMPLICIT: NOT COMPILING
            int STRINGtoINT2 = int.Parse("flatNumber"); //PARSE

            //3. BOOL CONVERSION

            //3.1 BOOL to CHAR

            //3.2 BOOL to STRING
            string BOOLtoSTRING = (string)hasFree2Pages;
            string BOOLtoSTRING1 = hasFree2Pages;
            string BOOLtoSTRING2 = Convert.ToString(hasFree2Pages);//CONVERT

            //3.3 BOOL to DECIMAL

            //3.4 BOOL to INT

            //4. DECIMAL CONVERSION

            //4.1 DECIMAL to CHAR

            //4.2 DECIMAL to BOOL

            //4.3 DECIMAL to STRING

            //4.4 DECIMAL to INT

            //5. INT CONVERSION         

            //5.1 INT to CHAR

            char IntToChar = (char)birthYear;
            char IntToChar1 = birthYear;
            char IntToChar2 = Convert.ToChar(birthYear);
            //5.2 INT to BOOL


            //5.3 INT to DECIMAL
            decimal IntToDecimal = (decimal)birthYear;
            decimal IntToDecimal2 = birthYear;
            decimal IntToDecimal3 =decimal.Parse( "birthYear");

            //5.4 INT to STRING
            string INTtoSTRING = (int)birthYear;
            string INTtoSTRING2 = birthYear;
            string INTtoSTRING3 = Convert.ToString(birthYear);


        }
    }
}
