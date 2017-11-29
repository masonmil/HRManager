using MasonApps.HRManager.models.address;
using Xunit;

namespace HRTest.tests.models.address
{
    public class AddressTest
    {
        [Fact]
        public void GetAddress1ReturnsAssigneddValue()
        {
            var sut = new Address();
            sut.Address1 = "foo";
            Assert.Equal("foo",sut.Address1);
        }
    }
}