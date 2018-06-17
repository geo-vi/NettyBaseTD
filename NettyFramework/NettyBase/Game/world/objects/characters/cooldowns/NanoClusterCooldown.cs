﻿using System;

namespace NettyBase.Game.world.objects.characters.cooldowns
{
    class NanoClusterCooldown : Cooldown
    {
        public NanoClusterCooldown(Player player) : base(DateTime.Now, DateTime.Now.AddMinutes(15))
        {
            Send(player.GetGameSession());
        }

        public override void OnFinish(Character character)
        {
        }

        public override void Send(GameSession gameSession)
        {
            //todo: fix
            //Packet.Builder.LegacyModule(gameSession, "0|A|CLD|IH|" + TotalTime);
        }
    }
}
