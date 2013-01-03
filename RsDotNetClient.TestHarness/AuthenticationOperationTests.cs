using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RSDotNetClient.RestClient.Operations;
using RSDotNetClient.RestClient.Requests;

namespace RsDotNetClient.TestHarness
{
    [TestFixture]
    public class AuthenticationOperationTests
    {
        [Test]
        public void Authenticate_GivenValidCredentials_ShouldReturnTokenWithTenantInformation()
        {
            var op = new AuthenticationOperation();
            var response = op.Authenticate(new AuthenticationRequest()
                {
                    Username = "spinsolutions",
                    Password = "15f3ad2d1de2e9dcd3050d772348cce6"
                });

            Assert.IsNotNull(response.Access);
            Assert.AreNotEqual(0, response.Access.ServiceCatalog.Count);
            Assert.IsNotNull(response.Access.Token);
        }

        [Test]
        public void Authenticate_GivenIncorrectCredentials_ShoudThrowAuthenticationException()
        {
            var op = new AuthenticationOperation();

            Assert.Throws<AuthenticationException>(() => op.Authenticate(new AuthenticationRequest()
                {
                    Username = "invaliduser",
                    Password = "invalidey"
                }));
        }

    }
}
