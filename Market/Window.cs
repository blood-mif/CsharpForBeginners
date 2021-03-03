using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    public class Window
    {
        static int _idWindow = 1;
        public Window()
        {
            CreationDateWindow = DateTime.Now;
            WindowId = _idWindow++;
        }

        public int WindowId { get; set; }

        public string WindowName { get; set; }

        public int WindowWeight { get; set; } // подправить имя

        public DateTime CreationDateWindow { get; set; }


    }
}
