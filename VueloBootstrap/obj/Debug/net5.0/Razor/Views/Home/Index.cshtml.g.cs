#pragma checksum "/Users/thiago/Projects/VueloBootstrap/VueloBootstrap/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21ffc53f9578a6fa5abdac87611434aa336d8617"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
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
#line 1 "/Users/thiago/Projects/VueloBootstrap/VueloBootstrap/Views/_ViewImports.cshtml"
using VueloBootstrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/thiago/Projects/VueloBootstrap/VueloBootstrap/Views/_ViewImports.cshtml"
using VueloBootstrap.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21ffc53f9578a6fa5abdac87611434aa336d8617", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83bb66a51802023846e9c2ab3b0b67b234a536ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/thiago/Projects/VueloBootstrap/VueloBootstrap/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>

    <!-- section pode ter v??rias dentro do main separando se????es principais -->
    <section class=""banner-principal fw-bolder"">
        <h1 class=""fw-bold"">Viaje ;.)<br>o mundo!</h1>
        <p>
            Aqui voce encontra destinos exclusivos <br>para os lugares mais incr??veis do mundo!.
        </p>
    </section>
    <!-- section do conteudo principal -->
    <section class=""login-cadastro"">
        <div class=""login-home"">
            <h4><img src=""img/login-user-6.svg"" alt=""Login Usu??rio"" width=""20px""> Login</h4>
            <p>para acessar seus orcamentos!</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21ffc53f9578a6fa5abdac87611434aa336d86174293", async() => {
                WriteLiteral(@"
                <label for=""lemail""></label>
                <input type=""email"" placeholder=""E-mail:"" id=""lemail"" name=""femail""><br>
                <label for=""pass""></label>
                <input type=""password"" placeholder=""Senha:"" id=""pass"" name=""pass""><br>
                <button class=""btn btn-primary mt-2"" >Entrar</button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n        <div class=\"cadastro-home\">\n            <h4>Cadastre-se</h4>\n            <p>cadastre e receba os melhores precos!</p>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21ffc53f9578a6fa5abdac87611434aa336d86176113", async() => {
                WriteLiteral(@"
                <label for=""lnome""></label>
                <input type=""text"" placeholder=""Seu Nome:"" id=""lnome"" name=""fnome""><br>
                <label for=""lemail""></label>
                <input type=""email"" placeholder=""Seu E-mail:"" id=""lemail"" name=""femail""><br>
                <label for=""pass""></label>
                <input type=""password"" placeholder=""Sua Senha:"" id=""pass"" name=""pass""><br>
                <button class=""btn btn-primary mt-2"" >Cadastrar</button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <div class=""busque-destinos"">
            <h4>Destinos</h4>
            <p>Simule os destinos mais procurados!</p>
            <a href=""#""><img src=""/img/grecia.png"" width=""40px""></a>
            <a href=""#""><img src=""/img/alemanha.png"" width=""40px""></a>
            <a href=""#""><img src=""/img/gra-bretanha.png"" width=""40px""></a>
            <a href=""#""><img src=""/img/franca.png"" width=""40px""></a>
            <a href=""/home/destinos""><button class=""btn btn-primary mt-2"" type=""button"">Consultar</button></a>
        </div>

    </section>


    <!-- article mais indicado o conteudo central, mais usado para conteudo de blogs onde contem comentarios autor -->
    <h2 class=""destinos-alta"">Destinos em Promo????o!</h2>
    <section class=""article-home"">
        <article class=""card-article text-center"">
            <img src=""img/grecia.png"" alt=""Bandeira Gr??cia"" width=""50px"">
            <h4>Gr??cia</h4>
            <p>
                A Gr??cia ?? um pa??s do sudeste da Europa com milhares de ilha");
            WriteLiteral(@"s espalhadas pelos mares Egeu e
                J??nico. Bastante influente na antiguidade,
                a na????o ?? considerada o ber??o da civiliza????o ocidental. Atenas, sua capital, conserva monumentos
                como a Acr??pole,
                do s??culo V a.C.
            </p>
            <a class=""mt-2"" href=""#"">40% Off / Aproveite!</a>
        </article>

        <article class=""card-article text-center"">
            <img src=""img/franca.png"" alt=""bandeira Inglaterra"" width=""50px"">
            <h4>P??ris</h4>
            <p>
                Paris, a capital da Fran??a, ?? uma importante cidade europeia e um centro mundial de arte, moda,
                gastronomia e cultura. Sua paisagem urbana
                do s??culo XIX ?? cortada por avenidas largas e pelo rio Sena. A cidade ?? conhecida por monumentos
                como a Torre Eiffel e a Catedral
                de Notre-Dame
            </p>
            <a class=""mt-2"" href=""#"">20% Off / Aproveite!</a>
        </article>

        <article clas");
            WriteLiteral(@"s=""card-article text-center"">
            <img src=""img/alemanha.png"" alt=""Bandeira Alemanha"" width=""50px"">
            <h4>Alemanha</h4>
            <p>
                A Alemanha ?? um pa??s situado na Europa Ocidental com uma paisagem de florestas, rios,
                cordilheiras e praias do Mar do Norte. A na????o tem mais
                de 2 mil??nios de hist??ria. Berlim, a capital, abriga cen??rios art??sticos e de vida noturna, o
                Port??o de Brandemburgo
                e muitos locais relacionados ?? Segunda Guerra Mundial.
            </p>
            <a class=""mt-2"" href=""#"">10% Off / Aproveite!</a>
        </article>
    </section>


</main>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
