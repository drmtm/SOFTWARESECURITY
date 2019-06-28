# Simple Software Protection solution
This is a simple project aimed at providing very simple software protection solution to help developer protect their software from unauthorized copy.

##WARNING!!!##
THIS IS NOT INTENDED AS PROTECTION FOR COMMERCIAL SOFTWARE.
YOU ARE FREE TO USE IT ON YOUR OWN RISK AND I BEAR NO RESPONSIBILTY FOR ANY CONSEQUENCES.

# The Idea
the solution is built on the idea that each hardware component has its own unique serial . the solution will collect several serials of different hardware component of the target machine then they are used to generate **Unique Identifier Key** (**UIK**).
the key is saved on the target machine and the software developer will use the provided library to check that authenticity of the key.
in case of unmatched key-machine the developer will add proper procedure to handle this situation.


## files and folders

Two files are provided :
1- mtmsoftsec1.dll : file used to generate UIK
2- mtmsoftsec.dll  : file used for checking the key

folders:
1-genidsample : folder containg sample VB .NET  project for generating UIK
2- checkidsample : folder containg sample VB.NET project for checking UIK

## Pre-requisites
- to be able to use the library file you will need any programing language able to import dll files under Microsoft Windows.
- to be able to see sample project you will need Visual Studio 2017 or later.



## Getting Started

the process is divided into 2 steps
- **Generatin UIK: ** 
You have to start by making a small program to generate UIK and run this program on the target machine (the computer on which you are going to install your protected software i.e customer pc ) .
you will optain the UIK which can be saved in a file in your software installation folder. 
1- add the file "mtmsoftsec1.dll" to the references of a new project
2- import "mtmsec" name space
3- instantiate the mtmsoftsec class
4- use the methode "genId()" to generate UIK the function will return a string
5- store the generated UIK
- **linking software to UIK: **i
here you will add procedure to your software to check the UIK . in case that the stored UIK is ok your protected software will continue as usual . otherwise it will shutoff or whatever you want.
1- add the file "mtmsoftsec.dll" to the references of a new project
2- import "mtmsec" name space
3- instantiate the mtmsoftsec class
4- read the stored UIK 
5- use the methode "checkId(string UIK)" passing the stored  UIK to the fuction to check it.
6- the checkid fuction return true for right UIK and false for wrong UIK





## CONTACT ME

feel free to contact me for any suggestion at M.ALMOGHAZY@GMAIL.COM



