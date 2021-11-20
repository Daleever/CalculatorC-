using System;

class OrdinaryCalc:AbstractCalc{
	protected double num1 = 0;
	protected double num2 = 0;
	public override double GetNum1(){
		return num1;
	}
	public override void SetNum1(double num1){
		this.num1 = num1;
	}
	public override double GetNum2(){
		return num2;
	}
	public override void SetNum2(double num2){
		this.num2 = num2;
	}
	public override double Add()
	{
		return num1 + num2;
	}
	public override double Sub()
	{
		return num1 - num2;
	}
	public override double Div()
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
	public override double Mul()
	{
		return num1 * num2;
	}
}