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
	/// Information about how to price a product in the specified price level, including pricing method, rounding option, and discount type based on a specified product unit.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("productpricelevel")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public partial class ProductPriceLevel : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string Amount = "amount";
			public const string Amount_Base = "amount_base";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string DiscountTypeId = "discounttypeid";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string Percentage = "percentage";
			public const string PriceLevelId = "pricelevelid";
			public const string PricingMethodCode = "pricingmethodcode";
			public const string ProcessId = "processid";
			public const string ProductId = "productid";
			public const string ProductNumber = "productnumber";
			public const string ProductPriceLevelId = "productpricelevelid";
			public const string Id = "productpricelevelid";
			public const string QuantitySellingCode = "quantitysellingcode";
			public const string RoundingOptionAmount = "roundingoptionamount";
			public const string RoundingOptionAmount_Base = "roundingoptionamount_base";
			public const string RoundingOptionCode = "roundingoptioncode";
			public const string RoundingPolicyCode = "roundingpolicycode";
			public const string StageId = "stageid";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string TraversedPath = "traversedpath";
			public const string UoMId = "uomid";
			public const string UoMScheduleId = "uomscheduleid";
			public const string VersionNumber = "versionnumber";
			public const string discount_type_product_price_levels = "discount_type_product_price_levels";
			public const string lk_productpricelevel_createdonbehalfby = "lk_productpricelevel_createdonbehalfby";
			public const string lk_productpricelevel_modifiedonbehalfby = "lk_productpricelevel_modifiedonbehalfby";
			public const string lk_productpricelevelbase_createdby = "lk_productpricelevelbase_createdby";
			public const string lk_productpricelevelbase_modifiedby = "lk_productpricelevelbase_modifiedby";
			public const string price_level_product_price_levels = "price_level_product_price_levels";
			public const string processstage_productpricelevels = "processstage_productpricelevels";
			public const string product_price_levels = "product_price_levels";
			public const string transactioncurrency_productpricelevel = "transactioncurrency_productpricelevel";
			public const string unit_of_measure_schedule_product_price_level = "unit_of_measure_schedule_product_price_level";
			public const string unit_of_measurement_product_price_levels = "unit_of_measurement_product_price_levels";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ProductPriceLevel() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "productpricelevel";
		
		public const int EntityTypeCode = 1026;
		
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
		/// Monetary amount for the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("amount")]
		public Microsoft.Xrm.Sdk.Money Amount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("amount");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Amount");
				this.SetAttributeValue("amount", value);
				this.OnPropertyChanged("Amount");
			}
		}
		
		/// <summary>
		/// Shows the Amount field converted to the system's default base currency, if specified as a fixed amount. The calculation uses the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("amount_base")]
		public Microsoft.Xrm.Sdk.Money Amount_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("amount_base");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the price list.
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
		/// Date and time when the price list was created.
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
		/// Unique identifier of the discount list associated with the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discounttypeid")]
		public Microsoft.Xrm.Sdk.EntityReference DiscountTypeId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("discounttypeid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DiscountTypeId");
				this.SetAttributeValue("discounttypeid", value);
				this.OnPropertyChanged("DiscountTypeId");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
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
		/// Unique identifier of the user who last modified the price list.
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
		/// Date and time when the price list was last modified.
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
		/// Shows who last updated the record on behalf of another user.
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
		/// Unique identifier of the organization associated with the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public System.Nullable<System.Guid> OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
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
		/// Percentage for the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("percentage")]
		public System.Nullable<decimal> Percentage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("percentage");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Percentage");
				this.SetAttributeValue("percentage", value);
				this.OnPropertyChanged("Percentage");
			}
		}
		
		/// <summary>
		/// Unique identifier of the price level associated with this price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
		public Microsoft.Xrm.Sdk.EntityReference PriceLevelId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("pricelevelid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PriceLevelId");
				this.SetAttributeValue("pricelevelid", value);
				this.OnPropertyChanged("PriceLevelId");
			}
		}
		
		/// <summary>
		/// Pricing method applied to the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricingmethodcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue PricingMethodCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("pricingmethodcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PricingMethodCode");
				this.SetAttributeValue("pricingmethodcode", value);
				this.OnPropertyChanged("PricingMethodCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the Process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		/// <summary>
		/// Product associated with the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
		public Microsoft.Xrm.Sdk.EntityReference ProductId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("productid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProductId");
				this.SetAttributeValue("productid", value);
				this.OnPropertyChanged("ProductId");
			}
		}
		
		/// <summary>
		/// User-defined product number.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productnumber")]
		public string ProductNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("productnumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productpricelevelid")]
		public System.Nullable<System.Guid> ProductPriceLevelId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("productpricelevelid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProductPriceLevelId");
				this.SetAttributeValue("productpricelevelid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ProductPriceLevelId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productpricelevelid")]
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
				this.ProductPriceLevelId = value;
			}
		}
		
		/// <summary>
		/// Quantity of the product that must be sold for a given price level.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantitysellingcode")]
		public Microsoft.Xrm.Sdk.OptionSetValue QuantitySellingCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("quantitysellingcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("QuantitySellingCode");
				this.SetAttributeValue("quantitysellingcode", value);
				this.OnPropertyChanged("QuantitySellingCode");
			}
		}
		
		/// <summary>
		/// Rounding option amount for the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roundingoptionamount")]
		public Microsoft.Xrm.Sdk.Money RoundingOptionAmount
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("roundingoptionamount");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RoundingOptionAmount");
				this.SetAttributeValue("roundingoptionamount", value);
				this.OnPropertyChanged("RoundingOptionAmount");
			}
		}
		
		/// <summary>
		/// Shows the Rounding Amount field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roundingoptionamount_base")]
		public Microsoft.Xrm.Sdk.Money RoundingOptionAmount_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("roundingoptionamount_base");
			}
		}
		
		/// <summary>
		/// Option for rounding the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roundingoptioncode")]
		public Microsoft.Xrm.Sdk.OptionSetValue RoundingOptionCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("roundingoptioncode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RoundingOptionCode");
				this.SetAttributeValue("roundingoptioncode", value);
				this.OnPropertyChanged("RoundingOptionCode");
			}
		}
		
		/// <summary>
		/// Policy for rounding the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roundingpolicycode")]
		public Microsoft.Xrm.Sdk.OptionSetValue RoundingPolicyCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("roundingpolicycode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RoundingPolicyCode");
				this.SetAttributeValue("roundingpolicycode", value);
				this.OnPropertyChanged("RoundingPolicyCode");
			}
		}
		
		/// <summary>
		/// Shows the ID of the stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
		
		/// <summary>
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
		
		/// <summary>
		/// Unique identifier of the unit for the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
		public Microsoft.Xrm.Sdk.EntityReference UoMId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uomid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UoMId");
				this.SetAttributeValue("uomid", value);
				this.OnPropertyChanged("UoMId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the unit schedule for the price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
		public Microsoft.Xrm.Sdk.EntityReference UoMScheduleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uomscheduleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UoMScheduleId");
				this.SetAttributeValue("uomscheduleid", value);
				this.OnPropertyChanged("UoMScheduleId");
			}
		}
		
		/// <summary>
		/// Version number of the price list.
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
		/// 1:N ProductPriceLevel_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductPriceLevel_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Entities.AsyncOperation> ProductPriceLevel_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.AsyncOperation>("ProductPriceLevel_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProductPriceLevel_AsyncOperations");
				this.SetRelatedEntities<Entities.AsyncOperation>("ProductPriceLevel_AsyncOperations", null, value);
				this.OnPropertyChanged("ProductPriceLevel_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N ProductPriceLevel_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductPriceLevel_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Entities.BulkDeleteFailure> ProductPriceLevel_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.BulkDeleteFailure>("ProductPriceLevel_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProductPriceLevel_BulkDeleteFailures");
				this.SetRelatedEntities<Entities.BulkDeleteFailure>("ProductPriceLevel_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("ProductPriceLevel_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N ProductPriceLevel_ProcessSessions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductPriceLevel_ProcessSessions")]
		public System.Collections.Generic.IEnumerable<Entities.ProcessSession> ProductPriceLevel_ProcessSessions
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.ProcessSession>("ProductPriceLevel_ProcessSessions", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProductPriceLevel_ProcessSessions");
				this.SetRelatedEntities<Entities.ProcessSession>("ProductPriceLevel_ProcessSessions", null, value);
				this.OnPropertyChanged("ProductPriceLevel_ProcessSessions");
			}
		}
		
		/// <summary>
		/// 1:N ProductPriceLevel_RecommendationCache_AdditionalDataRecordId
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductPriceLevel_RecommendationCache_AdditionalDataRecordId")]
		public System.Collections.Generic.IEnumerable<Entities.RecommendationCache> ProductPriceLevel_RecommendationCache_AdditionalDataRecordId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.RecommendationCache>("ProductPriceLevel_RecommendationCache_AdditionalDataRecordId", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProductPriceLevel_RecommendationCache_AdditionalDataRecordId");
				this.SetRelatedEntities<Entities.RecommendationCache>("ProductPriceLevel_RecommendationCache_AdditionalDataRecordId", null, value);
				this.OnPropertyChanged("ProductPriceLevel_RecommendationCache_AdditionalDataRecordId");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_productpricelevel
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_productpricelevel")]
		public System.Collections.Generic.IEnumerable<Entities.UserEntityInstanceData> userentityinstancedata_productpricelevel
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.UserEntityInstanceData>("userentityinstancedata_productpricelevel", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_productpricelevel");
				this.SetRelatedEntities<Entities.UserEntityInstanceData>("userentityinstancedata_productpricelevel", null, value);
				this.OnPropertyChanged("userentityinstancedata_productpricelevel");
			}
		}
		
		/// <summary>
		/// N:1 discount_type_product_price_levels
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discounttypeid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("discount_type_product_price_levels")]
		public Entities.DiscountType discount_type_product_price_levels
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.DiscountType>("discount_type_product_price_levels", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("discount_type_product_price_levels");
				this.SetRelatedEntity<Entities.DiscountType>("discount_type_product_price_levels", null, value);
				this.OnPropertyChanged("discount_type_product_price_levels");
			}
		}
		
		/// <summary>
		/// N:1 lk_productpricelevel_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevel_createdonbehalfby")]
		public Entities.SystemUser lk_productpricelevel_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_productpricelevel_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_productpricelevel_createdonbehalfby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_productpricelevel_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_productpricelevel_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_productpricelevel_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevel_modifiedonbehalfby")]
		public Entities.SystemUser lk_productpricelevel_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_productpricelevel_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_productpricelevel_modifiedonbehalfby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_productpricelevel_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_productpricelevel_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_productpricelevelbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevelbase_createdby")]
		public Entities.SystemUser lk_productpricelevelbase_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_productpricelevelbase_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_productpricelevelbase_createdby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_productpricelevelbase_createdby", null, value);
				this.OnPropertyChanged("lk_productpricelevelbase_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_productpricelevelbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevelbase_modifiedby")]
		public Entities.SystemUser lk_productpricelevelbase_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_productpricelevelbase_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_productpricelevelbase_modifiedby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_productpricelevelbase_modifiedby", null, value);
				this.OnPropertyChanged("lk_productpricelevelbase_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 price_level_product_price_levels
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_product_price_levels")]
		public Entities.PriceLevel price_level_product_price_levels
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.PriceLevel>("price_level_product_price_levels", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("price_level_product_price_levels");
				this.SetRelatedEntity<Entities.PriceLevel>("price_level_product_price_levels", null, value);
				this.OnPropertyChanged("price_level_product_price_levels");
			}
		}
		
		/// <summary>
		/// N:1 processstage_productpricelevels
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_productpricelevels")]
		public Entities.ProcessStage processstage_productpricelevels
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.ProcessStage>("processstage_productpricelevels", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_productpricelevels");
				this.SetRelatedEntity<Entities.ProcessStage>("processstage_productpricelevels", null, value);
				this.OnPropertyChanged("processstage_productpricelevels");
			}
		}
		
		/// <summary>
		/// N:1 product_price_levels
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_price_levels")]
		public Entities.Product product_price_levels
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.Product>("product_price_levels", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("product_price_levels");
				this.SetRelatedEntity<Entities.Product>("product_price_levels", null, value);
				this.OnPropertyChanged("product_price_levels");
			}
		}
		
		/// <summary>
		/// N:1 transactioncurrency_productpricelevel
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_productpricelevel")]
		public Entities.TransactionCurrency transactioncurrency_productpricelevel
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.TransactionCurrency>("transactioncurrency_productpricelevel", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("transactioncurrency_productpricelevel");
				this.SetRelatedEntity<Entities.TransactionCurrency>("transactioncurrency_productpricelevel", null, value);
				this.OnPropertyChanged("transactioncurrency_productpricelevel");
			}
		}
		
		/// <summary>
		/// N:1 unit_of_measure_schedule_product_price_level
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measure_schedule_product_price_level")]
		public Entities.UoMSchedule unit_of_measure_schedule_product_price_level
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.UoMSchedule>("unit_of_measure_schedule_product_price_level", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("unit_of_measure_schedule_product_price_level");
				this.SetRelatedEntity<Entities.UoMSchedule>("unit_of_measure_schedule_product_price_level", null, value);
				this.OnPropertyChanged("unit_of_measure_schedule_product_price_level");
			}
		}
		
		/// <summary>
		/// N:1 unit_of_measurement_product_price_levels
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_product_price_levels")]
		public Entities.UoM unit_of_measurement_product_price_levels
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.UoM>("unit_of_measurement_product_price_levels", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("unit_of_measurement_product_price_levels");
				this.SetRelatedEntity<Entities.UoM>("unit_of_measurement_product_price_levels", null, value);
				this.OnPropertyChanged("unit_of_measurement_product_price_levels");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ProductPriceLevel(object anonymousType) : 
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
                        Attributes["productpricelevelid"] = base.Id;
                        break;
                    case "productpricelevelid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricingmethodcode")]
		public virtual ProductPriceLevel_PricingMethodCode? PricingMethodCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ProductPriceLevel_PricingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "pricingmethodcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				PricingMethodCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantitysellingcode")]
		public virtual ProductPriceLevel_QuantitySellingCode? QuantitySellingCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ProductPriceLevel_QuantitySellingCode?)(EntityOptionSetEnum.GetEnum(this, "quantitysellingcode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				QuantitySellingCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roundingoptioncode")]
		public virtual ProductPriceLevel_RoundingOptionCode? RoundingOptionCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ProductPriceLevel_RoundingOptionCode?)(EntityOptionSetEnum.GetEnum(this, "roundingoptioncode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				RoundingOptionCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roundingpolicycode")]
		public virtual ProductPriceLevel_RoundingPolicyCode? RoundingPolicyCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ProductPriceLevel_RoundingPolicyCode?)(EntityOptionSetEnum.GetEnum(this, "roundingpolicycode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				RoundingPolicyCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}