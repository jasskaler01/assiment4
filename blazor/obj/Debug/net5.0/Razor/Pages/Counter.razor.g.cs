#pragma checksum "D:\karan\blazorapp\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ec51ee64d02e9de6c5e9e01406986711fa01c23"
// <auto-generated/>
#pragma warning disable 1591
namespace AssignmentSampleBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\karan\blazorapp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\karan\blazorapp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\karan\blazorapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\karan\blazorapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\karan\blazorapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\karan\blazorapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\karan\blazorapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\karan\blazorapp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\karan\blazorapp\_Imports.razor"
using AssignmentSampleBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\karan\blazorapp\_Imports.razor"
using AssignmentSampleBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "D:\karan\blazorapp\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "Increment Amount: ");
            __builder.AddContent(7, 
#nullable restore
#line 6 "D:\karan\blazorapp\Pages\Counter.razor"
                      IncrementAmount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "h4");
            __builder.AddContent(10, "High score: ");
            __builder.AddContent(11, 
#nullable restore
#line 7 "D:\karan\blazorapp\Pages\Counter.razor"
                 maxCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 8 "D:\karan\blazorapp\Pages\Counter.razor"
 if(Name != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.OpenElement(13, "strong");
            __builder.AddContent(14, 
#nullable restore
#line 11 "D:\karan\blazorapp\Pages\Counter.razor"
             Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 13 "D:\karan\blazorapp\Pages\Counter.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\karan\blazorapp\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n<br>\r\n");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "D:\karan\blazorapp\Pages\Counter.razor"
                                          ResetCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Reset Count");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n<br>\r\n");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-primary");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\karan\blazorapp\Pages\Counter.razor"
                                          IncreaseIncrementAmount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Increase Increment Amount");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n<br>\r\n");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-primary");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\karan\blazorapp\Pages\Counter.razor"
                                          DecreaseIncrementAmount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Decrease Increment Amount");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "D:\karan\blazorapp\Pages\Counter.razor"
       
    private int currentCount = 0;
    private int maxCount = 0;
    [Parameter]
    public int IncrementAmount { get; set; } = 1;
    [Parameter]
    public string Name { get; set; }

    private void IncrementCount()
    {
        currentCount += IncrementAmount;
        if (currentCount > maxCount)
        {
            maxCount = currentCount;
        }
    }
    private void ResetCount()
    {
        currentCount = 0;
    }
    private void IncreaseIncrementAmount()
    {
        if (IncrementAmount < 20)
        {
            IncrementAmount++;
        }
    }
    private void DecreaseIncrementAmount()
    {
        if (IncrementAmount > 1)
        {
            IncrementAmount--;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
