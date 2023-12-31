//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.NerdLab;

[assembly: RegisterDocumentType(AboutItem.CLASS_NAME, typeof(AboutItem))]

namespace CMS.DocumentEngine.Types.NerdLab
{
	/// <summary>
	/// Represents a content item of type AboutItem.
	/// </summary>
	public partial class AboutItem : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "NerdLab.AboutItem";


		/// <summary>
		/// The instance of the class that provides extended API for working with AboutItem fields.
		/// </summary>
		private readonly AboutItemFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// AboutItemID.
		/// </summary>
		[DatabaseIDField]
		public int AboutItemID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("AboutItemID"), 0);
			}
			set
			{
				SetValue("AboutItemID", value);
			}
		}


		/// <summary>
		/// Image.
		/// </summary>
		[DatabaseField]
		public string Image
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Image"), "");
			}
			set
			{
				SetValue("Image", value);
			}
		}


		/// <summary>
		/// Name.
		/// </summary>
		[DatabaseField]
		public string Name
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Name"), @"");
			}
			set
			{
				SetValue("Name", value);
			}
		}


		/// <summary>
		/// Designation.
		/// </summary>
		[DatabaseField]
		public string Designation
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Designation"), @"");
			}
			set
			{
				SetValue("Designation", value);
			}
		}


		/// <summary>
		/// Quote.
		/// </summary>
		[DatabaseField]
		public string Quote
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Quote"), @"");
			}
			set
			{
				SetValue("Quote", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with AboutItem fields.
		/// </summary>
		[RegisterProperty]
		public AboutItemFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with AboutItem fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class AboutItemFields : AbstractHierarchicalObject<AboutItemFields>
		{
			/// <summary>
			/// The content item of type AboutItem that is a target of the extended API.
			/// </summary>
			private readonly AboutItem mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="AboutItemFields" /> class with the specified content item of type AboutItem.
			/// </summary>
			/// <param name="instance">The content item of type AboutItem that is a target of the extended API.</param>
			public AboutItemFields(AboutItem instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// AboutItemID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.AboutItemID;
				}
				set
				{
					mInstance.AboutItemID = value;
				}
			}


			/// <summary>
			/// Image.
			/// </summary>
			public IEnumerable<global::CMS.MediaLibrary.AssetRelatedItem> Image
			{
				get
				{
					return global::CMS.DataEngine.Internal.JsonDataTypeConverter.ConvertToModels<global::CMS.MediaLibrary.AssetRelatedItem>(mInstance.Image);
				}
			}


			/// <summary>
			/// Name.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.Name;
				}
				set
				{
					mInstance.Name = value;
				}
			}


			/// <summary>
			/// Designation.
			/// </summary>
			public string Designation
			{
				get
				{
					return mInstance.Designation;
				}
				set
				{
					mInstance.Designation = value;
				}
			}


			/// <summary>
			/// Quote.
			/// </summary>
			public string Quote
			{
				get
				{
					return mInstance.Quote;
				}
				set
				{
					mInstance.Quote = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="AboutItem" /> class.
		/// </summary>
		public AboutItem() : base(CLASS_NAME)
		{
			mFields = new AboutItemFields(this);
		}

		#endregion
	}
}