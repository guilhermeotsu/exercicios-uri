#include<stdio.h>

int main ()
{ 
 int R100, R50, R20, R10, R5, R2;
 double Valor, M1, RM1, M05,RM05, M025, RM025, M01, RM01, M005, RM005, M001, N100, N50, N20, N10, N5, N2;
 
	scanf("%lf", &Valor);
	
	N100 = Valor / 100.0; 
	R100 = Valor % 100.0;
	
	N50 = R100 / 50.0; 
	R50 = R100 % 50.0; 
	
	N20 = R50 / 20.0; 
	R20 = R50 % 20.0; 
	
	N10 = R20 / 10.0; 
	R10 = R20 % 10.0; 
	
	N5 = R10 / 5.0; 
	R5 = R10 % 5.0; 
	
	N2 = R5 / 2.0; 
	R2 = R5 % 2.0; 
	
	M1 = R2 / 1.0;
	RM1 = R2 % 1.0;
	
	M05 = RM1 / 0.5;
	RM05 = RM1 % 0.5; 
	
	M025 = RM05 / 0.25;
	RM025 = RM05 % 0.25;
	
	M01 = RM025 / 0.1;
	RM01 = RM025 % 0.1;
	
	M005 = M01 / 0.05; 
	RM005 = M01 % 0.05;
	
	M001 = M005 / 0.01;
	
	
	printf("NOTAS:\n");
	printf("%i nota(s) de R$ 100.00\n", N100);
	printf("%i nota(s) de R$ 50.00\n", N50);
	printf("%i nota(s) de R$ 20.00\n", N20);
	printf("%i nota(s) de R$ 10.00\n", N10);
	printf("%i nota(s) de R$ 5.00\n", N5);
	printf("%i nota(s) de R$ 2.00\n", N2);
	
	print("MOEDAS:\n");
	printf("%i moeda(s) de R$ 1.00\n", M1);
	printf("%i moeda(s) de R$ 0.50\n", M05);
	printf("%i moeda(s) de R$ 00.25\n", M025);
	printf("%i moeda(s) de R$ 00.10\n", M01);
	printf("%i moeda(s) de R$ 00.01\n", M001);
	
	return 0; 
}
