/// <summary>
//  @ -игрок
//  W - wumpus(монстр).
//  B - Летучая мышь.
//  O - глубокая, смертельная яма.
/// </summary>
namespace HuntTheWumpus.GameObjects
{
    public class Wumpus : GameObject
    {
        public Wumpus(Coordinates coordinates) : base(coordinates,"[W]")
        {
            IsALive = true;
        }
        public bool IsALive { get; set; }
    }

}
