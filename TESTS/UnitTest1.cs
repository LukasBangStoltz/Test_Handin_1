using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;
using Test_Handind_1;

namespace TESTS
{
    public class UnitTest1
    {

        
        [Fact]
        public void TestSuccesFToC()
        {
            Assert.Equal(37.7808f, Virk.fToC(100f));
        }
        [Fact]
        public void TestFailFToC()
        {
            Assert.Equal(5, Virk.fToC(100));
        }

        


        [Fact]
        public void TestSuccesCToF()
        {
            Assert.Equal(212f, Virk.cToF (100f));
        }
        [Fact]
        public void TestFailCToF()
        {
            Assert.Equal(37, Virk.cToF(100f));
        }


        
    }
}