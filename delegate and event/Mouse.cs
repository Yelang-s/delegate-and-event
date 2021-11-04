using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_and_event
{
    class Mouse
    {
        private string _name;
        public Mouse(string name,Cat cat)
        {
            _name = name;
            cat.CatComeEvent += Cat_CatComeEvent;
        }

        private void Cat_CatComeEvent(object sender, CatEventArgs e)
        {
            Console.WriteLine(e.Msg);
            Console.WriteLine($"{_name} running......");
        }
    }
}
