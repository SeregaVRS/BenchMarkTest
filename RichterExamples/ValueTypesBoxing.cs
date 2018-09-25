namespace RichterExamples
{
    using System;

    internal struct PointStructure
    {
        private int first, second;

        public PointStructure(int x, int y)
        {
            this.first = x;
            this.second = y;
        }

        public void Change(int value1, int value2)
        {
            this.first = value1;
            this.second = value2;
        }

        public override string ToString()
        {
            return $"{this.first}, {this.second}";
        }
    }

    internal class PointClass
    {
        private int first, second;

        public PointClass(int x, int y)
        {
            this.first = x;
            this.second = y;
        }

        public void Change(int value1, int value2)
        {
            this.first = value1;
            this.second = value2;
        }

        public override string ToString()
        {
            return $"{this.first}, {this.second}";
        }
    }

    internal struct PointStructureWithInterface : IChangeBoxedPoint
    {
        private int first, second;

        public PointStructureWithInterface(int x, int y)
        {
            this.first = x;
            this.second = y;
        }

        public void Change(int value1, int value2)
        {
            this.first = value1;
            this.second = value2;
        }

        public override string ToString()
        {
            return $"{this.first}, {this.second}";
        }
    }

    internal interface IChangeBoxedPoint
    {
        void Change(int value1, int value2);
    }

    public class ValueTypesBoxing
    {
        public void ValueTypeBoxingExample()
        {
            var point = new PointStructure(1, 1);

            Console.WriteLine($"The 1st call (1, 1) - {point}");
            Console.WriteLine();

            point.Change(2, 2);
            Console.WriteLine($"The 2nd call (2, 2) - {point}");
            Console.WriteLine();

            object obj = point;
            Console.WriteLine($"The 3rd call (2, 2) - {obj}");
            Console.WriteLine();

            ((PointStructure)obj).Change(3, 3);
            Console.WriteLine($"The 4th call (Cast to object and call Change) - {point}");
            Console.WriteLine();
        }

        public void ValueTypeWithInterfaceBoxingExample()
        {
            var point = new PointStructureWithInterface(1, 1);

            Console.WriteLine($"The 1st call (1, 1) - {point}");
            Console.WriteLine();

            point.Change(2, 2);
            Console.WriteLine($"The 2nd call (2, 2) - {point}");
            Console.WriteLine();

            object obj = point;
            Console.WriteLine($"The object call (2, 2) - {obj}");
            Console.WriteLine();

            ((PointStructureWithInterface) obj).Change(3, 3);
            Console.WriteLine($"The 3th call (Cast to object and call Change) - {obj}");
            Console.WriteLine();

            ((IChangeBoxedPoint) point).Change(4, 4);
            Console.WriteLine($"The 4th call (Cast Point to Interface) - {point}");
            Console.WriteLine();

            ((IChangeBoxedPoint) obj).Change(5, 5);
            Console.WriteLine($"The 5th call (Cast Object to Interface) - {obj}");
            Console.WriteLine();
        }

        public void ReferenceTypeClassBoxingExample()
        {
            var point = new PointClass(1, 1);

            Console.WriteLine($"The 1st call (1, 1) - {point}");
            Console.WriteLine();

            point.Change(2, 2);
            Console.WriteLine($"The 2nd call (2, 2) - {point}");
            Console.WriteLine();

            object obj = point;
            Console.WriteLine($"The 3rd call (2, 2) - {obj}");
            Console.WriteLine();

            ((PointClass)obj).Change(3, 3);
            Console.WriteLine($"The 4th call (Cast to object and call Change) - {point}");
            Console.WriteLine();
        }
    }
}
