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
	/// Entity for Topic Model Execution History
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("topicmodelexecutionhistory")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public partial class TopicModelExecutionHistory : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string ErrorDetails = "azuresyncerrormessage";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string FetchXmlList = "fetchxmllist";
			public const string IsTestExecution = "istestexecution";
			public const string MaxTopics = "maxtopics";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string NumberOfTopicsFound = "numberoftopicsfound";
			public const string OrganizationId = "organizationid";
			public const string RecordCorrelationId = "recordcorrelationid";
			public const string RecordsProcessed = "recordsprocessed";
			public const string StartTime = "starttime";
			public const string Status = "status";
			public const string StatusReason = "statusreason";
			public const string TopicModelConfigurationId = "topicmodelconfigurationid";
			public const string TopicModelExecutionHistoryId = "topicmodelexecutionhistoryid";
			public const string Id = "topicmodelexecutionhistoryid";
			public const string TopicModelId = "topicmodelid";
			public const string TotalTime = "totaltime";
			public const string lk_topicmodelexecutionhistory_createdby = "lk_topicmodelexecutionhistory_createdby";
			public const string lk_topicmodelexecutionhistory_createdonbehalfby = "lk_topicmodelexecutionhistory_createdonbehalfby";
			public const string lk_topicmodelexecutionhistory_modifiedby = "lk_topicmodelexecutionhistory_modifiedby";
			public const string lk_topicmodelexecutionhistory_modifiedonbehalfby = "lk_topicmodelexecutionhistory_modifiedonbehalfby";
			public const string organization_topicmodelexecutionhistory = "organization_topicmodelexecutionhistory";
			public const string topicmodel_topicmodelexecutionhistory = "topicmodel_topicmodelexecutionhistory";
			public const string topicmodelconfiguration_topicmodelexecutionhistory = "topicmodelconfiguration_topicmodelexecutionhistory";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public TopicModelExecutionHistory() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "topicmodelexecutionhistory";
		
		public const int EntityTypeCode = 9943;
		
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
		/// Detailed error message for the Topic Analysis process
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azuresyncerrormessage")]
		public string ErrorDetails
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("azuresyncerrormessage");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ErrorDetails");
				this.SetAttributeValue("azuresyncerrormessage", value);
				this.OnPropertyChanged("ErrorDetails");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the topic model execution history.
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
		/// Date and time when the topic model execution history was created.
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
		/// Unique identifier of the delegate user who created the topic model execution history.
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
		/// Fetch Xml
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fetchxmllist")]
		public string FetchXmlList
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("fetchxmllist");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FetchXmlList");
				this.SetAttributeValue("fetchxmllist", value);
				this.OnPropertyChanged("FetchXmlList");
			}
		}
		
		/// <summary>
		/// Allow model to check is test executed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("istestexecution")]
		public System.Nullable<bool> IsTestExecution
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("istestexecution");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsTestExecution");
				this.SetAttributeValue("istestexecution", value);
				this.OnPropertyChanged("IsTestExecution");
			}
		}
		
		/// <summary>
		/// Maximum number of Topics.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxtopics")]
		public System.Nullable<int> MaxTopics
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("maxtopics");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MaxTopics");
				this.SetAttributeValue("maxtopics", value);
				this.OnPropertyChanged("MaxTopics");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the topic model execution history.
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
		/// Date and time when the topic model execution history was last modified.
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
		/// Unique identifier of the delegate user who last modified the topic model execution history.
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
		/// Number of Topics Identified
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberoftopicsfound")]
		public System.Nullable<int> NumberOfTopicsFound
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("numberoftopicsfound");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("NumberOfTopicsFound");
				this.SetAttributeValue("numberoftopicsfound", value);
				this.OnPropertyChanged("NumberOfTopicsFound");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization associated with the topic model execution history.
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
		/// Record Correlation Id.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recordcorrelationid")]
		public string RecordCorrelationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("recordcorrelationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RecordCorrelationId");
				this.SetAttributeValue("recordcorrelationid", value);
				this.OnPropertyChanged("RecordCorrelationId");
			}
		}
		
		/// <summary>
		/// Number of Records Synchronized
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recordsprocessed")]
		public System.Nullable<int> RecordsProcessed
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("recordsprocessed");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RecordsProcessed");
				this.SetAttributeValue("recordsprocessed", value);
				this.OnPropertyChanged("RecordsProcessed");
			}
		}
		
		/// <summary>
		/// StartTime
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("starttime")]
		public System.Nullable<System.DateTime> StartTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("starttime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StartTime");
				this.SetAttributeValue("starttime", value);
				this.OnPropertyChanged("StartTime");
			}
		}
		
		/// <summary>
		/// Status
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("status")]
		public Microsoft.Xrm.Sdk.OptionSetValue Status
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("status");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Status");
				this.SetAttributeValue("status", value);
				this.OnPropertyChanged("Status");
			}
		}
		
		/// <summary>
		/// StatusReason
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statusreason")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusReason
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statusreason");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusReason");
				this.SetAttributeValue("statusreason", value);
				this.OnPropertyChanged("StatusReason");
			}
		}
		
		/// <summary>
		/// Unique identifier for Model associated with Topic Model Execution History.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("topicmodelconfigurationid")]
		public Microsoft.Xrm.Sdk.EntityReference TopicModelConfigurationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("topicmodelconfigurationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TopicModelConfigurationId");
				this.SetAttributeValue("topicmodelconfigurationid", value);
				this.OnPropertyChanged("TopicModelConfigurationId");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("topicmodelexecutionhistoryid")]
		public System.Nullable<System.Guid> TopicModelExecutionHistoryId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("topicmodelexecutionhistoryid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TopicModelExecutionHistoryId");
				this.SetAttributeValue("topicmodelexecutionhistoryid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("TopicModelExecutionHistoryId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("topicmodelexecutionhistoryid")]
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
				this.TopicModelExecutionHistoryId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier for Model associated with Topic Model Execution History.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("topicmodelid")]
		public Microsoft.Xrm.Sdk.EntityReference TopicModelId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("topicmodelid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TopicModelId");
				this.SetAttributeValue("topicmodelid", value);
				this.OnPropertyChanged("TopicModelId");
			}
		}
		
		/// <summary>
		/// Duration (in mins)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaltime")]
		public System.Nullable<int> TotalTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("totaltime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TotalTime");
				this.SetAttributeValue("totaltime", value);
				this.OnPropertyChanged("TotalTime");
			}
		}
		
		/// <summary>
		/// 1:N topicmodelexecutionhistory_topichistory
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("topicmodelexecutionhistory_topichistory")]
		public System.Collections.Generic.IEnumerable<Entities.TopicHistory> topicmodelexecutionhistory_topichistory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.TopicHistory>("topicmodelexecutionhistory_topichistory", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("topicmodelexecutionhistory_topichistory");
				this.SetRelatedEntities<Entities.TopicHistory>("topicmodelexecutionhistory_topichistory", null, value);
				this.OnPropertyChanged("topicmodelexecutionhistory_topichistory");
			}
		}
		
		/// <summary>
		/// N:1 lk_topicmodelexecutionhistory_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_topicmodelexecutionhistory_createdby")]
		public Entities.SystemUser lk_topicmodelexecutionhistory_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_topicmodelexecutionhistory_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_topicmodelexecutionhistory_createdby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_topicmodelexecutionhistory_createdby", null, value);
				this.OnPropertyChanged("lk_topicmodelexecutionhistory_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_topicmodelexecutionhistory_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_topicmodelexecutionhistory_createdonbehalfby")]
		public Entities.SystemUser lk_topicmodelexecutionhistory_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_topicmodelexecutionhistory_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_topicmodelexecutionhistory_createdonbehalfby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_topicmodelexecutionhistory_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_topicmodelexecutionhistory_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_topicmodelexecutionhistory_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_topicmodelexecutionhistory_modifiedby")]
		public Entities.SystemUser lk_topicmodelexecutionhistory_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_topicmodelexecutionhistory_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_topicmodelexecutionhistory_modifiedby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_topicmodelexecutionhistory_modifiedby", null, value);
				this.OnPropertyChanged("lk_topicmodelexecutionhistory_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_topicmodelexecutionhistory_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_topicmodelexecutionhistory_modifiedonbehalfby")]
		public Entities.SystemUser lk_topicmodelexecutionhistory_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_topicmodelexecutionhistory_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_topicmodelexecutionhistory_modifiedonbehalfby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_topicmodelexecutionhistory_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_topicmodelexecutionhistory_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_topicmodelexecutionhistory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_topicmodelexecutionhistory")]
		public Entities.Organization organization_topicmodelexecutionhistory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.Organization>("organization_topicmodelexecutionhistory", null);
			}
		}
		
		/// <summary>
		/// N:1 topicmodel_topicmodelexecutionhistory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("topicmodelid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("topicmodel_topicmodelexecutionhistory")]
		public Entities.TopicModel topicmodel_topicmodelexecutionhistory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.TopicModel>("topicmodel_topicmodelexecutionhistory", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("topicmodel_topicmodelexecutionhistory");
				this.SetRelatedEntity<Entities.TopicModel>("topicmodel_topicmodelexecutionhistory", null, value);
				this.OnPropertyChanged("topicmodel_topicmodelexecutionhistory");
			}
		}
		
		/// <summary>
		/// N:1 topicmodelconfiguration_topicmodelexecutionhistory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("topicmodelconfigurationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("topicmodelconfiguration_topicmodelexecutionhistory")]
		public Entities.TopicModelConfiguration topicmodelconfiguration_topicmodelexecutionhistory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.TopicModelConfiguration>("topicmodelconfiguration_topicmodelexecutionhistory", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("topicmodelconfiguration_topicmodelexecutionhistory");
				this.SetRelatedEntity<Entities.TopicModelConfiguration>("topicmodelconfiguration_topicmodelexecutionhistory", null, value);
				this.OnPropertyChanged("topicmodelconfiguration_topicmodelexecutionhistory");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public TopicModelExecutionHistory(object anonymousType) : 
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
                        Attributes["topicmodelexecutionhistoryid"] = base.Id;
                        break;
                    case "topicmodelexecutionhistoryid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("status")]
		public virtual TopicModelExecutionHistory_Status? StatusEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((TopicModelExecutionHistory_Status?)(EntityOptionSetEnum.GetEnum(this, "status")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				Status = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statusreason")]
		public virtual TopicModelExecutionHistory_StatusReason? StatusReasonEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((TopicModelExecutionHistory_StatusReason?)(EntityOptionSetEnum.GetEnum(this, "statusreason")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				StatusReason = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}