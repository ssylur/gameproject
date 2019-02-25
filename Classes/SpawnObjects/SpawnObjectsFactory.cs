using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Classes.SpawnObjects
{
    class SpawnObjectsFactory
    {
        public void create(string spawnType, Form1 context)
        {
            switch (spawnType)
            {
                case SpawnObject.AMMO:
                    new AmmoSpawnObject(context).spawn();
                    break;
                case SpawnObject.ZOMBIE:
                    new ZombieSpawnObject(context).spawn();
                    break;
                case SpawnObject.HEAL:
                    new HealSpawnObject(context).spawn();
                    break;
                case SpawnObject.SHOOT:
                    new ShootSpawnObject(context).spawn();
                    break;
            }
        }
    }
}
