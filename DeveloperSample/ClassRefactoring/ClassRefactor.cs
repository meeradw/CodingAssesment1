using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperSample.ClassRefactoring
{
    using System;

    namespace DeveloperSample.ClassRefactoring
    {
        public enum SwallowType
        {
            African, European
        }

        public enum SwallowLoad
        {
            None, Coconut
        }

        public class SwallowFactory
        {
            public Swallow GetSwallow(SwallowType swallowType) => new Swallow(swallowType);
        }

        public class SwallowT
        {
            private SwallowType Type { get; }
            private SwallowLoad Load { get; }
            public SwallowT(SwallowType swallowType, SwallowLoad swallowLoad)
            {
                Type = swallowType;
                Load = swallowLoad;
            }
            public double GetAirspeedVelocity()
            {
                switch (Type)
                {
                    case SwallowType.African:
                        if (Load == SwallowLoad.None) return 22;
                        else if (Load == SwallowLoad.Coconut) return 18;
                        break;
                    case SwallowType.European:
                        if (Load == SwallowLoad.None) return 20;
                        else if (Load == SwallowLoad.Coconut) return 16;
                        break;
                    default: return 0;
                }
                throw new NotImplementedException();
            }
        }

        public class Swallow
        {
            public SwallowType Type { get; }
            public SwallowLoad Load { get; private set; }

            public Swallow(SwallowType swallowType)
            {
                Type = swallowType;
            }

            public void ApplyLoad(SwallowLoad load)
            {
                Load = load;
            }

            public double GetAirspeedVelocity()
            {
                if (Type == SwallowType.African && Load == SwallowLoad.None)
                {
                    return 22;
                }
                if (Type == SwallowType.African && Load == SwallowLoad.Coconut)
                {
                    return 18;
                }
                if (Type == SwallowType.European && Load == SwallowLoad.None)
                {
                    return 20;
                }
                if (Type == SwallowType.European && Load == SwallowLoad.Coconut)
                {
                    return 16;
                }
                throw new InvalidOperationException();
            }
        }
    }
}
