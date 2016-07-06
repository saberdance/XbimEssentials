// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.MaterialResource
{
	public partial class @IfcMaterialLayer : IIfcMaterialLayer
	{

		[CrossSchemaAttribute(typeof(IIfcMaterialLayer), 1)]
		IIfcMaterial IIfcMaterialLayer.Material 
		{ 
			get
			{
				return Material;
			} 
			set
			{
				Material = value as IfcMaterial;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcMaterialLayer), 2)]
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure IIfcMaterialLayer.LayerThickness 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcNonNegativeLengthMeasure(LayerThickness);
			} 
			set
			{
				LayerThickness = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcMaterialLayer), 3)]
		Ifc4.MeasureResource.IfcLogical? IIfcMaterialLayer.IsVentilated 
		{ 
			get
			{
				if (!IsVentilated.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLogical(IsVentilated.Value);
			} 
			set
			{
				IsVentilated = value.HasValue ? 
					new MeasureResource.IfcLogical(value.Value) :  
					 new MeasureResource.IfcLogical?() ;
				
			}
		}

		private  Ifc4.MeasureResource.IfcLabel? _name;


		[CrossSchemaAttribute(typeof(IIfcMaterialLayer), 4)]
		Ifc4.MeasureResource.IfcLabel? IIfcMaterialLayer.Name 
		{ 
			get
			{
				return _name;
			} 
			set
			{
				SetValue(v => _name = v, _name, value, "Name", -4);
				
			}
		}

		private  Ifc4.MeasureResource.IfcText? _description;


		[CrossSchemaAttribute(typeof(IIfcMaterialLayer), 5)]
		Ifc4.MeasureResource.IfcText? IIfcMaterialLayer.Description 
		{ 
			get
			{
				return _description;
			} 
			set
			{
				SetValue(v => _description = v, _description, value, "Description", -5);
				
			}
		}

		private  Ifc4.MeasureResource.IfcLabel? _category;


		[CrossSchemaAttribute(typeof(IIfcMaterialLayer), 6)]
		Ifc4.MeasureResource.IfcLabel? IIfcMaterialLayer.Category 
		{ 
			get
			{
				return _category;
			} 
			set
			{
				SetValue(v => _category = v, _category, value, "Category", -6);
				
			}
		}

		private  Ifc4.MeasureResource.IfcInteger? _priority;


		[CrossSchemaAttribute(typeof(IIfcMaterialLayer), 7)]
		Ifc4.MeasureResource.IfcInteger? IIfcMaterialLayer.Priority 
		{ 
			get
			{
				return _priority;
			} 
			set
			{
				SetValue(v => _priority = v, _priority, value, "Priority", -7);
				
			}
		}
		IIfcMaterialLayerSet IIfcMaterialLayer.ToMaterialLayerSet 
		{ 
			get
			{
				return Model.Instances.FirstOrDefault<IIfcMaterialLayerSet>(e => e.MaterialLayers != null &&  e.MaterialLayers.Contains(this), "MaterialLayers", this);
			} 
		}
		IEnumerable<IIfcRelAssociatesMaterial> IIfcMaterialDefinition.AssociatedTo 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociatesMaterial>(e => (e.RelatingMaterial as IfcMaterialLayer) == this, "RelatingMaterial", this);
			} 
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcMaterialDefinition.HasExternalReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
		IEnumerable<IIfcMaterialProperties> IIfcMaterialDefinition.HasProperties 
		{ 
			get
			{
				return Model.Instances.Where<IIfcMaterialProperties>(e => (e.Material as IfcMaterialLayer) == this, "Material", this);
			} 
		}
	//## Custom code
	//##
	}
}