#include <stdio.h> 

int main() 
{
	int A, B, C, D, Dif; 
	
	scanf("%i%i%i%i", &A, &B, &C, &D); 
	
	Dif = ((A * B) - (C * D));
	
	printf("DIFERENCA = %i\n", Dif); 
	
	return 0; 
}