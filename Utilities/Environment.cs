using System;
namespace Utilities
{
    public static class Environment
    {
        public static string Init(string environment)
        {
            return EnvironmentFactory.Build(environment);
        }
    }
}
