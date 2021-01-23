using System;

namespace HW210121
{
    public class Car
    {
        public int Id { get; set; }

        private int _volume;

        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                if (value > 0)
                    _volume = value;
            }
        }

        private string _model;

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    _model = value;
            }
        }

        private string _vendor;

        public string Vendor
        {
            get
            {
                return _vendor;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    _vendor = value;
            }
        }

        private DateTime _produceYear;
        public DateTime ProduceYear
        {
            get => _produceYear;
            set
            {
                if (value != null)
                    _produceYear = value;
            }
        }


        private static int CurrentId = 0;

        public Car()
        {
            
        }

        public Car(string model)
        {

            this.Model = model;
            this.Id = ++CurrentId;
        }

        public Car(string model, string vendor):this(model)
        {
            this.Vendor = vendor;
        }

        public Car(string model, string vendor, int volume):this(model, vendor)
        {
            this.Volume = volume;
        }

        public Car(string model, string vendor, int volume, DateTime produceYear):this(model, vendor, volume)
        {
            this.ProduceYear = produceYear;
        }


        public void Show()
        {
            Console.WriteLine("ID: {0}\nModel: {1}\nVendor: {2}\nVolume: {3}\nProduce Year: {4:d}",
                Id, Model, Vendor, Volume, ProduceYear);
        }

        public int GetAge() => (int)((DateTime.Now - ProduceYear).TotalDays / 365);
    }
}