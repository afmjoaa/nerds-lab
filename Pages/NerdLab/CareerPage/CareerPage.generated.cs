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

[assembly: RegisterDocumentType(CareerPage.CLASS_NAME, typeof(CareerPage))]

namespace CMS.DocumentEngine.Types.NerdLab
{
	/// <summary>
	/// Represents a content item of type CareerPage.
	/// </summary>
	public partial class CareerPage : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "NerdLab.CareerPage";


		/// <summary>
		/// The instance of the class that provides extended API for working with CareerPage fields.
		/// </summary>
		private readonly CareerPageFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// CareerPageID.
		/// </summary>
		[DatabaseIDField]
		public int CareerPageID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("CareerPageID"), 0);
			}
			set
			{
				SetValue("CareerPageID", value);
			}
		}


		/// <summary>
		/// CareerContent.
		/// </summary>
		[DatabaseField]
		public string CareerContent
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CareerContent"), @"");
			}
			set
			{
				SetValue("CareerContent", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with CareerPage fields.
		/// </summary>
		[RegisterProperty]
		public CareerPageFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with CareerPage fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class CareerPageFields : AbstractHierarchicalObject<CareerPageFields>
		{
			/// <summary>
			/// The content item of type CareerPage that is a target of the extended API.
			/// </summary>
			private readonly CareerPage mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="CareerPageFields" /> class with the specified content item of type CareerPage.
			/// </summary>
			/// <param name="instance">The content item of type CareerPage that is a target of the extended API.</param>
			public CareerPageFields(CareerPage instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// CareerPageID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.CareerPageID;
				}
				set
				{
					mInstance.CareerPageID = value;
				}
			}


			/// <summary>
			/// CareerContent.
			/// </summary>
			public string CareerContent
			{
				get
				{
					return mInstance.CareerContent;
				}
				set
				{
					mInstance.CareerContent = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="CareerPage" /> class.
		/// </summary>
		public CareerPage() : base(CLASS_NAME)
		{
			mFields = new CareerPageFields(this);
		}

		#endregion
	}
}