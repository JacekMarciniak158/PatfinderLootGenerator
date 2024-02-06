using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderLootGenerator
{
    internal class TwoHandedItemsDescriptions
    {
        public string TwoHandenItemsDescription(string itemWielding)
        {
            switch (itemWielding)
            {
                case "Axe":
                    return "Dwarven War Axe.Adze.Greataxe";

                case "Club":
                    return "Staff.Khakkara.Bo Staff.Greatclub";

                case "Flail":
                    return "Bladed Diabolo.Combat Grapnel.Whip Claw.Meteor Hammer.Bladed Scarf.Spiked Chain.War Flail";

                case "Hammer":
                    return "Gnome Hooked Hammer.Maul";

                case "Pick":
                    return "Greatpick.Ogre Hook";

                case "Polearm":
                    return "Fauchard.Glaive.Horsechopper.Naginata.Boarding Pike.Halberd.Ranseur.Guisarme.Scythe";

                case "Spear":
                    return "Longspear.Lance.Gill Hook";

                case "Sword":
                    return "Katana.Wish Blade.Bastard Sword.Rhoka Sword.Elven Curve Blade.Falchion.Greatsword";
            }
            return "";
        }
    }
}

