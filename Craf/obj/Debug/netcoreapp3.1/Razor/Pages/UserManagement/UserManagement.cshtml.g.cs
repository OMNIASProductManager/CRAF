#pragma checksum "C:\Users\Rachid\Desktop\Facilityz\Pages\UserManagement\UserManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2fd87a7a814502ad2664a5a80b30803ab7db0f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Facilityz.Pages.UserManagement.Pages_UserManagement_UserManagement), @"mvc.1.0.razor-page", @"/Pages/UserManagement/UserManagement.cshtml")]
namespace Facilityz.Pages.UserManagement
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
#line 1 "C:\Users\Rachid\Desktop\Facilityz\Pages\_ViewImports.cshtml"
using Facilityz;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2fd87a7a814502ad2664a5a80b30803ab7db0f4", @"/Pages/UserManagement/UserManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1c6499467b17ae9c13a907bf0fd26bbf84222f6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UserManagement_UserManagement : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/AddUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Rachid\Desktop\Facilityz\Pages\UserManagement\UserManagement.cshtml"
   Layout = "_LayoutConnected";
    ViewData["Title"] = "Gestion des utilisateurs"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<br />
<h1 class=""text-center"">Gestion des utilisateurs</h1>
<h4 class=""text-center"">
    Renseignez les informations à modifier
</h4>
<br />
<br />

<h2 class=""mt-5 mb-5"">Gestion du type de validation</h2>
<div class=""d-flex text-nowrap justify-content ml-2"">
    <span>
        Type de validation par défaut:
    </span>
    <div class=""ml-4"" role=""group"" aria-label=""Basic checkbox toggle button group"">
        <input type=""radio""");
            BeginWriteAttribute("class", " class=\"", 592, "\"", 600, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"btncheck1\" autocomplete=\"off\">\n        <label");
            BeginWriteAttribute("class", " class=\"", 651, "\"", 659, 0);
            EndWriteAttribute();
            WriteLiteral(" for=\"btncheck1\">à la semaine </label>\n\n        <input type=\"radio\" class=\"ml-4\" id=\"btncheck2\" autocomplete=\"off\">\n        <label");
            BeginWriteAttribute("class", " class=\"", 790, "\"", 798, 0);
            EndWriteAttribute();
            WriteLiteral(@" for=""btncheck2"">au mois</label>
    </div>
</div>
<div class=""ml-2"">
    <span>
        Ici vous pourrez déterminer si l'utilisateur de l'application doit valider une semaine, <br />
        un mois ou bien les deux avant de transmettre le rapport.
    </span>
</div>

<!-- Informations sur l'utilisateur-->
<h2 class=""mt-5 mb-5"">Liste des utilisateur FACILITYZ</h2>

<div class=""m-0 d-flex text-nowrap "">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2fd87a7a814502ad2664a5a80b30803ab7db0f45296", async() => {
                WriteLiteral("\n        <button type=\"submit\" class=\"btn btn-primary\">Ajouter un utilisateur</button>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <a class=""ml-3"">
        <button type=""submit"" class=""btn btn-primary""  onclick=""DeleteUser();"" >Supprimer un utilisateur</button>
    </a>
</div>
<br />

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Nom</th>
            <th scope=""col"">Prénom</th>
            <th scope=""col"">Société</th>
            <th scope=""col"">Adresse mail</th>
            <th scope=""col"">Droits</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope=""row""><input type=""checkbox"" id=""scales"" name=""scales""></th>
            <td>GUILLERMET</td>
            <td>Kévin</td>
            <td>Omnias</td>
            <td>k.guillermet@omnias.fr</td>
            <td>Administrateur</td>
        </tr>
        <tr>
            <th scope=""row""><input type=""checkbox"" id=""scales"" name=""scales""></th>
            <td>LEROY</td>
            <td>Frédéric</td>
            <td>Omnias</td>
            <td>f.leroy@omnias.fr</td>
            <td>Administrateur</td>
      ");
            WriteLiteral(@"  </tr>
        <tr>
            <th scope=""row""><input type=""checkbox"" id=""scales"" name=""scales""></th>
            <td>RENAULT</td>
            <td>Bertrand</td>
            <td>Omnias</td>
            <td>b.renault@omnias.fr</td>
            <td>Super-Administrateur</td>
        </tr>
        <tr>
            <th scope=""row""><input type=""checkbox"" id=""scales"" name=""scales""></th>
            <td>LEGOFF</td>
            <td>Régis</td>
            <td>Omnias</td>
            <td>r.legoff@omnias.fr</td>
            <td>Administrateur</td>
        </tr>
        <tr>
            <th scope=""row""><input type=""checkbox"" id=""scales"" name=""scales""></th>
            <td>COEZ</td>
            <td>Bertrand</td>
            <td>Omnias</td>
            <td>b.coez@omnias.fr</td>
            <td>Utilisateur</td>
        </tr>
    </tbody>
</table>

<br />
<div class=""container-center m-0 d-flex text-nowrap justify-content"">
    <button type=""submit"" class=""btn btn-primary label-size-20"" onclick=""alertUserManagement();"">Valid");
            WriteLiteral("er</button>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Facilityz.Pages.UserManagement.UserManagementModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Facilityz.Pages.UserManagement.UserManagementModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Facilityz.Pages.UserManagement.UserManagementModel>)PageContext?.ViewData;
        public Facilityz.Pages.UserManagement.UserManagementModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
