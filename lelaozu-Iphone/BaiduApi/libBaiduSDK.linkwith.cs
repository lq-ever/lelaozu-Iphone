using ObjCRuntime;

[assembly: LinkWith ("libBaiduSDK.a",LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true)]
