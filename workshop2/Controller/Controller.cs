using System;
using System.Collections.Generic;
using System.Text;

namespace workshop2.Controller
{
    class Controller
    {

        public void lowerToUper()
        {
            
            View.View v = new View.View();
            string lowerMsg = v.ui();
            if (lowerMsg.Length <= 8 && lowerMsg.Length >= 1 )
            {
                Model.Model m = new Model.Model();
                string newString = m.str(lowerMsg);
                //Console.WriteLine(lowerMsg.ToUpper());
                Console.WriteLine(newString.ToUpper());
            }
            else
            {
                Console.WriteLine("BAD INPUT");
            }
        }

    }
}
