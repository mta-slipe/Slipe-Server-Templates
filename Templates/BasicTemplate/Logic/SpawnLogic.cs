using SlipeServer.Packets.Lua.Camera;
using SlipeServer.Server;
using SlipeServer.Server.Elements;
using SlipeServer.Server.Elements.Enums;
using System.Numerics;

namespace BasicProjectTemplate.Logic
{
    public class SpawnLogic
    {
        public SpawnLogic(MtaServer server)
        {
            server.PlayerJoined += HandlePlayerJoin;
        }

        private void HandlePlayerJoin(Player player)
        {
            player.Spawn(new Vector3(0, 0, 3), 0, (ushort)PedModel.Sweet, 0, 0);
            player.Camera.Target = player;
            player.Camera.Fade(CameraFade.In);

            player.Wasted += HandlePlayerWasted;
        }

        private void HandlePlayerWasted(Ped sender, SlipeServer.Server.Elements.Events.PedWastedEventArgs e)
        {
            (sender as Player)?.Spawn(new Vector3(0, 0, 3), 0, (ushort)PedModel.Sweet, 0, 0);
        }
    }
}