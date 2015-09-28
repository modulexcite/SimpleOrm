﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;
namespace Company.OrmLanguage
{
	/// <summary>
	/// DomainModel OrmLanguageDomainModel
	/// Description for Company.OrmLanguage.OrmLanguage
	/// </summary>
	[DslDesign::DisplayNameResource("Company.OrmLanguage.OrmLanguageDomainModel.DisplayName", typeof(global::Company.OrmLanguage.OrmLanguageDomainModel), "Company.OrmLanguage.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Company.OrmLanguage.OrmLanguageDomainModel.Description", typeof(global::Company.OrmLanguage.OrmLanguageDomainModel), "Company.OrmLanguage.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.CoreDomainModel))]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.Diagrams.CoreDesignSurfaceDomainModel))]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
	[DslModeling::DomainObjectId("3418fb30-d41c-496d-9cb7-5c76ba66620c")]
	public partial class OrmLanguageDomainModel : DslModeling::DomainModel
	{
		#region Constructor, domain model Id
	
		/// <summary>
		/// OrmLanguageDomainModel domain model Id.
		/// </summary>
		public static readonly global::System.Guid DomainModelId = new global::System.Guid(0x3418fb30, 0xd41c, 0x496d, 0x9c, 0xb7, 0x5c, 0x76, 0xba, 0x66, 0x62, 0x0c);
	
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="store">Store containing the domain model.</param>
		public OrmLanguageDomainModel(DslModeling::Store store)
			: base(store, DomainModelId)
		{
			// Call the partial method to allow any required serialization setup to be done.
			this.InitializeSerialization(store);		
		}
		
	
		///<Summary>
		/// Defines a partial method that will be called from the constructor to
		/// allow any necessary serialization setup to be done.
		///</Summary>
		///<remarks>
		/// For a DSL created with the DSL Designer wizard, an implementation of this 
		/// method will be generated in the GeneratedCode\SerializationHelper.cs class.
		///</remarks>
		partial void InitializeSerialization(DslModeling::Store store);
	
	
		#endregion
		#region Domain model reflection
			
		/// <summary>
		/// Gets the list of generated domain model types (classes, rules, relationships).
		/// </summary>
		/// <returns>List of types.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override global::System.Type[] GetGeneratedDomainModelTypes()
		{
			return new global::System.Type[]
			{
				typeof(SampleOrmModel),
				typeof(EntityElement),
				typeof(Entry),
				typeof(Property),
				typeof(Reference),
				typeof(SampleOrmModelHasElements),
				typeof(EntityHasRelationShips),
				typeof(EntityHasProperties),
				typeof(EntityHasReferences),
				typeof(OrmLanguageDiagram),
				typeof(EntityHasRelationShipsConnector),
				typeof(EntityShape),
				typeof(global::Company.OrmLanguage.FixUpDiagram),
				typeof(global::Company.OrmLanguage.ConnectorRolePlayerChanged),
				typeof(global::Company.OrmLanguage.CompartmentItemAddRule),
				typeof(global::Company.OrmLanguage.CompartmentItemDeleteRule),
				typeof(global::Company.OrmLanguage.CompartmentItemRolePlayerChangeRule),
				typeof(global::Company.OrmLanguage.CompartmentItemRolePlayerPositionChangeRule),
				typeof(global::Company.OrmLanguage.CompartmentItemChangeRule),
			};
		}
		/// <summary>
		/// Gets the list of generated domain properties.
		/// </summary>
		/// <returns>List of property data.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override DomainMemberInfo[] GetGeneratedDomainProperties()
		{
			return new DomainMemberInfo[]
			{
				new DomainMemberInfo(typeof(EntityElement), "Name", EntityElement.NameDomainPropertyId, typeof(EntityElement.NamePropertyHandler)),
				new DomainMemberInfo(typeof(EntityElement), "TableName", EntityElement.TableNameDomainPropertyId, typeof(EntityElement.TableNamePropertyHandler)),
				new DomainMemberInfo(typeof(Entry), "Name", Entry.NameDomainPropertyId, typeof(Entry.NamePropertyHandler)),
				new DomainMemberInfo(typeof(Entry), "Guid", Entry.GuidDomainPropertyId, typeof(Entry.GuidPropertyHandler)),
				new DomainMemberInfo(typeof(Entry), "Type", Entry.TypeDomainPropertyId, typeof(Entry.TypePropertyHandler)),
				new DomainMemberInfo(typeof(Property), "ColumnName", Property.ColumnNameDomainPropertyId, typeof(Property.ColumnNamePropertyHandler)),
				new DomainMemberInfo(typeof(EntityHasRelationShips), "fromProperty", EntityHasRelationShips.fromPropertyDomainPropertyId, typeof(EntityHasRelationShips.fromPropertyPropertyHandler)),
				new DomainMemberInfo(typeof(EntityHasRelationShips), "toProperty", EntityHasRelationShips.toPropertyDomainPropertyId, typeof(EntityHasRelationShips.toPropertyPropertyHandler)),
				new DomainMemberInfo(typeof(EntityHasRelationShips), "fromPropertyName", EntityHasRelationShips.fromPropertyNameDomainPropertyId, typeof(EntityHasRelationShips.fromPropertyNamePropertyHandler)),
				new DomainMemberInfo(typeof(EntityHasRelationShips), "toPropertyName", EntityHasRelationShips.toPropertyNameDomainPropertyId, typeof(EntityHasRelationShips.toPropertyNamePropertyHandler)),
			};
		}
		/// <summary>
		/// Gets the list of generated domain roles.
		/// </summary>
		/// <returns>List of role data.</returns>
		protected sealed override DomainRolePlayerInfo[] GetGeneratedDomainRoles()
		{
			return new DomainRolePlayerInfo[]
			{
				new DomainRolePlayerInfo(typeof(SampleOrmModelHasElements), "SampleOrmModel", SampleOrmModelHasElements.SampleOrmModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(SampleOrmModelHasElements), "Element", SampleOrmModelHasElements.ElementDomainRoleId),
				new DomainRolePlayerInfo(typeof(EntityHasRelationShips), "SourceEntityElement", EntityHasRelationShips.SourceEntityElementDomainRoleId),
				new DomainRolePlayerInfo(typeof(EntityHasRelationShips), "TargetEntityElement", EntityHasRelationShips.TargetEntityElementDomainRoleId),
				new DomainRolePlayerInfo(typeof(EntityHasProperties), "EntityElement", EntityHasProperties.EntityElementDomainRoleId),
				new DomainRolePlayerInfo(typeof(EntityHasProperties), "Property", EntityHasProperties.PropertyDomainRoleId),
				new DomainRolePlayerInfo(typeof(EntityHasReferences), "EntityElement", EntityHasReferences.EntityElementDomainRoleId),
				new DomainRolePlayerInfo(typeof(EntityHasReferences), "Reference", EntityHasReferences.ReferenceDomainRoleId),
			};
		}
		#endregion
		#region Factory methods
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementMap;
	
		/// <summary>
		/// Creates an element of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementType">Element type which belongs to this domain model.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		public sealed override DslModeling::ModelElement CreateElement(DslModeling::Partition partition, global::System.Type elementType, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementType == null) throw new global::System.ArgumentNullException("elementType");
	
			if (createElementMap == null)
			{
				createElementMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(8);
				createElementMap.Add(typeof(SampleOrmModel), 0);
				createElementMap.Add(typeof(EntityElement), 1);
				createElementMap.Add(typeof(Property), 2);
				createElementMap.Add(typeof(Reference), 3);
				createElementMap.Add(typeof(OrmLanguageDiagram), 4);
				createElementMap.Add(typeof(EntityHasRelationShipsConnector), 5);
				createElementMap.Add(typeof(EntityShape), 6);
			}
			int index;
			if (!createElementMap.TryGetValue(elementType, out index))
			{
				// construct exception error message		
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::Company.OrmLanguage.OrmLanguageDomainModel.SingletonResourceManager.GetString("UnrecognizedElementType"),
								elementType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementType");
			}
			switch (index)
			{
				case 0: return new SampleOrmModel(partition, propertyAssignments);
				case 1: return new EntityElement(partition, propertyAssignments);
				case 2: return new Property(partition, propertyAssignments);
				case 3: return new Reference(partition, propertyAssignments);
				case 4: return new OrmLanguageDiagram(partition, propertyAssignments);
				case 5: return new EntityHasRelationShipsConnector(partition, propertyAssignments);
				case 6: return new EntityShape(partition, propertyAssignments);
				default: return null;
			}
		}
	
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementLinkMap;
	
		/// <summary>
		/// Creates an element link of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementLinkType">Element link type which belongs to this domain model.</param>
		/// <param name="roleAssignments">List of relationship role assignments for the new link.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element link.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		public sealed override DslModeling::ElementLink CreateElementLink(DslModeling::Partition partition, global::System.Type elementLinkType, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementLinkType == null) throw new global::System.ArgumentNullException("elementLinkType");
			if (roleAssignments == null) throw new global::System.ArgumentNullException("roleAssignments");
	
			if (createElementLinkMap == null)
			{
				createElementLinkMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(4);
				createElementLinkMap.Add(typeof(SampleOrmModelHasElements), 0);
				createElementLinkMap.Add(typeof(EntityHasRelationShips), 1);
				createElementLinkMap.Add(typeof(EntityHasProperties), 2);
				createElementLinkMap.Add(typeof(EntityHasReferences), 3);
			}
			int index;
			if (!createElementLinkMap.TryGetValue(elementLinkType, out index))
			{
				// construct exception error message
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::Company.OrmLanguage.OrmLanguageDomainModel.SingletonResourceManager.GetString("UnrecognizedElementLinkType"),
								elementLinkType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementLinkType");
			
			}
			switch (index)
			{
				case 0: return new SampleOrmModelHasElements(partition, roleAssignments, propertyAssignments);
				case 1: return new EntityHasRelationShips(partition, roleAssignments, propertyAssignments);
				case 2: return new EntityHasProperties(partition, roleAssignments, propertyAssignments);
				case 3: return new EntityHasReferences(partition, roleAssignments, propertyAssignments);
				default: return null;
			}
		}
		#endregion
		#region Resource manager
		
		private static global::System.Resources.ResourceManager resourceManager;
		
		/// <summary>
		/// The base name of this model's resources.
		/// </summary>
		public const string ResourceBaseName = "Company.OrmLanguage.GeneratedCode.DomainModelResx";
		
		/// <summary>
		/// Gets the DomainModel's ResourceManager. If the ResourceManager does not already exist, then it is created.
		/// </summary>
		public override global::System.Resources.ResourceManager ResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return OrmLanguageDomainModel.SingletonResourceManager;
			}
		}
	
		/// <summary>
		/// Gets the Singleton ResourceManager for this domain model.
		/// </summary>
		public static global::System.Resources.ResourceManager SingletonResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				if (OrmLanguageDomainModel.resourceManager == null)
				{
					OrmLanguageDomainModel.resourceManager = new global::System.Resources.ResourceManager(ResourceBaseName, typeof(OrmLanguageDomainModel).Assembly);
				}
				return OrmLanguageDomainModel.resourceManager;
			}
		}
		#endregion
		#region Copy/Remove closures
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter copyClosure;
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter removeClosure;
		/// <summary>
		/// Returns an IElementVisitorFilter that corresponds to the ClosureType.
		/// </summary>
		/// <param name="type">closure type</param>
		/// <param name="rootElements">collection of root elements</param>
		/// <returns>IElementVisitorFilter or null</returns>
		public override DslModeling::IElementVisitorFilter GetClosureFilter(DslModeling::ClosureType type, global::System.Collections.Generic.ICollection<DslModeling::ModelElement> rootElements)
		{
			switch (type)
			{
				case DslModeling::ClosureType.CopyClosure:
					return OrmLanguageDomainModel.CopyClosure;
				case DslModeling::ClosureType.DeleteClosure:
					return OrmLanguageDomainModel.DeleteClosure;
			}
			return base.GetClosureFilter(type, rootElements);
		}
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter CopyClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (OrmLanguageDomainModel.copyClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter copyFilter = new DslModeling::ChainingElementVisitorFilter();
					copyFilter.AddFilter(new OrmLanguageCopyClosure());
					copyFilter.AddFilter(new DslModeling::CoreCopyClosure());
					copyFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceCopyClosure());
					
					OrmLanguageDomainModel.copyClosure = copyFilter;
				}
				return OrmLanguageDomainModel.copyClosure;
			}
		}
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter DeleteClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (OrmLanguageDomainModel.removeClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter removeFilter = new DslModeling::ChainingElementVisitorFilter();
					removeFilter.AddFilter(new OrmLanguageDeleteClosure());
					removeFilter.AddFilter(new DslModeling::CoreDeleteClosure());
					removeFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceDeleteClosure());
		
					OrmLanguageDomainModel.removeClosure = removeFilter;
				}
				return OrmLanguageDomainModel.removeClosure;
			}
		}
		#endregion
		#region Diagram rule helpers
		/// <summary>
		/// Enables rules in this domain model related to diagram fixup for the given store.
		/// If diagram data will be loaded into the store, this method should be called first to ensure
		/// that the diagram behaves properly.
		/// </summary>
		public static void EnableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.EnableRule(typeof(global::Company.OrmLanguage.FixUpDiagram));
			ruleManager.EnableRule(typeof(global::Company.OrmLanguage.ConnectorRolePlayerChanged));
			ruleManager.EnableRule(typeof(global::Company.OrmLanguage.CompartmentItemAddRule));
			ruleManager.EnableRule(typeof(global::Company.OrmLanguage.CompartmentItemDeleteRule));
			ruleManager.EnableRule(typeof(global::Company.OrmLanguage.CompartmentItemRolePlayerChangeRule));
			ruleManager.EnableRule(typeof(global::Company.OrmLanguage.CompartmentItemRolePlayerPositionChangeRule));
			ruleManager.EnableRule(typeof(global::Company.OrmLanguage.CompartmentItemChangeRule));
		}
		
		/// <summary>
		/// Disables rules in this domain model related to diagram fixup for the given store.
		/// </summary>
		public static void DisableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.DisableRule(typeof(global::Company.OrmLanguage.FixUpDiagram));
			ruleManager.DisableRule(typeof(global::Company.OrmLanguage.ConnectorRolePlayerChanged));
			ruleManager.DisableRule(typeof(global::Company.OrmLanguage.CompartmentItemAddRule));
			ruleManager.DisableRule(typeof(global::Company.OrmLanguage.CompartmentItemDeleteRule));
			ruleManager.DisableRule(typeof(global::Company.OrmLanguage.CompartmentItemRolePlayerChangeRule));
			ruleManager.DisableRule(typeof(global::Company.OrmLanguage.CompartmentItemRolePlayerPositionChangeRule));
			ruleManager.DisableRule(typeof(global::Company.OrmLanguage.CompartmentItemChangeRule));
		}
		#endregion
	}
		
	#region Copy/Remove closure classes
	/// <summary>
	/// Remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class OrmLanguageDeleteClosure : OrmLanguageDeleteClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public OrmLanguageDeleteClosure() : base()
		{
		}
	}
	
	/// <summary>
	/// Base class for remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class OrmLanguageDeleteClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public OrmLanguageDeleteClosureBase()
		{
			#region Initialize DomainData Table
			DomainRoles.Add(global::Company.OrmLanguage.SampleOrmModelHasElements.ElementDomainRoleId, true);
			DomainRoles.Add(global::Company.OrmLanguage.EntityHasProperties.PropertyDomainRoleId, true);
			DomainRoles.Add(global::Company.OrmLanguage.EntityHasReferences.ReferenceDomainRoleId, true);
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			return DslModeling::VisitorFilterResult.Yes;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			if (targetDomainRole == null) throw new global::System.ArgumentNullException("targetDomainRole");
			return this.DomainRoles.Contains(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary DomainRoles
		{
			get
			{
				if (this.domainRoles == null)
				{
					this.domainRoles = new global::System.Collections.Specialized.HybridDictionary();
				}
				return this.domainRoles;
			}
		}
	
	}
	/// <summary>
	/// Copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class OrmLanguageCopyClosure : OrmLanguageCopyClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public OrmLanguageCopyClosure() : base()
		{
		}
	}
	/// <summary>
	/// Base class for copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class OrmLanguageCopyClosureBase : DslModeling::CopyClosureFilter, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public OrmLanguageCopyClosureBase():base()
		{
		}
	}
	#endregion
		
}

