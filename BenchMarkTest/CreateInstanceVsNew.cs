using System;

namespace BenchMarkTest
{
    using BenchmarkDotNet.Attributes;

    /// <summary>
    ///
    /// </summary>
    public class CreateInstanceVsNew
    {
        public static T Create<T>() where T : new() => new T();

        public static Func<Node> NodeFactory => () => new Node();

        [Benchmark]
        public Node ActivatorCreateInstace() => System.Activator.CreateInstance<Node>();

        [Benchmark]
        public Node FactoryWithNewConstraint() => CreateInstanceVsNew.Create<Node>();


        [Benchmark]
        public Node ConstructorCall() => new Node();


        [Benchmark]
        public Node FuncBasedFactory() => NodeFactory();
    }


    public class Node
    {
        public Node()
        {
        }
    }

    //public class NodeFactory
    //{
    //    public static TNode CreateNode<TNode>() where TNode : Node, new()
    //    {
    //        return new TNode();
    //    }
    //}
}
