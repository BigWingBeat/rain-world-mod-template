using System.Security.Permissions;
using BepInEx;

#pragma warning disable CS0618 // SecurityAction.RequestMinimum is obsolete. However, this does not apply to the mod, which still needs it. Suppress the warning indicating that it is obsolete.
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
#pragma warning restore CS0618

namespace YourModName
{
	[BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
	public class YourModNamePlugin : BaseUnityPlugin
	{
		public const string PLUGIN_GUID = "yourname.yourmodname";
		public const string PLUGIN_NAME = "Your Mod Name";
		public const string PLUGIN_VERSION = "0.1.0";

		private void Awake()
		{
			Logger.LogInfo($"Hello Rain World from {PLUGIN_NAME}!");
		}
	}
}
