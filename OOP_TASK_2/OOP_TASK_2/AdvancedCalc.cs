using System;

class AdvancedCalc : OrdinaryCalc
{
    public double TranslateToKByte()
    {
        if (num1<=1 || num1>=1000000000)
        {
            throw new Exception("Введене значення має лежати в промiжку вiд 1 до 10^9");
        }
        return num1 / 1024;
    }
}