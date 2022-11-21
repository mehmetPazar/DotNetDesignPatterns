using DotNetDesignPatterns.SingletonPattern;

#region Explanation

/* *** Pros ***
    - Ensure single instance (can be use for memory caching)
    - Globally Access
    - Created only when requested
*/

/* *** Cons ***
    - Difficult to UnitTest (mocking)
    - In multithread word, threads cannot create its own instance
*/

#endregion

Console.WriteLine(DateTime.Now.ToLongTimeString());
var roles = await RoleProvider.Instance.GetCountries();

foreach (var role in roles)
{
   Console.WriteLine(role.RoleName);
}

// Another service

var roles1 = await RoleProvider.Instance.GetCountries();

Console.WriteLine(RoleProvider.Instance.RoleCount);

Console.WriteLine(DateTime.Now.ToLongTimeString());