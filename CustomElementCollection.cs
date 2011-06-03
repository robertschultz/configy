using System.Configuration;

namespace CollectionConfiguration
{
	/// <summary>
	/// Container element configuration for collection of containers.
	/// </summary>
	public class CustomElementCollection : ConfigurationElementCollection
	{
		/// <summary>
		/// Gets or sets a property, attribute, or child element of this configuration element.
		/// </summary>
		/// <param name="index">Index of the item.
		/// </param>
		/// <returns>The specified property, attribute, or child element</returns>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">
		/// <paramref name="prop"/> is read-only or locked.</exception>
		public CustomElement this[int index]
		{
			get
			{
				return this.BaseGet(index) as CustomElement;
			}

			set
			{
				if (this.BaseGet(index) != null)
				{
					this.BaseRemoveAt(index);
				}

				this.BaseAdd(index, value);
			}
		}

		/// <summary>
		/// When overridden in a derived class, creates a new <see cref="T:System.Configuration.ConfigurationElement"/>.
		/// </summary>
		/// <returns>
		/// A new <see cref="T:System.Configuration.ConfigurationElement"/>.
		/// </returns>
		protected override ConfigurationElement CreateNewElement()
		{
			return new CustomElement();
		}

		/// <summary>
		/// Gets the element key for a specified configuration element when overridden in a derived class.
		/// </summary>
		/// <param name="element">The <see cref="T:System.Configuration.ConfigurationElement"/> to return the key for.</param>
		/// <returns>
		/// An <see cref="T:System.Object"/> that acts as the key for the specified <see cref="T:System.Configuration.ConfigurationElement"/>.
		/// </returns>
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((CustomElement)element).Name;
		}
	}
}