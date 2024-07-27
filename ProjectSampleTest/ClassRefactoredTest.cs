using DeveloperSample.ClassRefactoring;
using DeveloperSample.ClassRefactoring.DeveloperSample.ClassRefactoring;
using Xunit;

namespace ProjectSampleTest
{
    public class ClassRefactoredTest
    {
        //[Fact]
        //public void AfricanSwallowHasCorrectSpeed()
        //{
        //    var african = new African();
        //    Assert.Equal(22, african.GetAirspeedVelocity(SwallowLoad.None));
        //    Assert.Equal(18, african.GetAirspeedVelocity(SwallowLoad.Coconut));
        //}

        //[Fact]
        //public void EuropeanSwallowHasCorrectSpeed()
        //{
        //    var european = new European();
        //    Assert.Equal(20, european.GetAirspeedVelocity(SwallowLoad.None));
        //    Assert.Equal(16, european.GetAirspeedVelocity(SwallowLoad.Coconut));
        //}

        [Fact]
        public void AfricanSwallowHasCorrectSpeed()
        {
            ISwallowFactory abilityFactory = new SwallowTFactory();
            IAirSpeedVelocity ability = abilityFactory.GetSwallowType(SwallowType.African);
            Assert.Equal(22, ability.GetAirspeedVelocity(SwallowLoad.None));
            Assert.Equal(18, ability.GetAirspeedVelocity(SwallowLoad.Coconut)); 
        }

        [Fact]
        public void EuropeanSwallowHasCorrectSpeed()
        {
            ISwallowFactory abilityFactory = new SwallowTFactory();
            IAirSpeedVelocity ability = abilityFactory.GetSwallowType(SwallowType.European);
            Assert.Equal(20, ability.GetAirspeedVelocity(SwallowLoad.None));
            Assert.Equal(16, ability.GetAirspeedVelocity(SwallowLoad.Coconut));
        }
    }
}
