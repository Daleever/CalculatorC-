using System;

class AdvancedCalc : OrdinaryCalc
{
    public double TranslateToKByte(int Byte)
    {
        if (Byte < 1)
        {
            throw new Exception("Введено значение меньше 1");
        }
        return (double)Byte / 1024;
    }
}