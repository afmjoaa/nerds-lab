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

[assembly: RegisterDocumentType(ContactUsPage.CLASS_NAME, typeof(ContactUsPage))]

namespace CMS.DocumentEngine.Types.NerdLab
{
	/// <summary>
	/// Represents a content item of type ContactUsPage.
	/// </summary>
	public partial class ContactUsPage : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "NerdLab.ContactUsPage";


		/// <summary>
		/// The instance of the class that provides extended API for working with ContactUsPage fields.
		/// </summary>
		private readonly ContactUsPageFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// ContactUsPageID.
		/// </summary>
		[DatabaseIDField]
		public int ContactUsPageID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("ContactUsPageID"), 0);
			}
			set
			{
				SetValue("ContactUsPageID", value);
			}
		}


		/// <summary>
		/// ContactUsContent.
		/// </summary>
		[DatabaseField]
		public string ContactUsContent
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ContactUsContent"), @"");
			}
			set
			{
				SetValue("ContactUsContent", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with ContactUsPage fields.
		/// </summary>
		[RegisterProperty]
		public ContactUsPageFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with ContactUsPage fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class ContactUsPageFields : AbstractHierarchicalObject<ContactUsPageFields>
		{
			/// <summary>
			/// The content item of type ContactUsPage that is a target of the extended API.
			/// </summary>
			private readonly ContactUsPage mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="ContactUsPageFields" /> class with the specified content item of type ContactUsPage.
			/// </summary>
			/// <param name="instance">The content item of type ContactUsPage that is a target of the extended API.</param>
			public ContactUsPageFields(ContactUsPage instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// ContactUsPageID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.ContactUsPageID;
				}
				set
				{
					mInstance.ContactUsPageID = value;
				}
			}


			/// <summary>
			/// ContactUsContent.
			/// </summary>
			public string ContactUsContent
			{
				get
				{
					return mInstance.ContactUsContent;
				}
				set
				{
					mInstance.ContactUsContent = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="ContactUsPage" /> class.
		/// </summary>
		public ContactUsPage() : base(CLASS_NAME)
		{
			mFields = new ContactUsPageFields(this);
		}

		#endregion
	}
}