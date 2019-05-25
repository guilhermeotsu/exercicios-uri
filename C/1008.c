#include <stdio.h>

int main() 
{ 
	int NumFunc, HTrab; 
	float VlrHora, TotalRec; 
	
	scanf("%i%i%f", &NumFunc, &HTrab, &VlrHora); 
	 
	TotalRec = HTrab * VlrHora; 
		
	printf("NUMBER = %i\n", NumFunc);
	printf("SALARY = U$ %.2f\n", TotalRec); 
	
	return 0;
} 
