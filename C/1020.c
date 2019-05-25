#include<stdio.h>

int main() 
{ 
	int Idd, A, M, D; 
	
	scanf("%i", &Idd); 
	
	A = Idd / 365; 
	M = Idd % 365 / 30; 
	D = Idd % 365 % 30;

	printf("%i ano(s)\n%i mes(es)\n%i dia(s)", A, M, D);
	
	return 0;
}
