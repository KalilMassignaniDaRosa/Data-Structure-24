//Comentário de uma linha
/*
    Comentário de múltiplas linhas
*/

//Declarando Variável
using Aula_01;
/*
int number;
//Atribuindo Valor
number = 10;
*/
//Declarando Constante
const int DAYS_IN_WEEK = 7;

//Imprimindo string concatenada
//Métodos tem nomes de verbos
Console.WriteLine($"A semana tem {DAYS_IN_WEEK} dias");

// new TipoEnumerador -> invoca o método construtor do objeto
// toda classe tem seu construtor padrão implicito sem argumentos/params
// é possível sobreescrever este método especificando argumentos 
// todavia, se o fizermos perdemos o original implícito e
// precissaremos defini-lo explicitamente
TipoEnumerador tipoEnum = new TipoEnumerador();

TipoEnumerador.Language enumEnglish = tipoEnum.GetLanguageEnum("inglês"); 
Console.WriteLine($"O enum de english é {enumEnglish}");