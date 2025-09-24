namespace HxTagHelpers
{
    public class HxTriggerOptions : IOptions
    {
        // 存储所有触发器表达式
        private List<string> triggers = new List<string>();

        // 静态方法来创建实例
        public static HxTriggerOptions Create()
        {
            return new HxTriggerOptions();
        }

        // 添加标准事件
        public HxTriggerOptions Event(string eventName)
        {
            triggers.Add(eventName);
            return this;
        }

        // 添加事件过滤器
        public HxTriggerOptions Filter(string filter)
        {
            // 过滤器通过方括号包围，例如 click[ctrlKey]
            if (triggers.Count > 0)
            {
                triggers[triggers.Count - 1] += $"[{filter}]";
            }
            return this;
        }

        // 添加事件修饰符 (once, delay, throttle 等)
        public HxTriggerOptions Modifier(string modifier)
        {
            // 修饰符以冒号为分隔符，例如 delay:1s
            if (triggers.Count > 0)
            {
                triggers[triggers.Count - 1] += $" {modifier}";
            }
            return this;
        }

        // 添加轮询
        public HxTriggerOptions Polling(string timing)
        {
            triggers.Add($"every {timing}");
            return this;
        }

        // 添加来自其他元素的事件 (from:<CSS selector>)
        public HxTriggerOptions From(string selector)
        {
            if (triggers.Count > 0)
            {
                triggers[triggers.Count - 1] += $" from:{selector}";
            }
            return this;
        }

        // 添加 target 修饰符 (target:<CSS selector>)
        public HxTriggerOptions Target(string selector)
        {
            if (triggers.Count > 0)
            {
                triggers[triggers.Count - 1] += $" target:{selector}";
            }
            return this;
        }

        // 支持多事件（逗号分隔）
        public HxTriggerOptions AddMultipleEvents(params string[] events)
        {
            triggers.AddRange(events);
            return this;
        }

        // 返回最终的 hx-trigger 字符串
        public override string ToString()
        {
            return string.Join(", ", triggers);
        }
    }
}
