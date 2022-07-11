/*
Yorh Project Code Archives (YPCA)
Namespace import System from mscorlib.dll & System.dll
Path: Yorh.Block
*/

public static int PriorityAction(string name) {
     switch(name) {
       case "+": return 1;
       case "-": return 2;
       case "==": return 3;
       case "+=": return 4;
       case "-=": return 5;
       case "++": return 6;
       case "--": return 7;
       case "<=": return 1;
       case ">=": return 8;
       case ">": return 9;
       case "<": return 10;
     }
	return 0;
} 

public static int MainConditionalFunctions(string name) {
     switch(name) {
       case "if": return 1;
       case "else": return 2;
       case "for": return 3;
       case "while": return 4;
     }
	return 0;
} 


public static int DataTypeFunctions(string name) {
	  switch(name) {
       case "bool": return 1;
       case "inter": return 2;
       case "long": return 3;
       case "float": return 4;
       case "short": return 5;
       case "byte": return 6;
     }
	return 0;
}



