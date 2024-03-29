﻿using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerHandler = Exiled.Events.Handlers.Player;

namespace DoorsExplosionResistance
{
    public class DoorsExplosionResistance : Plugin<Config>
    {
        public static DoorsExplosionResistance Instance { get; private set; }

        public DoorsExplosionResistance() { }

        public override string Author => "JustMarfix";
        public override string Name => "DoorsExplosionResistance";

        public override void OnEnabled()
        {
            Instance = this;
            PlayerHandler.DamagingDoor += OnDamagingDoor;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            PlayerHandler.DamagingDoor -= OnDamagingDoor;
            Instance = null;
            base.OnDisabled();
        }

        public void OnDamagingDoor(DamagingDoorEventArgs ev)
        {
            if (Config.UnexplosiveDoors.Contains(ev.Door.Type) && ev.DamageType == Interactables.Interobjects.DoorUtils.DoorDamageType.Grenade)
            {
                ev.IsAllowed = false;
                return;
            }
        }
    }
}
