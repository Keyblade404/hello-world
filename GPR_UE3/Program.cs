namespace GPR_UE3
{
    class NPC
    {
        private string[] dialogLines;
        public string Name { get; private set; }
        public void Talk()
        {}
    }
    class Position
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    class Vehicle
    {
        public Position CurrentPosition { get; set; }
        public virtual Position Move(Position targetPosition)
        { return targetPosition; }
    }
    class Airplane : Vehicle
    {
        public double Speed { get; private set; }
        public Airplane (double speed)
        { this.Speed = speed; }
        public override Position Move(Position targetPosition)
        { return targetPosition; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray = { 3, 1, 4, 2, 0 };
            int i = 0;
            while (i < integerArray.Length) 
            {
                Console.Write(integerArray[i] + ", ");
                i++;
            }
            Console.WriteLine();
            for (int j = 0; j < integerArray.Length; j++)
            {
                Console.Write(integerArray[j] + ", ");
            }
            Console.WriteLine();
            foreach (int integer in integerArray)
            {
                Console.Write(integer +", ");
            }
        }
    }
}
