using CodeWars;

namespace CodeWarsTests
{
    public class FlattenNestedMapTest
    {
        [Fact]
        public void ReturnsFlattenedMap()
        {
            var input = new Dictionary<string, dynamic>();
            input.Add("a", new Dictionary<string, dynamic>());
            input["a"].Add("b", new Dictionary<string, dynamic>());
            input["a"]["b"].Add("c", 12);
            input["a"]["b"].Add("d", "Hello World");
            input["a"].Add("e", new int[] { 1, 2, 3 });
            var expected = new Dictionary<string, dynamic>();
            expected.Add("a/b/c", 12);
            expected.Add("a/b/d", "Hello World");
            expected.Add("a/e", new int[] { 1, 2, 3 });
            var actual = FlattenNestedMap.FlattenMap(input);
            actual.Keys.ToList().ForEach(key => Assert.True(expected.ContainsKey(key)));
            Assert.Equal(expected["a/b/c"], actual["a/b/c"]);
            Assert.Equal(expected["a/b/d"], actual["a/b/d"]);
            Assert.Equal(expected["a/e"], actual["a/e"]);
        }

        [Fact]
        public void ReturnsNullIfMapIsNull()
        {
            Assert.Null(FlattenNestedMap.FlattenMap(null));
        }

        [Fact]
        public void ReturnsEmptyDictIfMapIsEmpty()
        {
            Assert.Empty(FlattenNestedMap.FlattenMap(new Dictionary<string, object>()));
        }
    }
}
