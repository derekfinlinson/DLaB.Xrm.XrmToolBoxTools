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
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("recommendationmodelversionhistory")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public partial class RecommendationModelVersionHistory : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string ErrorDetails = "azuresyncerrormessage";
			public const string Duration = "duration";
			public const string EndTime = "endtime";
			public const string ErrorCount = "errorcount";
			public const string NumberRecordsSynchronized = "numberrecordssynchronized";
			public const string OrganizationId = "organizationid";
			public const string RecommendationModelVersionHistoryId = "recommendationmodelversionhistoryid";
			public const string Id = "recommendationmodelversionhistoryid";
			public const string RecommendationModelVersionId = "recommendationmodelversionid";
			public const string StartTime = "starttime";
			public const string WorkflowStep = "workflowstep";
			public const string WorkflowStepStatus = "workflowstepstatus";
			public const string organization_recommendationmodelversionhistory = "organization_recommendationmodelversionhistory";
			public const string recommendationmodelversion_recommendationmodelversionhistory = "recommendationmodelversion_recommendationmodelversionhistory";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public RecommendationModelVersionHistory() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "recommendationmodelversionhistory";
		
		public const int EntityTypeCode = 9937;
		
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
		/// Detailed error message for the Data Synchronization process
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
		/// Shows how long, in minutes, it took to finish the workflow step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duration")]
		public System.Nullable<int> Duration
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("duration");
			}
		}
		
		/// <summary>
		/// Shows the time when the step completed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("endtime")]
		public System.Nullable<System.DateTime> EndTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("endtime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EndTime");
				this.SetAttributeValue("endtime", value);
				this.OnPropertyChanged("EndTime");
			}
		}
		
		/// <summary>
		/// Shows the number of records the recommendation service rejected.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("errorcount")]
		public System.Nullable<int> ErrorCount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("errorcount");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ErrorCount");
				this.SetAttributeValue("errorcount", value);
				this.OnPropertyChanged("ErrorCount");
			}
		}
		
		/// <summary>
		/// Shows the number of records synchronized to the recommendation service.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberrecordssynchronized")]
		public System.Nullable<int> NumberRecordsSynchronized
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("numberrecordssynchronized");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("NumberRecordsSynchronized");
				this.SetAttributeValue("numberrecordssynchronized", value);
				this.OnPropertyChanged("NumberRecordsSynchronized");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization associated with the version execution history.
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
		/// Unique identifier for the version execution history
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recommendationmodelversionhistoryid")]
		public System.Nullable<System.Guid> RecommendationModelVersionHistoryId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("recommendationmodelversionhistoryid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RecommendationModelVersionHistoryId");
				this.SetAttributeValue("recommendationmodelversionhistoryid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("RecommendationModelVersionHistoryId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recommendationmodelversionhistoryid")]
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
				this.RecommendationModelVersionHistoryId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier for recommendation model associated with the version execution history.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recommendationmodelversionid")]
		public Microsoft.Xrm.Sdk.EntityReference RecommendationModelVersionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("recommendationmodelversionid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RecommendationModelVersionId");
				this.SetAttributeValue("recommendationmodelversionid", value);
				this.OnPropertyChanged("RecommendationModelVersionId");
			}
		}
		
		/// <summary>
		/// Shows the time when the step started.
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
		/// Shows the workflow step that was executed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowstep")]
		public Microsoft.Xrm.Sdk.OptionSetValue WorkflowStep
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("workflowstep");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("WorkflowStep");
				this.SetAttributeValue("workflowstep", value);
				this.OnPropertyChanged("WorkflowStep");
			}
		}
		
		/// <summary>
		/// Shows the status of the workflow step
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowstepstatus")]
		public Microsoft.Xrm.Sdk.OptionSetValue WorkflowStepStatus
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("workflowstepstatus");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("WorkflowStepStatus");
				this.SetAttributeValue("workflowstepstatus", value);
				this.OnPropertyChanged("WorkflowStepStatus");
			}
		}
		
		/// <summary>
		/// N:1 organization_recommendationmodelversionhistory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_recommendationmodelversionhistory")]
		public Entities.Organization organization_recommendationmodelversionhistory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.Organization>("organization_recommendationmodelversionhistory", null);
			}
		}
		
		/// <summary>
		/// N:1 recommendationmodelversion_recommendationmodelversionhistory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recommendationmodelversionid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recommendationmodelversion_recommendationmodelversionhistory")]
		public Entities.RecommendationModelVersion recommendationmodelversion_recommendationmodelversionhistory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.RecommendationModelVersion>("recommendationmodelversion_recommendationmodelversionhistory", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("recommendationmodelversion_recommendationmodelversionhistory");
				this.SetRelatedEntity<Entities.RecommendationModelVersion>("recommendationmodelversion_recommendationmodelversionhistory", null, value);
				this.OnPropertyChanged("recommendationmodelversion_recommendationmodelversionhistory");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public RecommendationModelVersionHistory(object anonymousType) : 
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
                        Attributes["recommendationmodelversionhistoryid"] = base.Id;
                        break;
                    case "recommendationmodelversionhistoryid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowstep")]
		public virtual RecommendationModelVersionHistory_WorkflowStep? WorkflowStepEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((RecommendationModelVersionHistory_WorkflowStep?)(EntityOptionSetEnum.GetEnum(this, "workflowstep")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				WorkflowStep = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowstepstatus")]
		public virtual RecommendationModelVersionHistory_WorkflowStepStatus? WorkflowStepStatusEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((RecommendationModelVersionHistory_WorkflowStepStatus?)(EntityOptionSetEnum.GetEnum(this, "workflowstepstatus")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				WorkflowStepStatus = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}