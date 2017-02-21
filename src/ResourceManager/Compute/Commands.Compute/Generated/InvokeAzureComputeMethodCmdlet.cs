// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    //[Cmdlet(VerbsLifecycle.Invoke, "AzureComputeMethod", DefaultParameterSetName = "InvokeByDynamicParameters")]
    [OutputType(typeof(object))]
    public partial class InvokeAzureComputeMethodCmdlet : ComputeAutomationBaseCmdlet, IDynamicParameters
    {
        protected RuntimeDefinedParameterDictionary dynamicParameters;
        protected object[] argumentList;

        protected static object[] ConvertDynamicParameters(RuntimeDefinedParameterDictionary parameters)
        {
            List<object> paramList = new List<object>();

            foreach (var param in parameters)
            {
                paramList.Add(param.Value.Value);
            }

            return paramList.ToArray();
        }

        [Parameter(Mandatory = true, ParameterSetName = "InvokeByDynamicParameters", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "InvokeByStaticParameters", Position = 0)]
        [ValidateSet(
            "AvailabilitySetCreateOrUpdate",
            "AvailabilitySetDelete",
            "AvailabilitySetGet",
            "AvailabilitySetList",
            "AvailabilitySetListAvailableSizes",
            "ContainerServiceCreateOrUpdate",
            "ContainerServiceDelete",
            "ContainerServiceGet",
            "ContainerServiceList",
            "ContainerServiceListByResourceGroup",
            "ContainerServiceListByResourceGroupNext",
            "ContainerServiceListNext",
            "DiskCreateOrUpdate",
            "DiskDelete",
            "DiskGet",
            "DiskGrantAccess",
            "DiskList",
            "DiskListByResourceGroup",
            "DiskListByResourceGroupNext",
            "DiskListNext",
            "DiskRevokeAccess",
            "DiskUpdate",
            "ImageCreateOrUpdate",
            "ImageDelete",
            "ImageGet",
            "ImageList",
            "ImageListByResourceGroup",
            "ImageListByResourceGroupNext",
            "ImageListNext",
            "SnapshotCreateOrUpdate",
            "SnapshotDelete",
            "SnapshotGet",
            "SnapshotGrantAccess",
            "SnapshotList",
            "SnapshotListByResourceGroup",
            "SnapshotListByResourceGroupNext",
            "SnapshotListNext",
            "SnapshotRevokeAccess",
            "SnapshotUpdate",
            "VirtualMachineScaleSetCreateOrUpdate",
            "VirtualMachineScaleSetDeallocate",
            "VirtualMachineScaleSetDelete",
            "VirtualMachineScaleSetDeleteInstances",
            "VirtualMachineScaleSetGet",
            "VirtualMachineScaleSetGetInstanceView",
            "VirtualMachineScaleSetList",
            "VirtualMachineScaleSetListAll",
            "VirtualMachineScaleSetListAllNext",
            "VirtualMachineScaleSetListNext",
            "VirtualMachineScaleSetListSkus",
            "VirtualMachineScaleSetListSkusNext",
            "VirtualMachineScaleSetPowerOff",
            "VirtualMachineScaleSetReimage",
            "VirtualMachineScaleSetReimageAll",
            "VirtualMachineScaleSetRestart",
            "VirtualMachineScaleSetStart",
            "VirtualMachineScaleSetUpdateInstances",
            "VirtualMachineScaleSetVMDeallocate",
            "VirtualMachineScaleSetVMDelete",
            "VirtualMachineScaleSetVMGet",
            "VirtualMachineScaleSetVMGetInstanceView",
            "VirtualMachineScaleSetVMList",
            "VirtualMachineScaleSetVMListNext",
            "VirtualMachineScaleSetVMPowerOff",
            "VirtualMachineScaleSetVMReimage",
            "VirtualMachineScaleSetVMReimageAll",
            "VirtualMachineScaleSetVMRestart",
            "VirtualMachineScaleSetVMStart",
            "VirtualMachineCapture",
            "VirtualMachineConvertToManagedDisks",
            "VirtualMachineCreateOrUpdate",
            "VirtualMachineDeallocate",
            "VirtualMachineDelete",
            "VirtualMachineGeneralize",
            "VirtualMachineGet",
            "VirtualMachineList",
            "VirtualMachineListAll",
            "VirtualMachineListAllNext",
            "VirtualMachineListAvailableSizes",
            "VirtualMachineListNext",
            "VirtualMachinePowerOff",
            "VirtualMachineRedeploy",
            "VirtualMachineRestart",
            "VirtualMachineStart"
        )]
        public virtual string MethodName { get; set; }

        protected object ParseParameter(object input)
        {
            if (input is PSObject)
            {
                return (input as PSObject).BaseObject;
            }
            else
            {
                return input;
            }
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ExecuteClientAction(() =>
            {
                if (ParameterSetName.StartsWith("InvokeByDynamicParameters"))
                {
                    argumentList = ConvertDynamicParameters(dynamicParameters);
                }
                else
                {
                    argumentList = ConvertFromArgumentsToObjects((object[])dynamicParameters["ArgumentList"].Value);
                }

                switch (MethodName)
                {
                    case "AvailabilitySetCreateOrUpdate":
                        ExecuteAvailabilitySetCreateOrUpdateMethod(argumentList);
                        break;
                    case "AvailabilitySetDelete":
                        ExecuteAvailabilitySetDeleteMethod(argumentList);
                        break;
                    case "AvailabilitySetGet":
                        ExecuteAvailabilitySetGetMethod(argumentList);
                        break;
                    case "AvailabilitySetList":
                        ExecuteAvailabilitySetListMethod(argumentList);
                        break;
                    case "AvailabilitySetListAvailableSizes":
                        ExecuteAvailabilitySetListAvailableSizesMethod(argumentList);
                        break;
                    case "ContainerServiceCreateOrUpdate":
                        ExecuteContainerServiceCreateOrUpdateMethod(argumentList);
                        break;
                    case "ContainerServiceDelete":
                        ExecuteContainerServiceDeleteMethod(argumentList);
                        break;
                    case "ContainerServiceGet":
                        ExecuteContainerServiceGetMethod(argumentList);
                        break;
                    case "ContainerServiceList":
                        ExecuteContainerServiceListMethod(argumentList);
                        break;
                    case "ContainerServiceListByResourceGroup":
                        ExecuteContainerServiceListByResourceGroupMethod(argumentList);
                        break;
                    case "ContainerServiceListByResourceGroupNext":
                        ExecuteContainerServiceListByResourceGroupNextMethod(argumentList);
                        break;
                    case "ContainerServiceListNext":
                        ExecuteContainerServiceListNextMethod(argumentList);
                        break;
                    case "DiskCreateOrUpdate":
                        ExecuteDiskCreateOrUpdateMethod(argumentList);
                        break;
                    case "DiskDelete":
                        ExecuteDiskDeleteMethod(argumentList);
                        break;
                    case "DiskGet":
                        ExecuteDiskGetMethod(argumentList);
                        break;
                    case "DiskGrantAccess":
                        ExecuteDiskGrantAccessMethod(argumentList);
                        break;
                    case "DiskList":
                        ExecuteDiskListMethod(argumentList);
                        break;
                    case "DiskListByResourceGroup":
                        ExecuteDiskListByResourceGroupMethod(argumentList);
                        break;
                    case "DiskListByResourceGroupNext":
                        ExecuteDiskListByResourceGroupNextMethod(argumentList);
                        break;
                    case "DiskListNext":
                        ExecuteDiskListNextMethod(argumentList);
                        break;
                    case "DiskRevokeAccess":
                        ExecuteDiskRevokeAccessMethod(argumentList);
                        break;
                    case "DiskUpdate":
                        ExecuteDiskUpdateMethod(argumentList);
                        break;
                    case "ImageCreateOrUpdate":
                        ExecuteImageCreateOrUpdateMethod(argumentList);
                        break;
                    case "ImageDelete":
                        ExecuteImageDeleteMethod(argumentList);
                        break;
                    case "ImageGet":
                        ExecuteImageGetMethod(argumentList);
                        break;
                    case "ImageList":
                        ExecuteImageListMethod(argumentList);
                        break;
                    case "ImageListByResourceGroup":
                        ExecuteImageListByResourceGroupMethod(argumentList);
                        break;
                    case "ImageListByResourceGroupNext":
                        ExecuteImageListByResourceGroupNextMethod(argumentList);
                        break;
                    case "ImageListNext":
                        ExecuteImageListNextMethod(argumentList);
                        break;
                    case "SnapshotCreateOrUpdate":
                        ExecuteSnapshotCreateOrUpdateMethod(argumentList);
                        break;
                    case "SnapshotDelete":
                        ExecuteSnapshotDeleteMethod(argumentList);
                        break;
                    case "SnapshotGet":
                        ExecuteSnapshotGetMethod(argumentList);
                        break;
                    case "SnapshotGrantAccess":
                        ExecuteSnapshotGrantAccessMethod(argumentList);
                        break;
                    case "SnapshotList":
                        ExecuteSnapshotListMethod(argumentList);
                        break;
                    case "SnapshotListByResourceGroup":
                        ExecuteSnapshotListByResourceGroupMethod(argumentList);
                        break;
                    case "SnapshotListByResourceGroupNext":
                        ExecuteSnapshotListByResourceGroupNextMethod(argumentList);
                        break;
                    case "SnapshotListNext":
                        ExecuteSnapshotListNextMethod(argumentList);
                        break;
                    case "SnapshotRevokeAccess":
                        ExecuteSnapshotRevokeAccessMethod(argumentList);
                        break;
                    case "SnapshotUpdate":
                        ExecuteSnapshotUpdateMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetCreateOrUpdate":
                        ExecuteVirtualMachineScaleSetCreateOrUpdateMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetDeallocate":
                        ExecuteVirtualMachineScaleSetDeallocateMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetDelete":
                        ExecuteVirtualMachineScaleSetDeleteMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetDeleteInstances":
                        ExecuteVirtualMachineScaleSetDeleteInstancesMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetGet":
                        ExecuteVirtualMachineScaleSetGetMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetGetInstanceView":
                        ExecuteVirtualMachineScaleSetGetInstanceViewMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetList":
                        ExecuteVirtualMachineScaleSetListMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetListAll":
                        ExecuteVirtualMachineScaleSetListAllMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetListAllNext":
                        ExecuteVirtualMachineScaleSetListAllNextMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetListNext":
                        ExecuteVirtualMachineScaleSetListNextMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetListSkus":
                        ExecuteVirtualMachineScaleSetListSkusMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetListSkusNext":
                        ExecuteVirtualMachineScaleSetListSkusNextMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetPowerOff":
                        ExecuteVirtualMachineScaleSetPowerOffMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetReimage":
                        ExecuteVirtualMachineScaleSetReimageMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetReimageAll":
                        ExecuteVirtualMachineScaleSetReimageAllMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetRestart":
                        ExecuteVirtualMachineScaleSetRestartMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetStart":
                        ExecuteVirtualMachineScaleSetStartMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetUpdateInstances":
                        ExecuteVirtualMachineScaleSetUpdateInstancesMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMDeallocate":
                        ExecuteVirtualMachineScaleSetVMDeallocateMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMDelete":
                        ExecuteVirtualMachineScaleSetVMDeleteMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMGet":
                        ExecuteVirtualMachineScaleSetVMGetMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMGetInstanceView":
                        ExecuteVirtualMachineScaleSetVMGetInstanceViewMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMList":
                        ExecuteVirtualMachineScaleSetVMListMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMListNext":
                        ExecuteVirtualMachineScaleSetVMListNextMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMPowerOff":
                        ExecuteVirtualMachineScaleSetVMPowerOffMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMReimage":
                        ExecuteVirtualMachineScaleSetVMReimageMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMReimageAll":
                        ExecuteVirtualMachineScaleSetVMReimageAllMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMRestart":
                        ExecuteVirtualMachineScaleSetVMRestartMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMStart":
                        ExecuteVirtualMachineScaleSetVMStartMethod(argumentList);
                        break;
                    case "VirtualMachineCapture":
                        ExecuteVirtualMachineCaptureMethod(argumentList);
                        break;
                    case "VirtualMachineConvertToManagedDisks":
                        ExecuteVirtualMachineConvertToManagedDisksMethod(argumentList);
                        break;
                    case "VirtualMachineCreateOrUpdate":
                        ExecuteVirtualMachineCreateOrUpdateMethod(argumentList);
                        break;
                    case "VirtualMachineDeallocate":
                        ExecuteVirtualMachineDeallocateMethod(argumentList);
                        break;
                    case "VirtualMachineDelete":
                        ExecuteVirtualMachineDeleteMethod(argumentList);
                        break;
                    case "VirtualMachineGeneralize":
                        ExecuteVirtualMachineGeneralizeMethod(argumentList);
                        break;
                    case "VirtualMachineGet":
                        ExecuteVirtualMachineGetMethod(argumentList);
                        break;
                    case "VirtualMachineList":
                        ExecuteVirtualMachineListMethod(argumentList);
                        break;
                    case "VirtualMachineListAll":
                        ExecuteVirtualMachineListAllMethod(argumentList);
                        break;
                    case "VirtualMachineListAllNext":
                        ExecuteVirtualMachineListAllNextMethod(argumentList);
                        break;
                    case "VirtualMachineListAvailableSizes":
                        ExecuteVirtualMachineListAvailableSizesMethod(argumentList);
                        break;
                    case "VirtualMachineListNext":
                        ExecuteVirtualMachineListNextMethod(argumentList);
                        break;
                    case "VirtualMachinePowerOff":
                        ExecuteVirtualMachinePowerOffMethod(argumentList);
                        break;
                    case "VirtualMachineRedeploy":
                        ExecuteVirtualMachineRedeployMethod(argumentList);
                        break;
                    case "VirtualMachineRestart":
                        ExecuteVirtualMachineRestartMethod(argumentList);
                        break;
                    case "VirtualMachineStart":
                        ExecuteVirtualMachineStartMethod(argumentList);
                        break;
                    default: WriteWarning("Cannot find the method by name = '" + MethodName + "'."); break;
                }
            });
        }


        public virtual object GetDynamicParameters()
        {
            switch (MethodName)
            {
                case "AvailabilitySetCreateOrUpdate": return CreateAvailabilitySetCreateOrUpdateDynamicParameters();
                case "AvailabilitySetDelete": return CreateAvailabilitySetDeleteDynamicParameters();
                case "AvailabilitySetGet": return CreateAvailabilitySetGetDynamicParameters();
                case "AvailabilitySetList": return CreateAvailabilitySetListDynamicParameters();
                case "AvailabilitySetListAvailableSizes": return CreateAvailabilitySetListAvailableSizesDynamicParameters();
                case "ContainerServiceCreateOrUpdate": return CreateContainerServiceCreateOrUpdateDynamicParameters();
                case "ContainerServiceDelete": return CreateContainerServiceDeleteDynamicParameters();
                case "ContainerServiceGet": return CreateContainerServiceGetDynamicParameters();
                case "ContainerServiceList": return CreateContainerServiceListDynamicParameters();
                case "ContainerServiceListByResourceGroup": return CreateContainerServiceListByResourceGroupDynamicParameters();
                case "ContainerServiceListByResourceGroupNext": return CreateContainerServiceListByResourceGroupNextDynamicParameters();
                case "ContainerServiceListNext": return CreateContainerServiceListNextDynamicParameters();
                case "DiskCreateOrUpdate": return CreateDiskCreateOrUpdateDynamicParameters();
                case "DiskDelete": return CreateDiskDeleteDynamicParameters();
                case "DiskGet": return CreateDiskGetDynamicParameters();
                case "DiskGrantAccess": return CreateDiskGrantAccessDynamicParameters();
                case "DiskList": return CreateDiskListDynamicParameters();
                case "DiskListByResourceGroup": return CreateDiskListByResourceGroupDynamicParameters();
                case "DiskListByResourceGroupNext": return CreateDiskListByResourceGroupNextDynamicParameters();
                case "DiskListNext": return CreateDiskListNextDynamicParameters();
                case "DiskRevokeAccess": return CreateDiskRevokeAccessDynamicParameters();
                case "DiskUpdate": return CreateDiskUpdateDynamicParameters();
                case "ImageCreateOrUpdate": return CreateImageCreateOrUpdateDynamicParameters();
                case "ImageDelete": return CreateImageDeleteDynamicParameters();
                case "ImageGet": return CreateImageGetDynamicParameters();
                case "ImageList": return CreateImageListDynamicParameters();
                case "ImageListByResourceGroup": return CreateImageListByResourceGroupDynamicParameters();
                case "ImageListByResourceGroupNext": return CreateImageListByResourceGroupNextDynamicParameters();
                case "ImageListNext": return CreateImageListNextDynamicParameters();
                case "SnapshotCreateOrUpdate": return CreateSnapshotCreateOrUpdateDynamicParameters();
                case "SnapshotDelete": return CreateSnapshotDeleteDynamicParameters();
                case "SnapshotGet": return CreateSnapshotGetDynamicParameters();
                case "SnapshotGrantAccess": return CreateSnapshotGrantAccessDynamicParameters();
                case "SnapshotList": return CreateSnapshotListDynamicParameters();
                case "SnapshotListByResourceGroup": return CreateSnapshotListByResourceGroupDynamicParameters();
                case "SnapshotListByResourceGroupNext": return CreateSnapshotListByResourceGroupNextDynamicParameters();
                case "SnapshotListNext": return CreateSnapshotListNextDynamicParameters();
                case "SnapshotRevokeAccess": return CreateSnapshotRevokeAccessDynamicParameters();
                case "SnapshotUpdate": return CreateSnapshotUpdateDynamicParameters();
                case "VirtualMachineScaleSetCreateOrUpdate": return CreateVirtualMachineScaleSetCreateOrUpdateDynamicParameters();
                case "VirtualMachineScaleSetDeallocate": return CreateVirtualMachineScaleSetDeallocateDynamicParameters();
                case "VirtualMachineScaleSetDelete": return CreateVirtualMachineScaleSetDeleteDynamicParameters();
                case "VirtualMachineScaleSetDeleteInstances": return CreateVirtualMachineScaleSetDeleteInstancesDynamicParameters();
                case "VirtualMachineScaleSetGet": return CreateVirtualMachineScaleSetGetDynamicParameters();
                case "VirtualMachineScaleSetGetInstanceView": return CreateVirtualMachineScaleSetGetInstanceViewDynamicParameters();
                case "VirtualMachineScaleSetList": return CreateVirtualMachineScaleSetListDynamicParameters();
                case "VirtualMachineScaleSetListAll": return CreateVirtualMachineScaleSetListAllDynamicParameters();
                case "VirtualMachineScaleSetListAllNext": return CreateVirtualMachineScaleSetListAllNextDynamicParameters();
                case "VirtualMachineScaleSetListNext": return CreateVirtualMachineScaleSetListNextDynamicParameters();
                case "VirtualMachineScaleSetListSkus": return CreateVirtualMachineScaleSetListSkusDynamicParameters();
                case "VirtualMachineScaleSetListSkusNext": return CreateVirtualMachineScaleSetListSkusNextDynamicParameters();
                case "VirtualMachineScaleSetPowerOff": return CreateVirtualMachineScaleSetPowerOffDynamicParameters();
                case "VirtualMachineScaleSetReimage": return CreateVirtualMachineScaleSetReimageDynamicParameters();
                case "VirtualMachineScaleSetReimageAll": return CreateVirtualMachineScaleSetReimageAllDynamicParameters();
                case "VirtualMachineScaleSetRestart": return CreateVirtualMachineScaleSetRestartDynamicParameters();
                case "VirtualMachineScaleSetStart": return CreateVirtualMachineScaleSetStartDynamicParameters();
                case "VirtualMachineScaleSetUpdateInstances": return CreateVirtualMachineScaleSetUpdateInstancesDynamicParameters();
                case "VirtualMachineScaleSetVMDeallocate": return CreateVirtualMachineScaleSetVMDeallocateDynamicParameters();
                case "VirtualMachineScaleSetVMDelete": return CreateVirtualMachineScaleSetVMDeleteDynamicParameters();
                case "VirtualMachineScaleSetVMGet": return CreateVirtualMachineScaleSetVMGetDynamicParameters();
                case "VirtualMachineScaleSetVMGetInstanceView": return CreateVirtualMachineScaleSetVMGetInstanceViewDynamicParameters();
                case "VirtualMachineScaleSetVMList": return CreateVirtualMachineScaleSetVMListDynamicParameters();
                case "VirtualMachineScaleSetVMListNext": return CreateVirtualMachineScaleSetVMListNextDynamicParameters();
                case "VirtualMachineScaleSetVMPowerOff": return CreateVirtualMachineScaleSetVMPowerOffDynamicParameters();
                case "VirtualMachineScaleSetVMReimage": return CreateVirtualMachineScaleSetVMReimageDynamicParameters();
                case "VirtualMachineScaleSetVMReimageAll": return CreateVirtualMachineScaleSetVMReimageAllDynamicParameters();
                case "VirtualMachineScaleSetVMRestart": return CreateVirtualMachineScaleSetVMRestartDynamicParameters();
                case "VirtualMachineScaleSetVMStart": return CreateVirtualMachineScaleSetVMStartDynamicParameters();
                case "VirtualMachineCapture": return CreateVirtualMachineCaptureDynamicParameters();
                case "VirtualMachineConvertToManagedDisks": return CreateVirtualMachineConvertToManagedDisksDynamicParameters();
                case "VirtualMachineCreateOrUpdate": return CreateVirtualMachineCreateOrUpdateDynamicParameters();
                case "VirtualMachineDeallocate": return CreateVirtualMachineDeallocateDynamicParameters();
                case "VirtualMachineDelete": return CreateVirtualMachineDeleteDynamicParameters();
                case "VirtualMachineGeneralize": return CreateVirtualMachineGeneralizeDynamicParameters();
                case "VirtualMachineGet": return CreateVirtualMachineGetDynamicParameters();
                case "VirtualMachineList": return CreateVirtualMachineListDynamicParameters();
                case "VirtualMachineListAll": return CreateVirtualMachineListAllDynamicParameters();
                case "VirtualMachineListAllNext": return CreateVirtualMachineListAllNextDynamicParameters();
                case "VirtualMachineListAvailableSizes": return CreateVirtualMachineListAvailableSizesDynamicParameters();
                case "VirtualMachineListNext": return CreateVirtualMachineListNextDynamicParameters();
                case "VirtualMachinePowerOff": return CreateVirtualMachinePowerOffDynamicParameters();
                case "VirtualMachineRedeploy": return CreateVirtualMachineRedeployDynamicParameters();
                case "VirtualMachineRestart": return CreateVirtualMachineRestartDynamicParameters();
                case "VirtualMachineStart": return CreateVirtualMachineStartDynamicParameters();
                default: break;
            }

            return null;
        }

    }
}
