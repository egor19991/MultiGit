using System;

public class Class1
{
	

	public double function(double x)
    {
		return pow(x, 2) + x + sin(x);
	}

	public double PowellMethod()
    {
		//Calculation error
		double epsX = 0.03;
		double epsY = 0.003;

		//Step
		double deltaX = 1;

		//X zero 
		double x1 = 3;

		int k = 0;
		double x2 = x1 + deltaX;
		double x3;
		double f1 = function(x1);
		double f2 = function(x2);
		double f3;
		if (f1 > f2)
			x3 = x1 + 2 * deltaX;
		else
			x3 = x1 - deltaX;
		f3 = function(x3);
		if (x3 < x1)
		{
			double var = x1;
			x1 = x3;
			x3 = x2;
			x2 = var;
			var = f1;
			f1 = f3;
			f3 = f2;
			f2 = var;
		}
		double functionMin = 0;
		double xMin = 0;
		double stationPoint = 0;
		double optimumPoint = 0;
		do
		{
			functionMin = std::min(std::min(f1, f2), f3);
			if (f1 == functionMin) xMin = x1;
			if (f2 == functionMin) xMin = x2;
			if (f3 == functionMin) xMin = x3;
			double a1 = (f2 - f1) / (x2 - x1);
			double a2 = (1 / (x3 - x2)) * (((f3 - f1) / (x3 - x1)) - ((f2 - f1) / (x2 - x1)));
			stationPoint = (x2 + x1) / 2 - (a1 / (2 * a2));
			if (stationPoint < x1 - deltaX)
				stationPoint = x1 - deltaX;
			if (stationPoint > x3 + deltaX)
				stationPoint = x3 + deltaX;

			if (functionMin < function(stationPoint))
				optimumPoint = xMin;
			else
				optimumPoint = stationPoint;

			//if ((abs(functionMin - function(stationPoint)) <= epsY) && (abs(xMin - stationPoint) <= epsX))
			if ((abs((functionMin - function(stationPoint)) / function(stationPoint)) <= epsY) && (abs((xMin - stationPoint) / stationPoint) <= epsX))
			{
				std::cout << "Minimum point = " << optimumPoint << "\n";
				std::cout << "Function in minimum point = " << function(optimumPoint) << "\n";
				std::cout << "Steps =" << k + 1 << "\n";
				break;
			}

			double varArray[4];
			varArray[0] = x1;
			varArray[1] = x2;
			varArray[2] = x3;
			varArray[3] = stationPoint;
			std::sort(varArray, varArray + 4);
			for (int i = 0; i < 4; i++)
			{
				if (varArray[i] == optimumPoint)
				{
					switch (i)
					{
						case 0:
							x1 = varArray[0];
							x2 = varArray[1];
							x3 = varArray[2];
							break;
						case 3:
							x1 = varArray[1];
							x2 = varArray[2];
							x3 = varArray[3];
							break;
						default:
							x1 = varArray[i - 1];
							x2 = varArray[i];
							x3 = varArray[i + 1];
							break;
					}
				}
			}

			f1 = function(x1);
			f2 = function(x2);
			f3 = function(x3);
			k++;
		} while (k < 100 || ((abs(functionMin - function(stationPoint)) >= epsY) && (abs(xMin - stationPoint) >= epsX)));
	}
}
