# HammerArchive
HammerArchive is a program that automatically saves the "old" files in a zip archive when compiling a map.

## Information
The program was written and tested for Garry's Mod version 2019.12.18. But it should also work for all other source applications and for older and newer versions.

## Usage

### Set up Hammer
1. Download the latest verion from the "Files" folder or compile your own
2. Inside of Hammer, Press F9.
3. If not already selected, click the "[Expert...]" button
4. Select a Configuration
5. Click the "New" button and select the checkbox at the new command
6. Press the "Cmds" button on the right and select "Executable"
7. Inside of the filedialoge navigate to the downloaded HammerArchive.exe file and press "Open"
8. Paste to the Parameters text box "$path $file" (without the quotes)
9. Press the "move up" button until the new entry is at the top of the list
10. Pressing "Go!" will copy your "old" files, start the compile of the map and save the new configuration

### Test it
11. Now a new folder was created with a folder and a .zip inside, containing the files
```
├─garrysmod
  ├─maps
  │   ├─gm_test_1.bsp
  │   ├─gm_test_1.log
  │   ├─gm_test_1.prt
  │   ├─gm_test_1.vmf
  │   ├─gm_test_1.vmx
  │   ├─gm_test_2.bsp
  │   ├─gm_test_2.log
  │   ├─gm_test_2.prt
  │   ├─gm_test_2.vmf
  │   ├─gm_test_2.vmx
  │
  ├─maps_archive
  │   ├─gm_test_1
  │       ├─2020-1-2-09-15-40.zip
  │       ├─2020-1-3-12-00-00.zip
  │   ├─gm_test_2
  │       ├─2020-1-3-12-15-20.zip
  │       ├─2020-1-3-12-35-00.zip
```


##### by [raulimann](https://www.reddit.com/user/raulimann)
