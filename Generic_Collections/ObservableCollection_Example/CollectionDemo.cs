using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Generic_Collections.ObservableCollection_Example
{
    public class CollectionDemo
    {
        public void Execute()
        {
            ObservableCollection<string> students = new ObservableCollection<string>();

            students.CollectionChanged += Students_CollectionChanged;

            students.Add("John");
            students.Add("David");
        }

        private void Students_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Collection Changed");
        }

        public static void Main(string[] args)
        {
            CollectionDemo demo = new CollectionDemo();
            demo.Execute();
        }
    }
}