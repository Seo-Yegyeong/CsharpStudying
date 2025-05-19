using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpStudying
{
    public partial class Form6DelegatePractice : Form
    {
        public delegate void EventDelegate(object sender, EventArgs e);
        public Form6DelegatePractice()
        {
            InitializeComponent();
            EventManager eventManager = new EventManager();
            eventManager.AppendEvent("button1_Click", new EventDelegate(button1_Click));
            eventManager.AppendEvent("button2_Click", new EventDelegate(button2_Click));
            eventManager.AppendEvent("button3_Click", new EventDelegate(button3_Click));
            eventManager.RemoveEvent("button2_Click", new EventDelegate(button2_Click));
            eventManager.InvokeEvent("button1_Click", this, EventArgs.Empty);
            eventManager.InvokeEvent("button2_Click", this, EventArgs.Empty);
            eventManager.InvokeEvent("button3_Click", this, EventArgs.Empty);

            Console.WriteLine("==========InvokeEventAll==========");
            eventManager.InvokeEventAll(this, EventArgs.Empty);

            Console.WriteLine("The end of program!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button 1 clicked!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button 2 clicked!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button 3 clicked!");
        }

        public class EventManager
        {
            private Dictionary<string, EventDelegate> eventDictionary = new Dictionary<string, EventDelegate>();

            public void AppendEvent(string eventName, EventDelegate eventDelegate)
            {
                if (eventDictionary.ContainsKey(eventName))
                {
                    eventDictionary[eventName] += eventDelegate;
                }
                else
                {
                    eventDictionary.Add(eventName, eventDelegate);
                }
            }

            public void RemoveEvent(string eventName, EventDelegate eventDelegate)
            {
                if (eventDictionary.ContainsKey(eventName))
                {
                    eventDictionary.Remove(eventName);
                }
            }

            public void InvokeEvent(string eventName, object sender, EventArgs e)
            {
                if (eventDictionary.ContainsKey(eventName))
                {
                    eventDictionary[eventName].Invoke(sender, e);
                }
            }

            public void InvokeEventAll(object sender, EventArgs e)
            {
                foreach (var eventDelegate in eventDictionary.Values)
                {
                    eventDelegate.Invoke(sender, e);
                }
            }

            public void ClearEvents()
            {
                eventDictionary.Clear();
            }
        }
    }
}
