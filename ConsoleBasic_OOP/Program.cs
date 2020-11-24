using System;

namespace ConsoleBasic_OOP
{
    // 문자열 둘러보기

    class Program
    {
        static void Main(string[] args)
        {
            string name = "Herry Potter";

            // 1. 찾기
            bool found = name.Contains("Harry"); // 문자열을 받을건데, 이 문자열이 안에 있냐?
            int index = name.IndexOf('P');  // 문자가 있는지. 7번째. 6 리턴.

            // 2. 변형
            name = name + " Junior";

            string lowerCaseName = name.ToLower(); // 전부 소문자로
            string upperCaseName = name.ToUpper(); // 전부 대문자로
            string newName = name.Replace('r', 'l'); // 모든캐릭터 r을 ㅣ로 바꾸어준다.

            // 3. 분할
            string[] names = name.Split(new char[] { ' ' });
            string substringName = name.Substring(5); // 문자열을 0,1,2,3,4,5 몇번째 문자열 부터 잘라서 새로운 문자열 만듬.
        }
    }
}
