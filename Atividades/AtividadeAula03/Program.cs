
int evenCounter = 0;
int oddCounter = 0;


int[] even = new int[50];
int[] odd = new int[50];

for(int i = 0; i <= 100; i++){

    if(i % 2 == 0 && evenCounter < 50){
        even[evenCounter] = i;
        evenCounter += 1;
    } else if(i % 2 != 0 && oddCounter < 50){
        odd[oddCounter] = i;
        oddCounter += 1;
    }
}

Console.WriteLine("Even numbers: ");

for(int i = 0; i < evenCounter; i++){
    Console.Write(even[i]+" ");
}
Console.WriteLine();
Console.WriteLine("Odd numbers: ");
for(int i = 0; i < oddCounter; i++){
    Console.Write(odd[i]+" ");
}