bool x = true;
bool y = true;

bool and = x && y; // e lógico
bool or  = x || y; // ou lógico
bool not  = !x; //não lógico

//exibindo resultados dos operadores lógicos
Console.WriteLine("\nOperadores lógicos:"); 
Console.WriteLine($"x && y: {and}"); // e lógico
Console.WriteLine($"x || y: {or}"); // ou lógico
Console.WriteLine($"!x: {not}"); //não lógico