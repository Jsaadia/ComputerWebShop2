using System.Web;
using System.Web.Optimization;

namespace ComputerWebShop
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
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            /****************************************************************CLIENT SIDE BUNDLES ****************************************************************************************/


            bundles.Add(new ScriptBundle("~/bundles/ScriptUser").Include(
                    //"~/Scripts/ApplicationScript/seller.js"
                    ));
            bundles.Add(new StyleBundle("~/Content/ClientStyle").Include(
                "~/Content/styles/style.css",
                "~/Content/styles/theme.css",
                "~/Content/styles/dataTables.bootstrap.min.css",
                "~/Content/styles/slider.css"
            ));

            bundles.Add(new StyleBundle("~/Content/ClientFontStyle").Include(
                "~/Content/fonts/pe-icon-7-stroke/css/pe-icon-7-stroke.css",
                "~/Content/fonts/pe-icon-7-stroke/css/helper.css"
                ));

            bundles.Add(new StyleBundle("~/Content/ClientVendorStyle").Include(
                "~/Content/vendor/fontawesome/css/font-awesome.css",
               // "~/Content/vendor/metisMenu/dist/metisMenu.css",
                "~/Content/vendor/animate.css/animate.css",
                "~/Content/vendor/bootstrap/dist/css/bootstrap.css",
                "~/Content/vendor/awesome-bootstrap-checkbox/awesome-bootstrap-checkbox.css",
                "~/Content/vendor/owlcarousel/assets/owl.carousel.min.css",
                "~/Content/vendor/bootstrap-datepicker-master/dist/css/bootstrap-datepicker3.min.css",
                "~/Content/vendor/toastr/toastr.min.css",
                "~/Content/vendor/blockUI/block.css",
                "~/Content/styles/fileinput.css",
                 "~/Content/vendor/sweetalert/lib/sweet-alert.css",
                 "~/Content/vendor/select2-3.5.2/select2.css",
                "~/Content/vendor/select2-bootstrap/select2-bootstrap.css",
                "~/Content/vendor/ladda/dist/ladda.min.css",
                "~/Content/vendor/bootstrap-star-rating/css/star-rating.css"

                ));

            bundles.Add(new ScriptBundle("~/bundles/ClientVendorScript").Include(
               // "~/Content/vendor/jquery/dist/jquery.min.js",
               // "~/Content/vendor/metisMenu/dist/metisMenu.js",
                "~/Content/vendor/slimScroll/jquery.slimscroll.min.js",
                "~/Content/vendor/bootstrap/dist/js/bootstrap.min.js",
                "~/Content/vendor/sparkline/index.js",
                "~/Content/vendor/iCheck/icheck.min.js",
                "~/Content/vendor/owlcarousel/owl.carousel.js",
                "~/Content/vendor/jquery/dist/scripts-wizard.js",
                "~/Content/vendor/jquery/dist/jquery.backstretch.min.js",
                "~/Content/vendor/jquery/dist/jquery.uploadPreview.min.js",
                "~/Content/vendor/jquery/dist/lightslider.js",
                "~/Content/vendor/toastr/toastr.min.js",
                "~/Content/vendor/blockUI/jquery.blockUI.js",
                 "~/Content/vendor/bootstrap-datepicker-master/dist/js/bootstrap-datepicker.min.js",
                "~/Content/Scripts/fileinput.js",
                "~/Content/Scripts/theme.js",
                "~/Content/Scripts/homer.js",
                "~/Content/vendor/select2-3.5.2/select2.min.js",
                "~/Content/vendor/sweetalert/lib/sweet-alert.min.js",
                "~/Content/vendor/bootstrap-star-rating/js/star-rating.min.js",
                "~/Scripts/moment.js",
                 "~/Scripts/bootstrap-slider.js"

                ));

            bundles.Add(new ScriptBundle("~/bundles/ClientScript").Include( 
                    "~/Scripts/Application/home.js",
                    "~/Scripts/Application/product.js",
                    "~/Scripts/Application/common.js"
                    
                    ));
        }
    }
}
