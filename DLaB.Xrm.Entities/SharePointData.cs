//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLaB.Xrm.Entities
{
	
	/// <summary>
	/// SharePoint's Data Corresponding to a user , Record , Location and Page
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sharepointdata")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public partial class SharePointData : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Data = "data";
			public const string IsValid = "isvalid";
			public const string Location = "location";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string NextPageToken = "nextpagetoken";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string PageNumber = "pagenumber";
			public const string PreviousPageToken = "previouspagetoken";
			public const string RegardingObjectId = "regardingobjectid";
			public const string SharePointDataId = "sharepointdataid";
			public const string Id = "sharepointdataid";
			public const string UserId = "userid";
			public const string lk_SharePointData_createdby = "lk_SharePointData_createdby";
			public const string lk_SharePointData_createdonbehalfby = "lk_SharePointData_createdonbehalfby";
			public const string lk_SharePointData_modifiedby = "lk_SharePointData_modifiedby";
			public const string lk_SharePointData_modifiedonbehalfby = "lk_SharePointData_modifiedonbehalfby";
			public const string lk_sharepointdata_user = "lk_sharepointdata_user";
			public const string organization_sharepointdata = "organization_sharepointdata";
			public const string sharepointdata_sharepointdocumentlocation = "sharepointdata_sharepointdocumentlocation";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SharePointData() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sharepointdata";
		
		public const int EntityTypeCode = 9509;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SharePoint Data.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedBy");
				this.SetAttributeValue("createdby", value);
				this.OnPropertyChanged("CreatedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the SharePoint Data was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOn");
				this.SetAttributeValue("createdon", value);
				this.OnPropertyChanged("CreatedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the SharePoint Data.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// SharePoint Data Serialized
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("data")]
		public string Data
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("data");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Data");
				this.SetAttributeValue("data", value);
				this.OnPropertyChanged("Data");
			}
		}
		
		/// <summary>
		/// Is valid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvalid")]
		public System.Nullable<bool> IsValid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isvalid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SharePoint Data.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("location")]
		public Microsoft.Xrm.Sdk.EntityReference Location
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("location");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SharePoint Data.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedBy");
				this.SetAttributeValue("modifiedby", value);
				this.OnPropertyChanged("ModifiedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the Sharepoint Data was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOn");
				this.SetAttributeValue("modifiedon", value);
				this.OnPropertyChanged("ModifiedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the SharePoint Data.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Next Page Token of the SharePoint document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nextpagetoken")]
		public string NextPageToken
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("nextpagetoken");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization associated with the SharePoint Data.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pagenumber")]
		public System.Nullable<int> PageNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("pagenumber");
			}
		}
		
		/// <summary>
		/// Previous Page Token of the SharePoint document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("previouspagetoken")]
		public string PreviousPageToken
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("previouspagetoken");
			}
		}
		
		/// <summary>
		/// Regarding Object Id.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		public string RegardingObjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("regardingobjectid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SharePoint data record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharepointdataid")]
		public System.Nullable<System.Guid> SharePointDataId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sharepointdataid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SharePointDataId");
				this.SetAttributeValue("sharepointdataid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SharePointDataId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharepointdataid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.SharePointDataId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SharePoint data.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userid")]
		public Microsoft.Xrm.Sdk.EntityReference UserId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("userid");
			}
		}
		
		/// <summary>
		/// N:1 lk_SharePointData_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SharePointData_createdby")]
		public Entities.SystemUser lk_SharePointData_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_SharePointData_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_SharePointData_createdby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_SharePointData_createdby", null, value);
				this.OnPropertyChanged("lk_SharePointData_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_SharePointData_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SharePointData_createdonbehalfby")]
		public Entities.SystemUser lk_SharePointData_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_SharePointData_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_SharePointData_createdonbehalfby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_SharePointData_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_SharePointData_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_SharePointData_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SharePointData_modifiedby")]
		public Entities.SystemUser lk_SharePointData_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_SharePointData_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_SharePointData_modifiedby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_SharePointData_modifiedby", null, value);
				this.OnPropertyChanged("lk_SharePointData_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_SharePointData_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SharePointData_modifiedonbehalfby")]
		public Entities.SystemUser lk_SharePointData_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_SharePointData_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_SharePointData_modifiedonbehalfby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_SharePointData_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_SharePointData_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_sharepointdata_user
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdata_user")]
		public Entities.SystemUser lk_sharepointdata_user
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_sharepointdata_user", null);
			}
		}
		
		/// <summary>
		/// N:1 organization_sharepointdata
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sharepointdata")]
		public Entities.Organization organization_sharepointdata
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.Organization>("organization_sharepointdata", null);
			}
		}
		
		/// <summary>
		/// N:1 sharepointdata_sharepointdocumentlocation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("location")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sharepointdata_sharepointdocumentlocation")]
		public Entities.SharePointDocumentLocation sharepointdata_sharepointdocumentlocation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SharePointDocumentLocation>("sharepointdata_sharepointdocumentlocation", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SharePointData(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["sharepointdataid"] = base.Id;
                        break;
                    case "sharepointdataid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}