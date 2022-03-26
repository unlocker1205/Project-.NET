using System.Web;
using System.Web.Optimization;

namespace Project.NET
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/BackToTop.js",
                      "~/Scripts/bstable.js",
                      "~/Scripts/CartAtHover.js",
                      "~/Scripts/click-filter.js",
                      "~/Scripts/clickAddCart.js",
                      "~/Scripts/hover-product.js",
                      "~/Scripts/nav-responsive.js",
                      "~/Scripts/product-bestseller.js",
                      "~/Scripts/register.js",
                      "~/Scripts/ripple-button.js",
                      "~/Scripts/Scroll-Indicator.js",
                      "~/Scripts/slick-all-product.js",
                      "~/Scripts/slider.js",
                      "~/Scripts/tabs-table.js",
                      "~/Scripts/tabs.js",
                      "~/Scripts/view-image-product.js",
                      "~/Scripts/visibleCart.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/about.css",
                      "~/Content/admin.css",
                      "~/Content/cart.css",
                      "~/Content/cartResponsive.css",
                      "~/Content/reponsiveProduct.css",
                      "~/Content/responsiveIndex.css",
                      "~/Content/style-product.css",
                      "~/Content/style-tutorial.css",
                      "~/Content/style.css"));
        }
    }
}
