using System;
namespace LinkedList
{
    class Node
    {
        public int num;
        public int nodecnt;
        public Node next = null;
    }
    class MainApp
    {
        private static Node head;
        private static Node tail;

        private static int func;
        public static int cnt = 1;
        static void MainMenu()
        {
            Console.WriteLine("원하는 기능의 번호를 입력하세요.");
            Console.WriteLine("1. 노드 추가");
            Console.WriteLine("2. 노드 삭제");
            Console.WriteLine("3. 노드 출력");
            Console.WriteLine("4. 종료");
            func = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
        static void AddNode()
        {
            Node node = new Node();
            Console.WriteLine("새로 생성할 노드에 저장할 숫자를 입력하세요.");
            int n = Convert.ToInt32(Console.ReadLine());
            node.num = n;
            if (cnt == 1)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
            node.nodecnt = cnt++;
            Console.WriteLine();
        }
        static void DelNode()
        {
            Node temp;

            PrintNode();
            Console.WriteLine();
            Console.WriteLine("삭제할 노드의 번호를 입력하세요.");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("************ 삭제 완료 ************");
            PrintNode();
            Console.WriteLine();
        }
        static void PrintNode()
        {
            Node temp = head;

            Console.WriteLine("< Nodes List >");
            for (int i = 1; temp != null; i++)
            {
                Console.WriteLine($"Node {i}. {temp.num}");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            do
            {
                MainMenu();

                switch (func)
                {
                    case 1:
                        AddNode();
                        break;
                    case 2:
                        DelNode();
                        break;
                    case 3:
                        PrintNode();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("잘못된 번호입니다. 다시 입력하세요.");
                        Console.WriteLine();
                        break;
                }
            } while (true);
        }
    }
}