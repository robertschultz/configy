using System.Configuration;

namespace CollectionConfiguration
{
	/// <summary>
	/// NOde element configuration representing each node.
	/// </summary>
	public class CustomNodeElement : ConfigurationElement
	{
		/// <summary>
		/// Gets or sets the key.
		/// </summary>
		/// <value>
		/// The key of the node.
		/// </value>
		[ConfigurationProperty("key", IsRequired = true, IsKey = true)]
		public string Name
		{
			get
			{
				return (string)this["key"];
			}

			set
			{
				this["key"] = value;
			}
		}

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>
		/// The type of the node.
		/// </value>
		[ConfigurationProperty("type", IsRequired = true)]
		public string Type
		{
			get
			{
				return (string)this["type"];
			}

			set
			{
				this["type"] = value;
			}
		}
	}
}