using System;
using System.Runtime.InteropServices;

class RailDriver
{

    public enum RDid
    {
        None = -1,
        Reverser,
        Throttle,
        CombinedThrottle,
        GearLever,
        TrainBrake,
        LocomotiveBrake,
        DynamicBrake,
        EmergencyBrake,
        HandBrake,
        WarningSystemReset,
        StartStopEngine,
        Horn,
        Wipers,
        Sander,
        Headlights,
        Pantograph,
        FireboxDoor,
        ExhaustInjectorSteam,
        ExhaustInjectorWater,
        LiveInjectorSteam,
        LiveInjectorWater,
        Damper,
        Blower,
        Stoking,
        CylinderCock,
        Waterscoop,
        SmallCompressor,
        AWS,
        AWSReset,
        Startup,
        Speedometer,
        // Events,
        PromptSave,
        ToggleLabels,
        Toggle2DMap,
        ToggleHud,
        ToggleQut,
        Pause,
        DriverGuide,
        ToggleRvNumber,
        DialogAssignment,
        SwitchJunctionAhead,
        SwitchJunctionBehind,
        LoadCargo,
        UnloadCargo,
        PassAtDangerAhead,
        PassAtDangerBehind,
        ManualCouple,
        // Camera,
        CabCamera,
        FollowCamera,
        HeadOutCamera,
        RearCamera,
        TrackSideCamera,
        CarriageCamera,
        CouplingCamera,
        YardCamera,
        SwitchToNextFrontCab,
        SwitchToNextRearCab,
        FreeCamera
    }

    public enum RDmod
    {
        Current,
        Min,
        Max
    }

    [DllImport("raildriver.dll")]
    public static extern float GetRailSimValue(RDid id, RDmod modifier);
    [DllImport("raildriver.dll")]
    public static extern void SetRailDriverConnected(bool isConnected);
    [DllImport("raildriver.dll")]
    public static extern void SetRailSimValue(RDid id, Single value);
    [DllImport("raildriver.dll")]
    public static extern bool GetRailSimConnected();
    [DllImport("raildriver.dll")]
    public static extern bool GetRailSimLocoChanged();
    [DllImport("raildriver.dll")]
    public static extern bool GetRailSimCombinedThrottleBrake();

    [DllImport("raildriver.dll")]
    public static extern void SetRailSimConnected(bool isConnected);
    [DllImport("raildriver.dll")]
    public static extern RDid GetNextRailDriverId(RDid Start);
    [DllImport("raildriver.dll")]
    public static extern float GetRailDriverValue(RDid id);

}
