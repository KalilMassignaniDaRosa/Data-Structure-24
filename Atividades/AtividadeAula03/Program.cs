int evenCounter;
int oddCounter;

int[] even = new int[50];
int[] odd = new int[50];

for(int i = 0; i <= 100; i++){
    if(i%2==0){
        even[i] = i ;
        evenCounter=+1;
    }else{
        odd[i] = i;
        oddCounter=+ 1;
    }
}

Console.WriteLine("Even numbers: ");
for(int i = 0; i <= even.Length; i++){
    Console.WriteLine(even[i]);
}

Console.WriteLine("Odd numbers: ");
for(int i = 0; i <= odd.Length; i++){
    Console.WriteLine(odd[i]);
}
