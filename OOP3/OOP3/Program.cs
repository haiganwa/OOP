//  #include <studio.h>
using System;


//命名空间。名字空间 package
namespace OOP3
{ class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        void Tellstory()
        {
            int a = 3;
            Student Tom = new Student();
            //People Tom = new Student();
            //多态：同一种行为却表现出了多种状态

            Tom.Birth();
            Tom.Name = "汤米";
            Tom.Earn(1000);
            Student Daming = new Student();
            Daming.Birth();
            Daming.Name = "大明";
            Daming.Earn(1200);

            Cafeteria cafe1 = new Cafeteria();

            Tom.Run();
            Daming.Walk();

            // fork  竞争？
            while (Tom .IsHungry()&& !Tom .IsDead() ) { 
             int food = cafe1.Charge(10);
            if (food < 0)
            {
                Tom.Cost(10);
                    Tom.Eat(food);
            }else
            {
                cafe1.SupplyFood();
            } }

            while (Daming .IsHungry() && !Daming.IsDead())
            {
                int food = cafe1.Charge(10);
                if (food < 0)
                {
                    Daming .Cost(10);
                    Daming .Eat(food);
                }
                else
                {
                    cafe1.SupplyFood();
                }
            }

        }
    }

    //抽离概念：   v. 抽象
    // => 定义 一个 类

    // 概念实践化   实际的个体 ：实体  v.具体化
    // 概念的一个   实际的例子 ：实例  instance

    class People {
        //成员变量:   状态
          int HungerLevel;
        bool Gender;
         int Age;
        public string Name;


        //成员方法： 功能 动作
        public void Birth() {
            Gender = DateTime.Now.Ticks % 2 == 0;  
            Age = 0;
            HungerLevel = 100;
        }
        public void Death() {
            Age = -1;
            HungerLevel = -1;
         }
        public  bool IsHungry()
        {
            return HungerLevel < 50;
        }
        public bool IsDead()
        {
            return HungerLevel < 0;

        }
        public string  Say() {
            return Say("Hello");
         }

        public string Say(string words) {  
        if (words == "你饿不饿？")
            {     if (HungerLevel < 60) return "饿了";
                else return "不饿";

            }
            return words;
        }

        public void Eat(int foodsize) {
            HungerLevel = HungerLevel + foodsize;
        }

        public void  Walk() {

            Walk(10);
                }

        public void  Run() {
            Walk(100);
        }

        public void Walk(int speed) {

            HungerLevel = HungerLevel - speed * 1;
        }
       
     
    }
    //继承
    class Student :People 
    {
        int Money;

        public void Earn(int count)
        {
            Money += count;
        }
        public void   Cost (int count) {
            Money -= count;
        }
    }

    class School { } 
   
    class Cafeteria {
         int FoodHeap;
         int Income;

        public void SupplyFood() {

            FoodHeap+=100;
                }
        public int Charge(int cost) {
            
            int food = cost  * 2;
            if (FoodHeap<food)
            {
                return 0;
            }else
            {
               Income += cost;
                return food;
            }

            
        }
    }
    
    class Money { }

    class Food { }

   


}
