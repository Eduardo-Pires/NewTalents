using NewTalents;

Calculadora calc = new Calculadora();

int val1 = 1, val2 = 3;
calc.Somar(val1, val2);
val1++;
val2++;

calc.Somar(val1, val2);
val1++;
val2++;

calc.Somar(val1, val2);
val1++;
val2++;

calc.Somar(val1, val2);
val1++;
val2++;

calc.Somar(val1, val2);

try { 
    var lista = calc.Historico();
    foreach (var item in lista)
        Console.WriteLine(item.ToString());
}
catch(Exception ex) {
    Console.WriteLine(ex.ToString());
}

    

