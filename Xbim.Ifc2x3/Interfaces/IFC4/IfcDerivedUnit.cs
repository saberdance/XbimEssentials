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
namespace Xbim.Ifc2x3.MeasureResource
{
	public partial class @IfcDerivedUnit : IIfcDerivedUnit
	{
		IEnumerable<IIfcDerivedUnitElement> IIfcDerivedUnit.Elements 
		{ 
			get
			{
				foreach (var member in Elements)
				{
					yield return member as IIfcDerivedUnitElement;
				}
			} 
		}
		Ifc4.Interfaces.IfcDerivedUnitEnum IIfcDerivedUnit.UnitType 
		{ 
			get
			{
				switch (UnitType)
				{
					case IfcDerivedUnitEnum.ANGULARVELOCITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.ANGULARVELOCITYUNIT;
					
					case IfcDerivedUnitEnum.COMPOUNDPLANEANGLEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.COMPOUNDPLANEANGLEUNIT;
					
					case IfcDerivedUnitEnum.DYNAMICVISCOSITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.DYNAMICVISCOSITYUNIT;
					
					case IfcDerivedUnitEnum.HEATFLUXDENSITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.HEATFLUXDENSITYUNIT;
					
					case IfcDerivedUnitEnum.INTEGERCOUNTRATEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.INTEGERCOUNTRATEUNIT;
					
					case IfcDerivedUnitEnum.ISOTHERMALMOISTURECAPACITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.ISOTHERMALMOISTURECAPACITYUNIT;
					
					case IfcDerivedUnitEnum.KINEMATICVISCOSITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.KINEMATICVISCOSITYUNIT;
					
					case IfcDerivedUnitEnum.LINEARVELOCITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.LINEARVELOCITYUNIT;
					
					case IfcDerivedUnitEnum.MASSDENSITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MASSDENSITYUNIT;
					
					case IfcDerivedUnitEnum.MASSFLOWRATEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MASSFLOWRATEUNIT;
					
					case IfcDerivedUnitEnum.MOISTUREDIFFUSIVITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MOISTUREDIFFUSIVITYUNIT;
					
					case IfcDerivedUnitEnum.MOLECULARWEIGHTUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MOLECULARWEIGHTUNIT;
					
					case IfcDerivedUnitEnum.SPECIFICHEATCAPACITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.SPECIFICHEATCAPACITYUNIT;
					
					case IfcDerivedUnitEnum.THERMALADMITTANCEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.THERMALADMITTANCEUNIT;
					
					case IfcDerivedUnitEnum.THERMALCONDUCTANCEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.THERMALCONDUCTANCEUNIT;
					
					case IfcDerivedUnitEnum.THERMALRESISTANCEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.THERMALRESISTANCEUNIT;
					
					case IfcDerivedUnitEnum.THERMALTRANSMITTANCEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.THERMALTRANSMITTANCEUNIT;
					
					case IfcDerivedUnitEnum.VAPORPERMEABILITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.VAPORPERMEABILITYUNIT;
					
					case IfcDerivedUnitEnum.VOLUMETRICFLOWRATEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.VOLUMETRICFLOWRATEUNIT;
					
					case IfcDerivedUnitEnum.ROTATIONALFREQUENCYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.ROTATIONALFREQUENCYUNIT;
					
					case IfcDerivedUnitEnum.TORQUEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.TORQUEUNIT;
					
					case IfcDerivedUnitEnum.MOMENTOFINERTIAUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MOMENTOFINERTIAUNIT;
					
					case IfcDerivedUnitEnum.LINEARMOMENTUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.LINEARMOMENTUNIT;
					
					case IfcDerivedUnitEnum.LINEARFORCEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.LINEARFORCEUNIT;
					
					case IfcDerivedUnitEnum.PLANARFORCEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.PLANARFORCEUNIT;
					
					case IfcDerivedUnitEnum.MODULUSOFELASTICITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MODULUSOFELASTICITYUNIT;
					
					case IfcDerivedUnitEnum.SHEARMODULUSUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.SHEARMODULUSUNIT;
					
					case IfcDerivedUnitEnum.LINEARSTIFFNESSUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.LINEARSTIFFNESSUNIT;
					
					case IfcDerivedUnitEnum.ROTATIONALSTIFFNESSUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.ROTATIONALSTIFFNESSUNIT;
					
					case IfcDerivedUnitEnum.MODULUSOFSUBGRADEREACTIONUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MODULUSOFSUBGRADEREACTIONUNIT;
					
					case IfcDerivedUnitEnum.ACCELERATIONUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.ACCELERATIONUNIT;
					
					case IfcDerivedUnitEnum.CURVATUREUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.CURVATUREUNIT;
					
					case IfcDerivedUnitEnum.HEATINGVALUEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.HEATINGVALUEUNIT;
					
					case IfcDerivedUnitEnum.IONCONCENTRATIONUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.IONCONCENTRATIONUNIT;
					
					case IfcDerivedUnitEnum.LUMINOUSINTENSITYDISTRIBUTIONUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.LUMINOUSINTENSITYDISTRIBUTIONUNIT;
					
					case IfcDerivedUnitEnum.MASSPERLENGTHUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MASSPERLENGTHUNIT;
					
					case IfcDerivedUnitEnum.MODULUSOFLINEARSUBGRADEREACTIONUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MODULUSOFLINEARSUBGRADEREACTIONUNIT;
					
					case IfcDerivedUnitEnum.MODULUSOFROTATIONALSUBGRADEREACTIONUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MODULUSOFROTATIONALSUBGRADEREACTIONUNIT;
					
					case IfcDerivedUnitEnum.PHUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.PHUNIT;
					
					case IfcDerivedUnitEnum.ROTATIONALMASSUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.ROTATIONALMASSUNIT;
					
					case IfcDerivedUnitEnum.SECTIONAREAINTEGRALUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.SECTIONAREAINTEGRALUNIT;
					
					case IfcDerivedUnitEnum.SECTIONMODULUSUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.SECTIONMODULUSUNIT;
					
					case IfcDerivedUnitEnum.SOUNDPOWERUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.SOUNDPOWERUNIT;
					
					case IfcDerivedUnitEnum.SOUNDPRESSUREUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.SOUNDPRESSUREUNIT;
					
					case IfcDerivedUnitEnum.TEMPERATUREGRADIENTUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.TEMPERATUREGRADIENTUNIT;
					
					case IfcDerivedUnitEnum.THERMALEXPANSIONCOEFFICIENTUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.THERMALEXPANSIONCOEFFICIENTUNIT;
					
					case IfcDerivedUnitEnum.WARPINGCONSTANTUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.WARPINGCONSTANTUNIT;
					
					case IfcDerivedUnitEnum.WARPINGMOMENTUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.WARPINGMOMENTUNIT;
					
					case IfcDerivedUnitEnum.USERDEFINED:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.USERDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcDerivedUnit.UserDefinedType 
		{ 
			get
			{
				if (!UserDefinedType.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(UserDefinedType.Value);
			} 
		}
		Common.Geometry.XbimDimensionalExponents IIfcDerivedUnit.Dimensions 
		{
			get 
			{
				return Dimensions;
			}
		}

	//## Custom code
	//##
	}
}