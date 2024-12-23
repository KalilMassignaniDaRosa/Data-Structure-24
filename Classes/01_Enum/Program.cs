using _01_Enum;

// Comentario de uma linha
/*
    Comentario de multiplas linhas
*/
// Declarando Variavel
/*
int number;
// Atribuindo Valor
number = 10;
*/
// Declarando Constante
const int DAYS_IN_WEEK = 7;

// Imprimindo string concatenada
// Metodos tem nomes de verbos
Console.WriteLine($"The week has {DAYS_IN_WEEK} days");

// new Enumerator -> invoca o metodo construtor do objeto
// Toda classe tem seu construtor padrao implicito sem argumentos/params
// E possivel sobreescrever este metodo especificando argumentos 
// Todavia, se o fizermos perdemos o original implicito e
// Precissaremos defini-lo explicitamente
Enumerator cutomEnumerator = new();
string lang = "English";

Enumerator.Language EnumeratorEnglish = cutomEnumerator.GetLanguageEnumerator(lang);
Console.WriteLine($"The Enumerator for {lang} is {EnumeratorEnglish}");
