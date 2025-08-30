using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Routing;

namespace PowerUtils.AspNetCore.Extensions
{
    [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
    public static class MvcOptionsExtensions
    { // https://stackoverflow.com/questions/58340979/how-to-add-global-route-prefix-in-asp-net-core-3
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static void UseGeneralRoutePrefix(this MvcOptions opts, IRouteTemplateProvider routeAttribute)
            => opts.Conventions.Add(new RoutePrefixConvention(routeAttribute));

        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static void UseGeneralRoutePrefix(this MvcOptions opts, string prefix)
            => opts.UseGeneralRoutePrefix(new RouteAttribute(prefix));
    }

    internal class RoutePrefixConvention : IApplicationModelConvention
    {
        private readonly AttributeRouteModel _routePrefix;

        public RoutePrefixConvention(IRouteTemplateProvider route)
            => _routePrefix = new AttributeRouteModel(route);

        public void Apply(ApplicationModel application)
        {
            foreach(var selector in application.Controllers.SelectMany(c => c.Selectors))
            {
                if(selector.AttributeRouteModel == null)
                {
                    selector.AttributeRouteModel = _routePrefix;
                }
                else
                {
                    selector.AttributeRouteModel = AttributeRouteModel.CombineAttributeRouteModel(_routePrefix, selector.AttributeRouteModel);
                }
            }
        }
    }
}
