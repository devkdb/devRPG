using System;

namespace ConsoleBasic_OOP
{
    // OOP(은닉성/상속성/다형성)

    // 클래스 형식 변환
    // null.  없음. 내가 참조하고 있는 type이 아무것도 가리키고 있지 않다.
    static Player FindPlayerByid(int id)
    {
        // id에 해당하는 플레이어를 탐색

        // 못찾았으면
        return null;
    }

    class Player
    {
        protected int hp;
        protected int attack;
    }
    class Knight : Player
    {
    }

    class Mage : Player
    {
        public int mp;
    }

    class Program
    {
        static void EnterGame(Player player)
        {
            // 자식 클래스를 부모 클래스로 바꾸고 해당 자식클래스가 맞는지 체크.
            
            // 첫번째 방법.
            bool isMage = (player is Mage);
            if(isMage)
            {
                Mage mage = (Mage)player;
                mage.mp = 10;
            }

/*            // 2번째 방법
            Mage mage = (Player as Mage); // 캐스팅까지 완료해서.
            if (mage != null) // 실제로 mage였다면.
            {
                mage.mp = 10;
            }
*/
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            // Mage type -> Player type enable. warum? mage는 모두 player.
            // Player type -> Mage type?  될수도 아닐수도 있다. Knight 일수도.
            Player magePlayer = mage;
            Mage mage2 = (Mage)magePlayer;  // mage인걸 안다. 그래서 이런식으로 casting 강요 가능.

            EnterGame(knight);
            EnterGame(mage);
        }
    }
}
