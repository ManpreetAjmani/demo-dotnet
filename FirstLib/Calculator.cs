using System;

namespace FirstLib
{
    public class Calculator
    {
        public int a;
        public int b;
        public Calculator(int a,int b){
            this.a=a;
            this.b=b;
        }
        public int add(){

            return a+b;
        }

        public int sub(){

            if(a>b) return a-b;
            
            return b-a;
        }

        public int mul(){
            System.Console.WriteLine("build after every push");
            
            return a*b;
        }
    }
}