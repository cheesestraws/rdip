using System;
using System.Runtime.InteropServices;

class RailDriver
{

    public enum RDid
    {
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

    private static bool inited = false;

    [DllImport("raildriver.dll")]
    public static extern float GetRailSimValue(RDid id, RDmod modifier);
    [DllImport("raildriver.dll")]
    public static extern void SetRailDriverConnected(bool isConnected);
    [DllImport("raildriver.dll")]
    public static extern void SetRailSimValue(RDid id, Single value);

    public static void init()
    {
        SetRailDriverConnected(true);
    }

}
