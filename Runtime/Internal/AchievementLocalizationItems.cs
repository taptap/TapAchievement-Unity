// <auto-generated />
//
// To parse this JSON data, add NuGet 'LC.Newtonsoft.Json' then do:
//
//    using TapTap.Achievement.Localization;
//
//    var achievementLocalizationItems = AchievementLocalizationItems.FromJson(jsonString);

namespace TapTap.Achievement.Localization
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using LC.Newtonsoft.Json;
    using LC.Newtonsoft.Json.Converters;
	using TapTap.Common;

    public partial class AchievementLocalizationItems
    {
	    public AchievementLocalizationItems()
	    {
	    }

	    [JsonProperty("items")]
        public Items Items { get; set; }
		public Item Current
		{
			get
			{
				switch (TapTap.Common.TapLocalizeManager.GetCurrentLanguage())
				{
					case TapLanguage.ZH_HANS:
						return this.Items.Zhs;
                    case TapLanguage.ZH_HANT:
						return this.Items.Zht;
					case TapLanguage.EN:
						return this.Items.En;
                    case TapLanguage.FR:
						return this.Items.Fr;
                    case TapLanguage.DE:
						return this.Items.De;
					case TapLanguage.ID:
						return this.Items.Id;
					case TapLanguage.JA:
						return this.Items.Ja;
					case TapLanguage.KO:
						return this.Items.Ko;
                    case TapLanguage.PT:
						return this.Items.Pt;
                    case TapLanguage.RU:
						return this.Items.Ru;
                    case TapLanguage.ES:
						return this.Items.Es;
					case TapLanguage.TH:
						return this.Items.Th;
                    case TapLanguage.TR:
						return this.Items.Tr;
                    case TapLanguage.VI:
						return this.Items.Vi;
					
					default:
						return this.Items.En;
				}
			}
		}
		public const string PATH = "Config/AchievementLocalization";
    }

    public partial class Items
    {
        [JsonProperty("zhs")]
        public Item Zhs { get; set; }
        [JsonProperty("zht")]
        public Item Zht { get; set; }

        [JsonProperty("en")]
        public Item En { get; set; }
        [JsonProperty("fr")]
        public Item Fr { get; set; }
        [JsonProperty("De")]
        public Item De { get; set; }

        [JsonProperty("id")]
        public Item Id { get; set; }

        [JsonProperty("ja")]
        public Item Ja { get; set; }

        [JsonProperty("ko")]
        public Item Ko { get; set; }
        [JsonProperty("Pt")]
        public Item Pt { get; set; }
        [JsonProperty("Ru")]
        public Item Ru { get; set; }
        [JsonProperty("Es")]
        public Item Es { get; set; }


        [JsonProperty("th")]
        public Item Th { get; set; }
        [JsonProperty("Tr")]
        public Item Tr { get; set; }
        [JsonProperty("Vi")]
        public Item Vi { get; set; }

        
    }

    public partial class Item
    {
        [JsonProperty("DetailAchievementData")]
        public string DetailAchievementData { get; set; }

        [JsonProperty("DetailGetPercent")]
        public string DetailGetPercent { get; set; }

        [JsonProperty("DetailGetPercentlow")]
        public string DetailGetPercentlow { get; set; }

        [JsonProperty("DetailGetDatetime")]
        public string DetailGetDatetime { get; set; }

        [JsonProperty("InvisibleTitle")]
        public string InvisibleTitle { get; set; }

        [JsonProperty("InvisibleSubtitle")]
        public string InvisibleSubtitle { get; set; }

        [JsonProperty("Unlock")]
        public string Unlock { get; set; }

        [JsonProperty("Lock")]
        public string Lock { get; set; }

        [JsonProperty("Common")]
        public string Common { get; set; }

        [JsonProperty("Uncommom")]
        public string Uncommom { get; set; }

        [JsonProperty("Rare")]
        public string Rare { get; set; }

        [JsonProperty("UltraRare")]
        public string UltraRare { get; set; }

        [JsonProperty("ToastCongra")]
        public string ToastCongra { get; set; }
    }

    public partial class AchievementLocalizationItems
    {
	    
        public static AchievementLocalizationItems FromJson(string json) => JsonConvert.DeserializeObject<AchievementLocalizationItems>(json, TapTap.Achievement.Localization.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this AchievementLocalizationItems self) => JsonConvert.SerializeObject(self, TapTap.Achievement.Localization.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
