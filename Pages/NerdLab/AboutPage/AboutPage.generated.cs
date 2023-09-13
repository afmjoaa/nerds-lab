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

[assembly: RegisterDocumentType(AboutPage.CLASS_NAME, typeof(AboutPage))]

namespace CMS.DocumentEngine.Types.NerdLab
{
	/// <summary>
	/// Represents a content item of type AboutPage.
	/// </summary>
	public partial class AboutPage : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "NerdLab.AboutPage";


		/// <summary>
		/// The instance of the class that provides extended API for working with AboutPage fields.
		/// </summary>
		private readonly AboutPageFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// AboutPageID.
		/// </summary>
		[DatabaseIDField]
		public int AboutPageID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("AboutPageID"), 0);
			}
			set
			{
				SetValue("AboutPageID", value);
			}
		}


		/// <summary>
		/// AboutUsContent.
		/// </summary>
		[DatabaseField]
		public string AboutUsContent
		{
			get
			{
				return ValidationHelper.GetString(GetValue("AboutUsContent"), @"");
			}
			set
			{
				SetValue("AboutUsContent", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with AboutPage fields.
		/// </summary>
		[RegisterProperty]
		public AboutPageFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with AboutPage fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class AboutPageFields : AbstractHierarchicalObject<AboutPageFields>
		{
			/// <summary>
			/// The content item of type AboutPage that is a target of the extended API.
			/// </summary>
			private readonly AboutPage mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="AboutPageFields" /> class with the specified content item of type AboutPage.
			/// </summary>
			/// <param name="instance">The content item of type AboutPage that is a target of the extended API.</param>
			public AboutPageFields(AboutPage instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// AboutPageID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.AboutPageID;
				}
				set
				{
					mInstance.AboutPageID = value;
				}
			}


			/// <summary>
			/// AboutUsContent.
			/// </summary>
			public string AboutUsContent
			{
				get
				{
					return mInstance.AboutUsContent;
				}
				set
				{
					mInstance.AboutUsContent = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="AboutPage" /> class.
		/// </summary>
		public AboutPage() : base(CLASS_NAME)
		{
			mFields = new AboutPageFields(this);
		}

		#endregion
	}
}