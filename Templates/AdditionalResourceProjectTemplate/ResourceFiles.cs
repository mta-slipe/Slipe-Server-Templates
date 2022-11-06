using SlipeServer.Resources.Base;
using System.Reflection;

namespace AdditionalResourceProjectTemplate;

public static class ResourceFiles
{
    private static Assembly Assembly { get; } = Assembly.GetExecutingAssembly();
    public static byte[] MainLua { get; } = EmbeddedResourceHelper.GetLuaFile("AdditionalResourceProjectTemplate.Lua.main.lua", Assembly);
}
