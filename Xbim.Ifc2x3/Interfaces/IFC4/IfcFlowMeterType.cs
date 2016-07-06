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
	public partial class @IfcFlowMeterType : IIfcFlowMeterType
	{

		[CrossSchemaAttribute(typeof(IIfcFlowMeterType), 10)]
		Ifc4.Interfaces.IfcFlowMeterTypeEnum IIfcFlowMeterType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcFlowMeterTypeEnum.ELECTRICMETER:
						//## Handle translation of ELECTRICMETER member from IfcFlowMeterTypeEnum in property PredefinedType
                        return Ifc4.Interfaces.IfcFlowMeterTypeEnum.USERDEFINED;
						//##
										
					case IfcFlowMeterTypeEnum.ENERGYMETER:
						return Ifc4.Interfaces.IfcFlowMeterTypeEnum.ENERGYMETER;
					
					case IfcFlowMeterTypeEnum.FLOWMETER:
						//## Handle translation of FLOWMETER member from IfcFlowMeterTypeEnum in property PredefinedType
                        return Ifc4.Interfaces.IfcFlowMeterTypeEnum.USERDEFINED;
						//##
										
					case IfcFlowMeterTypeEnum.GASMETER:
						return Ifc4.Interfaces.IfcFlowMeterTypeEnum.GASMETER;
					
					case IfcFlowMeterTypeEnum.OILMETER:
						return Ifc4.Interfaces.IfcFlowMeterTypeEnum.OILMETER;
					
					case IfcFlowMeterTypeEnum.WATERMETER:
						return Ifc4.Interfaces.IfcFlowMeterTypeEnum.WATERMETER;
					
					case IfcFlowMeterTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcFlowMeterTypeEnum.USERDEFINED;
					
					case IfcFlowMeterTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcFlowMeterTypeEnum.NOTDEFINED;
					
					
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
					case Ifc4.Interfaces.IfcFlowMeterTypeEnum.ENERGYMETER:
						PredefinedType = IfcFlowMeterTypeEnum.ENERGYMETER;
						return;
					
					case Ifc4.Interfaces.IfcFlowMeterTypeEnum.GASMETER:
						PredefinedType = IfcFlowMeterTypeEnum.GASMETER;
						return;
					
					case Ifc4.Interfaces.IfcFlowMeterTypeEnum.OILMETER:
						PredefinedType = IfcFlowMeterTypeEnum.OILMETER;
						return;
					
					case Ifc4.Interfaces.IfcFlowMeterTypeEnum.WATERMETER:
						PredefinedType = IfcFlowMeterTypeEnum.WATERMETER;
						return;
					
					case Ifc4.Interfaces.IfcFlowMeterTypeEnum.USERDEFINED:
						PredefinedType = IfcFlowMeterTypeEnum.USERDEFINED;
						return;
					
					case Ifc4.Interfaces.IfcFlowMeterTypeEnum.NOTDEFINED:
						PredefinedType = IfcFlowMeterTypeEnum.NOTDEFINED;
						return;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
        Ifc4.MeasureResource.IfcLabel? IIfcElementType.ElementType
        {
            get
            {
                switch (PredefinedType)
                {
                    case IfcFlowMeterTypeEnum.FLOWMETER:
                    case IfcFlowMeterTypeEnum.ELECTRICMETER:
                        return new Ifc4.MeasureResource.IfcLabel(System.Enum.GetName(typeof(IfcAirTerminalTypeEnum), PredefinedType));
                }
                return !ElementType.HasValue ? null : new Ifc4.MeasureResource.IfcLabel(ElementType.Value);
            }
            set
            {
                ElementType = value.HasValue
                    ? value.Value.ToString()
                    : null;

                if (!value.HasValue)
                    return;

                IfcFlowMeterTypeEnum e;
                if (System.Enum.TryParse(value.Value.ToString(), true, out e))
                    PredefinedType = e;
            }
        }
	//##
	}
}