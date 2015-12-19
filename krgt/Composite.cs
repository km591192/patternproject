using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace krgt
{
     public interface IEmployee
    {
        void ShowLevel(ListBox lb);
    }

    public class Worker : IEmployee
    {
        private string name;
        private int level;

        public Worker(string name, int level)
        {
            this.name = name;
            this.level = level;
        }

        void IEmployee.ShowLevel(ListBox lb)
        {
            lb.Items.Add(name + " showed level of " + level);
        }
    }

    public class Supervisor : IEmployee
    {
        private string name;
        private int level;

        private List<IEmployee> subordinate = new List<IEmployee>();

        public Supervisor(string name, int level)
        {
            this.name = name;
            this.level = level;
        }

        void IEmployee.ShowLevel(ListBox lb)
        {
            lb.Items.Add(name + " showed level of " + level);
            foreach (IEmployee i in subordinate)
            { i.ShowLevel(lb); }
        }

        public void AddSubordinate(IEmployee employee)
        {
            subordinate.Add(employee);
        }
    }
}
