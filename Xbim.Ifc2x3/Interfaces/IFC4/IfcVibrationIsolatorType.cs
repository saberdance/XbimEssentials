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
	public partial class @IfcVibrationIsolatorType : IIfcVibrationIsolatorType
	{
		Ifc4.Interfaces.IfcVibrationIsolatorTypeEnum IIfcVibrationIsolatorType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcVibrationIsolatorTypeEnum.COMPRESSION:
						return Ifc4.Interfaces.IfcVibrationIsolatorTypeEnum.COMPRESSION;
					
					case IfcVibrationIsolatorTypeEnum.SPRING:
						return Ifc4.Interfaces.IfcVibrationIsolatorTypeEnum.SPRING;
					
					case IfcVibrationIsolatorTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcVibrationIsolatorTypeEnum.USERDEFINED;
					
					case IfcVibrationIsolatorTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcVibrationIsolatorTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	//## Custom code
	//##
	}
}