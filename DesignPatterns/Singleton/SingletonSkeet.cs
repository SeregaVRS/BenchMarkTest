namespace DotNetInvestigation
{
    using System;

    // Bad code! Do not use!
    public sealed class SingletonNotThreadSafe
    {
        private static SingletonNotThreadSafe instance = null;

        private SingletonNotThreadSafe()
        {
        }

        public static SingletonNotThreadSafe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonNotThreadSafe();
                }
                return instance;
            }
        }
    }

    // 2
    public sealed class SingletonSimpleThreadSafety
    {
        private static SingletonSimpleThreadSafety instance = null;
        private static readonly object padlock = new object();

        SingletonSimpleThreadSafety()
        {
        }

        public static SingletonSimpleThreadSafety Instance
        {
            get
            {
                lock (padlock)
                {
                    return instance ?? (instance = new SingletonSimpleThreadSafety());
                }
            }
        }
    }

    // Bad code! Do not use!
    public sealed class SingletonDoubleCheckLocking
    {
        private static SingletonDoubleCheckLocking instance = null;
        private static readonly object padlock = new object();

        SingletonDoubleCheckLocking()
        {
        }

        public static SingletonDoubleCheckLocking Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonDoubleCheckLocking();
                        }
                    }
                }
                return instance;
            }
        }
    }

    // 4
    public sealed class SingletonThreadSafeWithoutLocks
    {
        private static readonly SingletonThreadSafeWithoutLocks instance = new SingletonThreadSafeWithoutLocks();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static SingletonThreadSafeWithoutLocks()
        {
        }

        private SingletonThreadSafeWithoutLocks()
        {
        }

        public static SingletonThreadSafeWithoutLocks Instance
        {
            get
            {
                return instance;
            }
        }
    }

    // 5
    public sealed class SingletonFullyLazyInstantiation
    {
        private SingletonFullyLazyInstantiation()
        {
        }

        public static SingletonFullyLazyInstantiation Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly SingletonFullyLazyInstantiation instance = new SingletonFullyLazyInstantiation();
        }
    }

    // 6 - Preferable
    public sealed class SingletonLazyType
    {
        private static readonly Lazy<SingletonLazyType> lazy =
            new Lazy<SingletonLazyType>(() => new SingletonLazyType());

        public static SingletonLazyType Instance { get { return lazy.Value; } }

        private SingletonLazyType()
        {
        }
    }
}
