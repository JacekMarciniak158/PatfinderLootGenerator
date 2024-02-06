using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderLootGenerator
{
    internal class OneHandedItemsDescriptions
    {
        public string OneHandedItemsDescription(string itemWielding)
        {
            switch (itemWielding)
            {
                case "Axe":                    
                    return "Hand Adze.Boarding Axe.Hatchet.Mambele.Battle Axe.Dwarven War Axe.Orc Necksplitter";
                    
                case "Brawling":
                    return "Gauntlet.Spiked Gauntlet.Fangwire.Tekko-kagi";

                case "Club":
                    return "Club.Mace.Morningstar.Gaff.Khakkara.Nunchaku.Rungu";

                case "Flail":
                    return "Poi.Scorpion Whip.Scourge.Whip.Fire Poi.Bladed Diabolo.Flail.Monkey's Fist.Urumi.Combat Grapnel.Whip Claw.Gnome Flickmace";
               
                case "Hammer":
                    return "Light Hammer.Warhammer";

                case "Knife":
                    return "Clan Dagger.Dagger.Katar.Throwing Knife.Shears.Sickle.Main-gauche.Sai.Starknife.Wish Knife.Claw Blade.Fighting Fan.War Razor.Orc Knuckle Dagger.Kama.Kukri.Bladed Hoop";

                case "Pick":
                    return "Light Pick.Pick.Tricky Pick.Greatpick.Ogre Hook";

                case "Spear":
                    return "Filcher's Fork.Spear.Trident";

                case "Sword":
                    return "Buugeng.Wakizashi.Polytool.Rapier.Shortsword.Sword Cane.Dogslicer.Machete.Scimitar.Tengu Gale Blade.Wish Blade.Sawtooth Saber.Khopesh.Longsword.Nine-Ring Sword.Temple Sword.Aldori Dueling Sword";
            }
            return "";
        }

    }
}
