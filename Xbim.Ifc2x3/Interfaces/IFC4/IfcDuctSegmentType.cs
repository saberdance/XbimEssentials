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
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcDuctSegmentType : IIfcDuctSegmentType
	{

		[CrossSchemaAttribute(typeof(IIfcDuctSegmentType), 10)]
		Ifc4.Interfaces.IfcDuctSegmentTypeEnum IIfcDuctSegmentType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcDuctSegmentTypeEnum.RIGIDSEGMENT:
						return Ifc4.Interfaces.IfcDuctSegmentTypeEnum.RIGIDSEGMENT;
					
					case IfcDuctSegmentTypeEnum.FLEXIBLESEGMENT:
						return Ifc4.Interfaces.IfcDuctSegmentTypeEnum.FLEXIBLESEGMENT;
					
					case IfcDuctSegmentTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcDuctSegmentTypeEnum.USERDEFINED;
					
					case IfcDuctSegmentTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDuctSegmentTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcDuctSegmentTypeEnum.RIGIDSEGMENT:
						PredefinedType = IfcDuctSegmentTypeEnum.RIGIDSEGMENT;
						return;
					
					case Ifc4.Interfaces.IfcDuctSegmentTypeEnum.FLEXIBLESEGMENT:
						PredefinedType = IfcDuctSegmentTypeEnum.FLEXIBLESEGMENT;
						return;
					
					case Ifc4.Interfaces.IfcDuctSegmentTypeEnum.USERDEFINED:
						PredefinedType = IfcDuctSegmentTypeEnum.USERDEFINED;
						return;
					
					case Ifc4.Interfaces.IfcDuctSegmentTypeEnum.NOTDEFINED:
						PredefinedType = IfcDuctSegmentTypeEnum.NOTDEFINED;
						return;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}