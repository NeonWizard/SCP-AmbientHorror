using Smod2;
using Smod2.Attributes;
using Smod2.EventHandlers;
using Smod2.Events;
using Smod2.Config;

namespace AmbientHorror
{
	[PluginDetails(
		author = "Spooky",
		name = "AmbientHorror",
		description = "spooky scary skeletons",
		id = "xyz.wizardlywonders.AmbientHorror",
		version = "1.0.0",
		SmodMajor = 3,
		SmodMinor = 2,
		SmodRevision = 2
	)]
	public class AmbientHorror : Plugin
    {
		internal static AmbientHorror plugin;

		public override void OnDisable()
		{
			this.Info("AmbientHorror has been disabled.");
		}

		public override void OnEnable()
		{
			this.Info("AmbientHorror has loaded successfully.");
		}

		public override void Register()
		{
			// Register config settings
			this.AddConfig(new ConfigSetting("ambienthorror_enable", true, SettingType.BOOL, true, "Whether AmbientHorror should be enabled on server start."));

			// Register commands
			this.AddCommand("ambienthorrordisable", new Commands.AmbientHorrorDisableCommand(this));
		}
	}
}
