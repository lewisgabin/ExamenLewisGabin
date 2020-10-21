#pragma checksum "C:\Aplicada2\PrestamosDetalle\Pages\Consultas\Cmoras.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a4608fffa708b64ccbbf4abfa10ae34518827aa"
// <auto-generated/>
#pragma warning disable 1591
namespace PrestamosDetalle.Pages.Consultas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Aplicada2\PrestamosDetalle\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aplicada2\PrestamosDetalle\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aplicada2\PrestamosDetalle\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Aplicada2\PrestamosDetalle\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Aplicada2\PrestamosDetalle\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Aplicada2\PrestamosDetalle\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Aplicada2\PrestamosDetalle\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Aplicada2\PrestamosDetalle\_Imports.razor"
using PrestamosDetalle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Aplicada2\PrestamosDetalle\_Imports.razor"
using PrestamosDetalle.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Aplicada2\PrestamosDetalle\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Aplicada2\PrestamosDetalle\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Aplicada2\PrestamosDetalle\_Imports.razor"
using PrestamosDetalle.Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Aplicada2\PrestamosDetalle\_Imports.razor"
using PrestamosDetalle.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ConsultaMoras")]
    public partial class Cmoras : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Consulta moras</h3>\r\n\r\n");
#nullable restore
#line 5 "C:\Aplicada2\PrestamosDetalle\Pages\Consultas\Cmoras.razor"
 if (moras == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 8 "C:\Aplicada2\PrestamosDetalle\Pages\Consultas\Cmoras.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>MoraId</th>\r\n                <th>Fecha</th>\r\n                <th>Total</th>\r\n                \r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 21 "C:\Aplicada2\PrestamosDetalle\Pages\Consultas\Cmoras.razor"
             foreach (var mora in moras)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 24 "C:\Aplicada2\PrestamosDetalle\Pages\Consultas\Cmoras.razor"
                         mora.MoraId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 25 "C:\Aplicada2\PrestamosDetalle\Pages\Consultas\Cmoras.razor"
                         mora.Fecha.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 26 "C:\Aplicada2\PrestamosDetalle\Pages\Consultas\Cmoras.razor"
                         mora.Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 28 "C:\Aplicada2\PrestamosDetalle\Pages\Consultas\Cmoras.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 31 "C:\Aplicada2\PrestamosDetalle\Pages\Consultas\Cmoras.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Aplicada2\PrestamosDetalle\Pages\Consultas\Cmoras.razor"
       

    private List<Moras> moras = new List<Moras>();
    private List<DetalleMora> detalle = new List<DetalleMora>();

    protected override void OnInitialized()
    {
        moras = MorasBLL.GetList(x => true);
       
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
