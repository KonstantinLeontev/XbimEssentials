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
	public partial class @IfcDoorPanelProperties : IIfcDoorPanelProperties
	{
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcDoorPanelProperties.PanelDepth 
		{ 
			get
			{
				if (PanelDepth == null) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)PanelDepth);
			} 
		}
		Ifc4.ArchitectureDomain.IfcDoorPanelOperationEnum IIfcDoorPanelProperties.PanelOperation 
		{ 
			get
			{
				switch (PanelOperation)
				{
					case IfcDoorPanelOperationEnum.SWINGING:
						return Ifc4.ArchitectureDomain.IfcDoorPanelOperationEnum.SWINGING;
					
					case IfcDoorPanelOperationEnum.DOUBLE_ACTING:
						return Ifc4.ArchitectureDomain.IfcDoorPanelOperationEnum.DOUBLE_ACTING;
					
					case IfcDoorPanelOperationEnum.SLIDING:
						return Ifc4.ArchitectureDomain.IfcDoorPanelOperationEnum.SLIDING;
					
					case IfcDoorPanelOperationEnum.FOLDING:
						return Ifc4.ArchitectureDomain.IfcDoorPanelOperationEnum.FOLDING;
					
					case IfcDoorPanelOperationEnum.REVOLVING:
						return Ifc4.ArchitectureDomain.IfcDoorPanelOperationEnum.REVOLVING;
					
					case IfcDoorPanelOperationEnum.ROLLINGUP:
						return Ifc4.ArchitectureDomain.IfcDoorPanelOperationEnum.ROLLINGUP;
					
					case IfcDoorPanelOperationEnum.USERDEFINED:
						return Ifc4.ArchitectureDomain.IfcDoorPanelOperationEnum.USERDEFINED;
					
					case IfcDoorPanelOperationEnum.NOTDEFINED:
						return Ifc4.ArchitectureDomain.IfcDoorPanelOperationEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.MeasureResource.IfcNormalisedRatioMeasure? IIfcDoorPanelProperties.PanelWidth 
		{ 
			get
			{
				if (PanelWidth == null) return null;
				return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure((double)PanelWidth);
			} 
		}
		Ifc4.ArchitectureDomain.IfcDoorPanelPositionEnum IIfcDoorPanelProperties.PanelPosition 
		{ 
			get
			{
				switch (PanelPosition)
				{
					case IfcDoorPanelPositionEnum.LEFT:
						return Ifc4.ArchitectureDomain.IfcDoorPanelPositionEnum.LEFT;
					
					case IfcDoorPanelPositionEnum.MIDDLE:
						return Ifc4.ArchitectureDomain.IfcDoorPanelPositionEnum.MIDDLE;
					
					case IfcDoorPanelPositionEnum.RIGHT:
						return Ifc4.ArchitectureDomain.IfcDoorPanelPositionEnum.RIGHT;
					
					case IfcDoorPanelPositionEnum.NOTDEFINED:
						return Ifc4.ArchitectureDomain.IfcDoorPanelPositionEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		IIfcShapeAspect IIfcDoorPanelProperties.ShapeAspectStyle 
		{ 
			get
			{
				return ShapeAspectStyle as IIfcShapeAspect;
			} 
		}
	}
}