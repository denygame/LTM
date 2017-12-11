using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controller
{
    public class EventCheckBox
    {
        private bool check;

        public bool Check { get => check; set => check = value; }

        public EventCheckBox(bool check)
        {
            this.Check = check;
        }
    }
}
