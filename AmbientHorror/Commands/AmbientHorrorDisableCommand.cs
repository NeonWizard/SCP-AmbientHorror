using Smod2.Commands;
using Smod2;
using Smod2.API;
using System.IO;

namespace AmbientHorror.Commands
{
	class AmbientHorrorDisableCommand : ICommandHandler
	{
		private AmbientHorror plugin;

		public AmbientHorrorDisableCommand(AmbientHorror plugin)
		{
			this.plugin = plugin;
		}

		public string GetCommandDescription()
		{
			return "Disables AmbientHorror";
		}

		public string GetUsage()
		{
			return "AMBIENTHORRORDISABLE";
		}

		public string[] OnCall(ICommandSender sender, string[] args)
		{
			plugin.Info(sender + " ran the " + GetUsage() + " command!");
			this.plugin.pluginManager.DisablePlugin(this.plugin);
			return new string[] { "AmbientHorror Disabled" };
		}
	}
}
