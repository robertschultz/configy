using System.Configuration;

namespace CollectionConfiguration
{
	/// <summary>
	/// Container element configuration representing each container node.
	/// </summary>
	public class CustomElement : ConfigurationElement
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>
		/// The name of the container.
		/// </value>
		[ConfigurationProperty("name", IsRequired = true)]
		public string Name
		{
			get
			{
				return (string)this["name"];
			}

			set
			{
				this["name"] = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="CustomElement"/> is enabled.
		/// </summary>
		/// <value>
		///   <c>true</c> if enabled; otherwise, <c>false</c>.
		/// </value>
		[ConfigurationProperty("enabled", IsRequired = true)]
		public bool Enabled
		{
			get
			{
				return (bool)this["enabled"];
			}

			set
			{
				this["enabled"] = value;
			}
		}

		/// <summary>
		/// Gets the nodes collection.
		/// </summary>
		[ConfigurationCollection(typeof(CustomNodeElementCollection), AddItemName = "node")]
		[ConfigurationProperty("", IsDefaultCollection = true, IsRequired = true)]
		public CustomNodeElementCollection Nodes
		{
			get { return (CustomNodeElementCollection)this[string.Empty]; }
		}
	}
}