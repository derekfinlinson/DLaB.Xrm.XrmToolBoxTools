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
	/// Relationship between a customer and a partner in which either can be an account or contact.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("customerrelationship")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public partial class CustomerRelationship : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string ConverseRelationshipId = "converserelationshipid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CustomerId = "customerid";
			public const string CustomerRelationshipId = "customerrelationshipid";
			public const string Id = "customerrelationshipid";
			public const string CustomerRoleDescription = "customerroledescription";
			public const string CustomerRoleId = "customerroleid";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string PartnerId = "partnerid";
			public const string PartnerRoleDescription = "partnerroledescription";
			public const string PartnerRoleId = "partnerroleid";
			public const string VersionNumber = "versionnumber";
			public const string account_customer_relationship_customer = "account_customer_relationship_customer";
			public const string account_customer_relationship_partner = "account_customer_relationship_partner";
			public const string business_unit_customer_relationship = "business_unit_customer_relationship";
			public const string contact_customer_relationship_customer = "contact_customer_relationship_customer";
			public const string contact_customer_relationship_partner = "contact_customer_relationship_partner";
			public const string createdby_customer_relationship = "createdby_customer_relationship";
			public const string createdonbehalfby_customer_relationship = "createdonbehalfby_customer_relationship";
			public const string Referencingcustomer_relationship_converse_relationship = "customer_relationship_converse_relationship";
			public const string modifiedby_customer_relationship = "modifiedby_customer_relationship";
			public const string modifiedonbehalfby_customer_relationship = "modifiedonbehalfby_customer_relationship";
			public const string relationship_role_customer_role = "relationship_role_customer_role";
			public const string relationship_role_partner_role = "relationship_role_partner_role";
			public const string team_customer_relationship = "team_customer_relationship";
			public const string user_customer_relationship = "user_customer_relationship";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public CustomerRelationship() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "customerrelationship";
		
		public const int EntityTypeCode = 4502;
		
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
		/// Unique identifier of the converse relationship of the customer relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("converserelationshipid")]
		public Microsoft.Xrm.Sdk.EntityReference ConverseRelationshipId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("converserelationshipid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConverseRelationshipId");
				this.SetAttributeValue("converserelationshipid", value);
				this.OnPropertyChanged("ConverseRelationshipId");
			}
		}
		
		/// <summary>
		/// Shows who created the record.
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
		/// Shows the date and time when the customer relationship was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
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
		/// Shows who created the record on behalf of another user.
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
		/// Select the primary account or contact involved in the customer relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		public Microsoft.Xrm.Sdk.EntityReference CustomerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("customerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CustomerId");
				this.SetAttributeValue("customerid", value);
				this.OnPropertyChanged("CustomerId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the customer relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerrelationshipid")]
		public System.Nullable<System.Guid> CustomerRelationshipId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("customerrelationshipid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CustomerRelationshipId");
				this.SetAttributeValue("customerrelationshipid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("CustomerRelationshipId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerrelationshipid")]
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
				this.CustomerRelationshipId = value;
			}
		}
		
		/// <summary>
		/// Type additional information about the primary party's role in the customer relationship, such as the length or quality of the relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerroledescription")]
		public string CustomerRoleDescription
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("customerroledescription");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CustomerRoleDescription");
				this.SetAttributeValue("customerroledescription", value);
				this.OnPropertyChanged("CustomerRoleDescription");
			}
		}
		
		/// <summary>
		/// Choose the primary party's role or nature of the relationship the customer has with the second party. The field is read-only until both parties have been selected. Administrators can configure role values under Business Management in the Settings area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerroleid")]
		public Microsoft.Xrm.Sdk.EntityReference CustomerRoleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("customerroleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CustomerRoleId");
				this.SetAttributeValue("customerroleid", value);
				this.OnPropertyChanged("CustomerRoleId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
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
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
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
		/// Shows who created the record on behalf of another user.
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
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the business unit that owns the customer relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningBusinessUnit");
				this.SetAttributeValue("owningbusinessunit", value);
				this.OnPropertyChanged("OwningBusinessUnit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the team who owns the customer relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningTeam");
				this.SetAttributeValue("owningteam", value);
				this.OnPropertyChanged("OwningTeam");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who owns the customer relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningUser");
				this.SetAttributeValue("owninguser", value);
				this.OnPropertyChanged("OwningUser");
			}
		}
		
		/// <summary>
		/// Select the secondary account or contact involved in the customer relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerid")]
		public Microsoft.Xrm.Sdk.EntityReference PartnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("partnerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PartnerId");
				this.SetAttributeValue("partnerid", value);
				this.OnPropertyChanged("PartnerId");
			}
		}
		
		/// <summary>
		/// Type additional information about the secondary party's role in the customer relationship, such as the length or quality of the relationship.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerroledescription")]
		public string PartnerRoleDescription
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("partnerroledescription");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PartnerRoleDescription");
				this.SetAttributeValue("partnerroledescription", value);
				this.OnPropertyChanged("PartnerRoleDescription");
			}
		}
		
		/// <summary>
		/// Choose the secondary party's role or nature of the relationship the customer has with the primary party. The field is read-only until both parties have been selected. Administrators can configure role values under Business Management in the Settings area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerroleid")]
		public Microsoft.Xrm.Sdk.EntityReference PartnerRoleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("partnerroleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PartnerRoleId");
				this.SetAttributeValue("partnerroleid", value);
				this.OnPropertyChanged("PartnerRoleId");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N customer_relationship_converse_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<Entities.CustomerRelationship> Referencedcustomer_relationship_converse_relationship
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.CustomerRelationship>("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencedcustomer_relationship_converse_relationship");
				this.SetRelatedEntities<Entities.CustomerRelationship>("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedcustomer_relationship_converse_relationship");
			}
		}
		
		/// <summary>
		/// 1:N CustomerRelationship_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerRelationship_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Entities.AsyncOperation> CustomerRelationship_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.AsyncOperation>("CustomerRelationship_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CustomerRelationship_AsyncOperations");
				this.SetRelatedEntities<Entities.AsyncOperation>("CustomerRelationship_AsyncOperations", null, value);
				this.OnPropertyChanged("CustomerRelationship_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N CustomerRelationship_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerRelationship_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Entities.BulkDeleteFailure> CustomerRelationship_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.BulkDeleteFailure>("CustomerRelationship_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CustomerRelationship_BulkDeleteFailures");
				this.SetRelatedEntities<Entities.BulkDeleteFailure>("CustomerRelationship_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("CustomerRelationship_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N CustomerRelationship_ProcessSessions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerRelationship_ProcessSessions")]
		public System.Collections.Generic.IEnumerable<Entities.ProcessSession> CustomerRelationship_ProcessSessions
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.ProcessSession>("CustomerRelationship_ProcessSessions", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CustomerRelationship_ProcessSessions");
				this.SetRelatedEntities<Entities.ProcessSession>("CustomerRelationship_ProcessSessions", null, value);
				this.OnPropertyChanged("CustomerRelationship_ProcessSessions");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_customerrelationship
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_customerrelationship")]
		public System.Collections.Generic.IEnumerable<Entities.UserEntityInstanceData> userentityinstancedata_customerrelationship
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.UserEntityInstanceData>("userentityinstancedata_customerrelationship", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_customerrelationship");
				this.SetRelatedEntities<Entities.UserEntityInstanceData>("userentityinstancedata_customerrelationship", null, value);
				this.OnPropertyChanged("userentityinstancedata_customerrelationship");
			}
		}
		
		/// <summary>
		/// N:1 account_customer_relationship_customer
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_customer_relationship_customer")]
		public Entities.Account account_customer_relationship_customer
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.Account>("account_customer_relationship_customer", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("account_customer_relationship_customer");
				this.SetRelatedEntity<Entities.Account>("account_customer_relationship_customer", null, value);
				this.OnPropertyChanged("account_customer_relationship_customer");
			}
		}
		
		/// <summary>
		/// N:1 account_customer_relationship_partner
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_customer_relationship_partner")]
		public Entities.Account account_customer_relationship_partner
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.Account>("account_customer_relationship_partner", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("account_customer_relationship_partner");
				this.SetRelatedEntity<Entities.Account>("account_customer_relationship_partner", null, value);
				this.OnPropertyChanged("account_customer_relationship_partner");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_customer_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_customer_relationship")]
		public Entities.BusinessUnit business_unit_customer_relationship
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.BusinessUnit>("business_unit_customer_relationship", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("business_unit_customer_relationship");
				this.SetRelatedEntity<Entities.BusinessUnit>("business_unit_customer_relationship", null, value);
				this.OnPropertyChanged("business_unit_customer_relationship");
			}
		}
		
		/// <summary>
		/// N:1 contact_customer_relationship_customer
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_relationship_customer")]
		public Entities.Contact contact_customer_relationship_customer
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.Contact>("contact_customer_relationship_customer", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("contact_customer_relationship_customer");
				this.SetRelatedEntity<Entities.Contact>("contact_customer_relationship_customer", null, value);
				this.OnPropertyChanged("contact_customer_relationship_customer");
			}
		}
		
		/// <summary>
		/// N:1 contact_customer_relationship_partner
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_relationship_partner")]
		public Entities.Contact contact_customer_relationship_partner
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.Contact>("contact_customer_relationship_partner", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("contact_customer_relationship_partner");
				this.SetRelatedEntity<Entities.Contact>("contact_customer_relationship_partner", null, value);
				this.OnPropertyChanged("contact_customer_relationship_partner");
			}
		}
		
		/// <summary>
		/// N:1 createdby_customer_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_customer_relationship")]
		public Entities.SystemUser createdby_customer_relationship
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("createdby_customer_relationship", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("createdby_customer_relationship");
				this.SetRelatedEntity<Entities.SystemUser>("createdby_customer_relationship", null, value);
				this.OnPropertyChanged("createdby_customer_relationship");
			}
		}
		
		/// <summary>
		/// N:1 createdonbehalfby_customer_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdonbehalfby_customer_relationship")]
		public Entities.SystemUser createdonbehalfby_customer_relationship
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("createdonbehalfby_customer_relationship", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("createdonbehalfby_customer_relationship");
				this.SetRelatedEntity<Entities.SystemUser>("createdonbehalfby_customer_relationship", null, value);
				this.OnPropertyChanged("createdonbehalfby_customer_relationship");
			}
		}
		
		/// <summary>
		/// N:1 customer_relationship_converse_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("converserelationshipid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public Entities.CustomerRelationship Referencingcustomer_relationship_converse_relationship
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.CustomerRelationship>("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencingcustomer_relationship_converse_relationship");
				this.SetRelatedEntity<Entities.CustomerRelationship>("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingcustomer_relationship_converse_relationship");
			}
		}
		
		/// <summary>
		/// N:1 modifiedby_customer_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_customer_relationship")]
		public Entities.SystemUser modifiedby_customer_relationship
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("modifiedby_customer_relationship", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("modifiedby_customer_relationship");
				this.SetRelatedEntity<Entities.SystemUser>("modifiedby_customer_relationship", null, value);
				this.OnPropertyChanged("modifiedby_customer_relationship");
			}
		}
		
		/// <summary>
		/// N:1 modifiedonbehalfby_customer_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedonbehalfby_customer_relationship")]
		public Entities.SystemUser modifiedonbehalfby_customer_relationship
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("modifiedonbehalfby_customer_relationship", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("modifiedonbehalfby_customer_relationship");
				this.SetRelatedEntity<Entities.SystemUser>("modifiedonbehalfby_customer_relationship", null, value);
				this.OnPropertyChanged("modifiedonbehalfby_customer_relationship");
			}
		}
		
		/// <summary>
		/// N:1 relationship_role_customer_role
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerroleid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationship_role_customer_role")]
		public Entities.RelationshipRole relationship_role_customer_role
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.RelationshipRole>("relationship_role_customer_role", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("relationship_role_customer_role");
				this.SetRelatedEntity<Entities.RelationshipRole>("relationship_role_customer_role", null, value);
				this.OnPropertyChanged("relationship_role_customer_role");
			}
		}
		
		/// <summary>
		/// N:1 relationship_role_partner_role
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerroleid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationship_role_partner_role")]
		public Entities.RelationshipRole relationship_role_partner_role
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.RelationshipRole>("relationship_role_partner_role", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("relationship_role_partner_role");
				this.SetRelatedEntity<Entities.RelationshipRole>("relationship_role_partner_role", null, value);
				this.OnPropertyChanged("relationship_role_partner_role");
			}
		}
		
		/// <summary>
		/// N:1 team_customer_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_customer_relationship")]
		public Entities.Team team_customer_relationship
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.Team>("team_customer_relationship", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("team_customer_relationship");
				this.SetRelatedEntity<Entities.Team>("team_customer_relationship", null, value);
				this.OnPropertyChanged("team_customer_relationship");
			}
		}
		
		/// <summary>
		/// N:1 user_customer_relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_customer_relationship")]
		public Entities.SystemUser user_customer_relationship
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("user_customer_relationship", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("user_customer_relationship");
				this.SetRelatedEntity<Entities.SystemUser>("user_customer_relationship", null, value);
				this.OnPropertyChanged("user_customer_relationship");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public CustomerRelationship(object anonymousType) : 
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
                        Attributes["customerrelationshipid"] = base.Id;
                        break;
                    case "customerrelationshipid":
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