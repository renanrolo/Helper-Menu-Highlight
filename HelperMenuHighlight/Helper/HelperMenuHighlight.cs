using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace Helper
{
    public static class HelperMenuHighlight
    {
        private static string ObterController()
        {
            var routeValues = HttpContext.Current.Request.RequestContext.RouteData.Values;

            if (routeValues.ContainsKey("controller"))
                return (string)routeValues["controller"];

            return string.Empty;
        }

        private static string ObterAction()
        {
            var routeValues = HttpContext.Current.Request.RequestContext.RouteData.Values;

            if (routeValues.ContainsKey("action"))
                return (string)routeValues["action"];

            return string.Empty;
        }

        public static MvcHtmlString LinkMenuHighlight(this HtmlHelper helper, string controller, string action, string classCSS = "default")
        {
            var link = new TagBuilder("a");

            var urlHelper = new UrlHelper(helper.ViewContext.RequestContext, helper.RouteCollection);

            link.MergeAttribute("href", urlHelper.Action(action, controller));

            string requestAction = ObterAction();
            string requestController = ObterController();

            if (controller.Equals(requestController) && action.Equals(requestAction))
            {
                link.MergeAttribute("class", classCSS);
            }

            return new MvcHtmlString(link.ToString());
        }
    }
}
