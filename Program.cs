using System;

namespace ExpressionBodiedExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank("MA1122");
            tank.weapons = new string[] {"Canon1", "Canon2", "Canon3"};
            tank.weaponIdx = 0;
            tank.weight = 400;
            Console.WriteLine("Tank");
            Console.WriteLine($"IsBigTank? {tank.isBigTank}");
            Console.WriteLine(tank.currentWeapon());
            Console.WriteLine(tank.attack());
            Console.WriteLine("Tank switch tank weapon to second weapon");
            tank.weaponIdx = 1;
            Console.WriteLine(tank.currentWeapon());
            Console.WriteLine(tank.attack());
            Console.WriteLine();

            TankExpressionBody tankExpressionBody = new TankExpressionBody("MB1122");
            tankExpressionBody.weapons = new string[] {"Canon1", "Canon2", "Canon3"};
            tankExpressionBody.weaponIdx = 0;
            tankExpressionBody.weight = 400;
            Console.WriteLine("TankExpressionBody");
            Console.WriteLine($"IsBigTank? {tank.isBigTank}");
            Console.WriteLine(tankExpressionBody.currentWeapon());
            Console.WriteLine(tankExpressionBody.attack());
            Console.WriteLine("switch tankExpressionBody weapon to second weapon");
            tankExpressionBody.weaponIdx = 1;
            Console.WriteLine(tankExpressionBody.currentWeapon());
            Console.WriteLine(tankExpressionBody.attack());

        }
    }
}
