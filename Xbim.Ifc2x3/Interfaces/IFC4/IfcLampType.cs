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
namespace Xbim.Ifc2x3.ElectricalDomain
{
	public partial class @IfcLampType : IIfcLampType
	{

		[CrossSchemaAttribute(typeof(IIfcLampType), 10)]
		Ifc4.Interfaces.IfcLampTypeEnum IIfcLampType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
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
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
                        if (ElementType.HasValue)
                        {
                            Ifc4.Interfaces.IfcLampTypeEnum result;
                            if (System.Enum.TryParse(ElementType.Value, false, out result))
                                return result;
                        }
						//##
						return Ifc4.Interfaces.IfcLampTypeEnum.USERDEFINED;
					
					case IfcLampTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcLampTypeEnum.NOTDEFINED;
					
					
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
					case Ifc4.Interfaces.IfcLampTypeEnum.COMPACTFLUORESCENT:
						PredefinedType = IfcLampTypeEnum.COMPACTFLUORESCENT;
						return;
					
					case Ifc4.Interfaces.IfcLampTypeEnum.FLUORESCENT:
						PredefinedType = IfcLampTypeEnum.FLUORESCENT;
						return;
					
					case Ifc4.Interfaces.IfcLampTypeEnum.HALOGEN:
						//## Handle setting of HALOGEN member from IfcLampTypeEnum in property PredefinedType
						ElementType = value.ToString();
                        PredefinedType = IfcLampTypeEnum.USERDEFINED;
				        return;
						//##
										
					case Ifc4.Interfaces.IfcLampTypeEnum.HIGHPRESSUREMERCURY:
						PredefinedType = IfcLampTypeEnum.HIGHPRESSUREMERCURY;
						return;
					
					case Ifc4.Interfaces.IfcLampTypeEnum.HIGHPRESSURESODIUM:
						PredefinedType = IfcLampTypeEnum.HIGHPRESSURESODIUM;
						return;
					
					case Ifc4.Interfaces.IfcLampTypeEnum.LED:
						//## Handle setting of LED member from IfcLampTypeEnum in property PredefinedType
						ElementType = value.ToString();
                        PredefinedType = IfcLampTypeEnum.USERDEFINED;
				        return;
						//##
										
					case Ifc4.Interfaces.IfcLampTypeEnum.METALHALIDE:
						PredefinedType = IfcLampTypeEnum.METALHALIDE;
						return;
					
					case Ifc4.Interfaces.IfcLampTypeEnum.OLED:
						//## Handle setting of OLED member from IfcLampTypeEnum in property PredefinedType
						ElementType = value.ToString();
                        PredefinedType = IfcLampTypeEnum.USERDEFINED;
				        return;
						//##
										
					case Ifc4.Interfaces.IfcLampTypeEnum.TUNGSTENFILAMENT:
						PredefinedType = IfcLampTypeEnum.TUNGSTENFILAMENT;
						return;
					
					case Ifc4.Interfaces.IfcLampTypeEnum.USERDEFINED:
						PredefinedType = IfcLampTypeEnum.USERDEFINED;
						return;
					
					case Ifc4.Interfaces.IfcLampTypeEnum.NOTDEFINED:
						PredefinedType = IfcLampTypeEnum.NOTDEFINED;
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