using System;
using System.Web;
using System.Web.Optimization;

namespace FinancialCalculator
{
    public class BundleConfig
    {
        public static void AddDefaultIgnorePatterns(IgnoreList ignoreList)
        {
            if (ignoreList == null)
                throw new ArgumentNullException("ignoreList");
            ignoreList.Ignore("*.intellisense.js");
            ignoreList.Ignore("*.-vsdoc.js");
            ignoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
            //ignoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
            ignoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);
        }

        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();
            AddDefaultIgnorePatterns(bundles.IgnoreList);

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery/jquery.min.js",
                        "~/Scripts/jquery/*.js"));

            bundles.Add(new ScriptBundle("~/bundles/metro").Include(
                        "~/Scripts/metro/metro-core.js",
                        "~/Scripts/metro/*.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css/metro-ui-css").Include(
                        "~/Content/metro-ui-css/metro-bootstrap.css",
                        "~/Content/metro-ui-css/metro-bootstrap-responsive.css"));
        }
    }
}