﻿using System.Configuration;

namespace Umbraco.Core.Configuration.UmbracoSettings
{
    internal class HelpElement : ConfigurationElement
    {
        [ConfigurationProperty("defaultUrl", DefaultValue = "http://our.umbraco.org/wiki/umbraco-help/{0}/{1}")]
        public string DefaultUrl
        {
            get { return (string) base["defaultUrl"]; }
        }

        [ConfigurationCollection(typeof (LinksCollection), AddItemName = "link")]
        [ConfigurationProperty("", IsDefaultCollection = true)]
        public LinksCollection Links
        {
            get { return (LinksCollection) base[""]; }
        }
    }
}