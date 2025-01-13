using LeetCode.Classes;
using Xunit.Abstractions;
namespace leet_code.Tests
{
    public class TwoSumTests
    {
        private readonly ITestOutputHelper _testOutputHelpter;
        public TwoSumTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelpter = testOutputHelper;
        }
        public static IEnumerable<object[]> TwoSumTestData() {
            yield return new object[] { new int[] {2,7,11,15}, new int[] {0,1}, 9 };
            yield return new object[] { new int[] {3,2,4}, new int[] {1,2}, 6 };
            yield return new object[] { new int[] {3,3}, new int[] {0,1}, 6 };
        }

        [Theory]
        [MemberData(nameof(TwoSumTestData))]
        public void Test1(int[] nums, int[] expected, int sum)
        {
                // Act
                var result = TwoSumQuestion.TwoSum(nums, sum); // Assuming you move the sum logic to a method.
                _testOutputHelpter.WriteLine(result.ToString());
                // Assert
                Assert.Equal(expected, result);
        }
    }
}