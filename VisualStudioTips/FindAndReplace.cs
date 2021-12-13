
namespace VisualStudioTips
{
    // Press Ctrl + F to open up the Find dialog. Type in "WriteLine". Note that all occurrences of "WriteLine" are highlighted.
    //
    // Press F3. Note that the occurrence closest to the cursor gets focus. Press F3 again. Or Shift and F3 to go to the previous occurrence. 
    //
    // Now press Ctrl + H. Note that in the Find/Replace window, the focus is still on the search text: "WriteLine". Hit the Tab to move the focus
    // to the replacement text box. Now type "Ninja". Press Alt + A to replace all occurrences of the "WriteLine" with "Ninja". At this point you'll
    // get a confirmation dialog. Press Enter to hit OK. Now the focus is gone from the editor. Put the cursor back somewhere in the editor and 
    // press Ctrl + Z to undo the replacement.
    //
    // Now, press Alt + R. Note that only the instance of "WriteLine" that's currently in focus is replaced with "Ninja" and the focus is on the next instance. 
    // Press F3 to skip. Now press Alt and R again to replace another instance.
    public class FindAndReplace
    {
        public void Start()
        {
            System.Console.WriteLine("WriteLine, WriteLine");

            System.Console.WriteLine("WriteLine, WriteLine");

            System.Console.WriteLine("WriteLine, WriteLine");

            System.Console.WriteLine("WriteLine, WriteLine");

            System.Console.WriteLine("WriteLine, WriteLine");
        }
    }
}
