#pragma checksum "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5a3e4826a38b7ee65090f776b2827f13598995b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Statistics), @"mvc.1.0.view", @"/Views/Accounts/Statistics.cshtml")]
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
#line 1 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\_ViewImports.cshtml"
using CoronaWedding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\_ViewImports.cshtml"
using CoronaWedding.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a3e4826a38b7ee65090f776b2827f13598995b", @"/Views/Accounts/Statistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"647b5bc3eaf93b22636f03734877ced82583bc83", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Statistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoronaWedding.Models.StatisticsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://d3js.org/d3.v6.min.js\"></script>\r\n\r\n\r\n    <script>\r\n        // Bar Chart code\r\n        const margin = ({ top: 20, right: 0, bottom: 30, left: 40 });\r\n        const width = 500;\r\n        const height = 400;\r\n        const data = ");
#nullable restore
#line 13 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Statistics.cshtml"
                Write(Json.Serialize(Model.barChart.dataPoints));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

        const yAxis = g => g
            .attr(""transform"", `translate(${margin.left},0)`)
            .call(d3.axisLeft(y))
            .call(g => g.select("".domain"").remove());
        const xAxis = g => g
            .attr(""transform"", `translate(0,${height - margin.bottom})`)
            .call(d3.axisBottom(x).tickSizeOuter(0));
        const y = d3.scaleLinear()
            .domain([0, d3.max(data, d => d.value)]).nice()
            .range([height - margin.bottom, margin.top]);
        const x = d3.scaleBand()
            .domain(data.map(d => d.name))
            .range([margin.left, width - margin.right])
            .padding(0.1);


        const chartSvg = d3.select(""svg.js-statistics-bar-chart"")
            .attr(""viewBox"", [0, 0, width, height]);
        const bar = chartSvg.append(""g"")
            .attr(""fill"", ""steelblue"")
            .selectAll(""rect"")
            .data(data)
            .join(""rect"")
            .style(""mix-blend-mode"", ""multiply"")
            .attr");
                WriteLiteral(@"(""x"", d => x(d.name))
            .attr(""y"", d => y(d.value))
            .attr(""height"", d => y(0) - y(d.value))
            .attr(""width"", x.bandwidth());
        const gx = chartSvg.append(""g"")
            .call(xAxis);

        const gy = chartSvg.append(""g"")
            .call(yAxis);


        const barChart = Object.assign(chartSvg.node(), {
            update(order) {
                x.domain(data.sort(order).map(d => d.name));

                const t = chartSvg.transition()
                    .duration(750);

                bar.data(data, d => d.name)
                    .order()
                    .transition(t)
                    .delay((d, i) => i * 20)
                    .attr(""x"", d => x(d.name));

                gx.transition(t)
                    .call(xAxis)
                    .selectAll("".tick"")
                    .delay((d, i) => i * 20);
            }
        });
        const order = () => { };
        const update = barChart.update(order);


   ");
                WriteLiteral("     ///////////////////////////////////////////////\r\n\r\n\r\n         var pieData =  ");
#nullable restore
#line 76 "C:\Users\Diana_Lanciano\Source\Repos\Corona-wedding-planner\CoronaWedding\Views\Accounts\Statistics.cshtml"
                   Write(Json.Serialize(Model.pieChart.dataPoints));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        var w = 500,                        //width
            h = 400,                            //height
            r = 200,                            //radius
            color = d3.scaleOrdinal()
                .domain(data.map(d => d.name))
                .range(d3.quantize(t => d3.interpolateSpectral(t * 0.8 + 0.1), data.length).reverse())     //builtin range of colors

        var vis = d3.select("".pieChart"")
            .append(""svg:svg"")              //create the SVG element inside the <body>
            .data([pieData])                   //associate our data with the document
            .attr(""width"", w)           //set the width and height of our visualization (these will be attributes of the <svg> tag
            .attr(""height"", h)
            .append(""svg:g"")                //make a group to hold our pie chart
            .attr(""transform"", ""translate("" + r + "","" + r + "")"")    //move the center of the pie chart from 0, 0 to radius, radius

        const svg = d3.create(""s");
                WriteLiteral(@"vg"")
            .attr(""viewBox"", [-width / 2, -height / 2, width, height]);

            const radius = Math.min(width, height) / 2;
        var arc = d3.arc().innerRadius(radius * 0.67).outerRadius(radius - 1);

        var pie = d3.pie()           //this will create arc data for us given a list of values
            .value(function (d) { return d.value; });    //we must tell it out to access the value of each element in our data array

        var arcs = vis.selectAll(""g.slice"")     //this selects all <g> elements with class slice (there aren't any yet)
            .data(pie)
            .enter()                            //this will create <g> elements for every ""extra"" data element that should be associated with a selection. The result is creating a <g> for every object in the data array
            .append(""svg:g"")                //create a group to hold each slice (we will have a <path> and a <text> element associated with each slice)
            .attr(""class"", ""slice"")    //allow us to s");
                WriteLiteral(@"tyle things in the slices (like text)
            .attr(""font-family"", ""sans-serif"")
            .attr(""font-size"", 12)
            .attr(""text-anchor"", ""middle"");

        arcs.append(""svg:path"")
            .attr(""fill"", function (d, i) { return color(i); }) //set the color for each slice to be chosen from the color function defined above
            .attr(""d"", arc);                                    //this creates the actual SVG path using the associated data (pie) with the arc drawing function

        arcs.append(""svg:text"")                                     //add a label to each slice
            .attr(""transform"", function (d) {                    //set the label's origin to the center of the arc
                //we have to make sure to set these before calling arc.centroid
                d.innerRadius = 0;
                d.outerRadius = r;
                return ""translate("" + arc.centroid(d) + "")"";        //this gives us a pair of coordinates like [50, 50]
            })
       ");
                WriteLiteral("     .attr(\"text-anchor\", \"middle\")                          //center the text on it\'s origin\r\n            .text(function (d, i) { return pieData[i].name; });        //get the label from our original data array\r\n\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"

<div class=""text-center"">
    <div class=""title row"">
        <img src=""/Media/images/popularMonths.PNG"" alt=""title"" class=""rounded mx-auto d-block"">
    </div>
    <svg class=""js-statistics-bar-chart"">
    </svg>
</div>


<div class=""text-center pieChart"">
    <div class=""title row"">
        <img src=""/Media/images/villasPopularity.PNG"" alt=""title"" class=""rounded mx-auto d-block"">
    </div>
    <svg class=""js-statistics-pie-chart"">
    </svg>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoronaWedding.Models.StatisticsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
