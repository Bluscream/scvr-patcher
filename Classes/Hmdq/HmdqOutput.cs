﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'System.Text.Json' then do:
//
//    using SCVRPatcher;
//
//    var hmdqOutput = HmdqOutput.FromJson(jsonString);
#nullable enable
#pragma warning disable CS8618
// <auto-generated />
//
// To parse this JSON data, add NuGet 'System.Text.Json' then do:
//
//    using SCVRPatcher;
//
//    var hmdqOutput = HmdqOutput.FromJson(jsonString);
#nullable enable
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8603

namespace SCVRPatcher {
    using System;
    using System.Collections.Generic;

    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Globalization;

    public partial class HmdqOutput {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("misc")]
        public virtual Misc Misc { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("openvr")]
        public virtual Openvr Openvr { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("oculus")]
        public virtual Oculus Oculus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("checksum")]
        public virtual string Checksum { get; set; }
    }

    public partial class Misc {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("time")]
        public virtual DateTimeOffset? Time { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("hmdq_ver")]
        public virtual string HmdqVer { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("log_ver")]
        public virtual long? LogVer { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("os_ver")]
        public virtual string OsVer { get; set; }
    }

    public partial class Oculus {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("error@")]
        public virtual string Error { get; set; }
    }

    public partial class Openvr {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("error@")]
        public virtual string Error { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("rt_path")]
        public virtual string RtPath { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("rt_ver")]
        public virtual string RtVer { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("devices")]
        public virtual List<List<long>> Devices { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("properties")]
        public virtual Dictionary<string, Property> Properties { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("geometry")]
        public virtual Geometry Geometry { get; set; }
    }

    public partial class Geometry {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("rec_rts")]
        public virtual List<long> RecRts { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("raw_eye")]
        public virtual RawEye RawEye { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("eye2head")]
        public virtual Eye2Head Eye2Head { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("view_geom")]
        public virtual ViewGeom ViewGeom { get; set; }

        [JsonPropertyName("fov_eye")]
        public virtual object FovEye { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("fov_head")]
        public virtual FovHead FovHead { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("fov_tot")]
        public virtual FovTot FovTot { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ham_mesh")]
        public virtual HamMesh HamMesh { get; set; }
    }

    public partial class Eye2Head {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Left")]
        public virtual List<List<double>> Left { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Right")]
        public virtual List<List<double>> Right { get; set; }
    }

    public partial class FovHead {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Left")]
        public virtual FovHeadLeft Left { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Right")]
        public virtual FovHeadLeft Right { get; set; }
    }

    public partial class FovHeadLeft {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("fov_pts")]
        public virtual List<List<double>> FovPts { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("deg_left")]
        public virtual double? DegLeft { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("deg_right")]
        public virtual double? DegRight { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("deg_bottom")]
        public virtual double? DegBottom { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("deg_top")]
        public virtual double? DegTop { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("deg_hor")]
        public virtual double? DegHor { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("deg_ver")]
        public virtual double? DegVer { get; set; }
    }

    public partial class FovTot {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("fov_hor")]
        public virtual double? FovHor { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("fov_ver")]
        public virtual double? FovVer { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("fov_diag")]
        public virtual double? FovDiag { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("overlap")]
        public virtual double? Overlap { get; set; }
    }

    public partial class HamMesh {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Left")]
        public virtual HamMeshLeft Left { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Right")]
        public virtual HamMeshLeft Right { get; set; }
    }

    public partial class HamMeshLeft {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ham_area")]
        public virtual double? HamArea { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("verts_raw")]
        public virtual List<List<double>> VertsRaw { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("verts_opt")]
        public virtual List<List<double>> VertsOpt { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("faces_opt")]
        public virtual List<List<long>> FacesOpt { get; set; }
    }

    public partial class RawEye {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Left")]
        public virtual RawEyeLeft Left { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Right")]
        public virtual RawEyeLeft Right { get; set; }
    }

    public partial class RawEyeLeft {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("tan_left")]
        public virtual double? TanLeft { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("tan_right")]
        public virtual double? TanRight { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("tan_bottom")]
        public virtual double? TanBottom { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("tan_top")]
        public virtual double? TanTop { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("aspect")]
        public virtual double? Aspect { get; set; }
    }

    public partial class ViewGeom {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("left_rot")]
        public virtual long? LeftRot { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("right_rot")]
        public virtual long? RightRot { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ipd")]
        public virtual double? Ipd { get; set; }
    }

    public partial class Property {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_TrackingSystemName_String")]
        public virtual string PropTrackingSystemNameString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ModelNumber_String")]
        public virtual string PropModelNumberString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_SerialNumber_String")]
        public virtual string PropSerialNumberString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_RenderModelName_String")]
        public virtual string PropRenderModelNameString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_WillDriftInYaw_Bool")]
        public virtual bool? PropWillDriftInYawBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ManufacturerName_String")]
        public virtual string PropManufacturerNameString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_TrackingFirmwareVersion_String")]
        public virtual string PropTrackingFirmwareVersionString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_HardwareRevision_String")]
        public virtual string PropHardwareRevisionString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_AllWirelessDongleDescriptions_String")]
        public virtual string PropAllWirelessDongleDescriptionsString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_Firmware_UpdateAvailable_Bool")]
        public virtual bool? PropFirmwareUpdateAvailableBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_Firmware_ManualUpdate_Bool")]
        public virtual bool? PropFirmwareManualUpdateBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_Firmware_ManualUpdateURL_String")]
        public virtual Uri PropFirmwareManualUpdateUrlString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_HardwareRevision_Uint64")]
        public virtual long? PropHardwareRevisionUint64 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_FirmwareVersion_Uint64")]
        public virtual long? PropFirmwareVersionUint64 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_FPGAVersion_Uint64")]
        public virtual long? PropFpgaVersionUint64 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_VRCVersion_Uint64")]
        public virtual long? PropVrcVersionUint64 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_BlockServerShutdown_Bool")]
        public virtual bool? PropBlockServerShutdownBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ContainsProximitySensor_Bool")]
        public virtual bool? PropContainsProximitySensorBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_Firmware_ProgrammingTarget_String")]
        public virtual string PropFirmwareProgrammingTargetString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DeviceClass_Int32")]
        public virtual long? PropDeviceClassInt32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_HasCamera_Bool")]
        public virtual bool? PropHasCameraBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_Firmware_ForceUpdateRequired_Bool")]
        public virtual bool? PropFirmwareForceUpdateRequiredBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ParentDriver_Uint64")]
        public virtual long? PropParentDriverUint64 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ResourceRoot_String")]
        public virtual string PropResourceRootString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_InputProfilePath_String")]
        public virtual string PropInputProfilePathString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_NumCameras_Int32")]
        public virtual long? PropNumCamerasInt32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_CameraFrameLayout_Int32")]
        public virtual long? PropCameraFrameLayoutInt32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_AdditionalDeviceSettingsPath_String")]
        public virtual string PropAdditionalDeviceSettingsPathString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_Identifiable_Bool")]
        public virtual bool? PropIdentifiableBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_Firmware_RemindUpdate_Bool")]
        public virtual bool? PropFirmwareRemindUpdateBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ManufacturerSerialNumber_String")]
        public virtual string PropManufacturerSerialNumberString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ComputedSerialNumber_String")]
        public virtual string PropComputedSerialNumberString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_EstimatedDeviceFirstUseTime_Int32")]
        public virtual long? PropEstimatedDeviceFirstUseTimeInt32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ReportsTimeSinceVSync_Bool")]
        public virtual bool? PropReportsTimeSinceVSyncBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_SecondsFromVsyncToPhotons_Float")]
        public virtual double? PropSecondsFromVsyncToPhotonsFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayFrequency_Float")]
        public virtual double? PropDisplayFrequencyFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_UserIpdMeters_Float")]
        public virtual double? PropUserIpdMetersFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_CurrentUniverseId_Uint64")]
        public virtual long? PropCurrentUniverseIdUint64 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_PreviousUniverseId_Uint64")]
        public virtual long? PropPreviousUniverseIdUint64 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayMCType_Int32")]
        public virtual long? PropDisplayMcTypeInt32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayMCOffset_Float")]
        public virtual float? PropDisplayMcOffsetFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayMCScale_Float")]
        public virtual float? PropDisplayMcScaleFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_EdidVendorID_Int32")]
        public virtual long? PropEdidVendorIdInt32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayMCImageLeft_String")]
        public virtual string PropDisplayMcImageLeftString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayMCImageRight_String")]
        public virtual string PropDisplayMcImageRightString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayGCBlackClamp_Float")]
        public virtual float? PropDisplayGcBlackClampFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_EdidProductID_Int32")]
        public virtual long? PropEdidProductIdInt32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_CameraToHeadTransform_Matrix34")]
        public virtual List<List<double>> PropCameraToHeadTransformMatrix34 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayGCType_Int32")]
        public virtual long? PropDisplayGcTypeInt32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayGCOffset_Float")]
        public virtual float? PropDisplayGcOffsetFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayGCScale_Float")]
        public virtual float? PropDisplayGcScaleFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayGCPrescale_Float")]
        public virtual float? PropDisplayGcPrescaleFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayGCImage_String")]
        public virtual string PropDisplayGcImageString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_LensCenterLeftU_Float")]
        public virtual float? PropLensCenterLeftUFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_LensCenterLeftV_Float")]
        public virtual double? PropLensCenterLeftVFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_LensCenterRightU_Float")]
        public virtual double? PropLensCenterRightUFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_LensCenterRightV_Float")]
        public virtual double? PropLensCenterRightVFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_UserHeadToEyeDepthMeters_Float")]
        public virtual float? PropUserHeadToEyeDepthMetersFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_CameraFirmwareVersion_Uint64")]
        public virtual long? PropCameraFirmwareVersionUint64 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_CameraFirmwareDescription_String")]
        public virtual string PropCameraFirmwareDescriptionString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_CameraCompatibilityMode_Int32")]
        public virtual long? PropCameraCompatibilityModeInt32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ScreenshotHorizontalFieldOfViewDegrees_Float")]
        public virtual float? PropScreenshotHorizontalFieldOfViewDegreesFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ScreenshotVerticalFieldOfViewDegrees_Float")]
        public virtual float? PropScreenshotVerticalFieldOfViewDegreesFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ExpectedTrackingReferenceCount_Int32")]
        public virtual long? PropExpectedTrackingReferenceCountInt32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ExpectedControllerCount_Int32")]
        public virtual long? PropExpectedControllerCountInt32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_NamedIconPathControllerLeftDeviceOff_String")]
        public virtual string PropNamedIconPathControllerLeftDeviceOffString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_NamedIconPathControllerRightDeviceOff_String")]
        public virtual string PropNamedIconPathControllerRightDeviceOffString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_NamedIconPathTrackingReferenceDeviceOff_String")]
        public virtual string PropNamedIconPathTrackingReferenceDeviceOffString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_CameraToHeadTransforms_Matrix34_Array")]
        public virtual List<List<List<double>>> PropCameraToHeadTransformsMatrix34Array { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_MinimumIpdStepMeters_Float")]
        public virtual float? PropMinimumIpdStepMetersFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ImuToHeadTransform_Matrix34")]
        public virtual List<List<double>> PropImuToHeadTransformMatrix34 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ImuFactoryGyroBias_Vector3")]
        public virtual List<double> PropImuFactoryGyroBiasVector3 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ImuFactoryGyroScale_Vector3")]
        public virtual List<double> PropImuFactoryGyroScaleVector3 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ImuFactoryAccelerometerBias_Vector3")]
        public virtual List<double> PropImuFactoryAccelerometerBiasVector3 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ImuFactoryAccelerometerScale_Vector3")]
        public virtual List<double> PropImuFactoryAccelerometerScaleVector3 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ConfigurationIncludesLighthouse20Features_Bool")]
        public virtual bool? PropConfigurationIncludesLighthouse20FeaturesBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_AdditionalRadioFeatures_Uint64")]
        public virtual long? PropAdditionalRadioFeaturesUint64 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_CameraDistortionFunction_Int32_Array")]
        public virtual List<long> PropCameraDistortionFunctionInt32Array { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_CameraDistortionCoefficients_Float_Array")]
        public virtual List<double> PropCameraDistortionCoefficientsFloatArray { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ExpectedControllerType_String")]
        public virtual string PropExpectedControllerTypeString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_HmdTrackingStyle_Int32")]
        public virtual long? PropHmdTrackingStyleInt32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_HmdColumnCorrectionSettingPrefix_String")]
        public virtual string PropHmdColumnCorrectionSettingPrefixString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_CameraSupportsCompatibilityModes_Bool")]
        public virtual bool? PropCameraSupportsCompatibilityModesBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_SupportsRoomViewDepthProjection_Bool")]
        public virtual bool? PropSupportsRoomViewDepthProjectionBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayAvailableFrameRates_Float_Array")]
        public virtual List<double> PropDisplayAvailableFrameRatesFloatArray { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplaySupportsMultipleFramerates_Bool")]
        public virtual bool? PropDisplaySupportsMultipleFrameratesBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayColorMultLeft_Vector3")]
        public virtual List<double> PropDisplayColorMultLeftVector3 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayColorMultRight_Vector3")]
        public virtual List<double> PropDisplayColorMultRightVector3 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplaySupportsRuntimeFramerateChange_Bool")]
        public virtual bool? PropDisplaySupportsRuntimeFramerateChangeBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplaySupportsAnalogGain_Bool")]
        public virtual bool? PropDisplaySupportsAnalogGainBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayMinAnalogGain_Float")]
        public virtual float? PropDisplayMinAnalogGainFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DisplayMaxAnalogGain_Float")]
        public virtual double? PropDisplayMaxAnalogGainFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DashboardScale_Float")]
        public virtual float? PropDashboardScaleFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_Hmd_EnableParallelRenderCameras_Bool")]
        public virtual bool? PropHmdEnableParallelRenderCamerasBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_IpdUIRangeMinMeters_Float")]
        public virtual double? PropIpdUiRangeMinMetersFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_IpdUIRangeMaxMeters_Float")]
        public virtual double? PropIpdUiRangeMaxMetersFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_Hmd_SupportsHDCP14LegacyCompat_Bool")]
        public virtual bool? PropHmdSupportsHdcp14LegacyCompatBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_Hmd_SupportsMicMonitoring_Bool")]
        public virtual bool? PropHmdSupportsMicMonitoringBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_Hmd_SupportsDisplayPortTrainingMode_Bool")]
        public virtual bool? PropHmdSupportsDisplayPortTrainingModeBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_Hmd_SupportsAppThrottling_Bool")]
        public virtual bool? PropHmdSupportsAppThrottlingBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DSCVersion_Int32")]
        public virtual long? PropDscVersionInt32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DSCSliceCount_Int32")]
        public virtual long? PropDscSliceCountInt32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_DSCBPPx16_Int32")]
        public virtual long? PropDscbpPx16Int32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_Audio_DefaultPlaybackDeviceVolume_Float")]
        public virtual double? PropAudioDefaultPlaybackDeviceVolumeFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_Audio_SupportsDualSpeakerAndJackOutput_Bool")]
        public virtual bool? PropAudioSupportsDualSpeakerAndJackOutputBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_NamedIconPathDeviceOff_String")]
        public virtual string PropNamedIconPathDeviceOffString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_NamedIconPathDeviceSearching_String")]
        public virtual string PropNamedIconPathDeviceSearchingString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_NamedIconPathDeviceSearchingAlert_String")]
        public virtual string PropNamedIconPathDeviceSearchingAlertString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_NamedIconPathDeviceReady_String")]
        public virtual string PropNamedIconPathDeviceReadyString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_NamedIconPathDeviceReadyAlert_String")]
        public virtual string PropNamedIconPathDeviceReadyAlertString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_NamedIconPathDeviceNotReady_String")]
        public virtual string PropNamedIconPathDeviceNotReadyString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_NamedIconPathDeviceStandby_String")]
        public virtual string PropNamedIconPathDeviceStandbyString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_NamedIconPathDeviceStandbyAlert_String")]
        public virtual string PropNamedIconPathDeviceStandbyAlertString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_HasDisplayComponent_Bool")]
        public virtual bool? PropHasDisplayComponentBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_HasCameraComponent_Bool")]
        public virtual bool? PropHasCameraComponentBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_HasDriverDirectModeComponent_Bool")]
        public virtual bool? PropHasDriverDirectModeComponentBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_HasVirtualDisplayComponent_Bool")]
        public virtual bool? PropHasVirtualDisplayComponentBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ControllerType_String")]
        public virtual string PropControllerTypeString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ControllerHandSelectionPriority_Int32")]
        public virtual long? PropControllerHandSelectionPriorityInt32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_RadioVersion_Uint64")]
        public virtual long? PropRadioVersionUint64 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_BootloaderVersion_Uint64")]
        public virtual long? PropBootloaderVersionUint64 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_CompositeFirmwareVersion_String")]
        public virtual string PropCompositeFirmwareVersionString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_FieldOfViewLeftDegrees_Float")]
        public virtual double? PropFieldOfViewLeftDegreesFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_FieldOfViewRightDegrees_Float")]
        public virtual double? PropFieldOfViewRightDegreesFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_FieldOfViewTopDegrees_Float")]
        public virtual double? PropFieldOfViewTopDegreesFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_FieldOfViewBottomDegrees_Float")]
        public virtual double? PropFieldOfViewBottomDegreesFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_TrackingRangeMinimumMeters_Float")]
        public virtual double? PropTrackingRangeMinimumMetersFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_TrackingRangeMaximumMeters_Float")]
        public virtual long? PropTrackingRangeMaximumMetersFloat { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_ModeLabel_String")]
        [JsonConverter(typeof(Extensions.ParseStringConverter))]
        public virtual long? PropModeLabelString { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_CanWirelessIdentify_Bool")]
        public virtual bool? PropCanWirelessIdentifyBool { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_Nonce_Int32")]
        public virtual long? PropNonceInt32 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Prop_NamedIconPathDeviceAlertLow_String")]
        public virtual string PropNamedIconPathDeviceAlertLowString { get; set; }
    }

    public partial class HmdqOutput {
        public static HmdqOutput FromJson(string json) => JsonSerializer.Deserialize<HmdqOutput>(json, SCVRPatcher.Converter.Settings);
    }

    public static partial class Serialize {
        public static string ToJson(this HmdqOutput self) => JsonSerializer.Serialize(self, SCVRPatcher.Converter.Settings);
    }
}
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8603