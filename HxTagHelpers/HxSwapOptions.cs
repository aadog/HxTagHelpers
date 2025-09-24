namespace HxTagHelpers
{
    public enum HxSwapMethod
    {
        InnerHTML,
        OuterHTML,
        TextContent,
        BeforeBegin,
        AfterBegin,
        BeforeEnd,
        AfterEnd,
        Delete,
        None
    }

    public static class HxSwapMethodExtensions
    {
        public static string ToSwapValue(this HxSwapMethod method) => method switch
        {
            HxSwapMethod.InnerHTML => "innerHTML",
            HxSwapMethod.OuterHTML => "outerHTML",
            HxSwapMethod.TextContent => "textContent",
            HxSwapMethod.BeforeBegin => "beforebegin",
            HxSwapMethod.AfterBegin => "afterbegin",
            HxSwapMethod.BeforeEnd => "beforeend",
            HxSwapMethod.AfterEnd => "afterend",
            HxSwapMethod.Delete => "delete",
            HxSwapMethod.None => "none",
            _ => "innerHTML"
        };
    }
    public class HxSwapOptions:IOptions
    {
        public static HxSwapOptions Create()
        {
            return new HxSwapOptions();
        }
        public HxSwapMethod Method { get; set; } = HxSwapMethod.InnerHTML;

        public string? SwapDelay { get; set; }
        public string? SettleDelay { get; set; }
        public string? Scroll { get; set; }
        public string? Show { get; set; }
        public bool? FocusScroll { get; set; }
        public bool? Transition { get; set; }
        public bool? IgnoreTitle { get; set; }

        public HxSwapOptions WithSwapDelay(string time)
        {
            SwapDelay = time;
            return this;
        }

        public HxSwapOptions WithSettleDelay(string time)
        {
            SettleDelay = time;
            return this;
        }

        public HxSwapOptions WithScroll(string target)
        {
            Scroll = target;
            return this;
        }

        public HxSwapOptions WithShow(string target)
        {
            Show = target;
            return this;
        }

        public HxSwapOptions WithFocusScroll(bool value)
        {
            FocusScroll = value;
            return this;
        }

        public HxSwapOptions WithTransition(bool value = true)
        {
            Transition = value;
            return this;
        }

        public HxSwapOptions WithIgnoreTitle(bool value = true)
        {
            IgnoreTitle = value;
            return this;
        }

        public override string ToString()
        {
            var parts = new List<string> { Method.ToSwapValue() };

            if (!string.IsNullOrWhiteSpace(SwapDelay))
                parts.Add($"swap:{SwapDelay}");

            if (!string.IsNullOrWhiteSpace(SettleDelay))
                parts.Add($"settle:{SettleDelay}");

            if (!string.IsNullOrWhiteSpace(Scroll))
                parts.Add($"scroll:{Scroll}");

            if (!string.IsNullOrWhiteSpace(Show))
                parts.Add($"show:{Show}");

            if (FocusScroll.HasValue)
                parts.Add($"focus-scroll:{FocusScroll.Value.ToString().ToLower()}");

            if (Transition == true) 
                parts.Add("transition:true");

            if (IgnoreTitle == true)
                parts.Add("ignoreTitle:true");

            return string.Join(' ', parts);
        }

        public static HxSwapOptions InnerHTML => new() { Method = HxSwapMethod.InnerHTML };
        public static HxSwapOptions OuterHTML => new() { Method = HxSwapMethod.OuterHTML };
        public static HxSwapOptions Delete => new() { Method = HxSwapMethod.Delete };
        public static HxSwapOptions None => new() { Method = HxSwapMethod.None };
    }
}
