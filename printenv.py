import os

if "Path" in os.environ:
    print("Path Exists!")
else:
    print("Path Not exists...")
 
if "TST_VAR" in os.environ:
    print("TST_VER Exists!")
else:
    print("TST_VER Not exists...")
