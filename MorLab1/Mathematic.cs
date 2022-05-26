using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorLab1
{
	class Mathematic
	{
		private double _minimum;

		private double _maximum;

		private double _step;

		private double _interval;

		private double _searchPoint;

		private double _epsX;

		private double _epsY;

		private int _mantissa;

		public string Message { get; set; }

		public int Mantissa
        {
            get { return _mantissa; }
            set
            {
				if(value >= 0 && value < 9)
                {
					_mantissa = value;
                }
            }
        }

		public double Minimum 
		{ 
			get 
			{
				return _minimum; 
			} 
			set 
			{ 
				if(value < _maximum)
                {
					_minimum = value;
                }
				else
                {
					throw new ArgumentException("Минимальное значение должно быть меньше чем максимальное.");
                }
			}
		}

		public double Maximum 
		{
			get
			{
				return _maximum;
			}
			set
			{
				if (value > _minimum)
				{
					_maximum = value;
				}
				else
				{
					throw new ArgumentException("Максимальное значение должно быть больше чем минимальное.");
				}
			}
		}

		public double Step
        {
            get { return _step; }
			set
            {
				if (value > 0)
                {
					_step = value;
                }
                else
                {
					throw new ArgumentException("Шаг должен быть больше 0.");
                }
            }
        }

		public double Interval
        {
            get { return _interval; }
            set
            {
				if((value > 0) && ((Math.Abs(_maximum)+Math.Abs(_minimum))> value ))
                {
					_interval = value;
                }
                else
                {
					throw new ArgumentException("Интервал должен быть больше 0 и меньше чем длина интервала");
                }
            }
        }

		public double SearchPoint
        {
            get { return _searchPoint; }
            set
            {
				if (value >= _minimum && value <= _maximum)
                {
					_searchPoint = value;
                }
                else
                {
					throw new ArgumentException("X0 должен быть больше a и меньше b");
                }
            }
        }

		public double EpsX
        {
            get { return _epsX; }
            set
            {
				if(value > 0)
                {
					_epsX = value;
                }
                else
                {
					throw new ArgumentException("Точность поиска по X должна быть больше 0");
                }
            }
        }


		public double EpsY
		{
			get { return _epsY; }
			set
			{
				if (value > 0)
				{
					_epsY = value;
				}
				else
				{
					throw new ArgumentException("Точность поиска по X должна быть больше 0");
				}
			}
		}

		public double function(double x)
		{
			//return Math.Pow(x, 2) + x + Math.Sin(x);
			//return  2 * pow(x,2) + (16 / x);
			//return  Math.Pow(x, 4) + 8 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) - 72*x;
			return -4 * x * Math.Sin(x);
		}

		public double derivative(double x)
        {
			return 2 * x + 1 + Math.Cos(x);
        }

		public double MethodPaull(double x0, double deltaX, int n, double epsX, double epsY)
		{

			Message = String.Empty;
			double x1 = x0;
			int i = 0;
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
			double[] optimumPointArray = new double[3];
			for (i = 0; i < n; i++)
			{
				functionMin = Math.Min(Math.Min(f1, f2), f3);
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

                if (i < 3)
                {
					optimumPointArray[i] = optimumPoint;
                }

				Message = Message + $"Итерация: {i } Точка оптимума {Math.Round(optimumPoint,_mantissa)} F(x)" +
					$" оптимума {Math.Round(function(optimumPoint),_mantissa)} Стационарная точка {Math.Round(stationPoint, _mantissa)}" +
					$" F(x) стационарной точки {Math.Round(function(stationPoint), _mantissa)} X1:{Math.Round(x1, _mantissa)} " +
					$"F1:{Math.Round(f1, _mantissa)}   X2:{Math.Round(x2, _mantissa)} F2:{Math.Round(f2, _mantissa)}  " +
					$"X3:{Math.Round(x3, _mantissa)} F3:{Math.Round(f3, _mantissa)} {Environment.NewLine}";
				if ((Math.Abs(functionMin - function(stationPoint)) <= epsY) && (Math.Abs(xMin - stationPoint) <= epsX))
                //if ((abs((functionMin - function(stationPoint)) / function(stationPoint)) <= epsY) && (abs((xMin - stationPoint) / stationPoint) <= epsX))
                {
					Message = Message + $"{Environment.NewLine}Итого {Environment.NewLine}Итераций: {i + 1 } Точка оптимума " +
						$"{Math.Round(optimumPoint, _mantissa)} F(x) оптимума {Math.Round(function(optimumPoint), _mantissa)}" +
						$" {Environment.NewLine}Количество вычислений функции {3+5*(i+1)}. {Environment.NewLine}" +
						$"Количество вычислений производных 0. {Environment.NewLine}";
                    if (i >= 2)
                    {
						double alpha = Math.Round(Math.Abs(optimumPointArray[1] - optimumPointArray[2]) / Math.Abs(optimumPointArray[0] - optimumPointArray[1]), _mantissa) ;
						Message = Message + $"Коэффициент сходимости {alpha}";
                    }
					return optimumPoint;
                }

                double[] varArray = new double[4];
				varArray[0] = x1;
				varArray[1] = x2;
				varArray[2] = x3;
				varArray[3] = stationPoint;
				//std::sort(varArray, varArray + 4);
				Array.Sort(varArray);
				for (int j = 0; j < 4; j++)
				{
					if (varArray[j] == optimumPoint)
					{
						switch (j)
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
								x1 = varArray[j - 1];
								x2 = varArray[j];
								x3 = varArray[j + 1];
								break;
						}
					}
				}

				f1 = function(x1);
				f2 = function(x2);
				f3 = function(x3);
				
			}
			throw new ArgumentException("Метод работает некорректно, количество итераций превысило 100.");
			//return 0;
		}

		public Mathematic()
        {
			this.Maximum = 10;
			this.Minimum = -10;
			this.Step = 1;
			this.Interval = 1;
			this.SearchPoint = 1;
			this.EpsX = 0.003;
			this.EpsY = 0.003;
			this.Mantissa = 3;
        }
	}
}
