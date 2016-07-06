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
namespace Xbim.Ifc2x3.MeasureResource
{
	public partial class @IfcMonetaryUnit : IIfcMonetaryUnit
	{

		[CrossSchemaAttribute(typeof(IIfcMonetaryUnit), 1)]
		Ifc4.MeasureResource.IfcLabel IIfcMonetaryUnit.Currency 
		{ 
			get
			{
				//## Handle return of Currency for which no match was found
			    //return value which was set before or string representation of the enumeration
                return !string.IsNullOrWhiteSpace(_currencyLabel) ? 
                    _currencyLabel : 
                    new Ifc4.MeasureResource.IfcLabel(System.Enum.GetName(typeof(IfcCurrencyEnum),Currency));
			    //##
			} 
			set
			{
				//## Handle setting of Currency for which no match was found
                //try to parse the value. If it doesn't fit, set value in private field to persist the value.
                IfcCurrencyEnum c;
			    if (System.Enum.TryParse(value.ToString(), true, out c))
			        Currency = c;
			    else
			        SetValue(v => _currencyLabel = v, _currencyLabel, value, "Currency", byte.MaxValue);
			    //##
				
			}
		}
	//## Custom code
	    private Ifc4.MeasureResource.IfcLabel _currencyLabel;
	    //##
	}
}