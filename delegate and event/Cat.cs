using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_and_event
{
    public class CatEventArgs:EventArgs
    {
        public CatEventArgs(string msg)
        {
            Msg = msg;
        }
        public string Msg { get; set; }
    }
    class Cat
    {
        public event EventHandler<CatEventArgs> CatComeEvent;

        private string _name;
        public Cat(string name)
        {
            _name = name;
        }
        public void Coming()
        {
            //Console.WriteLine($"{_name} Cat coming.....");
            OnComing(new CatEventArgs($"{_name} Cat coming....."));
        }

        protected virtual void OnComing(CatEventArgs c)
        {
            EventHandler<CatEventArgs> handler = CatComeEvent;
            if (handler != null)
            {
                c.Msg += $" at {DateTime.Now}";
                handler.Invoke(this, c);
            }
        }
    }
}
