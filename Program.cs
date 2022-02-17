//Ejercicio 1 - While

Console.Write("Type a number: ");
string strNumber = Console.ReadLine();
int number = Convert.ToInt32(strNumber);
int multiple = 1;

Console.WriteLine("The multiples of " + number + " are: ");
while (multiple <= 10){
    Console.Write((multiple * number) + " " );
    multiple++;
}

//Ejercicio 2 - Do while

Console.WriteLine(" ");
Console.Write("Type another number: ");
strNumber = Console.ReadLine();
number = Convert.ToInt32(strNumber);

if (number > 0){
    Console.WriteLine("Regressive counting... ");
    do {
        Console.Write(number + " ");
        number--;
    } while (number >= 0);
} else if (number < 0) {
    Console.Write("Progressive counting...");
    do {
        Console.Write(number + " ");
        number++;
    } while (number <= 0);
} else {
    Console.Write("Nothing to see here...");
}

//Ejercicio 3 - For

/*
    Escribe un programa que realice estos pasos:
    Reciba 3 datos:
    ancho
    alto
    relleno o no
    Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.
    En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n. */

Console.WriteLine(" ");
Console.WriteLine("Drawing a rectangle...");
Console.Write("Width: ");
string strWidth = Console.ReadLine();
int width = Convert.ToInt32(strWidth);

Console.Write("Height: ");
string strHeight = Console.ReadLine();
int height = Convert.ToInt32(strHeight);

Console.Write("Painted? (y or n) ");
string strPainted = Console.ReadLine();
bool painted = false;

if (strPainted == "y"){
    painted = true;
}

//Column
for (int i = 1; i <= height; i++){

    //Line
    for ( int j = 1; j <= width; j++){

        if (i == 1 || i == height || j == 1 || j == height){
            Console.Write("*");
        } else if (painted == true){
            Console.Write("*");            
        } else {
            Console.Write(" ");
        }
        
    }

    Console.WriteLine(" ");
}