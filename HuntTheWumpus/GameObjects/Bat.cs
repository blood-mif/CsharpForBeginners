/// <summary>
//  @ -игрок
//  W - wumpus(монстр).
//  B - Летучая мышь.
//  O - глубокая, смертельная яма.
/// </summary>
namespace HuntTheWumpus.GameObjects
{
    public class Bat : GameObject
    {
        public Bat(Coordinates coordinates) : base(coordinates,"[B]")
        {
        }
    }

}
