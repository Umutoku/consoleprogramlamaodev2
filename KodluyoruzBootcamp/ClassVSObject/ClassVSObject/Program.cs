using System;

namespace ClassVSObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person trainerOfBootcamp = new Person();
            trainerOfBootcamp.Name = "Türkay";
            trainerOfBootcamp.LastName = "Ürkmez";

            Cooker cooker = new Cooker();
            cooker.Name = "Perihan";
            cooker.LastName = "Elibol";
            cooker.kitchenStyle = "italyan";

            Person student1 = new Person();
            student1.Name = "Ahmed Jam";

            Person student2 = new Person();
            student2.Name = "İrem Ergin";
            
            



        }

      


    }
}
