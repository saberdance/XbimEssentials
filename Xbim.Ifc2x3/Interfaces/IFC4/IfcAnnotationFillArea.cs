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
namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	public partial class @IfcAnnotationFillArea : IIfcAnnotationFillArea
	{

		[CrossSchemaAttribute(typeof(IIfcAnnotationFillArea), 1)]
		IIfcCurve IIfcAnnotationFillArea.OuterBoundary 
		{ 
			get
			{
				return OuterBoundary;
			} 
			set
			{
				OuterBoundary = value as GeometryResource.IfcCurve;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcAnnotationFillArea), 2)]
		IItemSet<IIfcCurve> IIfcAnnotationFillArea.InnerBoundaries 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<GeometryResource.IfcCurve, IIfcCurve>(InnerBoundaries);
			} 
		}
	//## Custom code
	//##
	}
}