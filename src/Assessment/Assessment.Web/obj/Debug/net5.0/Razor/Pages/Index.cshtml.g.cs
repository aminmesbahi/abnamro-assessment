#pragma checksum "D:\src\ABN Amro\Assessment\src\Assessment\Assessment.Web\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "265a2f93fde1f72044578c8797125bc3a8639066"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Assessment.Web.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Assessment.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\src\ABN Amro\Assessment\src\Assessment\Assessment.Web\Pages\_ViewImports.cshtml"
using Assessment.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"265a2f93fde1f72044578c8797125bc3a8639066", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b35e775043e404b87e00131f0fecfeb9a9956f5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnStartCalculation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "StartCalculation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary px-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3 needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("startCalculationForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnGetStatus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "GetStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info text-light px-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3 d-none ms-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("statusInquiryForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\src\ABN Amro\Assessment\src\Assessment\Assessment.Web\Pages\Index.cshtml"
  
  ViewData["Title"] = "Assesment Task | Mohammad Amin Mesbahi";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n  <div class=\"col-xs-12 col-lg-4 col-xxl-2\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "265a2f93fde1f72044578c8797125bc3a86390667601", async() => {
                WriteLiteral(@"
      <div class=""mb-1"">
        <label for=""requestValue"" class=""form-label"">Enter value to calculate:</label>
        <input type=""number"" class=""form-control"" id=""requestValue"" name=""requestValue"" min=""10"" max=""99"" required />
        <div class=""invalid-tooltip"">Please enter a 2-digit number<br>(10 <= value <=99)</div>
            <div id=""requestValueHelpBlock"" class=""form-text""><span id=""requestValueHelpBlockText""
                class=""text-muted"">The value must be 2-digits number</span></div>
        </div>

        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "265a2f93fde1f72044578c8797125bc3a86390668424", async() => {
                    WriteLiteral("<i class=\"bi bi-calculator\"></i> Start Calculate");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  </div>\r\n  <div class=\"col-sx-12 col-lg-6 col-xxl-3 border-start ms-3\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "265a2f93fde1f72044578c8797125bc3a863906612037", async() => {
                WriteLiteral(@"
      <div class=""mb-1"">
        <label for=""returnedHandler"" class=""form-label"">Your Calculation Hendler:</label>
        <input type=""text"" class=""form-control"" id=""returnedHandler"" name=""returnedHandler"" readonly />
        <div id=""returnedHandlerHelpBlock"" class=""form-text""><span id=""returnedHandlerHelpBlockText""
            class=""text-muted"">The Guid returned from StartCalculation</span></div>

      </div>

      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "265a2f93fde1f72044578c8797125bc3a863906612750", async() => {
                    WriteLiteral("<i\r\n          class=\"bi bi-search\"></i> Get Current Status");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div id=""getStatusResult"" class=""d-none ms-3 text-info fs-6 mt-3 border-top pt-3"">

    </div>
  </div>
</div>

<hr class=""col-3 col-md-3 my-5 d-none"">


<div class=""row g-5 d-none"">
  <div class=""col-md-6"">
    <h2>Starter projects</h2>
    <p>Ready to beyond the starter template? Check out these open source projects that you can quickly duplicate to a
      new GitHub repository.</p>
    <ul class=""icon-list"">
      <li><a href=""https://github.com/twbs/bootstrap-npm-starter"" rel=""noopener"" target=""_blank"">Bootstrap npm
          starter</a></li>
      <li class=""text-muted"">Bootstrap Parcel starter (coming soon!)</li>
    </ul>
  </div>

  <div class=""col-md-6"">
    <h2>Guides</h2>
    <p>Read more detailed instructions and documentation on using or contributing to Bootstrap.</p>
    <ul class=""icon-list"">
      <li><a href=""../getting-started/introduction/"">Bootstrap quick start guide</a></li>
      <li><a href=""../getting-started/webpack/"">Bootstrap Webpack guide</a></li>
");
            WriteLiteral(@"      <li><a href=""../getting-started/parcel/"">Bootstrap Parcel guide</a></li>
      <li><a href=""../getting-started/contribute/"">Contributing to Bootstrap</a></li>
    </ul>
  </div>
</div>

<hr class=""col-3 col-md-3 my-5"">
<div class=""row"">
  <h1>Assesment Task</h1>
  <div class=""fs-6 col-md-12 col-xl-5 text-black-50"">
    <ol>
      <li>Write a simple C# (Core 3.1, .NET5+) REST web service with two methods:</li>
      <ol type=""a"">
        <li>GUID StartCalculation(some input values) calculates ‘something’, but takes its time, somewhere between 20
          seconds and 1 minute.</li>
        <li>StatusObject GetStatus(GUID) can be called to get a (JSON) status object back. This object should contain
          the status (i.e. ‘running’, ‘failed’, ‘completed’), progress(10%, 20% etc) and – when completed – the outcome
          of
          the calculation.</li>
      </ol>
      <li>Write a simple C# Web App that consists of a single page where a user can enter some input data for the
");
            WriteLiteral(@"        calculation. It also contains a ‘start’ button.
        The web app performs both client and server side validation of the user input (are fields empty, is the value
        numeric). The Start button will only be enabled when the client validation passes.
        When the user clicks the button, the REST web service’s startCalculation is fed with the user input. The
        progress
        of the calculation is visualised (knock yourself out!) and when the calculation is done, the result is
        displayed.
      </li>
      <li>Both client and server app have sufficient unit tests to prove they work.</li>
      <li>Version control of the code is done through GitHub (you can create a free account there).</li>
    </ol>
    <hr />
    <p>Bonus 1: The server and/or client use SQL Server to persist their data</p>
    <p>Bonus 2: The calculation(s) is/are written in stored procedures which are also unit tested</p>
    <p>Bonus 3: The solution is deployed to an Azure App Service (<a href=");
            WriteLiteral("\"https://azure.microsoft.com/en-us/free\"\r\n        target=\"_blank\">free account available here</a>)</p>\r\n  </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
<script>
  $(function () {
    $('#btnStartCalculation').on('click', function (evt) {
      evt.preventDefault();
      let calcIcon = '<span class=""spinner-border spinner-border-sm"" role=""status"" aria-hidden=""true""></span> Calculating...';
      let normIcon = '<i class=""bi bi-calculator bi-spin""></i>';
      $.post('/?handler=StartCalculation', $('#startCalculationForm').serialize(), function () {
        $(""#btnStartCalculation"").html(calcIcon);
        $(""#btnStartCalculation"").attr(""disabled"", 'disabled');
      }).done(function (data) {
        $(""#statusInquiryForm"").removeClass(""d-none"");
        $(""#returnedHandler"").val(data);
      });
    });
    $('#btnGetStatus').on('click', function (evt) {
      evt.preventDefault();
      let calcIcon = '<span class=""spinner-border spinner-border-sm"" role=""status"" aria-hidden=""true""></span> Calculating...';
      let normIcon = '<i class=""bi bi-calculator bi-spin""></i>';
      $.post('/?handler=GetStatus', $('#statusInquiryForm').serialize");
                WriteLiteral(@"(), function () {
        $(""#btnStartCalculation"").html(calcIcon);
        $(""#btnStartCalculation"").attr(""disabled"", 'disabled');
      }).done(function (data) {
        $(""#getStatusResult"").removeClass(""d-none"");
        $(""#getStatusResult"").addClass(""d-block"");
        console.log(data);
        let jsonData = JSON.parse(data);
        $(""#getStatusResult"").html(`Progress: ${jsonData.progress} <br> State: ${jsonData.state} <br> Result: ${((jsonData.result == -1) ? 'Not Ready Yet!' : jsonData.result)}`);
        console.log(jsonData);
      });
    });
  });
</script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591