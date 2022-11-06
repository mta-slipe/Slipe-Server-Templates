using Microsoft.Extensions.Logging;
using SlipeServer.Server;
using SlipeServer.Server.Elements;
using SlipeServer.Server.Events;
using SlipeServer.Server.Services;

namespace AdditionalResourceProjectTemplate;

public class AdditionalResourceProjectTemplateResourceLogic
{
    private readonly MtaServer server;
    private readonly ILogger logger;
    private readonly AdditionalResourceProjectTemplateResource resource;

    public AdditionalResourceProjectTemplateResourceLogic(MtaServer server,
        LuaEventService luaEventService,
        ILogger logger)
    {
        this.server = server;
        this.logger = logger;
        server.PlayerJoined += HandlePlayerJoin;

        luaEventService.AddEventHandler("event", HandleEvent);

        this.resource = this.server.GetAdditionalResource<AdditionalResourceProjectTemplateResource>();
    }

    private void HandlePlayerJoin(Player player)
    {
        this.resource.StartFor(player);
    }

    public void HandleEvent(LuaEvent luaEvent)
    {
        this.logger.LogInformation("Additional resource event triggered", luaEvent.Player.Name);
    }
}
