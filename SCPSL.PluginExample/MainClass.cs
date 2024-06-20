using PluginAPI.Core;
using PluginAPI.Core.Attributes;

public class MainClass
{
	[PluginEntryPoint("Template", "1.0.0", "Template plugin.", "Northwood")]
	public void Entry()
	{
		Log.Info("Execute");
	}
}