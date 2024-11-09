for (int i=0;i<5;i++){
    Console.WriteLine($"Interation: {i}");
}

int count = 0;
while(count < 5){
    Console.WriteLine($"Count: {count}");
    count++;
}

int number;
do {
    Console.WriteLine($"Enter a number (0 to quit): ");
    number = Convert.ToInt32(Console.ReadLine());
} while(number != 0);

