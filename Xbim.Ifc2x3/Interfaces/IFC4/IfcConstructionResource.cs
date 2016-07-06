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
namespace Xbim.Ifc2x3.ConstructionMgmtDomain
{
	public partial class @IfcConstructionResource : IIfcConstructionResource
	{

		private  IIfcResourceTime _usage;


		[CrossSchemaAttribute(typeof(IIfcConstructionResource), 8)]
		IIfcResourceTime IIfcConstructionResource.Usage 
		{ 
			get
			{
				return _usage;
			} 
			set
			{
				SetValue(v => _usage = v, _usage, value, "Usage", -8);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcConstructionResource), 9)]
		IItemSet<IIfcAppliedValue> IIfcConstructionResource.BaseCosts 
		{ 
			get
			{
				//## Handle return of BaseCosts for which no match was found
				return _baseCosts ?? (_baseCosts = new ItemSet<IIfcAppliedValue>(this, 0, byte.MaxValue));
			    //##
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcConstructionResource), 10)]
		IIfcPhysicalQuantity IIfcConstructionResource.BaseQuantity 
		{ 
			get
			{
				//## Handle return of BaseQuantity for which no match was found
			    return BaseQuantity.ToPhysicalSimpleQuantity();
				//##
			} 
			set
			{
				//## Handle setting of BaseQuantity for which no match was found
			    var val = value as QuantityResource.IfcPhysicalSimpleQuantity;
			    if (val == null)
			    {
			        BaseQuantity = null;
			        return;
			    }
			    BaseQuantity = Model.Instances.New<MeasureResource.IfcMeasureWithUnit>(m =>
			    {
			        m.UnitComponent = val.Unit;

			        var l = val as QuantityResource.IfcQuantityLength;
			        if (l != null)
			            m.ValueComponent = l.LengthValue;

			        var a = val as QuantityResource.IfcQuantityArea;
                    if (a != null)
                        m.ValueComponent = a.AreaValue;

                    var v = val as QuantityResource.IfcQuantityVolume;
                    if (v != null)
                        m.ValueComponent = v.VolumeValue;

                    var c = val as QuantityResource.IfcQuantityCount;
                    if (c != null)
                        m.ValueComponent = c.CountValue;

                    var w = val as QuantityResource.IfcQuantityWeight;
                    if (w != null)
                        m.ValueComponent = w.WeightValue;

                    var t = val as QuantityResource.IfcQuantityTime;
                    if (t != null)
                        m.ValueComponent = t.TimeValue;
			    });
				//##
				
			}
		}
	//## Custom code
	    private IItemSet<IIfcAppliedValue> _baseCosts;
	    //##
	}
}