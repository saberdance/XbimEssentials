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
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class @IfcPresentationStyle : IIfcPresentationStyle
	{

		[CrossSchemaAttribute(typeof(IIfcPresentationStyle), 1)]
		Ifc4.MeasureResource.IfcLabel? IIfcPresentationStyle.Name 
		{ 
			get
			{
				if (!Name.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Name.Value);
			} 
			set
			{
				Name = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
	//## Custom code
        public IEnumerable<IIfcSurfaceStyle> SurfaceStyles { get { return Enumerable.Empty<IfcSurfaceStyle>(); } }
	//##
	}
}