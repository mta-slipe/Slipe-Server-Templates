using SlipeServer.Packets.Lua.Camera;
using SlipeServer.Server;
using SlipeServer.Server.Elements;
using SlipeServer.Server.Elements.Enums;
using System.Numerics;

namespace Logic;

public class LogicTemplate
{
    public LogicTemplate(MtaServer server)
    {
        server.PlayerJoined += HandlePlayerJoin;
    }

    private void HandlePlayerJoin(Player player)
    {
        player.Spawn(new Vector3(0, 0, 3), 0, (ushort)PedModel.Sweet, 0, 0);
        player.Camera.Target = player;
        player.Camera.Fade(CameraFade.In);
    }
}
