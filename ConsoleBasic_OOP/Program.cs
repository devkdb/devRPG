using System;

namespace ConsoleBasic_OOP
{
    // OOP(은닉성/상속성/다형성)

    // 다형성. 여러가지 형태를 가지고 있다.
    class Player
    {
        protected int hp;
        protected int attack;

        // 일반함수보다 virtual이 성능에 부하를 준다. 귀찮다고 전부다 virtual로 하지 말것.
        // 공통함수인데, 모두 조금씩 뭔가 더 추가.. 다른 경우.
        public virtual void Move()
        {
            Console.WriteLine( "Player 이동!");
        }
    }
    class Knight : Player
    {
        // 접근 한정자 public protected private
        // int hp;              // private.
        private int hp;
        public int mp;          // 상속 받은 경우도 접근 불가.
        protected int coolTime; // 외부 접근 안됨. 상속받은 아이가 있다면 접근 가능.

        public void SetHp(int hp)
        {
            this.hp = hp;

        }

        // 오버로딩:함수이름의 재사용. 
        // 오버라이딩:어떤 함수에다가 실제 타입에 따라서 다양한 동작을 하겠다.
        public override void Move()
        // public sealed override void Move() // 봉인. 내 밑으로 더이상 오버라이드 못함.
        {
            Console.WriteLine("Knight 이동");
        }
    }

    class SuperKnight : Knight
    {
        public override void Move()
        {
            base.Move(); // 부모님 거 호출.
            Console.WriteLine("SuberKnight 이동!");
        }
        void Test()
        {
            coolTime = 10;
        }
    }

    class Program
    {
        static void EnterGame(Player player)
        {
            player.Move();  // player의 개체가, 인스턴스가 어떤 타입인지를
                            // 런타임에 체크해서 그 타입에 맞는, 타입의 함수를 호출.
        }
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.SetHp(100);  // 여러 군데서, hp 세팅 해도, 문제 발생시 SetHp() 함수만 브레이크포인트 걸고 찾으면 됨.
            knight.mp = 10; // 문제 발생시, 셋팅하는 곳 다 찾아야 함.

            knight.Move();
            EnterGame(knight); // "knight 이동"
        }
    }
}
