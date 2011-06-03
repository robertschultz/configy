using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace CollectionConfiguration
{
    /// <summary>
    /// Segment configuration section for Web.config.
    /// </summary>
    public class CustomSection : ConfigurationSection
    {
        /// <summary>
        /// Gets or sets the container element.
        /// </summary>
        /// <value>
        /// Collection of container elements.
        /// </value>
        [ConfigurationCollection(typeof(CustomElementCollection), AddItemName = "container")]
        [ConfigurationProperty("", IsRequired = true, IsKey = false, IsDefaultCollection = true)]
        public CustomElementCollection Containers
        {
            get
            {
                return (CustomElementCollection)this[string.Empty];
            }

            set
            {
                this[string.Empty] = value;
            }
        }
    }
}
