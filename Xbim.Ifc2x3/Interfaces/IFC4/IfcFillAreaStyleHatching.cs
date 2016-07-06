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
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class @IfcFillAreaStyleHatching : IIfcFillAreaStyleHatching
	{

		[CrossSchemaAttribute(typeof(IIfcFillAreaStyleHatching), 1)]
		IIfcCurveStyle IIfcFillAreaStyleHatching.HatchLineAppearance 
		{ 
			get
			{
				return HatchLineAppearance;
			} 
			set
			{
				HatchLineAppearance = value as IfcCurveStyle;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcFillAreaStyleHatching), 2)]
		IIfcHatchLineDistanceSelect IIfcFillAreaStyleHatching.StartOfNextHatchLine 
		{ 
			get
			{
				if (StartOfNextHatchLine == null) return null;
				var ifconedirectionrepeatfactor = StartOfNextHatchLine as IfcOneDirectionRepeatFactor;
				if (ifconedirectionrepeatfactor != null) 
					//## Handle entity IfcOneDirectionRepeatFactor which is not a part of the target select interface IIfcHatchLineDistanceSelect in property StartOfNextHatchLine
			        return ifconedirectionrepeatfactor.RepeatFactor;
					//##
				if (StartOfNextHatchLine is MeasureResource.IfcPositiveLengthMeasure) 
					return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((MeasureResource.IfcPositiveLengthMeasure)StartOfNextHatchLine);
				return null;
			} 
			set
			{
				if (value == null)
				{
					StartOfNextHatchLine = null;
					return;
				}	
				var ifcvector = value as GeometryResource.IfcVector;
				if (ifcvector != null) 
				{
					//## Handle setting of entity IfcVector which is not a part of the target select interface IIfcHatchLineDistanceSelect in property StartOfNextHatchLine
				    StartOfNextHatchLine = Model.Instances.New<IfcOneDirectionRepeatFactor>(f => f.RepeatFactor = ifcvector);
				    return;
				    //##
				}
				if (value is Ifc4.MeasureResource.IfcPositiveLengthMeasure) 
				{
					StartOfNextHatchLine = new MeasureResource.IfcPositiveLengthMeasure((Ifc4.MeasureResource.IfcPositiveLengthMeasure)value);
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcFillAreaStyleHatching), 3)]
		IIfcCartesianPoint IIfcFillAreaStyleHatching.PointOfReferenceHatchLine 
		{ 
			get
			{
				return PointOfReferenceHatchLine;
			} 
			set
			{
				PointOfReferenceHatchLine = value as GeometryResource.IfcCartesianPoint;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcFillAreaStyleHatching), 4)]
		IIfcCartesianPoint IIfcFillAreaStyleHatching.PatternStart 
		{ 
			get
			{
				return PatternStart;
			} 
			set
			{
				PatternStart = value as GeometryResource.IfcCartesianPoint;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcFillAreaStyleHatching), 5)]
		Ifc4.MeasureResource.IfcPlaneAngleMeasure IIfcFillAreaStyleHatching.HatchLineAngle 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPlaneAngleMeasure(HatchLineAngle);
			} 
			set
			{
				HatchLineAngle = new MeasureResource.IfcPlaneAngleMeasure(value);
				
			}
		}
	//## Custom code
	//##
	}
}