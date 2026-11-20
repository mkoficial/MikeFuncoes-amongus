using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using MiraAPI.PluginLoading;
using Reactor;
using Reactor.Networking;
using Reactor.Networking.Attributes;

namespace MiraAPI.Example;

[BepInAutoPlugin("mike.funcoesmod", "Mike Funções Mod")]
// [BepInProcess("Among Us.exe")] <-- REMOVA ESTA LINHA para funcionar no celular!
[BepInDependency(ReactorPlugin.Id)]
[BepInDependency(MiraApiPlugin.Id)]
[ReactorModFlags(ModFlags.RequireOnAllClients)]
public partial class ExamplePlugin : BasePlugin, IMiraPlugin
{
    public Harmony Harmony { get; } = new(Id);
    public string OptionsTitleText => "Mike Funções Mod";
    public ConfigFile GetConfigFile() => Config;
    public override void Load()
    {
        Harmony.PatchAll();
    }
}
