

using System.Diagnostics;

namespace ls1_5_class
{
    public class Program
    {
        static List<Level> levels = new List<Level>();

        static void Main(string[] args)
        {
            Console.Write("Enter levels count: ");
            int countLevels = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter high price: ");
            decimal priceUp = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter step level: ");
            decimal stepLevel = Convert.ToDecimal(Console.ReadLine());

            calculateLevels(countLevels, priceUp, stepLevel);

            writeLevelsList();
        }

        static void calculateLevels(int _countLevels, decimal _priceUp, decimal _stepLevel)
        {
            for (int i = 0; i < _countLevels; i++)
            {
                if (_priceUp > 0)
                {
                    Level _level = new Level() { PriceLevel = _priceUp };
                    levels.Add(_level);
                    _priceUp -= _stepLevel;
                }
            }
            
        }

        static void writeLevelsList()
        {
            Console.Write("Elements level's list: ");

            if (levels.Count == 0)
            {
                Console.Write("elements not found ");
            }
            else
            {
                string _elementListString = "";
                for (int i = 0; i < levels.Count; i++)
                {
                    if (i != levels.Count-1)
                    {
                        _elementListString += Convert.ToString(levels[i].PriceLevel) + ", ";
                    }
                    else
                    {
                        _elementListString += Convert.ToString(levels[i].PriceLevel);
                    }
                }
                Console.Write(_elementListString);
            }
        }


    }


}