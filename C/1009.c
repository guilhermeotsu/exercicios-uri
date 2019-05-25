#include <stdio.h> 

int main()
{ 
	char Nome[100]; 
	double Sal, TotVend, VlrFin; 
	
	scanf("%s%lf%lf", &Nome, &Sal, &TotVend); 
	
	VlrFin = Sal + (TotVend * 0.15); 
	
	printf("TOTAL = R$ %.2lf\n", VlrFin);
	
	return 0;
}