using System;
using ObjCRuntime;

[assembly: LinkWith("libMJRefresh.a", LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.ArmV7 | LinkTarget.Simulator64,
    SmartLink = true, ForceLoad = true, LinkerFlags = "-ObjC")]
