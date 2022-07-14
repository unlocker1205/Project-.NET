using System.Web;
using System.Web.Optimization;

namespace Project.NET
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/ssss").Include(
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

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                       "~/Scripts/BackToTop.js",
                       "~/Scripts/nav-responsive.js",
                       "~/Scripts/Scroll-Indicator.js",
                       "~/Scripts/visibleCart.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/about.css",
                      "~/Content/css/admin.css",
                      "~/Content/css/cart.css",
                      "~/Content/css/cartResponsive.css",
                      "~/Content/css/loading.css",
                      "~/Content/css/reponsiveProduct.css",
                      "~/Content/css/responsiveIndex.css",
                      "~/Content/css/style-product.css",
                      "~/Content/css/style-tutorial.css",
                      "~/Content/css/style.css"));

            bundles.Add(new StyleBundle("~/Content/layoutCSS").Include(
                      "~/fonts/themify-icons/themify-icons.css",
                      "~/fonts/font-awesome-4.7.0/css/font-awesome.css",
                      "~/fonts/font-awesome-4.7.0/css/font-awesome.min.css"));
        }
    }
}
