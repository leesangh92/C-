using System;
using System.IO;

namespace CH07
{
    class SourceFile
    {
        private FileStream src;

        public SourceFile(string name)
        {
            src = File.Open(name, FileMode.Open);
            Console.WriteLine("{0} Open !!!", name);
        }

        ~SourceFile()
        {
            src.Close();
            Console.WriteLine("Destructor !!!"); // 환경적인 요소 때문에 보이지 않으나 원래는 대괄호에서 빠져나올 때 소멸자가 작동한다. 
        }
    }

    class Class_Destructor
    {
        static void Main(string[] args)
        {
            SourceFile src = new SourceFile("../../../e. Class_Destructor.cs");
        }
    }
}
