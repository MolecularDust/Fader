/*
 
    Set desired fade length in milliseconds of frames and click OK button.

    If you want to create crossfades with specific curve types tick the "Change Curve Type" checkbox.
    You can also change curve type of existing events or remove fades by selecting the appropiate mode from the drop down list.

    Press "I" and "O" to quick check/uncheck FadeIn and FadeOut checkboxes.

    The script can operate in non-intecactive mode, without GUI.
    To do so change script's settings below and set Settings.ShowDialog to false and tune other settings to your needs.
    This way you can copy the script to a new file with custom settings and run it triggered by a shortcut key.

    "Edit Script" menu opens "Fader.cs" in Notepad for a quick edit.

*/

using System;
using System.Windows.Forms;
using ScriptPortal.Vegas;

namespace Fader
{
    public class EntryPoint
    {
        public Settings Settings { get; set; }

        public void FromVegas(Vegas vegas)
        {
            var Settings = new Settings();

            // ********* Change default script parameters here

            Settings.FadeTime = 100; // Set fade length here
            Settings.TimeUnit = TimeUnit.Milliseconds; // Select fade time unit: Milliseconds or Frames
            Settings.ScriptMode = ScriptMode.AddFades; // AddFades, ChangeFades or RemoveFades
            Settings.ApplyTo = ApplyTo.Audio; // Type of events to apply the script to: Audio, Video or AudioAndVideo
            Settings.FadeIn = true; // Apply script to fade-ins
            Settings.FadeOut = true; // Apply script to fade-outs
            Settings.ChangeCurveType = false; // // Set to true to be able to apply curve types
            Settings.FadeInCurveType = CurveType.Fast; // Fade-in curve type: Fast, Linear, Sharp, Slow, Smooth. Vegas's default is Fast
            Settings.FadeOutCurveType = CurveType.Slow; // Fade-out curve type: Fast, Linear, Sharp, Slow, Smooth. Vegas's default is Slow
            Settings.ShowDialog = true; // Show dialog window or apply the above settings without user prompt

            // ********* Do no change anything below unless you know what you're doing

            Settings.Vegas = vegas;

            Timecode FadeAmount = new Timecode();
            Timecode ZeroTime = new Timecode();

            if (Settings.ShowDialog)
            {
                FaderForm form = new FaderForm(Settings);
                var dialogResult = form.ShowDialog();
                if (dialogResult != DialogResult.OK)
                    return;
            }

            if (Settings.TimeUnit == TimeUnit.Milliseconds)
                FadeAmount = Timecode.FromMilliseconds(Settings.FadeTime);
            if (Settings.TimeUnit == TimeUnit.Frames)
                FadeAmount = Timecode.FromFrames(Settings.FadeTime);

            if (Settings.FadeOut == false && Settings.FadeIn == false)
                return;

            Action<Fade> ApplyFade = (fade) =>
            {
                if (Settings.ScriptMode == ScriptMode.AddFades)
                    fade.Length = FadeAmount;
                if (Settings.ScriptMode == ScriptMode.RemoveFades)
                    fade.Length = ZeroTime;
            };

            try
            {
                foreach (var track in vegas.Project.Tracks)
                {
                    foreach (var trackEvent in track.Events)
                    {
                        if (trackEvent.Selected)
                        {
                            if (trackEvent.IsVideo() && Settings.ApplyTo == ApplyTo.Audio)
                                continue;
                            if (trackEvent.IsAudio() && Settings.ApplyTo == ApplyTo.Video)
                                continue;

                            if (Settings.FadeIn)
                                ApplyFade(trackEvent.FadeIn);
                            if (Settings.ScriptMode != ScriptMode.RemoveFades && Settings.ChangeCurveType)
                                trackEvent.FadeIn.Curve = Settings.FadeInCurveType;

                            if (Settings.FadeOut)
                                ApplyFade(trackEvent.FadeOut);
                            if (Settings.ScriptMode != ScriptMode.RemoveFades && Settings.ChangeCurveType)
                                trackEvent.FadeOut.Curve = Settings.FadeOutCurveType;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
