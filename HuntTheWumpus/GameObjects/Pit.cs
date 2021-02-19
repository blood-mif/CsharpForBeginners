/// <summary>
//  @ -игрок
//  W - wumpus(монстр).
//  B - Летучая мышь.
//  O - глубокая, смертельная яма.
/// </summary>
namespace HuntTheWumpus.GameObjects
{
    public class Pit : GameObject
    {
        public Pit(Coordinates coordinates) : base(coordinates,"[O]")
        {

        }
    }

}
