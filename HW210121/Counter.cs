namespace HW210121
{
    public class Counter
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public int Current { get; private set; }

        public Counter()
        {
        }

        public Counter(int min, int max)
        {
            this.Min = min;
            this.Max = max;

            this.Current = min;
        }

        public void Increment()
        {
            Current++;

            if (Current == Max)
                Current = Min;
        }

        public int GetCurrent() => Current;
    }
}