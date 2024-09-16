namespace DataStructuresPractice
{
    internal class Program
    {
        //LinkedList
        public class LinkedList
        {
            public class Node
            {
                public object data;
                public Node next;
            }
            private Node root;
            public Node First
            {
                get
                {
                    return root;
                }
            }
            public Node Last
            {
                get
                {
                    Node currentNode = root;
                    if (currentNode == null)
                    {
                        return null;
                    }
                    while (currentNode != null)
                    {
                        currentNode = currentNode.next;
                    }
                    return currentNode;
                }
            }
            public void Add(object value)
            {
                Node node = new Node { data = value };
                if(root == null)    
                {
                    root = node;
                }
                else
                {
                    Last.next = node;
                }
            }
            public void Remove(Node node)
            {
                if(root == node)
                {
                    root = node.next;
                    node.next = null;
                }
                else
                {
                    Node current = root;
                    while(current.next != null)
                    {
                       if (current.next == node)
                        {
                            current.next = node.next;
                            node.next = null;
                            break;
                        }
                       current = current.next; 
                    }
                }
            }

        }



        static void Main(string[] args)
        {
            //HashSet
            HashSet<string> set = new HashSet<string> { "a", "b", "c"};
            HashSet<string> set2 = new HashSet<string> { "d", "e", "f", "a", "b" };

            set.SymmetricExceptWith(set2);
            foreach (string s in set)
            {
                
            }
            
            //SortedList
            SortedList<string, int> list = new SortedList<string, int>()
            { 
                { "key1", 1 },
                { "Key2", 2 },
                { "Key3", 3 }
            };

            list.Add("Key4", 4);
            list.Capacity = 5;
            list.Remove("key1");
            list.RemoveAt(1);

            Console.WriteLine(list.IndexOfKey("key3"));
            Console.WriteLine(list.IndexOfValue(4));

            //SortedDictionary
            SortedDictionary<string, string> sortedDict = new SortedDictionary<string, string>()
            {
                {"key1", "value1"},
                {"key2", "value2" },
                {"key3", "value3" }
            };

            sortedDict.Add("key4", "value4");
            sortedDict.ContainsKey("key1");
            sortedDict.Remove("key2");

            if (sortedDict.ContainsValue("value3")) { };

            var sortedValue = string.Empty;
            sortedDict.TryGetValue("key1", out sortedValue);

            sortedDict.Clear();

            //SortedSets
            SortedSet<int> sortedSet = new SortedSet<int>()
            {
                1,2,25,6
            };
            sortedSet.Add(12);
            sortedSet.Add(5);
            sortedSet.Add(8);


            foreach (var sorted in sortedSet)
            {
                Console.WriteLine(sorted);
            }

            if (sortedSet.Contains(1)) { };

            sortedSet.Remove(6);
            sortedSet.Overlaps(new List<int>() { 1,2,3});
            sortedSet.RemoveWhere(x => x > 20);

            foreach (var i in sortedSet.Reverse())
            {
                Console.WriteLine(i);
            }

            List<int> sortedList = new List<int>()
            {
                9,10,11
            };
            sortedSet.UnionWith(sortedList);
            sortedSet.IntersectWith(sortedList);
            sortedSet.ExceptWith(new List<int> { 9,10});
            Console.WriteLine(sortedSet.Count);

            // Tuples
           Tuple<int> tuple = Tuple.Create(1);
            Tuple<int> singleton = new Tuple<int> (1);
            Tuple<int, int> Pair = new Tuple<int, int> (1,2);
            Tuple<int, int, int,int,int,int,int> sepTuple = new Tuple<int, int, int,int,int,int,int > (1,2,3,4,5,6,7);
            Tuple<int, int, int, int> quadruple = new Tuple<int, int, int, int>(1, 2, 3, 4);
            Tuple<int, string, char> mixedTuple = new Tuple<int, string, char>(1, "and", '!');


        }
    }
}
