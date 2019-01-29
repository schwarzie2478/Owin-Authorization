using Microsoft.Owin.Security.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebApi_OWIN.Controllers;

namespace WebApi_OWIN
{
    public class HasEmployeeNumberRequirement : IAuthorizationRequirement
    {
        public HasEmployeeNumberRequirement()
        {
        }
    }

    public class HasEmployeeNumberHandler : AuthorizationHandler<HasEmployeeNumberRequirement>
    {
        public HasEmployeeNumberHandler()
        {
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, HasEmployeeNumberRequirement requirement)
        {
            var employee = context.Resource as Employee;
            if (context.User.Claims.Any(c => c.Type == ExampleConstants.EmployeeClaimType && c.Value == employee.Id.ToString()))
                context.Succeed(requirement);
            return Task.FromResult(0);
        }
    }
}