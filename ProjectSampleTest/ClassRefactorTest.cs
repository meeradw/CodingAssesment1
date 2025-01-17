﻿using DeveloperSample.ClassRefactoring.DeveloperSample.ClassRefactoring;
using Xunit;

namespace DeveloperSample.ClassRefactoring
{
    public class ClassRefactorTest
    {
        [Fact]
        public void AfricanSwallowHasCorrectSpeed()
        {
            var swallowFactory = new SwallowFactory();
            var swallow = swallowFactory.GetSwallow(SwallowType.African);
            Assert.Equal(22, swallow.GetAirspeedVelocity());
        }

        [Fact]
        public void AfricanSwallowHasCorrectSpeed1()
        {
            var swallow = new SwallowT(SwallowType.African,SwallowLoad.None);
            Assert.Equal(22, swallow.GetAirspeedVelocity());
        }

        [Fact]
        public void LadenAfricanSwallowHasCorrectSpeed()
        {
            var swallowFactory = new SwallowFactory();
            var swallow = swallowFactory.GetSwallow(SwallowType.African);
            swallow.ApplyLoad(SwallowLoad.Coconut);
            Assert.Equal(18, swallow.GetAirspeedVelocity());
        }
        [Fact]
        public void LadenAfricanSwallowHasCorrectSpeed1()
        {
            var swallow = new SwallowT(SwallowType.African, SwallowLoad.Coconut);
            Assert.Equal(18, swallow.GetAirspeedVelocity());
        }

        [Fact]
        public void EuropeanSwallowHasCorrectSpeed()
        {
            var swallowFactory = new SwallowFactory();
            var swallow = swallowFactory.GetSwallow(SwallowType.European);
            Assert.Equal(20, swallow.GetAirspeedVelocity());
        }

        [Fact]
        public void EuropeanSwallowHasCorrectSpeed1()
        {
            var swallow = new SwallowT(SwallowType.European, SwallowLoad.None);
            Assert.Equal(20, swallow.GetAirspeedVelocity());
        }

        [Fact]
        public void LadenEuropeanSwallowHasCorrectSpeed()
        {
            var swallowFactory = new SwallowFactory();
            var swallow = swallowFactory.GetSwallow(SwallowType.European);
            swallow.ApplyLoad(SwallowLoad.Coconut);
            Assert.Equal(16, swallow.GetAirspeedVelocity());
        }

        [Fact]
        public void LadenEuropeanSwallowHasCorrectSpeed1()
        {
            var swallow = new SwallowT(SwallowType.European, SwallowLoad.Coconut);
            Assert.Equal(16, swallow.GetAirspeedVelocity());
        }
    }
}