#pragma checksum "C:\Users\Simara\Desktop\Back--Front\FrontToBack\Fiorella\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38582dd7c2f63ed97dd70b1540e335585a57d09e"
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
#line 1 "C:\Users\Simara\Desktop\Back--Front\FrontToBack\Fiorella\Views\Home\Index.cshtml"
using Fiorella.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38582dd7c2f63ed97dd70b1540e335585a57d09e", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Slide>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Simara\Desktop\Back--Front\FrontToBack\Fiorella\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Main start -->\r\n<main>\r\n    <section id=\"slider\">\r\n        <div class=\"intro\">\r\n            <div class=\"intro-slideshow\">\r\n");
#nullable restore
#line 12 "C:\Users\Simara\Desktop\Back--Front\FrontToBack\Fiorella\Views\Home\Index.cshtml"
                 foreach (var slide in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div> <img");
            BeginWriteAttribute("src", " src=\"", 311, "\"", 327, 1);
#nullable restore
#line 14 "C:\Users\Simara\Desktop\Back--Front\FrontToBack\Fiorella\Views\Home\Index.cshtml"
WriteAttributeValue("", 317, slide.Url, 317, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"slide-image\" /> </div>\r\n");
#nullable restore
#line 15 "C:\Users\Simara\Desktop\Back--Front\FrontToBack\Fiorella\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""intro-header"">
                <h1>Send <span style=""color: red;"">flowers</span> like you mean it.</h1>
                <p>Where flowers are our inspiration to create lasting memories. Whatever the occasion, our flowers will make it special cursus a sit amet mauris.</p>
                <div>
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h2-sign-img.png"">
                </div>
            </div>
        </div>
    </section>
    <section id=""filter"">

        <!-- Control buttons -->
        <section id=""products"">
            <div id=""filter"">
                <!-- <button class=""btn active"" onclick=""filterSelection('all')""> ALL</button>
                <button class=""btn "" onclick=""filterSelection('cactuses')""> CACTUSES</button>
                <button class=""btn"" onclick=""filterSelection('exotic')""> EXOTIC</button>
                <button class=""btn"" onclick=""filterSelection('greens')""> GREENS</butto");
            WriteLiteral(@"n>
                <button class=""btn"" onclick=""filterSelection('popular')""> POPULAR</button>
                <button class=""btn"" onclick=""filterSelection('various')""> VARIOUS</button>
                <button class=""btn"" onclick=""filterSelection('winter')""> WINTER</button> -->
                <ul id=""categories"">
                    <li class=""category active"" data-filter=""*"" id=""red-all"" onclick=""filterSelection('all')"">ALL</li>
                    <li class=""category"" data-filter="".cactuses"" onclick=""filterSelection('cactuses')"">CACTUSES</li>
                    <li class=""category"" data-filter="".exotic"" onclick=""filterSelection('exotic')"">EXOTIC</li>
                    <li class=""category"" data-filter="".greens"" onclick=""filterSelection('greens')"">GREENS</li>
                    <li class=""category"" data-filter="".popular"" onclick=""filterSelection('popular')"">POPULAR</li>
                    <li class=""category"" data-filter="".various"" onclick=""filterSelection('various')"">VARIOUS</li>
            ");
            WriteLiteral(@"        <li class=""category"" data-filter="".winter"" onclick=""filterSelection('winter')"">WINTER</li>
                </ul>
                <span id=""filter-span"">
                    FILTER <i class=""fa-solid fa-caret-down""></i>
                    <div id=""filter-dropdown"">
                        <ul id=""sort_by"">
                            <li>
                                <a");
            BeginWriteAttribute("href", " href=\"", 2815, "\"", 2822, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <h2 id=\"sort-h2-font\">Sort By</h2>\r\n                                </a>\r\n                            </li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3005, "\"", 3012, 0);
            EndWriteAttribute();
            WriteLiteral(">Default</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3066, "\"", 3073, 0);
            EndWriteAttribute();
            WriteLiteral(">Popularity</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3130, "\"", 3137, 0);
            EndWriteAttribute();
            WriteLiteral(">Newness</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3191, "\"", 3198, 0);
            EndWriteAttribute();
            WriteLiteral(">Price:Low To High</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3262, "\"", 3269, 0);
            EndWriteAttribute();
            WriteLiteral(">Price:Hogh To Low</a></li>\r\n                        </ul>\r\n                        <ul id=\"price_range\">\r\n                            <li>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3445, "\"", 3452, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <h2 id=\"price-h2-font\">Price Range</h2>\r\n                                </a>\r\n                            </li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3640, "\"", 3647, 0);
            EndWriteAttribute();
            WriteLiteral(">All</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3697, "\"", 3704, 0);
            EndWriteAttribute();
            WriteLiteral(">$0-$10</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3757, "\"", 3764, 0);
            EndWriteAttribute();
            WriteLiteral(">$10-$20</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3818, "\"", 3825, 0);
            EndWriteAttribute();
            WriteLiteral(">$20-$30</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3879, "\"", 3886, 0);
            EndWriteAttribute();
            WriteLiteral(">$30-$40</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3940, "\"", 3947, 0);
            EndWriteAttribute();
            WriteLiteral(@">40$+</a></li>

                        </ul>
                    </div>
                </span>
            </div>
            <div id=""product-cards"">
                <div class=""card popular winter"">
                    <div class=""card-image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-14-img.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4319, "\"", 4325, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"card-summary\">\r\n                        <p class=\"item-name\">MAJESTY PALM</p>\r\n                        <p class=\"add-to-card\"><a");
            BeginWriteAttribute("href", " href=\"", 4517, "\"", 4524, 0);
            EndWriteAttribute();
            WriteLiteral(@">Add to cart</a></p>
                        <p class=""item-price"">$259</p>
                    </div>
                </div>
                <div class=""card popular winter"">
                    <div class=""card-image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-13-img.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4866, "\"", 4872, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"card-summary\">\r\n                        <p class=\"item-name\">FOXGLOVE FLOWER</p>\r\n                        <p class=\"add-to-card\"><a");
            BeginWriteAttribute("href", " href=\"", 5067, "\"", 5074, 0);
            EndWriteAttribute();
            WriteLiteral(@">Add to cart</a></p>
                        <p class=""item-price"">$259</p>
                    </div>
                </div>
                <div class=""card popular winter"">
                    <div class=""card-image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/shop-10-img.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5416, "\"", 5422, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"card-summary\">\r\n                        <p class=\"item-name\">SWEET ALYSSUM</p>\r\n                        <p class=\"read-more\"><a");
            BeginWriteAttribute("href", " href=\"", 5613, "\"", 5620, 0);
            EndWriteAttribute();
            WriteLiteral(@">Read More</a></p>
                        <p class=""item-price"">$259</p>
                    </div>
                </div>
                <div class=""card popular"">
                    <div class=""card-image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-11-img.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5953, "\"", 5959, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"card-summary\">\r\n                        <p class=\"item-name\">SPRING SNOWFLAKE</p>\r\n                        <p class=\"add-to-card\"><a");
            BeginWriteAttribute("href", " href=\"", 6155, "\"", 6162, 0);
            EndWriteAttribute();
            WriteLiteral(@">Add to cart</a></p>
                        <p class=""item-price"">$170</p>
                    </div>
                </div>
                <div class=""card popular"">
                    <div class=""card-image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-12-img.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6497, "\"", 6503, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"card-summary\">\r\n                        <p class=\"item-name\">SCARLET SAGE</p>\r\n                        <p class=\"add-to-card\"><a");
            BeginWriteAttribute("href", " href=\"", 6695, "\"", 6702, 0);
            EndWriteAttribute();
            WriteLiteral(@">Add to cart</a></p>
                        <p class=""item-price"">
                            <span style=""text-decoration:line-through ;margin-right:5px ;"">$259</span>$159
                        </p>
                    </div>
                </div>
                <div class=""card various"">
                    <div class=""card-image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-9-img.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7166, "\"", 7172, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"card-summary\">\r\n                        <p class=\"item-name\">ROCK SOAPWORT</p>\r\n                        <p class=\"view-products\"><a");
            BeginWriteAttribute("href", " href=\"", 7367, "\"", 7374, 0);
            EndWriteAttribute();
            WriteLiteral(@">View Products</a></p>
                        <p class=""item-price"">$259</p>

                    </div>
                </div>
                <div class=""card greens various"">
                    <div class=""card-image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-8-img.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7719, "\"", 7725, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"card-summary\">\r\n                        <p class=\"item-name\">SUMMER SAVORY</p>\r\n                        <p class=\"add-to-card\"><a");
            BeginWriteAttribute("href", " href=\"", 7918, "\"", 7925, 0);
            EndWriteAttribute();
            WriteLiteral(@">Add to cart</a></p>
                        <p class=""item-price"">$259</p>

                    </div>
                </div>
                <div class=""card exotic various"">
                    <div class=""card-image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-7-img.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8268, "\"", 8274, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"card-summary\">\r\n                        <p class=\"item-name\">WILD ROSES</p>\r\n                        <p class=\"buy-on-amazon\"><a");
            BeginWriteAttribute("href", " href=\"", 8466, "\"", 8473, 0);
            EndWriteAttribute();
            WriteLiteral(@">Buy on Amazon</a></p>
                        <p class=""item-price"">$259</p>

                    </div>
                </div>
            </div>
        </section>
        <section id=""valentine"">
            <div class=""valentine_container"">
                <div class=""valentine_video"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-video-img.jpg"" alt=""image"">
                    <div class=""play"">
                        <i class=""fa-solid fa-play""></i>
                    </div>
                </div>
                <div class=""valentine_text"">
                    <h3>
                        Suprise Your <span>Valentine!</span>
                        Let us arrange a smile.
                    </h3>
                    <p>Where flowers are our inspiration to create lasting memories. Whatever the occasion...</p>
                    <ul>
                        <li>Hand picked just for you.</li>
                        <li>Unique ");
            WriteLiteral(@"flower arrangements</li>
                        <li>Best way to say you care.</li>
                    </ul>
                </div>
            </div>
        </section>
        <section id=""experts"">
            <div class=""experts_text"">
                <h3>Flower Experts</h3>
                <p>
                    A perfect blend of creativity, energy, communication, happiness and love. Let us arrange a smile for you.
                </p>
            </div>
            <div class=""experts_cards"">
                <div class=""experts_cards-item"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-1.png""
                         alt=""image"">
                    <h5>CRYSTAL BROOKS</h5>
                    <p>Florist</p>
                </div>
                <div class=""experts_cards-item"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/h3-team-img-2.png""
                         alt=""i");
            WriteLiteral(@"mage"">
                    <h5>SHIRLER HARRIS</h5>
                    <p>Manager</p>
                </div>
                <div class=""experts_cards-item"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-3.png""
                         alt=""image"">
                    <h5>BEVERLY CLARK</h5>
                    <p>Florist</p>
                </div>
                <div class=""experts_cards-item"">
                    <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-4.png""
                         alt=""image"">
                    <h5>AMANDA WATKINS</h5>
                    <p>Florist</p>
                </div>
            </div>
        </section>
        <section id=""join"">
            <div class=""join_summary"">
                <h3>
                    Join The Colorful Bunch!
                </h3>
                <div class=""join_input"">
                    <input type=""text"" placeholder=""Em");
            WriteLiteral(@"ail Address"">
                    <button>SUBSCRIBE</button>
                </div>
            </div>
        </section>
        <section id=""blog"">
            <div class=""blog_summary"">
                <h3>From our Blog</h3>
                <p>
                    A perfect blend of creativity, energy, communication, happiness and love. Let us arrange a smile for you.
                </p>
            </div>
            <div class=""blog_cards"">
                <div class=""blog_card"">
                    <div class=""blog_image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/blog-feature-img-1.jpg""
                             alt=""image"">
                    </div>
                    <div class=""blog_text"">
                        <a href=""#"" class=""blog_link"">Flower Power</a>
                        <p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per</p>
                    </div>
                    <a href=""#");
            WriteLiteral(@""" class=""date_link"">27.04.2018</a>
                </div>
                <div class=""blog_card"">
                    <div class=""blog_image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/blog-feature-img-3.jpg""
                             alt=""image"">
                    </div>
                    <div class=""blog_text"">
                        <a href=""#"" class=""blog_link"">Local Florists</a>
                        <p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per</p>
                    </div>
                    <a href=""#"" class=""date_link"">03.05.2018</a>
                </div>
                <div class=""blog_card"">
                    <div class=""blog_image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/blog-feature-img-4.jpg""
                             alt=""image"">
                    </div>
                    <div class=""blog_text"">
                ");
            WriteLiteral(@"        <a href=""#"" class=""blog_link"">Flower Beauty</a>
                        <p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per</p>
                    </div>
                    <a href=""#"" class=""date_link"">03.05.2018</a>
                </div>
            </div>
        </section>
        <section id=""slick-carousel"">
            <div class=""slick-carousel-items"">
                <div class=""slick_carousel-item"">
                    <div class=""slick_image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/testimonial-img-2.png""
                             alt=""image"">
                    </div>
                    <h2>Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus lingua.</h2>
                    <h6>ANNA BARNES</h6>
                    <p>Florist</p>
                </div>
                <div class=""slick_carousel-item"">
                    <div class=""slick_image"">
             ");
            WriteLiteral(@"           <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/testimonial-img-1.png""
                             alt=""image"">
                    </div>
                    <h2>Lorem ipsum dolor sit amet,consectruer adipicing elit. Aenean commodo ligua eget.</h2>
                    <h6>JASMINE WHITE</h6>
                    <p>Florist</p>
                </div>
            </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Slide>> Html { get; private set; }
    }
}
#pragma warning restore 1591