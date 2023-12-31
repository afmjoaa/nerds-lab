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

[assembly: RegisterDocumentType(CareerItem.CLASS_NAME, typeof(CareerItem))]

namespace CMS.DocumentEngine.Types.NerdLab
{
	/// <summary>
	/// Represents a content item of type CareerItem.
	/// </summary>
	public partial class CareerItem : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "NerdLab.CareerItem";


		/// <summary>
		/// The instance of the class that provides extended API for working with CareerItem fields.
		/// </summary>
		private readonly CareerItemFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// CareerItemID.
		/// </summary>
		[DatabaseIDField]
		public int CareerItemID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("CareerItemID"), 0);
			}
			set
			{
				SetValue("CareerItemID", value);
			}
		}


		/// <summary>
		/// RibbonColor.
		/// </summary>
		[DatabaseField]
		public int RibbonColor
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("RibbonColor"), 0);
			}
			set
			{
				SetValue("RibbonColor", value);
			}
		}


		/// <summary>
		/// Title.
		/// </summary>
		[DatabaseField]
		public string Title
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Title"), @"");
			}
			set
			{
				SetValue("Title", value);
			}
		}


		/// <summary>
		/// Description.
		/// </summary>
		[DatabaseField]
		public string Description
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Description"), @"");
			}
			set
			{
				SetValue("Description", value);
			}
		}


		/// <summary>
		/// Responsibility.
		/// </summary>
		[DatabaseField]
		public string Responsibility
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Responsibility"), @"");
			}
			set
			{
				SetValue("Responsibility", value);
			}
		}


		/// <summary>
		/// TechStack.
		/// </summary>
		[DatabaseField]
		public string TechStack
		{
			get
			{
				return ValidationHelper.GetString(GetValue("TechStack"), @"");
			}
			set
			{
				SetValue("TechStack", value);
			}
		}


		/// <summary>
		/// Project.
		/// </summary>
		[DatabaseField]
		public string Project
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Project"), @"");
			}
			set
			{
				SetValue("Project", value);
			}
		}


		/// <summary>
		/// Experience.
		/// </summary>
		[DatabaseField]
		public string Experience
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Experience"), @"");
			}
			set
			{
				SetValue("Experience", value);
			}
		}


		/// <summary>
		/// Location.
		/// </summary>
		[DatabaseField]
		public string Location
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Location"), @"");
			}
			set
			{
				SetValue("Location", value);
			}
		}


		/// <summary>
		/// Compensation.
		/// </summary>
		[DatabaseField]
		public string Compensation
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Compensation"), @"");
			}
			set
			{
				SetValue("Compensation", value);
			}
		}


		/// <summary>
		/// ApplyText.
		/// </summary>
		[DatabaseField]
		public string ApplyText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ApplyText"), @"Apply");
			}
			set
			{
				SetValue("ApplyText", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with CareerItem fields.
		/// </summary>
		[RegisterProperty]
		public CareerItemFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with CareerItem fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class CareerItemFields : AbstractHierarchicalObject<CareerItemFields>
		{
			/// <summary>
			/// The content item of type CareerItem that is a target of the extended API.
			/// </summary>
			private readonly CareerItem mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="CareerItemFields" /> class with the specified content item of type CareerItem.
			/// </summary>
			/// <param name="instance">The content item of type CareerItem that is a target of the extended API.</param>
			public CareerItemFields(CareerItem instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// CareerItemID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.CareerItemID;
				}
				set
				{
					mInstance.CareerItemID = value;
				}
			}


			/// <summary>
			/// RibbonColor.
			/// </summary>
			public int RibbonColor
			{
				get
				{
					return mInstance.RibbonColor;
				}
				set
				{
					mInstance.RibbonColor = value;
				}
			}


			/// <summary>
			/// Title.
			/// </summary>
			public string Title
			{
				get
				{
					return mInstance.Title;
				}
				set
				{
					mInstance.Title = value;
				}
			}


			/// <summary>
			/// Description.
			/// </summary>
			public string Description
			{
				get
				{
					return mInstance.Description;
				}
				set
				{
					mInstance.Description = value;
				}
			}


			/// <summary>
			/// Responsibility.
			/// </summary>
			public string Responsibility
			{
				get
				{
					return mInstance.Responsibility;
				}
				set
				{
					mInstance.Responsibility = value;
				}
			}


			/// <summary>
			/// TechStack.
			/// </summary>
			public string TechStack
			{
				get
				{
					return mInstance.TechStack;
				}
				set
				{
					mInstance.TechStack = value;
				}
			}


			/// <summary>
			/// Project.
			/// </summary>
			public string Project
			{
				get
				{
					return mInstance.Project;
				}
				set
				{
					mInstance.Project = value;
				}
			}


			/// <summary>
			/// Experience.
			/// </summary>
			public string Experience
			{
				get
				{
					return mInstance.Experience;
				}
				set
				{
					mInstance.Experience = value;
				}
			}


			/// <summary>
			/// Location.
			/// </summary>
			public string Location
			{
				get
				{
					return mInstance.Location;
				}
				set
				{
					mInstance.Location = value;
				}
			}


			/// <summary>
			/// Compensation.
			/// </summary>
			public string Compensation
			{
				get
				{
					return mInstance.Compensation;
				}
				set
				{
					mInstance.Compensation = value;
				}
			}


			/// <summary>
			/// ApplyText.
			/// </summary>
			public string ApplyText
			{
				get
				{
					return mInstance.ApplyText;
				}
				set
				{
					mInstance.ApplyText = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="CareerItem" /> class.
		/// </summary>
		public CareerItem() : base(CLASS_NAME)
		{
			mFields = new CareerItemFields(this);
		}

		#endregion
	}
}