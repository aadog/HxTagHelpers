namespace HxTagHelpers
{
    public class HxSyncOptions:IOptions
    {
        private List<string> syncOptions = new List<string>();

        /// <summary>
        /// 创建 HxSyncOptions 实例。
        /// </summary>
        public static HxSyncOptions Create()
        {
            return new HxSyncOptions();
        }

        /// <summary>
        /// 添加同步策略
        /// </summary>
        /// <param name="selector">指定要同步的目标元素的 CSS 选择器。</param>
        /// <param name="strategy">同步策略（默认：drop）。可选值包括 "drop"、"abort"、"replace"、"queue"。</param>
        /// <returns>返回当前的 HxSyncOptions 实例。</returns>
        public HxSyncOptions SyncOn(string selector, string strategy = "drop")
        {
            if (strategy == "drop")
            {
                AddDropStrategy(selector);
            }
            else if (strategy == "abort")
            {
                AddAbortStrategy(selector);
            }
            else if (strategy == "replace")
            {
                AddReplaceStrategy(selector);
            }
            else if (strategy == "queue")
            {
                AddQueueStrategy(selector);
            }
            else
            {
                throw new ArgumentException($"Unknown strategy: {strategy}");
            }
            return this;
        }

        private void AddDropStrategy(string selector)
        {
            // drop：如果现有请求正在进行中，则丢弃（忽略）此请求（默认策略）
            syncOptions.Add($"{selector}:drop");
        }

        private void AddAbortStrategy(string selector)
        {
            // abort：如果现有请求正在进行中，则丢弃（忽略）此请求；如果不是，在仍在进行中时发生另一个请求，则中止此请求
            syncOptions.Add($"{selector}:abort");
        }

        private void AddReplaceStrategy(string selector)
        {
            // replace：中止当前请求（如果有），并用该请求替换它
            syncOptions.Add($"{selector}:replace");
        }

        private void AddQueueStrategy(string selector)
        {
            // queue：将此请求放入与给定元素关联的请求队列中
            syncOptions.Add($"{selector}:queue");
        }

        /// <summary>
        /// 设置同步队列的策略。如果使用 "queue"，可以进一步指定队列的行为：first、last、all。
        /// </summary>
        /// <param name="selector">指定要同步的目标元素的 CSS 选择器。</param>
        /// <param name="queueStrategy">队列策略（例如："first"、"last"、"all"）。</param>
        /// <returns>返回当前的 HxSyncOptions 实例。</returns>
        public HxSyncOptions QueueSyncOn(string selector, string queueStrategy)
        {
            if (queueStrategy == "first" || queueStrategy == "last" || queueStrategy == "all")
            {
                syncOptions.Add($"{selector}:queue {queueStrategy}");
            }
            else
            {
                throw new ArgumentException($"Invalid queue strategy: {queueStrategy}. Use 'first', 'last' or 'all'.");
            }

            return this;
        }

        /// <summary>
        /// 将同步选项转换为字符串，便于设置 hx-sync 属性。
        /// </summary>
        /// <returns>返回最终的同步字符串。</returns>
        public override string ToString()
        {
            return string.Join(", ", syncOptions);
        }
    }
}
