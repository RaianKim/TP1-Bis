using System.Threading;
Dictionary<string,int> listaCursoYValores = new Dictionary<string,int>();
int ar = 0;
while(ar != 3){
Console.Clear();
Console.WriteLine("1. Ingrese los importes de un curso");
Console.WriteLine("2. Ver estadisticas");
Console.WriteLine("3. Salir");
ar = int.Parse(Console.ReadLine());
Console.Clear();

switch(ar){

    case 1:
    
    string nombreCurso(){
    bool ae = true;
    string Curso = "";
    while(ae==true){
    Console.WriteLine("Escriba el nombre del curso");
    Curso = Console.ReadLine();
    ae = repetio(Curso);
    }
    return Curso;
    }
    int sumaValores(){
    int suma = 0;
    Console.WriteLine("Escriba la cantidad de estudiantes que tiene el curso");
    int alumnos = int.Parse(Console.ReadLine());
    alumnos = mayorACero(alumnos);
    for(int i = 0; i < alumnos;i++){
        Console.WriteLine("Ingrese cuanto va a pagar Estudiante N°" + (i+1));
        suma = suma + int.Parse(Console.ReadLine());
        suma = mayorACero(suma);
    }
    return suma;
    
}
string a = nombreCurso();
int b = sumaValores();
listaCursoYValores.Add(a,b);

    break;

    case 2:
    
    Console.WriteLine("Estadisticas");
    Console.WriteLine("Curso que más plata puso");
    Console.WriteLine(cursoMasPlata(listaCursoYValores));
    Console.WriteLine("promedio de plata regalado por todos los cursos");
    double aux = Promedio(listaCursoYValores.Count);
    Console.WriteLine(aux);
    Console.WriteLine("Recaudación total entre los todos cursos");
    Console.WriteLine(recaTotal());
    Console.WriteLine("Cantidad de cursos que participan del regalo");
    Console.WriteLine(cursoTotal());
    Thread.Sleep(5000);
    break;



}
}


bool repetio(string nombre){
    
    bool k = false;
    foreach(string i in listaCursoYValores.Keys){
        if(nombre == i){
            k = true;
        }
        
    }
    return k;
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

double Promedio(int a){
    double suma = 0; 
    foreach(int elements in listaCursoYValores.Values){
        suma = suma + elements;
        
    }
    double promedio = suma / a;
    return promedio;
}

int recaTotal(){
    int suma = 0;
    foreach(int elements in listaCursoYValores.Values){
        suma = suma + elements;
    }
    return suma;
}

int cursoTotal(){
    int i = listaCursoYValores.Count;
    return i;
}


