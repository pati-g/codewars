using System.Text;

namespace CodeWars
{
    internal class FlattenNestedMap
    {
        public static Dictionary<string, object> FlattenMap(object obj)
        {
            var flatMap = new Dictionary<string, object>();

            if (obj is Dictionary<string, object> map)
            {
                if (map.Count == 0) { return map; }
                Flatten(map, new StringBuilder(), flatMap);
                return flatMap;
            }
            else
            {
                return null;
            }
        }

        private static void Flatten(Dictionary<string, object> map, StringBuilder keyBuilder, Dictionary<string, object> flatMap)
        {
            foreach (var key in map.Keys)
            {
                if (map[key] is Dictionary<string, object> innerMap)
                {
                    Flatten(innerMap, keyBuilder.Append(key).Append('/'), flatMap);
                }
                else
                {
                    if (keyBuilder[keyBuilder.Length - 1] != '/')
                        keyBuilder.Append('/');
                    keyBuilder.Append(key);
                    flatMap.Add(keyBuilder.ToString(), map[key]);
                }
                if (keyBuilder.Length >= 2)
                    keyBuilder.Remove(keyBuilder.Length - 2, 2);
            }
        }
    }
}
