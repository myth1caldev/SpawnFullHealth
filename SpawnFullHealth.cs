// Coded by @mythical.dev

using Oxide.Core.Plugins;

namespace Oxide.Plugins
{
    [Info("Spawn Full Health", "mythical.dev", "1.0.0")]
    public class SpawnFullHealth : RustPlugin
    {
        void OnPlayerRespawned(BasePlayer player)
        {
            if (player == null) return;
            player.health = 100f; // Change this to any value you want
            player.metabolism.hydration.value = 250f; // Change this to any value you want
            player.metabolism.calories.value = 500f;  // Change this to any value you want
        }
    }
}
