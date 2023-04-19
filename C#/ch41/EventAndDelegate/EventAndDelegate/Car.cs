using System;

namespace EventAndDelegateDemo
{
    // 이벤트 게시자(publisher)
    class Car
    {
        private int _fuelGuage;

        public int FuelGauge
        {
            get { return _fuelGuage; }
            set 
            { 
                _fuelGuage = value;
                OnFuelEmptyReached();
            }
        }

        public Car()
        {
            _fuelGuage = 25;        // 25%
        }

        public void Go()
        {
            Console.WriteLine("운전");
            FuelGauge -= 5;        // 메서드 호출 시 5% 씩 감소
        }

        //public delegate void EventHandler();      // 이벤트 생성
        //public event EventHandler warning;
        public event Action warning;                // 이벤트 생성2
        public void OnFuelEmptyReached()
        {
            Console.WriteLine($"연료 상태: {_fuelGuage}%");
            if (_fuelGuage < 20)
            {
                if (warning != null)
                {
                    //warning();
                    warning?.Invoke();
                } 
            }
        }
    }
}