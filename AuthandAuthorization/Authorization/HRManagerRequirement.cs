using Microsoft.AspNetCore.Authorization;

namespace AuthandAuthorization.Authorization
{
    public class HRManagerRequirement : IAuthorizationRequirement
    {

        public HRManagerRequirement(int probMonths)
        {
            ProbMonths = probMonths;
        }

        public int ProbMonths { get; }
    }

 /*   public class HRManagerRequirementHandler : AuthorizationHandler<HRManagerRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, HRManagerRequirement requirement)
        {
            if(!context.User.HasClaim(x => x.Type == "EmployementDate"))
                return Task.CompletedTask;
            var empDate

        }
    }
*/
}
