using System;

namespace foxui
{
    class Ui
    {
        static void Main(string[] args)
        {
            DbConector dbConector= new DbConector();
            
            dbConector.connect();
        }
    }
}
