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
namespace Xbim.Ifc2x3.ElectricalDomain
{
	public partial class @IfcLampType : IIfcLampType
	{
		Ifc4.Interfaces.IfcLampTypeEnum IIfcLampType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcLampTypeEnum.COMPACTFLUORESCENT:
						return Ifc4.Interfaces.IfcLampTypeEnum.COMPACTFLUORESCENT;
					
					case IfcLampTypeEnum.FLUORESCENT:
						return Ifc4.Interfaces.IfcLampTypeEnum.FLUORESCENT;
					
					case IfcLampTypeEnum.HIGHPRESSUREMERCURY:
						return Ifc4.Interfaces.IfcLampTypeEnum.HIGHPRESSUREMERCURY;
					
					case IfcLampTypeEnum.HIGHPRESSURESODIUM:
						return Ifc4.Interfaces.IfcLampTypeEnum.HIGHPRESSURESODIUM;
					
					case IfcLampTypeEnum.METALHALIDE:
						return Ifc4.Interfaces.IfcLampTypeEnum.METALHALIDE;
					
					case IfcLampTypeEnum.TUNGSTENFILAMENT:
						return Ifc4.Interfaces.IfcLampTypeEnum.TUNGSTENFILAMENT;
					
					case IfcLampTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcLampTypeEnum.USERDEFINED;
					
					case IfcLampTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcLampTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	//## Custom code
	//##
	}
}