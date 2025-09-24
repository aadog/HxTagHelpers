using System.Text;
using System.Text.Json;

namespace HxTagHelpers
{
    public class HxHeadersOptions:IOptions
    {
        private readonly Dictionary<string, object> _jsonValues = new();
        private readonly Dictionary<string, string> _jsValues = new();
        public static HxHeadersOptions Create()
        {
            return new HxHeadersOptions();
        }
        public HxHeadersOptions With(string key, object value)
        {
            _jsonValues[key] = value;
            _jsValues.Remove(key); // 如果该字段之前是JS字段，移除
            return this;
        }

        public HxHeadersOptions WithJs(string key, string jsExpression)
        {
            _jsValues[key] = jsExpression;
            _jsonValues.Remove(key); // 移除普通字段，确保不混淆
            return this;
        }

        public HxHeadersOptions WithObject(object obj)
        {
            // 遍历对象的所有字段并添加到 _jsonValues
            foreach (var property in obj.GetType().GetProperties())
            {
                _jsonValues[property.Name] = property.GetValue(obj)!;
            }
            return this;
        }

        public HxHeadersOptions WithDict(Dictionary<string, object> dict)
        {
            // 将字典中的所有键值对添加到 _jsonValues
            foreach (var kvp in dict)
            {
                _jsonValues[kvp.Key] = kvp.Value;
            }
            return this;
        }

        public override string ToString()
        {
            if (_jsValues.Count == 0)
            {
                // 如果没有 JS 字段，纯 JSON 序列化
                return JsonSerializer.Serialize(_jsonValues);
            }
            else
            {
                var sb = new StringBuilder("js:{");

                foreach (var pair in _jsonValues)
                {
                    sb.Append($"\"{pair.Key}\":{JsonSerializer.Serialize(pair.Value)},");
                }

                foreach (var pair in _jsValues)
                {
                    sb.Append($"\"{pair.Key}\":{pair.Value},");
                }

                if (sb[^1] == ',') sb.Length--;
                sb.Append('}');
                return sb.ToString();
            }
        }
    }
}
