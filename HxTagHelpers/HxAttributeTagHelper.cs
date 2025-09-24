using Microsoft.AspNetCore.Razor.TagHelpers;
using System.ComponentModel;
using System.Text.Json;

namespace HxTagHelpers
{

    [HtmlTargetElement("div")]
    public class HxAttributeTagHelper:TagHelper
    {
   
        [HtmlAttributeName("hx-get")]
        public string? HxGet { get; set; }
        [HtmlAttributeName("hx-post")]
        public string? HxPost { get; set; }
        [HtmlAttributeName("hx-put")]
        public string? HxPut { get; set; }
        [HtmlAttributeName("hx-patch")]
        public string? HxPatch { get; set; }
        [HtmlAttributeName("hx-delete")]
        public string? HxDelete { get; set; }

        [HtmlAttributeName("hx-indicator")]
        public string? HxIndicator { get; set; }

   
        [HtmlAttributeName("hx-trigger")]
        public string? HxTrigger { get; set; }

        [HtmlAttributeName("hx-trigger-with-options")]
        public HxTriggerOptions? HxTriggerWithOptions { get; set; }

        [HtmlAttributeName("hx-target")]
        public string? HxTarget { get; set; }

        [HtmlAttributeName("hx-target-with-options")]
        public HxTargetOptions? HxTargetWithOptions { get; set; }

        [HtmlAttributeName("hx-swap")]
        public string? HxSwap { get; set; }
        [HtmlAttributeName("hx-swap-with-options")]
        public HxSwapOptions? HxSwapWithOptions { get; set; }

        [HtmlAttributeName("hx-sync")]
        public string? HxSync { get; set; }
        [HtmlAttributeName("hx-sync-with-options")]
        public HxSyncOptions? HxSyncWithOptions { get; set; }

        [HtmlAttributeName("hx-swap-oob")]
        public string? HxSwapOob { get; set; }

        [HtmlAttributeName("hx-confirm")]
        public string? HxConfirm { get; set; }

        [HtmlAttributeName("hx-disinherit")]
        public string? HxDisinherit { get; set; }

        [HtmlAttributeName("hx-boost")]
        public bool? HxBoost { get; set; }

        [HtmlAttributeName("hx-ext")]
        public string? HxExt { get; set; }

        [HtmlAttributeName("hx-disable")]
        public bool? HxDisable { get; set; }
 

        /// <summary>
        /// this
        /// closest &lt;CSS selector&gt;
        /// next &lt;CSS selector&gt;
        /// previous &lt;CSS selector&gt;
        /// find &lt;CSS selector&gt;
        /// 高级用法:
        /// click[event.target.matches('button')] from:body
        /// click[find &lt;CSS selector&gt;] delay:500ms
        /// </summary>
        [HtmlAttributeName("hx-disabled-elt")]
        public string? HxDisabledElt { get; set; }
        [HtmlAttributeName("hx-disable-elt-with-options")]
        public HxDisabledEltOptions? HxDisabledEltWithOptions { get; set; }

        [HtmlAttributeName("hx-encoding")]
        public string? HxEncoding { get; set; }

        [HtmlAttributeName("hx-headers")]
        public string? HxHeaders { get; set; }

        [HtmlAttributeName("hx-headers-with-options")]
        public HxHeadersOptions? HxHeadersWithOptions { get; set; }

        [HtmlAttributeName("hx-params")]
        public string? HxParams { get; set; }
        [HtmlAttributeName("hx-history")]
        public string? HxHistory { get; set; }

        [HtmlAttributeName("hx-preserve")]
        public string? HxPreserve { get; set; }

        [HtmlAttributeName("hx-prompt")]
        public string? HxPrompt { get; set; }

        [HtmlAttributeName("hx-request")]
        public string? HxRequest { get; set; }

        [HtmlAttributeName("hx-request-with-options")]
        public HxRequestOptions? HxRequestWithOptions { get; set; }

        [HtmlAttributeName("hx-vals")]
        public string? HxVals { get; set; }

        [HtmlAttributeName("hx-vals-with-options")]
        public HxValsOptions? HxValsWithOptions { get; set; }


        // 事件属性（修正后）
        [HtmlAttributeName("hx-on-htmx-abort")]
        public string? HxOnHtmxAbort { get; set; }

        [HtmlAttributeName("hx-on-htmx-after-on-load")]
        public string? HxOnHtmxAfterOnLoad { get; set; }

        [HtmlAttributeName("hx-on-htmx-after-process-node")]
        public string? HxOnHtmxAfterProcessNode { get; set; }

        [HtmlAttributeName("hx-on-htmx-after-request")]
        public string? HxOnHtmxAfterRequest { get; set; }

        [HtmlAttributeName("hx-on-htmx-after-settle")]
        public string? HxOnHtmxAfterSettle { get; set; }

        [HtmlAttributeName("hx-on-htmx-after-swap")]
        public string? HxOnHtmxAfterSwap { get; set; }

        [HtmlAttributeName("hx-on-htmx-before-cleanup-element")]
        public string? HxOnHtmxBeforeCleanupElement { get; set; }

        [HtmlAttributeName("hx-on-htmx-before-on-load")]
        public string? HxOnHtmxBeforeOnLoad { get; set; }

        [HtmlAttributeName("hx-on-htmx-before-process-node")]
        public string? HxOnHtmxBeforeProcessNode { get; set; }

        [HtmlAttributeName("hx-on-htmx-before-request")]
        public string? HxOnHtmxBeforeRequest { get; set; }

        [HtmlAttributeName("hx-on-htmx-before-swap")]
        public string? HxOnHtmxBeforeSwap { get; set; }

        [HtmlAttributeName("hx-on-htmx-before-send")]
        public string? HxOnHtmxBeforeSend { get; set; }

        [HtmlAttributeName("hx-on-htmx-before-transition")]
        public string? HxOnHtmxBeforeTransition { get; set; }

        [HtmlAttributeName("hx-on-htmx-config-request")]
        public string? HxOnHtmxConfigRequest { get; set; }

        [HtmlAttributeName("hx-on-htmx-confirm")]
        public string? HxOnHtmxConfirm { get; set; }

        [HtmlAttributeName("hx-on-htmx-history-cache-error")]
        public string? HxOnHtmxHistoryCacheError { get; set; }

        [HtmlAttributeName("hx-on-htmx-history-cache-hit")]
        public string? HxOnHtmxHistoryCacheHit { get; set; }

        [HtmlAttributeName("hx-on-htmx-history-cache-miss")]
        public string? HxOnHtmxHistoryCacheMiss { get; set; }

        [HtmlAttributeName("hx-on-htmx-history-cache-miss-load-error")]
        public string? HxOnHtmxHistoryCacheMissLoadError { get; set; }

        [HtmlAttributeName("hx-on-htmx-history-cache-miss-load")]
        public string? HxOnHtmxHistoryCacheMissLoad { get; set; }

        [HtmlAttributeName("hx-on-htmx-history-restore")]
        public string? HxOnHtmxHistoryRestore { get; set; }

        [HtmlAttributeName("hx-on-htmx-before-history-save")]
        public string? HxOnHtmxBeforeHistorySave { get; set; }

        [HtmlAttributeName("hx-on-htmx-load")]
        public string? HxOnHtmxLoad { get; set; }

        [HtmlAttributeName("hx-on-htmx-no-sse-source-error")]
        public string? HxOnHtmxNoSSESourceError { get; set; }

        [HtmlAttributeName("hx-on-htmx-on-load-error")]
        public string? HxOnHtmxOnLoadError { get; set; }

        [HtmlAttributeName("hx-on-htmx-oob-after-swap")]
        public string? HxOnHtmxOobAfterSwap { get; set; }

        [HtmlAttributeName("hx-on-htmx-oob-before-swap")]
        public string? HxOnHtmxOobBeforeSwap { get; set; }

        [HtmlAttributeName("hx-on-htmx-oob-error-no-target")]
        public string? HxOnHtmxOobErrorNoTarget { get; set; }

        [HtmlAttributeName("hx-on-htmx-prompt")]
        public string? HxOnHtmxPrompt { get; set; }

        [HtmlAttributeName("hx-on-htmx-pushed-into-history")]
        public string? HxOnHtmxPushedIntoHistory { get; set; }

        [HtmlAttributeName("hx-on-htmx-replaced-in-history")]
        public string? HxOnHtmxReplacedInHistory { get; set; }

        [HtmlAttributeName("hx-on-htmx-response-error")]
        public string? HxOnHtmxResponseError { get; set; }

        [HtmlAttributeName("hx-on-htmx-send-abort")]
        public string? HxOnHtmxSendAbort { get; set; }

        [HtmlAttributeName("hx-on-htmx-send-error")]
        public string? HxOnHtmxSendError { get; set; }

        [HtmlAttributeName("hx-on-htmx-sse-error")]
        public string? HxOnHtmxSseError { get; set; }

        [HtmlAttributeName("hx-on-htmx-sse-open")]
        public string? HxOnHtmxSseOpen { get; set; }

        [HtmlAttributeName("hx-on-htmx-swap-error")]
        public string? HxOnHtmxSwapError { get; set; }

        [HtmlAttributeName("hx-on-htmx-target-error")]
        public string? HxOnHtmxTargetError { get; set; }

        [HtmlAttributeName("hx-on-htmx-timeout")]
        public string? HxOnHtmxTimeout { get; set; }

        [HtmlAttributeName("hx-on-htmx-validation-validate")]
        public string? HxOnHtmxValidationValidate { get; set; }

        [HtmlAttributeName("hx-on-htmx-validation-failed")]
        public string? HxOnHtmxValidationFailed { get; set; }

        [HtmlAttributeName("hx-on-htmx-validation-halted")]
        public string? HxOnHtmxValidationHalted { get; set; }

        [HtmlAttributeName("hx-on-htmx-xhr-abort")]
        public string? HxOnHtmxXhrAbort { get; set; }

        [HtmlAttributeName("hx-on-htmx-xhr-loadend")]
        public string? HxOnHtmxXhrLoadend { get; set; }

        [HtmlAttributeName("hx-on-htmx-xhr-loadstart")]
        public string? HxOnHtmxXhrLoadstart { get; set; }

        [HtmlAttributeName("hx-on-htmx-xhr-progress")]
        public string? HxOnHtmxXhrProgress { get; set; }


        [HtmlAttributeName(DictionaryAttributePrefix = "hx-")]
        public Dictionary<string, string> HxAttributes { get; set; } = new();

        [HtmlAttributeName("hx-include")]
        public string? HxInclude { get; set; }

        [HtmlAttributeName("hx-include-with-options")]
        public HxIncludeOptions? HxIncludeWithOptions { get; set; }

        [HtmlAttributeName("hx-inherit")]
        public string? HxInherit { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            ApplyAttribute(output, "hx-get", HxGet);
            ApplyAttribute(output, "hx-post", HxPost);
            ApplyAttribute(output, "hx-put", HxPut);
            ApplyAttribute(output, "hx-patch", HxPatch);
            ApplyAttribute(output, "hx-delete", HxDelete);

            ApplyAttribute(output, "hx-trigger", HxTrigger);
            ApplyAttribute(output, "hx-trigger", HxTriggerWithOptions);
            ApplyAttribute(output, "hx-target", HxTarget);
            ApplyAttribute(output, "hx-target", HxTargetWithOptions);
            ApplyAttribute(output, "hx-indicator", HxIndicator);
            ApplyAttribute(output, "hx-sync", HxSync);
            ApplyAttribute(output, "hx-sync", HxSyncWithOptions);
            ApplyAttribute(output, "hx-swap", HxSwap);
            ApplyAttribute(output, "hx-swap", HxSwapWithOptions);
            ApplyAttribute(output, "hx-swap-oob", HxSwapOob);

            ApplyAttribute(output, "hx-confirm", HxConfirm);
            ApplyAttribute(output, "hx-disinherit", HxDisinherit);
            ApplyAttribute(output, "hx-boost", HxBoost);
            ApplyAttribute(output, "hx-ext", HxExt);
            ApplyAttribute(output, "hx-disable", HxDisable);
            ApplyAttribute(output, "hx-disabled-elt", HxDisabledElt);
            ApplyAttribute(output, "hx-disabled-elt", HxDisabledEltWithOptions);
            ApplyAttribute(output, "hx-encoding", HxEncoding);
            ApplyAttribute(output, "hx-headers", HxHeaders);
            ApplyAttribute(output, "hx-headers", HxHeadersWithOptions);
            ApplyAttribute(output, "hx-params", HxParams);
            ApplyAttribute(output, "hx-history", HxHistory);
            ApplyAttribute(output, "hx-preserve", HxPreserve);
            ApplyAttribute(output, "hx-prompt", HxPrompt);
            ApplyAttribute(output, "hx-request", HxRequest);
            ApplyAttribute(output, "hx-request", HxRequestWithOptions);
            ApplyAttribute(output, "hx-vals", HxVals);
            ApplyAttribute(output, "hx-vals", HxValsWithOptions);
            ApplyAttribute(output, "hx-include", HxInclude);
            ApplyAttribute(output, "hx-include", HxIncludeWithOptions);
            ApplyAttribute(output, "hx-inherit", HxInherit);




            // 应用事件属性
            ApplyAttribute(output, "hx-on-htmx-abort", HxOnHtmxAbort);
            ApplyAttribute(output, "hx-on-htmx-after-on-load", HxOnHtmxAfterOnLoad);
            ApplyAttribute(output, "hx-on-htmx-after-process-node", HxOnHtmxAfterProcessNode);
            ApplyAttribute(output, "hx-on-htmx-after-request", HxOnHtmxAfterRequest);
            ApplyAttribute(output, "hx-on-htmx-after-settle", HxOnHtmxAfterSettle);
            ApplyAttribute(output, "hx-on-htmx-after-swap", HxOnHtmxAfterSwap);
            ApplyAttribute(output, "hx-on-htmx-before-cleanup-element", HxOnHtmxBeforeCleanupElement);
            ApplyAttribute(output, "hx-on-htmx-before-on-load", HxOnHtmxBeforeOnLoad);
            ApplyAttribute(output, "hx-on-htmx-before-process-node", HxOnHtmxBeforeProcessNode);
            ApplyAttribute(output, "hx-on-htmx-before-request", HxOnHtmxBeforeRequest);
            ApplyAttribute(output, "hx-on-htmx-before-swap", HxOnHtmxBeforeSwap);
            ApplyAttribute(output, "hx-on-htmx-before-send", HxOnHtmxBeforeSend);
            ApplyAttribute(output, "hx-on-htmx-before-transition", HxOnHtmxBeforeTransition);
            ApplyAttribute(output, "hx-on-htmx-config-request", HxOnHtmxConfigRequest);
            ApplyAttribute(output, "hx-on-htmx-confirm", HxOnHtmxConfirm);
            ApplyAttribute(output, "hx-on-htmx-history-cache-error", HxOnHtmxHistoryCacheError);
            ApplyAttribute(output, "hx-on-htmx-history-cache-hit", HxOnHtmxHistoryCacheHit);
            ApplyAttribute(output, "hx-on-htmx-history-cache-miss", HxOnHtmxHistoryCacheMiss);
            ApplyAttribute(output, "hx-on-htmx-history-cache-miss-load-error", HxOnHtmxHistoryCacheMissLoadError);
            ApplyAttribute(output, "hx-on-htmx-history-cache-miss-load", HxOnHtmxHistoryCacheMissLoad);
            ApplyAttribute(output, "hx-on-htmx-history-restore", HxOnHtmxHistoryRestore);
            ApplyAttribute(output, "hx-on-htmx-before-history-save", HxOnHtmxBeforeHistorySave);
            ApplyAttribute(output, "hx-on-htmx-load", HxOnHtmxLoad);
            ApplyAttribute(output, "hx-on-htmx-no-sse-source-error", HxOnHtmxNoSSESourceError);
            ApplyAttribute(output, "hx-on-htmx-on-load-error", HxOnHtmxOnLoadError);
            ApplyAttribute(output, "hx-on-htmx-oob-after-swap", HxOnHtmxOobAfterSwap);
            ApplyAttribute(output, "hx-on-htmx-oob-before-swap", HxOnHtmxOobBeforeSwap);
            ApplyAttribute(output, "hx-on-htmx-oob-error-no-target", HxOnHtmxOobErrorNoTarget);
            ApplyAttribute(output, "hx-on-htmx-prompt", HxOnHtmxPrompt);
            ApplyAttribute(output, "hx-on-htmx-pushed-into-history", HxOnHtmxPushedIntoHistory);
            ApplyAttribute(output, "hx-on-htmx-replaced-in-history", HxOnHtmxReplacedInHistory);
            ApplyAttribute(output, "hx-on-htmx-response-error", HxOnHtmxResponseError);
            ApplyAttribute(output, "hx-on-htmx-send-abort", HxOnHtmxSendAbort);
            ApplyAttribute(output, "hx-on-htmx-send-error", HxOnHtmxSendError);
            ApplyAttribute(output, "hx-on-htmx-sse-error", HxOnHtmxSseError);
            ApplyAttribute(output, "hx-on-htmx-sse-open", HxOnHtmxSseOpen);
            ApplyAttribute(output, "hx-on-htmx-swap-error", HxOnHtmxSwapError);
            ApplyAttribute(output, "hx-on-htmx-target-error", HxOnHtmxTargetError);
            ApplyAttribute(output, "hx-on-htmx-timeout", HxOnHtmxTimeout);
            ApplyAttribute(output, "hx-on-htmx-validation-validate", HxOnHtmxValidationValidate);
            ApplyAttribute(output, "hx-on-htmx-validation-failed", HxOnHtmxValidationFailed);
            ApplyAttribute(output, "hx-on-htmx-validation-halted", HxOnHtmxValidationHalted);
            ApplyAttribute(output, "hx-on-htmx-xhr-abort", HxOnHtmxXhrAbort);
            ApplyAttribute(output, "hx-on-htmx-xhr-loadend", HxOnHtmxXhrLoadend);
            ApplyAttribute(output, "hx-on-htmx-xhr-loadstart", HxOnHtmxXhrLoadstart);
            ApplyAttribute(output, "hx-on-htmx-xhr-progress", HxOnHtmxXhrProgress);

            foreach (var attr in HxAttributes)
            {
                output.Attributes.SetAttribute("hx-" + attr.Key, attr.Value);
            }
            
            base.Process(context, output);
        }
        // 辅助方法：仅在属性值不为null时设置属性
        private void ApplyAttribute(TagHelperOutput output, string name, object? value)
        {
            if (value == null)
                return;

            switch (value)
            {
                case string str:
                    output.Attributes.SetAttribute(name, str);
                    break;

                case bool b:
                    output.Attributes.SetAttribute(name, b.ToString().ToLower());
                    break;

                case IOptions e:
                    output.Attributes.SetAttribute(name, e.ToString());
                    break;
                case Enum e:
                    var description = e.GetType()
                        .GetMember(e.ToString()!)
                        .FirstOrDefault()?
                        .GetCustomAttributes(typeof(DescriptionAttribute), false)
                        .OfType<DescriptionAttribute>()
                        .FirstOrDefault()?.Description ?? e.ToString();
                    output.Attributes.SetAttribute(name, description);
                    break;

                case IDictionary<string, object> dict:
                    output.Attributes.SetAttribute(name, JsonSerializer.Serialize(dict));
                    break;

                case int or long or float or double or decimal:
                    output.Attributes.SetAttribute(name, Convert.ToString(value, System.Globalization.CultureInfo.InvariantCulture));
                    break;

                default:
                    // 如果是对象，尝试序列化
                    try
                    {
                        var json = JsonSerializer.Serialize(value);
                        output.Attributes.SetAttribute(name, json);
                    }
                    catch
                    {
                        // 如果序列化失败，作为字符串处理
                        output.Attributes.SetAttribute(name, value.ToString());
                    }
                    break;
            }
        }
    }
}
