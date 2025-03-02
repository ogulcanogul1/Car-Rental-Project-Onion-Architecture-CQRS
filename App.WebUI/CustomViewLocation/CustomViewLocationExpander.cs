using Microsoft.AspNetCore.Mvc.Razor;

namespace App.WebUI.CustomViewLocation
{
    public class CustomViewLocationExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            var customLocations = new[]
            {
            "/Views/Shared/Components/Admin/{0}.cshtml",
            "/Views/Shared/Components/Admin/{1}/{0}.cshtml",
            "/Views/Shared/Components/User/{0}.cshtml",
            "/Views/Shared/Components/User/{1}/{0}.cshtml"
            };

            return customLocations;
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
        }
    }
}
