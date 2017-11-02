using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AdminBootrap.App_Start
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {

            //< link href = "~/Content/dist/css/main.css" rel = "stylesheet" >

               bundles.Add(new StyleBundle("~/bundle/css")
                .Include(
                //"",
                //"",
                "~/Content/dist/css/main.css"
                ));
            bundles.Add(new ScriptBundle("~/bundle/js")
                .Include(

                //"",
                //"",
                //""

                ));
        }

    }
}