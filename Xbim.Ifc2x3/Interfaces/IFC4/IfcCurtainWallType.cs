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
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcCurtainWallType : IIfcCurtainWallType
	{
		Ifc4.Interfaces.IfcCurtainWallTypeEnum IIfcCurtainWallType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcCurtainWallTypeEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcCurtainWallTypeEnum.USERDEFINED;
					
					case IfcCurtainWallTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCurtainWallTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	//## Custom code
	//##
	}
}