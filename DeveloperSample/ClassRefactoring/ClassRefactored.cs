using DeveloperSample.ClassRefactoring.DeveloperSample.ClassRefactoring;


namespace DeveloperSample.ClassRefactoring
{
    public interface IAirSpeedVelocity
    {
        double GetAirspeedVelocity(SwallowLoad load);
    }

    public class African : IAirSpeedVelocity
    {
        public double GetAirspeedVelocity(SwallowLoad load)
        {
            if(load == SwallowLoad.None)
                return 22;
            else if(load == SwallowLoad.Coconut)
                return 18;
            throw new InvalidOperationException();
        }   
    }

    public class European : IAirSpeedVelocity
    {
        public double GetAirspeedVelocity(SwallowLoad load)
        {
            if (load == SwallowLoad.None)
                return 20;
            else if (load == SwallowLoad.Coconut)
                return 16;
            throw new InvalidOperationException();
        }
    }

    public interface ISwallowFactory
    {
        IAirSpeedVelocity GetSwallowType(SwallowType swallowType);
    }

    public class SwallowTFactory : ISwallowFactory
    {
        public IAirSpeedVelocity GetSwallowType(SwallowType swallowType)
        {
            switch (swallowType)
            {
                case SwallowType.African:
                    return new African();
                case SwallowType.European:
                    return new European();
                default:
                    return null;
            }
        }
    }

}
