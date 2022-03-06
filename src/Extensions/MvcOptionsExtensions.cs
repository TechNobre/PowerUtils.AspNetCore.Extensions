using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Routing;

namespace PowerUtils.AspNetCore.Extensions
{
    public static class MvcOptionsExtensions
    { // https://stackoverflow.com/questions/58340979/how-to-add-global-route-prefix-in-asp-net-core-3
        public static void UseGeneralRoutePrefix(this MvcOptions opts, IRouteTemplateProvider routeAttribute)
            => opts.Conventions.Add(new RoutePrefixConvention(routeAttribute));

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
