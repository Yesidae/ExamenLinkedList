namespace LinkedList.Logic
{
    public class DoubleList<T>
    {
        private DoubleNode<T>? _first;

        private DoubleNode<T>? _last;

        public DoubleList()
        {
            _first = null;
            _last = null;
            Count = 0;
        }

        public int Count { get; set; }

        public bool IsEmpty => Count == 0;

        public override string ToString()
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer != null)
            {
                output += $"{pointer.Data}\n";
                pointer = pointer.Right;
            }
            return output;
        }

        public string ToInvertedList()
        {
            var output = string.Empty;
            var pointer = _last;
            while (pointer != null)
            {
                output += $"{pointer.Data}\n";
                pointer = pointer.Left;
            }
            return output;
        }

        public void Add(T item)
        {
            var node = new DoubleNode<T>(item);
            if (IsEmpty)
            {
                _first = node;
                _last = node;
            }
            else
            {
                node.Left = _last;
                _last!.Right = node;
                _last = node;
            }
            Count++;
        }

        public T[] ToArray()
        {
            var array = new T[Count];
            int i = 0;
            var pointer = _first;
            while (pointer != null)
            {
                array[i] = pointer.Data!;
                i++;
                pointer = pointer.Right;
            }
            return array;
        }

        public DoubleList<Car> GetBrand(string brand)
        {

            var BrandList = new DoubleList<Car>();

            var pointer = _first;

            while (pointer != null)
            {
                Car newpointer= (Car)Convert.ChangeType(pointer.Data, typeof(Car))!;
                if (brand.Equals(newpointer.Brand))
                {
                    BrandList.Add(newpointer);
                }
                pointer = pointer.Right;
            }


            return BrandList;
        }


        public DoubleList<Car> GetYear(int lower, int upper)
        {
            var YearList = new DoubleList<Car>();

            var pointer = _first;

            while (pointer != null)
            {
                Car newpointer = (Car)Convert.ChangeType(pointer.Data, typeof(Car))!;

                if (lower <= newpointer.Year && upper >= newpointer.Year)
                {
                    YearList.Add(newpointer);
                }
                pointer = pointer.Right;
            }


            return YearList;
        }

        public DoubleList<Car> GetPrice(decimal lower, decimal upper)
        {
            var PriceList = new DoubleList<Car>();

            var pointer = _first;

            while (pointer != null)
            {
                Car newpointer = (Car)Convert.ChangeType(pointer.Data, typeof(Car))!;

                if (lower <= newpointer.Price && upper >= newpointer.Price)
                {
                    PriceList.Add(newpointer);
                }
                pointer = pointer.Right;
            }


            return PriceList;
        }


        public DoubleList<Car> GetSeveralFilter(string brand, string model, string color, int minimunYear, int maximunYear)
        {
            var SeveralList = new DoubleList<Car>();

            var pointer = _first;

            while (pointer != null)
            {
                Car newpointer = (Car)Convert.ChangeType(pointer.Data, typeof(Car))!;

                if (minimunYear <= newpointer.Year && maximunYear >= newpointer.Year)
                {
                    if (   brand == "*" && model == "*" && color == "*" //todos son *
                        || brand == "*" && model == "*" && color.Equals(newpointer.Color) // color admitido y los demas *
                        || brand == "*" && model.Equals(newpointer.Model) && color.Equals(newpointer.Color)//todos cumplen y el bran es *

                        || brand.Equals(newpointer.Brand) && model == "*" && color == "*" // el brand cumple y model y color son *
                        || brand.Equals(newpointer.Brand) && model.Equals(newpointer.Model) && color == "*" //todos cumplen y el color es *
                        || brand == "*" && model.Equals(newpointer.Model) && color == "*" //model cumple y brand y color son *

                        || brand.Equals(newpointer.Brand) && model == "*" && color.Equals(newpointer.Color) //todos cumplen y el model es *
                        || brand.Equals(newpointer.Brand) && model.Equals(newpointer.Model) && color.Equals(newpointer.Color) //todos cumplen su condicion
                        ) 

                    {
                        SeveralList.Add(newpointer);
                    }
                    
                }
                pointer = pointer.Right;
            }


            return SeveralList;
        }

        public Car[] GetMinMax(DoubleList<Car> list)
        {
            var Array = new Car[2];
            var pointer = _first;
            Car minimun = (Car)Convert.ChangeType(pointer!.Data, typeof(Car))!;
            Car maximun = (Car)Convert.ChangeType(pointer!.Data, typeof(Car))!;

            while (pointer != null)
            {
                Car newpointer = (Car)Convert.ChangeType(pointer.Data, typeof(Car))!;
                if (newpointer.Price > maximun.Price)
                {
                    maximun = newpointer;
                }
                else if (newpointer.Price < minimun.Price)
                {

                    minimun = newpointer;
                }

                pointer = pointer.Right;
            }

            Array[0] = minimun;
            Array[1] = maximun;

            return Array;
        }   
    }
}
