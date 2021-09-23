using System;
using System.Diagnostics;

namespace  ExpressionBodiedExample
{
    public class Tank {
        public string model {get; private set;}

        public float weight;
      
        public string[] weapons;
           
        private int _weaponIdx;

        public int weaponIdx {
            get { return _weaponIdx; }
            set {
                this._weaponIdx = value;
            }
        }

        public bool isBigTank {
           get {
              if(weight > 300)
                  return true;
               else
                  return false;
           }
        }

        public string mainWeapon {
            get {
                return this.weapons[this.weaponIdx];
            }
        }

        public Tank(string model){
            this.model = model;
        }

        ~Tank(){
            Trace.WriteLine("The tank descructor is called");
        }

        public string attack(){
            return $"{this.mainWeapon} fire";
        }

        public string currentWeapon(){
            return $"Current weapon is {this.mainWeapon}";
        }
    }
}