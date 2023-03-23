
Dictionary<string,int> listaCursoYValores = new Dictionary<string,int>();
int ar = 0;
while(ar != 2){
Console.WriteLine("1. Ingrese los importes de un curso");
Console.WriteLine("2. Ver estadisticas");
ar = int.Parse(Console.ReadLine());
switch(ar){

    case 1:

    (string,int) CursoYCantidadAlumnos(){
    Dictionary<string,int> diccionario = new Dictionary<string,int>();
    Console.WriteLine("Escriba la cantidad de estudiantes que tiene el curso");
    int alumnos = int.Parse(Console.ReadLine());
    alumnos = mayorACero(alumnos);
    Console.WriteLine("Escriba el nombre del curso");
    string Curso = Console.ReadLine();
    int suma = 0;
    for(int i = -1; i < alumnos;i++){
        Console.WriteLine("Ingrese cuanto va a pagar Estudiante N°" + i);
        suma = suma + int.Parse(Console.ReadLine());
        suma = mayorACero(suma);
    }
    return (Curso,suma);
    
}
    var (curso,total) = CursoYCantidadAlumnos();
    listaCursoYValores.Add(curso,total);
    
    break;

    case 2:
    Console.WriteLine("Estadisticas");
    Console.WriteLine("Curso que más plata puso");
    Console.WriteLine(cursoMasPlata(listaCursoYValores));
    Console.WriteLine("promedio de plata regalado por todos los cursos");
    Console.WriteLine(Promedio(listaCursoYValores.Count,listaCursoYValores));
    Console.WriteLine("Recaudación total entre los todos cursos");
    Console.WriteLine(recaTotal((listaCursoYValores)));
    Console.WriteLine("Cantidad de cursos que participan del regalo");
    Console.WriteLine(cursoTotal(listaCursoYValores));
    
    break;



}
}





int mayorACero(int i){
    while(i <=0){
        Console.WriteLine("Escriba de nuevo el valor");
        i = int.Parse(Console.ReadLine());
        
    }
    return i;

}
int Mayor(int i, int a){
    int mayor;
    if(i < a){
        mayor = a;
    }
    else
    {
        mayor = i;
    }
    return mayor;

}

string cursoMasPlata(Dictionary<string,int> lista){
    string str = "";
    int mayor = 0;
    int nt = mayor;
    foreach(string elemt in lista.Keys){
        mayor = Mayor(mayor,lista[elemt]);
        if(mayor != nt){
            nt = mayor;
            str = elemt;
        }
    }
    return str;
}

double Promedio(int a,Dictionary<string,int> lista){
    int suma = 0; 
    foreach(int elements in lista.Values){
        suma = suma + elements;
    }
    double promedio = suma / a;
    return promedio;
}

int recaTotal(Dictionary<string,int> lista){
    int suma = 0;
    foreach(int elements in lista.Values){
        suma = suma + elements;
    }
    return suma;
}

int cursoTotal(Dictionary<string,int> lista){
    int i = lista.Count;
    return i;
}


