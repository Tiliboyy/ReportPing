using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Loader;
using HarmonyLib;

namespace ReportPing
{
	public class ReportPing : Plugin<Config>
	{
		
		public static ReportPing Instance;
		public Harmony Harmony;
		
		public override string Author => "Tiliboyy";

		public override string Name => "ReportPing";

		public override string Prefix => "ReportPing";
		public override Version Version => new(1, 0, 0);

		public override Version RequiredExiledVersion => new(6, 0, 0, 0);

		public override void OnEnabled()
		{
			Instance = this;
			Harmony = new Harmony($"Tiliboyy.ReportPing.Patches");
			Harmony.PatchAll();
			base.OnEnabled();

		}

		public override void OnDisabled()
		{
			Instance = null;
			Harmony.UnpatchAll();
			base.OnDisabled();
		}
		
	}
}
