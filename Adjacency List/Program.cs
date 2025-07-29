using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Adjacency_List.Program.Graph;

namespace Adjacency_List
{
    internal class Program
    {
        public class Graph
        {
            public enum enGraphDirectionType { Directed, unDirected }
            private Dictionary<string, List<Tuple<string, int>>> _adjacecyList;
            private Dictionary<string, int> _vertixDictionary;
            private int _numberOfvertices;
            private enGraphDirectionType _direction;

            public Graph(List<string> Vertices, enGraphDirectionType directionType)
            {
                _direction = directionType;
                _numberOfvertices = Vertices.Count;
                _adjacecyList = new Dictionary<string, List<Tuple<string, int>>>();
                _vertixDictionary = new Dictionary<string, int>();
                for(int i  = 0; i < _numberOfvertices; i++)
                {
                    _vertixDictionary.Add(Vertices[i], i);
                    _adjacecyList[Vertices[i]] = new List<Tuple<string, int>>();
                }
            }


            public void AddEdge(string source,string destenation,int weight)
            {
                if (_adjacecyList.ContainsKey(source) && _adjacecyList.ContainsKey(destenation))
                {
                    _adjacecyList[source].Add(new Tuple<string, int>(destenation, weight));
                    if (_direction == enGraphDirectionType.unDirected)
                    {
                        _adjacecyList[destenation].Add(new Tuple<string, int>(source, weight));

                    }
                }
                else
                {
                    Console.WriteLine("||~~~~~~~~~~~~~~~~~~~~~~~~||");
                    Console.WriteLine("||        FUCK YOU        ||");
                    Console.WriteLine("||~~~~~~~~~~~~~~~~~~~~~~~~||");
                }
            }
            public void RemoveEdge(string source,string destenation)
            {
                if (_adjacecyList.ContainsKey(source) && _adjacecyList.ContainsKey(destenation))
                {
                    _adjacecyList[source].RemoveAll(x => x.Item1 == source);
                    if (_direction == enGraphDirectionType.unDirected)
                    {
                        _adjacecyList[destenation].RemoveAll(x => x.Item1 == source);
                    }
                }
            }
            public void DisplayGraph(string message)
            {
                Console.WriteLine(message);
                foreach(var vertix in  _adjacecyList)
                {
                    Console.Write(vertix.Key + " -> ");
                    foreach (var edge in vertix.Value)
                    {
                        Console.Write($"{edge.Item1}: {edge.Item2}");
                    }
                    Console.WriteLine();
                }
            }
            public bool IsEdge(string source,string destenation)
            {
                if (_adjacecyList.ContainsKey(source) && _adjacecyList.ContainsKey(destenation))
                {
                    foreach(var edge in _adjacecyList[source])
                    {
                        if (edge.Item1 == source) return true;
                    }
                }
                return false;
            }

        }

        static void Main(string[] args)
        {
            ConsoleColor color = ConsoleColor.DarkRed;
            Console.ForegroundColor = color;
            List<string> vertices = new List<string> { "A", "B", "C", "D", "E" };

            Graph graph1 = new Graph(vertices, enGraphDirectionType.unDirected);
            graph1.AddEdge("A", "B", 1);
            graph1.AddEdge("A", "C", 1);
            graph1.AddEdge("B", "D", 1);
            graph1.AddEdge("C", "D", 1);
            graph1.AddEdge("B", "E", 1);
            graph1.AddEdge("D", "E", 1);
            graph1.DisplayGraph("Adjacency Matrix for Example1 (Undirected Graph):");

            Console.WriteLine("\n------------------------------\n");

            Graph graph2 = new Graph(vertices, enGraphDirectionType.Directed);
            graph2.AddEdge("A", "A", 1);
            graph2.AddEdge("A", "B", 1);
            graph2.AddEdge("A", "C", 1);
            graph2.AddEdge("B", "E", 1);
            graph2.AddEdge("D", "B", 1);
            graph2.AddEdge("D", "C", 1);
            graph2.AddEdge("D", "E", 1);
            graph2.DisplayGraph("Adjacency Matrix for Example2 (Directed Graph):");

           
        
        }
    }
}
