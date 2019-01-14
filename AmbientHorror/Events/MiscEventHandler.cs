using Smod2;
using Smod2.API;
using Smod2.Events;
using Smod2.EventHandlers;
using UnityEngine;
using System.Collections.Generic;
using System;
using System.Threading;
using System.Linq;

namespace AmbientHorror.Events
{
	class MiscEventHandler : IEventHandlerWaitingForPlayers
	{
		private readonly AmbientHorror plugin;

		public MiscEventHandler(AmbientHorror plugin) => this.plugin = plugin;

		public void OnWaitingForPlayers(WaitingForPlayersEvent ev)
		{
			if (!this.plugin.GetConfigBool("ambienthorror_enable")) this.plugin.pluginManager.DisablePlugin(this.plugin);
		}
	}
}
