namespace DotNetInvestigation
{
    using System;
    using System.Collections.Generic;

    public enum Operation
    {
        Add,
        Remove
    }

    public class CSharp6Features
    {

    }

    /// <summary>
    /// String Interpolation 
    /// </summary>
    class ObjectWithStringInterpolation
    {
        public int Id { get; set; }
        public string FeatureName { get; set; }

        public override string ToString()
        {
            return $"Id: {this.Id}; Feature Name: {this.FeatureName}";
        }

        public static void ValidateOperation(Operation operation)
        {
            if (operation != Operation.Add && operation != Operation.Remove)
            {
                throw new ArgumentException($"Operation '{operation}' is not supported!");
            }
        }
    }

    /// <summary>
    /// Default Values for Properties
    /// </summary>
    public class ElasticsearchConfiguration
    {
        public const int DefaultTimeout = 42;

        public int Timeout { get; set; } = DefaultTimeout;

        public const string DefaultUrl = "http://localhost:9200";

        public string Url { get; set; } = DefaultUrl;
    }

    public class IndexConfiguration
    {
        /// <summary>
        /// Get Only Property
        /// </summary>
        public List<string> Aliases { get; } = new List<string>();
        public string Name { get; set; } = "Default";
        public int Timeout { get; set; } = 42;
    }
    public class BackendConfiguration
    {
        private ElasticsearchConfiguration _configuration = new ElasticsearchConfiguration();
        public List<IndexConfiguration> Indices { get; } = new List<IndexConfiguration>();
        public int Timeout => _configuration.Timeout;
        public string Url => _configuration.Url;
        public int NumberOfIndices => Indices.Count;
        public override string ToString() => $"Url: {Url}; Timeout: {Timeout}";
    }

    public class FireEvent
    {
        public event EventHandler SomethingHappened;

        private void FireSomethingHappened()
        {
            this.SomethingHappened?.Invoke(this, EventArgs.Empty);
        }
    }
}
