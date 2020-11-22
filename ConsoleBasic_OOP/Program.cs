using System;

namespace ConsoleBasic_OOP
{
    // OOP(은닉성/상속성/다형성)

    // 자동차
    // 핸들 패달 차문
    // 전기장치 엔진 ... 고급 기술들 <-> 외부 노출 시킬 필요 없다.

    class Knight
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
    }

    class SuperKnight : Knight
    {
        void Test()
        {
            coolTime = 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.SetHp(100);  // 여러 군데서, hp 세팅 해도, 문제 발생시 SetHp() 함수만 브레이크포인트 걸고 찾으면 됨.
            knight.mp = 10; // 문제 발생시, 셋팅하는 곳 다 찾아야 함.
        }
    }
}
