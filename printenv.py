import os

if "Path" in os.environ:
    print("Path Exists!: "+os.environ["Path"])
else:
    print("Path Not exists...")
 
if "TST_VAR" in os.environ:
    print("TST_VER Exists!: "+os.environ["TST_VAR"])
else:
    print("TST_VER Not exists...")
