#include <stdio.h> 

int main() 
{ 
	int Cod1, Cod2, Qntde1, Qntde2; 
	float VlrUni1, VlrUni2, VlrTot; 
	
	scanf("%i %i %f", &Cod1, &Qntde1, &VlrUni1);
	scanf("%i %i %f", &Cod2, &Qntde2, &VlrUni2); 
	
	VlrTot = (VlrUni1 * Qntde1) + (VlrUni2 * Qntde2);
	
	printf("VALOR A PAGAR: R$ %.2f\n", VlrTot);
	
	return 0;
}