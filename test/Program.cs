using System;
using symbolist;

namespace test
{
    public class TestList : SymbioticList<TestList, TestItem>
    {
        protected override void PreAdd(TestItem item)
        {
            base.PreAdd(item);
            Console.WriteLine($"Pre-add {item.Name}");
        }
        
        protected override void PostAdd(TestItem item)
        {
            base.PostAdd(item);
            Console.WriteLine($"Post-add {item.Name}");
        }
        
        protected override void PreRemove(TestItem item)
        {
            base.PreRemove(item);
            Console.WriteLine($"Pre-remove {item.Name}");
        }
        
        protected override void PostRemove(TestItem item)
        {
            base.PostRemove(item);
            Console.WriteLine($"Post-remove {item.Name}");
        }
    }

    public class TestItem : SymbioticItem<TestList, TestItem>
    {
        public new int Index => base.Index;

        public string? Name;
    }

    public class Program
    {
        static void Main(string[] args)
        {
            TestList list = [];
            void printList()
            {
                foreach (var item in list)
                    Console.WriteLine($"{item.Index,-10}{item.Name}");
                Console.WriteLine();
            }
            TestItem apple = new() { Name = "Apple", };
            TestItem banana = new() { Name = "Banana", };
            TestItem cherry = new() { Name = "Cherry", };
            TestItem date = new() { Name = "Date", };
            TestItem elderberry = new() { Name = "Elderberry", };
            TestItem fig = new() { Name = "Fig", };
            TestItem grape = new() { Name = "Grape", };
            TestItem honeydew = new() { Name = "Honeydew", };
            list.Add(apple);
            list.Add(banana);
            list.Add(cherry);
            list.Add(date);
            list.Add(elderberry);
            list.Add(fig);
            list.Add(grape);
            list.Add(honeydew);
            Console.WriteLine();
            printList();
            list.Clear();
            Console.WriteLine();
            printList();
        }
    }
}