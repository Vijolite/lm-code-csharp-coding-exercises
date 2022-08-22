using System;
namespace Exercises
{
    public class Exercise003
    {
        public string[] IceCreamFlavours = {"Pistachio","Raspberry Ripple","Vanilla","Mint Chocolate Chip","Chocolate", "Mango Sorbet"};

        public int IceCreamCode(string iceCreamFlavour) {
            for (int i = 0; i < IceCreamFlavours.Length; i++)
            {
                if (IceCreamFlavours[i]==iceCreamFlavour) return i;
            }
            return -1;

        }

    }
}
