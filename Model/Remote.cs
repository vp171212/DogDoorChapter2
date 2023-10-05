using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DogDoorApp.Model
{
    internal class Remote
    {
        private DogDoor _door;
        private Timer _timer = new Timer(5000);

        public Remote(DogDoor door)
        {
            _door = door;
            _timer.Elapsed += new ElapsedEventHandler(TimerElapsedCloseDoor);
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button ...");
            ToggleDoorState();
            AutoCloseDoor();
        }

        private void ToggleDoorState()
        {
            if (_door.isOpen)
            {
                _door.close();
            }
            else
            {
                _door.open();
            }
        }

        private void AutoCloseDoor()
        {
            _timer.Enabled = true;
        }

        private void TimerElapsedCloseDoor(object sender, ElapsedEventArgs e)
        {
            _door.close();
            _timer.Enabled = false;
        }
    }
}
