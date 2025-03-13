using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace CSharpVersionInfoApp.Tests
{
    public class VersionInfoTests
    {
        private readonly ITestOutputHelper _output;

        public VersionInfoTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void VersionShouldIncludeGitCommitHash()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? "Unknown";

            _output.WriteLine($"Retrieved C# Project Version with Hash: {version}"); // Logs to xUnit output

            Assert.Contains("+", version); // Commit hash should be present
        }
    }
}