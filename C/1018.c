#include<stdio.h>

int main()
{
	int Valor, N100, R100, N50, R50, N20, R20, N10, R10, N5, R5, N2, R2, N1;
	
	scanf("%i", &Valor);
	
	N100 = Valor / 100; 
	R100 = Valor % 100;
	
	N50 = R100 / 50; 
	R50 = R100 % 50; 
	
	N20 = R50 / 20; 
	R20 = R50 % 20; 
	
	N10 = R20 / 10; 
	R10 = R20 % 10; 
	
	N5 = R10 / 5; 
	R5 = R10 % 5; 
	
	N2 = R5 / 2; 
	R2 = R5 % 2; 
	
	N1 = R2 / 1; 
	
	printf("%i\n", Valor);
	printf("%i nota(s) de R$ 100,00\n", N100);
	printf("%i nota(s) de R$ 50,00\n", N50);
	printf("%i nota(s) de R$ 20,00\n", N20);
	printf("%i nota(s) de R$ 10,00\n", N10);
	printf("%i nota(s) de R$ 5,00\n", N5);
	printf("%i nota(s) de R$ 2,00\n", N2);
	printf("%i nota(s) de R$ 1,00\n", N1); 
	
	return 0; 
}
