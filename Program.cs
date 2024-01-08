using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsLearning
{
    // A 
    internal class Program
    {
        //Unity Struct Example
        //A word that has variables in it
        struct Vector3
        {
            public float x; // Public Position for X 
            public float y; // Public Position for Y
            public float z; // Public Position for Z
            //...
            //...

            public float Lenght()
            {
                return (float)Math.Sqrt(x*x*y*y*z*z);
            }
        }

        struct Vector4
        {
            public float w;
            public float x;
            public float y;
            public float z;
            //...
            //...
        }

        struct Point2D // 2D movement 
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            Vector3 position;
            position.x = 10.0f;
            position.y = 20.0f;
            position.z = 30.0f;
            Console.WriteLine("Structs, what it is how to use it");
            Console.WriteLine();
            Console.WriteLine("Vector3 Position, see the struct at the top");
            Console.WriteLine(position.Lenght());
            Console.WriteLine();



            // no-structs
            // no classes (objects)

            // player
            int score = 0;
            int health = 100;
            int shelid = 50;
            //int x = 10; // X pos
            //int y = 10; // Y pos
            Point2D playerPosition;
            playerPosition.x = 10;
            playerPosition.y = 10;

            // 1000 enemies
            int newEnemies = 1000;
            //int[] enemyX = new int[newEnemies];
            //int[] enemyY = new int[newEnemies];
           
            //loop to initilize them...
            Point2D[] enemyPosition = new Point2D[newEnemies];
            //loop to initilize them...
            for (int i = 0; i < newEnemies; i++)
            {
                enemyPosition[i].x = 10;
                enemyPosition[i].y = 10;
            }

            //enemy
            //int enemyX1 = 20; // Don't list enemy 1 and enemy 2 pos (X,Y) 
            //int enemyY1 = 20;

            //enemy
            //int enemyX2 = 20;
            //int enemyY2 = 20;

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
