using System;

class OrdinaryCalc{
	protected double num1 = 0;
	protected double num2 = 0;
	public double GetNum1(){
		return num1;
	}
	public void SetNum1(double num1){
		this.num1 = num1;
	}
	public double GetNum2(){
		return num2;
	}
	public void SetNum2(double num2){
		this.num2 = num2;
	}
	public double Add()
	{
		return num1 + num2;
	}
	public double Sub()
	{
		return num1 - num2;
	}
	public double Div()
	{
		if (num2 == 0)
		{
			throw new Exception("!! Помилка : дiлення на нуль  !!");
		}
		else
		{
			return num1 / num2;
		}
	}
	public double Mul()
	{
		return num1 * num2;
	}
}