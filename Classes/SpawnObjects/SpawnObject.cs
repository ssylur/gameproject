using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Classes.SpawnObjects
{
    abstract class SpawnObject : ISpawnObject
    {
        public const string ZOMBIE = "zombie";
        public const string SHOOT = "shoot";
        public const string AMMO = "ammo";
        public const string HEAL = "heal";

        public void spawn() { }
    }
}
