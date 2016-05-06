﻿using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Owin.Security.Authorization
{
    [TestClass, ExcludeFromCodeCoverage]
    public class AuthorizationOwinHelperTests
    {
        [SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "Microsoft.Owin.Security.Authorization.AuthorizationHelper", Justification = "Expected exception")]
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void AuthorizationOwinHelperShouldThrowWhenPassedNullOwinContext()
        {
            // ReSharper disable once ObjectCreationAsStatement
            new AuthorizationHelper(null);
        }
    }
}