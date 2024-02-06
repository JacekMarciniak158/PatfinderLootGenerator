using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PathfinderLootGenerator
{
    internal class ButtonsDelete : Form1
    {
        internal void GroupButtonsDelete(List<Button> buttonsAdded) 
        {
            if (buttonsAdded != null)
            {
                foreach (Button button in buttonsAdded)
                {
                    //Check if the button has a parent control
                    if (button.Parent != null)
                    {
                        //Removing and disposing button to release resources
                        button.Parent.Controls.Remove(button);                        
                        button.Dispose(); 
                    }
                }
                buttonsAdded.Clear();
            }
        }
    }
}
