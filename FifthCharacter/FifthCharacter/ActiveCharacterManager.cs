using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter {
    /*
     * This class helps with facilitating gathering information on the active character
     * from static memory and switching which avaliable characters the user can switch
     * between, facilitating those switches
     */
    public class ActiveCharacterManager {
        /*
         * Things needed:
         * A way to uniquly identify characters
         *      hashing together name, race, levels, random key?
         * A way to make the active character the one that the static managers retrieve
         * infomation for 
         *      using character uuid as a file prefix or preference key prefix?
         *      making sure that method is static, as the static managers will need it
         * A way to rebuild the view reliably when the activecharacter is changed
         * A way to facilitate new character creation
         * A way to facilitate character importing
         *      it may just be making sure the list of saved characters is generated
         *      dynamically
         */
    }
}
