namespace HxTagHelpers
{
    public class HxRequestOptions:IOptions
    {
        // 存储请求选项
        private Dictionary<string, string> options = new Dictionary<string, string>();

        // 静态方法来创建实例
        public static HxRequestOptions Create()
        {
            return new HxRequestOptions();
        }

        // 设置 timeout
        public HxRequestOptions Timeout(int milliseconds)
        {
            options["timeout"] = milliseconds.ToString();
            return this;
        }

        // 设置 timeout, 支持 js 动态评估
        public HxRequestOptions TimeoutJs(string jsExpression)
        {
            options["timeout"] = $"js:{jsExpression}";
            return this;
        }

        // 设置 credentials
        public HxRequestOptions Credentials(bool includeCredentials)
        {
            options["credentials"] = includeCredentials ? "true" : "false";
            return this;
        }

        // 设置 noHeaders
        public HxRequestOptions NoHeaders(bool noHeaders)
        {
            options["noHeaders"] = noHeaders ? "true" : "false";
            return this;
        }

        // 返回最终的 hx-request 字符串
        public override string ToString()
        {
            // 将字典转成 JSON 风格的字符串
            var jsonParts = options.Select(kv => $"\"{kv.Key}\":{kv.Value}");
            return "{" + string.Join(", ", jsonParts) + "}";
        }
    }
}
