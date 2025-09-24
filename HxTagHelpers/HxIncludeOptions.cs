namespace HxTagHelpers
{
    public class HxIncludeOptions:IOptions
    {
        public static HxIncludeOptions Create()
        {
            return new HxIncludeOptions();
        }
        private List<string> selectors = new List<string>();

        // 添加 this 选项
        public HxIncludeOptions This()
        {
            selectors.Add("this");
            return this;
        }

        // 添加 Selector 选项
        public HxIncludeOptions Selector(string selector)
        {
            selectors.Add(selector);
            return this;
        }

        // 添加 closest <CSS selector>
        public HxIncludeOptions Closest(string selector)
        {
            selectors.Add($"closest {selector}");
            return this;
        }

        // 添加 find <CSS selector>
        public HxIncludeOptions Find(string selector)
        {
            selectors.Add($"find {selector}");
            return this;
        }

        // 添加 next <CSS selector> 或 element.nextElementSibling
        public HxIncludeOptions Next(string selector = "")
        {
            // 如果没有传入 selector，直接使用 "next" 对应 nextElementSibling
            selectors.Add(string.IsNullOrEmpty(selector) ? "next" : $"next {selector}");
            return this;
        }

        // 添加 previous <CSS selector> 或 element.previousElementSibling
        public HxIncludeOptions Previous(string selector = "")
        {
            // 如果没有传入 selector，直接使用 "previous" 对应 previousElementSibling
            selectors.Add(string.IsNullOrEmpty(selector) ? "previous" : $"previous {selector}");
            return this;
        }

        // 添加 inherit 选项
        public HxIncludeOptions Inherit()
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
