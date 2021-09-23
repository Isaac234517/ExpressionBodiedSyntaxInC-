using System;
using System.Diagnostics;
namespace  ExpressionBodiedExample
{
    public class TankExpressionBody {
        public string model {get; private set;}

        public float weight;

        public string[] weapons;

        private int _weaponIdx;

        public int weaponIdx {
            get => _weaponIdx;
            set => _weaponIdx = value;
        }

        public bool isBigTank => weight > 300? true: false;
           
        public string mainWeapon => this.weapons[this.weaponIdx];
        
        public TankExpressionBody(string model) => this.model = model;

        ~TankExpressionBody() => Trace.WriteLine("The tank descructor is called");

        public string attack() => $"{mainWeapon} fire";

        public string currentWeapon() => $"Current weapon is ${mainWeapon}";
    }
}