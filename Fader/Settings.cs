using ScriptPortal.Vegas;
using System.Collections.Generic;

namespace Fader
{
    public class Settings
    {
        public long FadeTime { get; set; }
        public TimeUnit TimeUnit { get; set; }
        public ScriptMode ScriptMode { get; set; }
        public bool FadeIn { get; set; }
        public bool FadeOut { get; set; }
        public bool ChangeCurveType { get; set; }
        public CurveType FadeInCurveType { get; set; }
        public CurveType FadeOutCurveType { get; set; }
        public bool ShowDialog { get; set; }
        public ApplyTo ApplyTo { get; set; }

        public static Vegas Vegas { get; set; }
        public static string ScriptFileName { get; set; }

        public static Dictionary<ScriptMode, string> ScriptModesList { get; set; }
        public static Dictionary<CurveType, string> CurveTypeList { get; set; }
        public static Dictionary<ApplyTo, string> ApplyToList { get; set; }

        public Settings()
        {
            ScriptFileName = "Fader.cs";

            ScriptModesList = new Dictionary<ScriptMode, string>
            {
                { ScriptMode.AddFades, "Create Fades" },
                { ScriptMode.ChangeFades, "Change Existing Fade Curves"},
                { ScriptMode.RemoveFades, "Remove Fades"}
            };

            CurveTypeList = new Dictionary<CurveType, string>
            {
                {CurveType.Fast, "Fast" },
                {CurveType.Linear, "Linear" },
                {CurveType.Sharp, "Sharp" },
                {CurveType.Slow, "Slow" },
                {CurveType.Smooth, "Smooth" },
            };

            ApplyToList = new Dictionary<ApplyTo, string>
            {
                { ApplyTo.Audio, "Apply To Audio Events" },
                { ApplyTo.Video, "Apply To Video Events"},
                { ApplyTo.AudioAndVideo, "Apply To Audio And Video Events"}
            };
        }
    }

    public enum TimeUnit
    {
        Milliseconds,
        Frames
    }

    public enum ScriptMode
    {
        AddFades,
        ChangeFades,
        RemoveFades
    }

    public enum ApplyTo
    {
        Audio,
        Video,
        AudioAndVideo
    }
}
