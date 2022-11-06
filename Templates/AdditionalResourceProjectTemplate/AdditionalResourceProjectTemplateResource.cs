using SlipeServer.Server;
using SlipeServer.Server.Elements;
using SlipeServer.Server.Resources;

namespace AdditionalResourceProjectTemplate;

public class AdditionalResourceProjectTemplateResource : Resource
{
    public Dictionary<string, byte[]> AdditionalFiles { get; } = new Dictionary<string, byte[]>()
    {
        ["main.lua"] = ResourceFiles.MainLua,
    };

    public AdditionalResourceProjectTemplateResource(MtaServer server)
        : base(server, server.GetRequiredService<RootElement>(), "additionalResource")
    {
        foreach (var (path, content) in this.AdditionalFiles)
            this.Files.Add(ResourceFileFactory.FromBytes(content, path));
    }
}
