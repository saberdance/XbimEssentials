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

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcPipeSegmentType : IIfcPipeSegmentType
	{
		Ifc4.Interfaces.IfcPipeSegmentTypeEnum IIfcPipeSegmentType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcPipeSegmentTypeEnum.FLEXIBLESEGMENT:
						return Ifc4.Interfaces.IfcPipeSegmentTypeEnum.FLEXIBLESEGMENT;
					
					case IfcPipeSegmentTypeEnum.RIGIDSEGMENT:
						return Ifc4.Interfaces.IfcPipeSegmentTypeEnum.RIGIDSEGMENT;
					
					case IfcPipeSegmentTypeEnum.GUTTER:
						return Ifc4.Interfaces.IfcPipeSegmentTypeEnum.GUTTER;
					
					case IfcPipeSegmentTypeEnum.SPOOL:
						return Ifc4.Interfaces.IfcPipeSegmentTypeEnum.SPOOL;
					
					case IfcPipeSegmentTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcPipeSegmentTypeEnum.USERDEFINED;
					
					case IfcPipeSegmentTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcPipeSegmentTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	//## Custom code
	//##
	}
}