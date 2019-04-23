using System.Collections.Generic;
using System.Globalization;
using MrCMS.Entities.Resources;
using MrCMS.Services.Caching;


namespace MrCMS.Services.Resources
{
    public interface IStringResourceProvider : IClearCache
    {
        IEnumerable<StringResource> AllResources { get; }
        string GetValue(string key, string defaultValue = null);
        string GetValueForCulture(string key, CultureInfo cultureInfo, string defaultValue = null);
        IEnumerable<string> GetOverriddenLanguages();
        IEnumerable<string> GetOverriddenLanguages(string key, int? siteId);
        void Insert(StringResource resource);
        void AddOverride(StringResource resource);
        void Update(StringResource resource);
        void Delete(StringResource resource);
    }
}