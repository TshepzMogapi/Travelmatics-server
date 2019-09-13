using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Travelmatics.Localization
{
    public static class TravelmaticsLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TravelmaticsConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TravelmaticsLocalizationConfigurer).GetAssembly(),
                        "Travelmatics.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
