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
	public partial class @IfcCurveStyle : IIfcCurveStyle
	{

		[CrossSchemaAttribute(typeof(IIfcCurveStyle), 2)]
		IIfcCurveFontOrScaledCurveFontSelect IIfcCurveStyle.CurveFont 
		{ 
			get
			{
				if (CurveFont == null) return null;
				var ifcpredefinedcurvefont = CurveFont as IfcPreDefinedCurveFont;
				if (ifcpredefinedcurvefont != null) 
					return ifcpredefinedcurvefont;
				var ifccurvestylefont = CurveFont as IfcCurveStyleFont;
				if (ifccurvestylefont != null) 
					return ifccurvestylefont;
				var ifccurvestylefontandscaling = CurveFont as IfcCurveStyleFontAndScaling;
				if (ifccurvestylefontandscaling != null) 
					return ifccurvestylefontandscaling;
				return null;
			} 
			set
			{
				if (value == null)
				{
					CurveFont = null;
					return;
				}	
				var ifccurvestylefont = value as IfcCurveStyleFont;
				if (ifccurvestylefont != null) 
				{
					CurveFont = ifccurvestylefont;
					return;
				}
				var ifccurvestylefontandscaling = value as IfcCurveStyleFontAndScaling;
				if (ifccurvestylefontandscaling != null) 
				{
					CurveFont = ifccurvestylefontandscaling;
					return;
				}
				var ifcpredefinedcurvefont = value as IfcPreDefinedCurveFont;
				if (ifcpredefinedcurvefont != null) 
				{
					CurveFont = ifcpredefinedcurvefont;
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCurveStyle), 3)]
		IIfcSizeSelect IIfcCurveStyle.CurveWidth 
		{ 
			get
			{
				if (CurveWidth == null) return null;
				if (CurveWidth is MeasureResource.IfcRatioMeasure) 
					return new Ifc4.MeasureResource.IfcRatioMeasure((MeasureResource.IfcRatioMeasure)CurveWidth);
				if (CurveWidth is MeasureResource.IfcLengthMeasure) 
					return new Ifc4.MeasureResource.IfcLengthMeasure((MeasureResource.IfcLengthMeasure)CurveWidth);
				if (CurveWidth is MeasureResource.IfcDescriptiveMeasure) 
					return new Ifc4.MeasureResource.IfcDescriptiveMeasure((MeasureResource.IfcDescriptiveMeasure)CurveWidth);
				if (CurveWidth is MeasureResource.IfcPositiveLengthMeasure) 
					return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((MeasureResource.IfcPositiveLengthMeasure)CurveWidth);
				if (CurveWidth is MeasureResource.IfcNormalisedRatioMeasure) 
					return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure((MeasureResource.IfcNormalisedRatioMeasure)CurveWidth);
				if (CurveWidth is MeasureResource.IfcPositiveRatioMeasure) 
					return new Ifc4.MeasureResource.IfcPositiveRatioMeasure((MeasureResource.IfcPositiveRatioMeasure)CurveWidth);
				return null;
			} 
			set
			{
				if (value == null)
				{
					CurveWidth = null;
					return;
				}	
				if (value is Ifc4.MeasureResource.IfcDescriptiveMeasure) 
				{
					CurveWidth = new MeasureResource.IfcDescriptiveMeasure((Ifc4.MeasureResource.IfcDescriptiveMeasure)value);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcLengthMeasure) 
				{
					CurveWidth = new MeasureResource.IfcLengthMeasure((Ifc4.MeasureResource.IfcLengthMeasure)value);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcNormalisedRatioMeasure) 
				{
					CurveWidth = new MeasureResource.IfcNormalisedRatioMeasure((Ifc4.MeasureResource.IfcNormalisedRatioMeasure)value);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcPositiveLengthMeasure) 
				{
					CurveWidth = new MeasureResource.IfcPositiveLengthMeasure((Ifc4.MeasureResource.IfcPositiveLengthMeasure)value);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcPositiveRatioMeasure) 
				{
					CurveWidth = new MeasureResource.IfcPositiveRatioMeasure((Ifc4.MeasureResource.IfcPositiveRatioMeasure)value);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcRatioMeasure) 
				{
					CurveWidth = new MeasureResource.IfcRatioMeasure((Ifc4.MeasureResource.IfcRatioMeasure)value);
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCurveStyle), 4)]
		IIfcColour IIfcCurveStyle.CurveColour 
		{ 
			get
			{
				if (CurveColour == null) return null;
				var ifccolourspecification = CurveColour as PresentationResource.IfcColourSpecification;
				if (ifccolourspecification != null) 
					return ifccolourspecification;
				var ifcpredefinedcolour = CurveColour as PresentationResource.IfcPreDefinedColour;
				if (ifcpredefinedcolour != null) 
					return ifcpredefinedcolour;
				return null;
			} 
			set
			{
				if (value == null)
				{
					CurveColour = null;
					return;
				}	
				var ifccolourspecification = value as PresentationResource.IfcColourSpecification;
				if (ifccolourspecification != null) 
				{
					CurveColour = ifccolourspecification;
					return;
				}
				var ifcpredefinedcolour = value as PresentationResource.IfcPreDefinedColour;
				if (ifcpredefinedcolour != null) 
				{
					CurveColour = ifcpredefinedcolour;
					return;
				}
				
			}
		}

		private  Ifc4.MeasureResource.IfcBoolean? _modelOrDraughting;


		[CrossSchemaAttribute(typeof(IIfcCurveStyle), 5)]
		Ifc4.MeasureResource.IfcBoolean? IIfcCurveStyle.ModelOrDraughting 
		{ 
			get
			{
				return _modelOrDraughting;
			} 
			set
			{
				SetValue(v => _modelOrDraughting = v, _modelOrDraughting, value, "ModelOrDraughting", -5);
				
			}
		}
	//## Custom code
	//##
	}
}