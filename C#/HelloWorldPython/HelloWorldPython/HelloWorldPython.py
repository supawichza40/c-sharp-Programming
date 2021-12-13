from subprocess import check_output
import os
import time

import win32gui

print("Hello World")

while ( True ) :
    newWindowTile = win32gui.GetWindowText (win32gui.GetForegroundWindow());        
    if( newWindowTile != windowTile ) :
        windowTile = newWindowTile ; 
        print( windowTile );
        time.sleep(1)

    





