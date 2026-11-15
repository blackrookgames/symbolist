using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using symbolist;

namespace test
{
    public class TestList : SymbioticKeyedList<TestList, TestItem, string>
    {
        protected override void PreAdd(TestItem item)
        {
            base.PreAdd(item);
            Console.WriteLine($"Pre-add {item.Key}");
        }
        
        protected override void PostAdd(TestItem item)
        {
            base.PostAdd(item);
            Console.WriteLine($"Post-add {item.Key}");
        }
        
        protected override void PreRemove(TestItem item)
        {
            base.PreRemove(item);
            Console.WriteLine($"Pre-remove {item.Key}");
        }
        
        protected override void PostRemove(TestItem item)
        {
            base.PostRemove(item);
            Console.WriteLine($"Post-remove {item.Key}");
        }
    }

    public class TestItem : SymbioticKeyedItem<TestList, TestItem, string> { }

    public class Program
    {
        static void Main(string[] args)
        {
            TestList list = [];
            void printList()
            {
                foreach (var item in list)
                    Console.WriteLine($"{item.Index,-10}{item.Key}");
                Console.WriteLine();
            }
            TestItem apple = new(); apple.SetKey("Apple");
            TestItem banana = new(); banana.SetKey("Banana");
            TestItem cherry = new(); cherry.SetKey("Cherry");
            TestItem date = new(); date.SetKey("Date");
            TestItem elderberry = new(); elderberry.SetKey("Elderberry");
            TestItem fig = new(); fig.SetKey("Fig");
            TestItem grape = new(); grape.SetKey("Grape");
            TestItem honeydew = new(); honeydew.SetKey("Honeydew");
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
            list.Remove(apple);
            apple.SetKey("Incaberry");
            list.Add(apple);
            Console.WriteLine();
            Console.WriteLine($"Found the {list["Incaberry"].Key}");
            Console.WriteLine();
            printList();
        }
    }
}