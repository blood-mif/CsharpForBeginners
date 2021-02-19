using HuntTheWumpus.GameObjects;
using System;

namespace HuntTheWumpus
{
    public class Map
    {
        private GameObject[] _gameObjects;
        private string[,] _map;

        public Map(byte mapSize)
        {
            _map = new string[mapSize, mapSize];
            for (int y = 0; y < mapSize; y++)
            {
                for (int x = 0; x < mapSize; x++)
                {
                    _map[x,y] = "[ ]";
                }
                Console.WriteLine();
            }
        }

        public void AddObject(GameObject gameObjects)
        {
            Coordinates objectCoorinates = gameObjects.Coordinates;
            _map[objectCoorinates.X,objectCoorinates.Y] = gameObjects.Model;
        }

        public string[,] GetMap()
        {
        return _map;
            }
    }
}
