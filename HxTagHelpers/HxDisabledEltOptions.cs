namespace HxTagHelpers
{
    public class HxDisabledEltOptions:IOptions
    {
        public static HxDisabledEltOptions Create()
        {
            return new HxDisabledEltOptions();
        }
        private List<string> selectors = new List<string>();

        // 添加 this 选项
        public HxDisabledEltOptions This()
        {
            selectors.Add("this");
            return this;
        }

        // 添加 Selector 选项
        public HxDisabledEltOptions Selector(string selector)
        {
            selectors.Add(selector);
            return this;
        }

        // 添加 closest <CSS selector>
        public HxDisabledEltOptions Closest(string selector)
        {
            selectors.Add($"closest {selector}");
            return this;
        }

        // 添加 find <CSS selector>
        public HxDisabledEltOptions Find(string selector)
        {
            selectors.Add($"find {selector}");
            return this;
        }

        // 添加 next <CSS selector> 或 element.nextElementSibling
        public HxDisabledEltOptions Next(string selector = "")
        {
            // 如果没有传入 selector，直接使用 "next" 对应 nextElementSibling
            selectors.Add(string.IsNullOrEmpty(selector) ? "next" : $"next {selector}");
            return this;
        }

        // 添加 previous <CSS selector> 或 element.previousElementSibling
        public HxDisabledEltOptions Previous(string selector = "")
        {
            // 如果没有传入 selector，直接使用 "previous" 对应 previousElementSibling
            selectors.Add(string.IsNullOrEmpty(selector) ? "previous" : $"previous {selector}");
            return this;
        }

        // 添加 inherit 选项
        public HxDisabledEltOptions Inherit()
        {
            selectors.Add("inherit");
            return this;
        }

        // 返回最终的字符串
        public override string ToString()
        {
            return string.Join(", ", selectors);
        }
    }
}
