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
	public partial class @IfcCondenserType : IIfcCondenserType
	{
		Ifc4.Interfaces.IfcCondenserTypeEnum IIfcCondenserType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcCondenserTypeEnum.WATERCOOLEDSHELLTUBE:
						return Ifc4.Interfaces.IfcCondenserTypeEnum.WATERCOOLEDSHELLTUBE;
					
					case IfcCondenserTypeEnum.WATERCOOLEDSHELLCOIL:
						return Ifc4.Interfaces.IfcCondenserTypeEnum.WATERCOOLEDSHELLCOIL;
					
					case IfcCondenserTypeEnum.WATERCOOLEDTUBEINTUBE:
						return Ifc4.Interfaces.IfcCondenserTypeEnum.WATERCOOLEDTUBEINTUBE;
					
					case IfcCondenserTypeEnum.WATERCOOLEDBRAZEDPLATE:
						return Ifc4.Interfaces.IfcCondenserTypeEnum.WATERCOOLEDBRAZEDPLATE;
					
					case IfcCondenserTypeEnum.AIRCOOLED:
						return Ifc4.Interfaces.IfcCondenserTypeEnum.AIRCOOLED;
					
					case IfcCondenserTypeEnum.EVAPORATIVECOOLED:
						return Ifc4.Interfaces.IfcCondenserTypeEnum.EVAPORATIVECOOLED;
					
					case IfcCondenserTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcCondenserTypeEnum.USERDEFINED;
					
					case IfcCondenserTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCondenserTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	//## Custom code
	//##
	}
}