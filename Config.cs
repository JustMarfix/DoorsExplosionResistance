using Exiled.API.Enums;
using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace DoorsExplosionResistance
{
    public class Config : IConfig
    {
        [Description("Is plugin enabled? (bool)")]
        public bool IsEnabled { get; set; } = true;

        [Description("Is debug enabled? (bool)")]
        public bool Debug { get; set; } = false;

        [Description("List of unexplosive doors (List<DoorType>)")]

        public List<DoorType> UnexplosiveDoors { get; set; } = new List<DoorType>()
        {
            DoorType.HID
        };
    }
}
