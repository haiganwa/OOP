using MongoDB.Bson.IO;
using Newtonsoft.Json;
using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;
using JsonConvert = Newtonsoft.Json.JsonConvert;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {


            People Haigang = GeneratePeople();
            People xiaohong = new People();
            xiaohong.Age = 16;

            People xiaoli = new People();
            xiaoli.Age = 17;
            People xiaozhang = new People();
            xiaozhang.Age = 20;


            PeopleCurRepository database = new PeopleCurRepository();
            database.Add(Haigang);
            database.Add(xiaozhang);
            database.Add(xiaoli);
            database.Add(xiaohong);
     

            //序列化
            Console.WriteLine(JsonConvert.SerializeObject(database.GetAll()));
            ////反序列化
            //People Haigang2 = JsonConvert.DeserializeObject<People>("asdfafdadfa");
            // Clone 深拷贝
            //People Haigang2 = JsonConvert.DeserializeObject<People>(JsonConvert.SerializeObject(Haigang));
        }
          static  People GeneratePeople()
        {
            People Haigang = new People();
            //素人

            
            Haigang.Gender = true;
            Haigang.Age = 18;
            Haigang.Name = "海钢";
            Haigang.Birthday = new DateTime(2000, 10, 10, 10, 10, 36);
            Haigang.HungerIndex = 100;
            Haigang.Eat(99);

            return Haigang;
        }
        
    }
    //数据库
    class PeopleCurRepository : RepositoryBase<People> { }

    class People : DomainModel
    {       //成员方法
        public void Eat(int foodsize) {
            HungerIndex = HungerIndex + foodsize / 2;
        }

        //成员变量或成员属性
        public int HungerIndex;
        //唯一标识符
        public string Name;
        public int Age;
        public bool Gender;
        public DateTime Birthday;
       

    }
}
